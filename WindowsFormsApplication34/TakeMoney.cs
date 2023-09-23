/*
* Copyright (c) 2010, Демченко Сергей Сергеевич, doctor.dss@mail.ru
*
* Разрешается повторное распространение и использование как в виде исходного
* кода, так и в двоичной форме, с изменениями или без, при соблюдении
* следующих условий:
*
*     * При повторном распространении исходного кода должно оставаться
*       указанное выше уведомление об авторском праве, этот список условий и
*       последующий отказ от гарантий.
*     * При повторном распространении двоичного кода должна сохраняться
*       указанная выше информация об авторском праве, этот список условий и
*       последующий отказ от гарантий в документации и/или в других
*       материалах, поставляемых при распространении.
*
* ЭТА ПРОГРАММА ПРЕДОСТАВЛЕНА ВЛАДЕЛЬЦАМИ АВТОРСКИХ ПРАВ И/ИЛИ ДРУГИМИ
* СТОРОНАМИ "КАК ОНА ЕСТЬ" БЕЗ КАКОГО-ЛИБО ВИДА ГАРАНТИЙ, ВЫРАЖЕННЫХ ЯВНО
* ИЛИ ПОДРАЗУМЕВАЕМЫХ, ВКЛЮЧАЯ, НО НЕ ОГРАНИЧИВАЯСЬ ИМИ, ПОДРАЗУМЕВАЕМЫЕ
* ГАРАНТИИ КОММЕРЧЕСКОЙ ЦЕННОСТИ И ПРИГОДНОСТИ ДЛЯ КОНКРЕТНОЙ ЦЕЛИ. НИ В
* КОЕМ СЛУЧАЕ, ЕСЛИ НЕ ТРЕБУЕТСЯ СООТВЕТСТВУЮЩИМ ЗАКОНОМ, ИЛИ НЕ УСТАНОВЛЕНО
* В УСТНОЙ ФОРМЕ, НИ ОДИН ВЛАДЕЛЕЦ АВТОРСКИХ ПРАВ И НИ ОДНО  ДРУГОЕ ЛИЦО,
* КОТОРОЕ МОЖЕТ ИЗМЕНЯТЬ И/ИЛИ ПОВТОРНО РАСПРОСТРАНЯТЬ ПРОГРАММУ, КАК БЫЛО
* СКАЗАНО ВЫШЕ, НЕ НЕСЁТ ОТВЕТСТВЕННОСТИ, ВКЛЮЧАЯ ЛЮБЫЕ ОБЩИЕ, СЛУЧАЙНЫЕ,
* СПЕЦИАЛЬНЫЕ ИЛИ ПОСЛЕДОВАВШИЕ УБЫТКИ, ВСЛЕДСТВИЕ ИСПОЛЬЗОВАНИЯ ИЛИ
* НЕВОЗМОЖНОСТИ ИСПОЛЬЗОВАНИЯ ПРОГРАММЫ (ВКЛЮЧАЯ, НО НЕ ОГРАНИЧИВАЯСЬ
* ПОТЕРЕЙ ДАННЫХ, ИЛИ ДАННЫМИ, СТАВШИМИ НЕПРАВИЛЬНЫМИ, ИЛИ ПОТЕРЯМИ
* ПРИНЕСЕННЫМИ ИЗ-ЗА ВАС ИЛИ ТРЕТЬИХ ЛИЦ, ИЛИ ОТКАЗОМ ПРОГРАММЫ РАБОТАТЬ
* СОВМЕСТНО С ДРУГИМИ ПРОГРАММАМИ), ДАЖЕ ЕСЛИ ТАКОЙ ВЛАДЕЛЕЦ ИЛИ ДРУГОЕ
* ЛИЦО БЫЛИ ИЗВЕЩЕНЫ О ВОЗМОЖНОСТИ ТАКИХ УБЫТКОВ.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DSS
{
    public partial class TakeMoney : Form
    {
        public TakeMoney()
        {
            InitializeComponent();
        }

        public decimal predSumma = 0;
        public int[] dolgManyIDS;
        public int posesenie;
        public int PID;
        public int dolgOneID;
        ___BASA__DataSetTableAdapters.PredoplataTableAdapter predoplataTA = new DSS.___BASA__DataSetTableAdapters.PredoplataTableAdapter();
        ___BASA__DataSet.DolgRow dolgRow;
        public decimal dolgSumma = 0;
        public string PFIO;

        private void TakeMoney_Load(object sender, EventArgs e)
      {
          numericUpDown1.Maximum = decimal.MaxValue;
          labelPFIO0. Text+= PFIO;
          if ((string)this.Tag == "take")// "Прием Предоплаты"
          {
              labelPay.Text = "Предоплата :";
              labelPFIO0.Text = PFIO;
              labelDolg.Visible=false;
          }
          if ((string)this.Tag == "pred")//"Возврат Предоплаты"
          {
              labelDolg.Text += dolgSumma.ToString();
              labelPFIO0.Text = PFIO;
              labelDolg.Text = "Предоплата : " + dolgSumma;
              labelPay.Text = "Возвращаем :";
              numericUpDown1.Enabled = false;
              numericUpDown1.Value = dolgSumma;
          }
          if ((string)this.Tag == "pay1")//"Оплата Долга";
          {
              dolgRow = dolgTableAdapter.GetDataBy1(dolgOneID)[0];
              dolgSumma = dolgRow.dolg;
           labelDolg   .Text += dolgSumma.ToString();
          }
          if ((string)this.Tag == "pay0")//"СПИСАНИЕ ДОЛГА"
          {
              dolgRow = dolgTableAdapter.GetDataBy1(dolgOneID)[0];
              dolgSumma = dolgRow.dolg;
              labelDolg.Text += dolgSumma.ToString();
              numericUpDown1.Maximum = dolgSumma;
              labelPay.Text = "Прощаем";
          }
          if ((string)this.Tag == "payAll")//"Оплата Долгов"
          {
              labelDolg.Text += dolgSumma.ToString();
              numericUpDown1.Maximum = dolgSumma;
              numericUpDown1.Minimum = dolgSumma;
          }
          if ((string)this.Tag == "from")//"Списание Долга из Предоплаты"
          {
              dolgRow = dolgTableAdapter.GetDataBy1(dolgOneID)[0];
              dolgSumma = dolgRow.dolg;
              labelDolg.Text += dolgSumma.ToString();
              labelPred.Text += predSumma.ToString();
              labelPred.Visible = true;
              if (dolgSumma > predSumma)
              {                 
                  numericUpDown1.Maximum =dolgSumma- predSumma;
                  labelPay.Text = "Доплата :";
              }
              else if (dolgSumma <= predSumma)
              {
                  numericUpDown1.Value = predSumma - dolgSumma;
                  numericUpDown1.Enabled = false;
                  labelPay.Text = "Остаток предоплаты :";
              }            
          }
      }

        private void button1_Click(object sender, EventArgs e)
        {
            bool close = true;
            if ((string)this.Tag == "take")// "Прием Предоплаты"
            {
                if (numericUpDown1.Value != 0)
                {
                    if (MessageBox.Show("Внесена предоплата : " + numericUpDown1.Value.ToString()+".", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        predoplataTA.Insert(numericUpDown1.Value, DateTime.Now, PID);
                        plataTableAdapter1.Insert(numericUpDown1.Value, PID, textBox1.Text, DateTime.Now, "предоплата");
                    }
                    else
                    { close = false; }
                }
                else
                {
                    MessageBox.Show("Предоплата не может быть 0.");
                    close = false;
                }
            }

            else if ((string)this.Tag == "from")//"Списание Долга из Предоплаты"
            {
                if (dolgSumma >= predSumma && numericUpDown1.Value + predSumma == dolgSumma)
                {
                    if (MessageBox.Show("Долг полностью погашен.\rОстаток предоплаты : 0.\rДоплачено : " + numericUpDown1.Value .ToString()+".", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        dolgTableAdapter.Delete(dolgRow.ID, dolgRow.posesenie, dolgRow.dolg);
                        if (numericUpDown1.Value != 0)
                        {
                            plataTableAdapter1.Insert(numericUpDown1.Value, PID, textBox1.Text, DateTime.Now, "оплата лечения");
                        }
                        plataTableAdapter1.Insert(predSumma, PID, textBox1.Text, DateTime.Now, "учет предоплаты");
                        for (int i = 0; i < dolgManyIDS.Length; i++)
                        {
                            predoplataTA.DeleteQuery(dolgManyIDS[i]);
                        }
                    }
                    else
                    { close = false; }
                   

                }
                else if (dolgSumma > predSumma && numericUpDown1.Value + predSumma < dolgSumma)
                {
                    if (MessageBox.Show("Долг погашен не полностью.\rДоплачено : " + numericUpDown1.Value .ToString()+ ".\rОстаток предоплаты : 0.\rОстаток долга : " + (dolgSumma - (numericUpDown1.Value + predSumma)).ToString()+".", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        for (int i = 0; i < dolgManyIDS.Length; i++)
                        {
                            predoplataTA.DeleteQuery(dolgManyIDS[i]);
                        }
                        dolgTableAdapter.Update(dolgRow.posesenie, dolgSumma - (numericUpDown1.Value + predSumma), dolgRow.ID, dolgRow.posesenie, dolgRow.dolg);
                        plataTableAdapter1.Insert(predSumma, PID, textBox1.Text, DateTime.Now, "учет предоплаты");
                        if (numericUpDown1.Value != 0)
                        {
                            plataTableAdapter1.Insert(numericUpDown1.Value, PID, textBox1.Text, DateTime.Now, "оплата лечения");
                        }

                    }
                    else
                    { close = false; }
                }

                else if (dolgSumma < predSumma)
                {
                    if (MessageBox.Show("Долг полностью погашен.\rОстаток предоплаты : " + (predSumma-dolgSumma).ToString()+".", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        dolgTableAdapter.DeleteQueryByID(dolgRow.ID);
                        for (int i = 0; i < dolgManyIDS.Length; i++)
                        {
                            predoplataTA.DeleteQuery(dolgManyIDS[i]);
                        }
                        predoplataTA.Insert(predSumma - dolgSumma, DateTime.Now, PID);
                        plataTableAdapter1.Insert(dolgSumma, PID, textBox1.Text, DateTime.Now, "учет предоплаты");

                    }
                    else
                    { close = false; }
                }
            }

            else if ((string)this.Tag == "pay1")//"Оплата Долга";
            {
                if (numericUpDown1.Value == dolgSumma)
                {
                    dolgTableAdapter.Delete(dolgRow.ID, dolgRow.posesenie, dolgRow.dolg);
                    if (numericUpDown1.Value != 0)
                    {
                        plataTableAdapter1.Insert(numericUpDown1.Value, PID, textBox1.Text, DateTime.Now, "оплата лечения");
                    }

                }
                if (numericUpDown1.Value > dolgSumma)
                {
                    if (MessageBox.Show("Долг полностью погашен.\rВнести в предоплату остаток : " + (numericUpDown1.Value - dolgSumma).ToString() + " ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        dolgTableAdapter.DeleteQueryByID(dolgRow.ID);
                        plataTableAdapter1.Insert(dolgSumma, PID, textBox1.Text, DateTime.Now, "оплата лечения");
                        plataTableAdapter1.Insert(numericUpDown1.Value - dolgSumma, PID, textBox1.Text, DateTime.Now, "предоплата");
                        predoplataTA.Insert(numericUpDown1.Value - dolgSumma, DateTime.Now, PID);
                    }
                    else
                    { close = false; }
                }

                if (numericUpDown1.Value < dolgSumma)
                {
                    if (MessageBox.Show("Остаток долга : " + (dolgSumma - numericUpDown1.Value).ToString() + ".\rОставить долг, уменьшив его сумму?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        dolgTableAdapter.Update(dolgRow.posesenie, dolgSumma - numericUpDown1.Value, dolgRow.ID, dolgRow.posesenie, dolgRow.dolg);
                        if (numericUpDown1.Value != 0)
                        {
                            plataTableAdapter1.Insert(numericUpDown1.Value, PID, textBox1.Text, DateTime.Now, "оплата лечения");
                        }
                    } 
                    else
                    { close = false; }
                }
            }

            else if ((string)this.Tag == "pay0")//"СПИСАНИЕ ДОЛГА"
            {
                if (numericUpDown1.Value == dolgSumma)
                {
                    dolgTableAdapter.DeleteQueryByID(dolgRow.ID);
                 //  
                    plataTableAdapter1.Insert(numericUpDown1.Value, PID, textBox1.Text, DateTime.Now, "списание долга");

                }
                              

                if (numericUpDown1.Value < dolgSumma)
                {
                    if (MessageBox.Show("Остаток долга : " + (dolgSumma - numericUpDown1.Value).ToString() + ".\rОставить долг, уменьшив его сумму?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        dolgTableAdapter.Update(dolgRow.posesenie, dolgSumma - numericUpDown1.Value, dolgRow.ID, dolgRow.posesenie, dolgRow.dolg);
                        if (numericUpDown1.Value != 0)
                        {
                            plataTableAdapter1.Insert(numericUpDown1.Value, PID, textBox1.Text, DateTime.Now, "списание долга");
                        }
                    } 
                    else
                    { close = false; }
                }
            }
            else if ((string)this.Tag == "payAll")//"Оплата Долгов"
            {
                if (MessageBox.Show("Остаток долга : 0.\rОплачено : " + numericUpDown1.Value .ToString()+".", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    for (int i = 0; i < dolgManyIDS.Length; i++)
                    {
                        dolgTableAdapter.DeleteQueryByID(dolgManyIDS[i]);
                        
                    }
                    if (numericUpDown1.Value != 0)
                    {
                        plataTableAdapter1.Insert(numericUpDown1.Value, PID, textBox1.Text, DateTime.Now, "оплата лечения");
                    }
                }
            }
            else if ((string)this.Tag == "pred")//"Возврат Предоплаты"
            {
                predoplataTA.DeleteQuery(dolgOneID);
                if (numericUpDown1.Value != 0)
                {
                    plataTableAdapter1.Insert(numericUpDown1.Value, PID, textBox1.Text, DateTime.Now, "возврат предоплаты");
                }
            }
            if (close)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("функция пока не доступна");
        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
