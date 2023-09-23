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
    public partial class AddZapis : Form
    {
        public AddZapis()
        {
            InitializeComponent();
        }

        private void AddZapis_Load(object sender, EventArgs e)
        {
            kartyTableAdapter.Fill(___BASA__DataSet.Karty, true);
            if (((int)((ZapisZur)this.Tag).pid) == 0)
            {
                comboBoxPat.Text = "";
                radioButtonTXT.Checked = true;
                richTextBoxTXT.Text = ((string)((ZapisZur)this.Tag).postS);
            }

            else
            {
                kartyBindingSource.Position = kartyBindingSource.Find("PID", (int)((ZapisZur)this.Tag).pid);
                richTextBoxPS.Text = ((string)((ZapisZur)this.Tag).postS);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool q = false;
            foreach (object it in comboBoxPat.Items)
            {
                if ((((DataRowView)it)["PF"]).ToString().StartsWith(textBoxSearch.Text, true, null))
                {
                    textBoxSearch.ForeColor = Color.Black;
                    comboBoxPat.SelectedItem = (DataRowView)it;
                    comboBoxPat.SelectionLength = textBoxSearch.Text.Length;
                    q = true;
                    break;
                }

            }
            if (!q)
            {

                if (textBoxSearch.Text != "")
                {
                    textBoxSearch.ForeColor = Color.Red;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (radioButtonPAT.Checked)
            {
                ((ZapisZur)this.Tag).pid = (int)comboBoxPat.SelectedValue;
                ((ZapisZur)this.Tag).postS = richTextBoxPS.Text;
                ((ZapisZur)this.Tag).zapis = "Пациент: " + (string)comboBoxPat.Text;
                if (richTextBoxPS.Text != "")
                {
                    ((ZapisZur)this.Tag).zapis = "Пациент: " + (string)comboBoxPat.Text + ";\rЗаметка:  " + richTextBoxPS.Text;
                }
            }

            else if (richTextBoxTXT.Text != "")
            {
                ((ZapisZur)this.Tag).pid = 0;
                ((ZapisZur)this.Tag).zapis = "Заметка: " + richTextBoxTXT.Text;
                ((ZapisZur)this.Tag).postS = richTextBoxTXT.Text;

            }
            else
            {
                ((ZapisZur)this.Tag).pid = 0;
                ((ZapisZur)this.Tag).zapis = "";
                ((ZapisZur)this.Tag).postS = richTextBoxTXT.Text;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPAT.Checked)
            {
                comboBoxPat.Enabled = textBoxSearch.Enabled = richTextBoxPS.Enabled = true;
                richTextBoxTXT.Enabled = false;
            }
            else
            {
                comboBoxPat.Enabled = textBoxSearch.Enabled = richTextBoxPS.Enabled = false;
                richTextBoxTXT.Enabled = true;
            }
        }
    }
}
