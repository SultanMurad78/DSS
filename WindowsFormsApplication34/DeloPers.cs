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
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DSS
{
    public partial class DeloPers : Form
    {
        public DeloPers()
        {
            InitializeComponent();
        }


        int DID = 0;


        private void DeloPers_Load(object sender, EventArgs e)
        {
            DID = (int)this.Tag;
            this.personalProfessiaTableAdapter.Fill(this.___BASA__DataSet.PersonalProfessia);
            this.ulizaTableAdapter.Fill(this.___BASA__DataSet.Uliza);
            this.gorodTableAdapter.Fill(this.___BASA__DataSet.Gorod);
            this.oblastTableAdapter.Fill(this.___BASA__DataSet.Oblast);
            this.sexTableAdapter.Fill(this.___BASA__DataSet.Sex);
            if (DID != 0)
            {
                if (!isDeloNotDel())
                {
                    loadDelo();
                }
                else
                {
                    loadCleanDelo();
                }
            }
            else
            {
                loadCleanDelo();
            }
        }

        private bool isDeloNotDel()
        {
            bool b = false;
            if (DID != 0)
            {
                int n = personalTableAdapter.GetDataByID(DID).Rows.Count;
                // 
                if (n == 1 && kadryTableAdapter1.GetDataByDID(DID).Rows.Count == 0)
                {
                    DID = 0;
                    MessageBox.Show("Личное дело не найдено. Возможно, оно было удалено.", this.Text);
                    b = true;
                }
                else if (n > 1)
                {
                    DID = 0;
                    MessageBox.Show("Неопознанная ошибка(>1) базы данных, возможно, вызванная попыткой несанкционированного доступа", this.Text);
                    b = true;
                }
                else if (n == 0)
                {
                    DID = 0;
                    MessageBox.Show("Неопознанная ошибка(=0) базы данных, возможно, вызванная попыткой несанкционированного доступа", this.Text);
                    b = true;
                }
            }
            return b;
        }

        private void loadCleanDelo()
        {
            ___BASA__DataSet.PersonalRow newPersRow = this.___BASA__DataSet.Personal.AddPersonalRow("", "", null, "", DateTime.Today, DateTime.Today, null, "", "", "", "", "", null, null, false, "", "", "", null);
            newPersRow.Uliza = newPersRow.Gorod = 1;
            newPersRow.DProfessia = newPersRow.DProfessia = 1;
            change();
        }

        void change()
        {
            comboBoxProf.Visible = dateTimePickerReg.Visible = textBoxPNK.Visible = comboBoxGorod.Visible = comboBoxObl.Visible = comboBoxUl.Visible = comboBoxS.Visible = dateTimePickerBD.Visible = true;
            labelReg.Visible = labelPNK.Visible = false;
            textBoxNote.ReadOnly = textBoxF.ReadOnly = textBoxDom.ReadOnly = textBoxKv.ReadOnly = textBoxTD.ReadOnly = textBoxTM.ReadOnly = textBoxTR.ReadOnly = textBoxI.ReadOnly = textBoxO.ReadOnly = false;
            textBoxVozr.BorderStyle = textBoxF.BorderStyle = textBoxTR.BorderStyle = textBoxTM.BorderStyle = textBoxTD.BorderStyle = textBoxKv.BorderStyle = textBoxDom.BorderStyle = textBoxI.BorderStyle = textBoxO.BorderStyle = BorderStyle.Fixed3D;
            checkBoxIsDoc.Enabled = toolStripButtonDelPhoto.Enabled = TakePhototoolStripButton.Enabled = true;
            toolStripButton_Save.Enabled = toolStripButton_change.Enabled = chengToolStripMenuItem.Enabled = false;
        }

        private void loadDelo()
        {
            this.personalTableAdapter.FillByID(this.___BASA__DataSet.Personal, DID);
            ___BASA__DataSet.PersonalRow PersRow = ___BASA__DataSet.Personal[0];
            this.Text = "Персонал: " + PersRow.DFIO;

            if (!PersRow.IsUlizaNull())
            {
                ulizaBindingSource.Position = ulizaBindingSource.Find("UlizaID", PersRow.Uliza);
            }
            else
            {
                ulizaBindingSource.Position = ulizaBindingSource.Find("UlizaID", 1);
            }

            if (!PersRow.IsGorodNull())
            {
                oblastBindingSource.Position = oblastBindingSource.Find("OblastID", ___BASA__DataSet.Gorod.FindByGorodID((int)PersRow.Gorod).Oblast);
                gorodBindingSource.Position = gorodBindingSource.Find("GorodID", PersRow.Gorod);
            }
            else
            {
                oblastBindingSource.Position = oblastBindingSource.Find("OblastID", 1);
                gorodBindingSource.Position = gorodBindingSource.Find("GorodID", 1);
            }

            if (!PersRow.IsSexNull())
            {
                sexBindingSource.Position = sexBindingSource.Find("ID", PersRow.Sex.ToString());
            }
            else
            {
                textBoxS.Text = "";
                PersRow.SexRow = null;
            }
            if (!PersRow.IsDProfessiaNull())
            {
                personalProfessiaBindingSource.Position = personalProfessiaBindingSource.Find("PersProfessiaID", PersRow.DProfessia);
            }
            else
            {
                PersRow.PersonalProfessiaRow = null;
                textBoxProf.Text = "";
            }

            if (!PersRow.IsDBDNull())
            {
                textBoxVozr.Text = Vozrast((DateTime)PersRow.DBD).ToString();
            }
            else
            {
                textBoxVozr.Text = "";
            }
            ggrafikToolStripMenuItem.Enabled = chengToolStripMenuItem.Enabled =
                toolStripButtonMoney.Enabled = toolStripButton_change.Enabled = true;

            toolStripButton_Save.Enabled = false;
            if (pictureBoxPhoto.Image != null)
            {
                toolStripDropDownButtonZUMM.Enabled = true;
            }
        }



        private int Vozrast(DateTime bd)
        {
            int age;
            if (bd.Month < DateTime.Today.Month || bd.Month == DateTime.Today.Month && bd.Day <= DateTime.Today.Day)
            {
                age = DateTime.Today.Year - bd.Year;
            }
            else
            {
                age = DateTime.Today.Year - bd.Year - 1;
            }
            return age;
        }

        private void textBoxF_TextChanged(object sender, EventArgs e)
        {
            toolStripButton_Save.Enabled = true;
        }

        private void toolStripButton_change_Click(object sender, EventArgs e)
        {
            change();
        }

        private void TakePhototoolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxPhoto.ImageLocation = openFileDialog1.FileName;
                    this.ValidateChildren(ValidationConstraints.Visible);
                    toolStripDropDownButtonZUMM.Enabled = toolStripButton_Save.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        private void toolStripButtonDelPhoto_Click(object sender, EventArgs e)
        {
            pictureBoxPhoto.Image = null;
            pictureBoxPhoto.DataBindings[0].WriteValue();
            toolStripButton_Save.Enabled = true;
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoom((ToolStripMenuItem)sender);
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void strechToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoom((ToolStripMenuItem)sender);
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoom((ToolStripMenuItem)sender);
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoom((ToolStripMenuItem)sender);
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.Normal;
        }

        void zoom(ToolStripMenuItem item)
        {
            foreach (ToolStripMenuItem chItem in toolStripDropDownButtonZUMM.DropDownItems)
            {
                chItem.Checked = false;

            }
            item.Checked = true;
        }

        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            Save(false);
        }

        private bool Save(bool onCloseF)
        {
            bool saveOK = true;
            Cursor = Cursors.WaitCursor;
            if (!isDeloNotDel())
            {
                if (check_Filds())
                {
                    check_U_G_O_P();
                    this.personalBindingSource.EndEdit();
                    oblastBindingSource.EndEdit();
                    gorodBindingSource.EndEdit();
                    ulizaBindingSource.EndEdit();
                    personalProfessiaBindingSource.EndEdit();
                    if (check_Basa())
                    {
                        personalTableAdapter.Update(___BASA__DataSet.Personal);
                        if (DID == 0)
                        {
                            DID = (int)(personalTableAdapter.GetDataByAll(textBoxF.Text, textBoxI.Text, textBoxO.Text, dateTimePickerBD.Value, (int)comboBoxUl.SelectedValue, (int)comboBoxGorod.SelectedValue)[0].DID);
                            this.Tag = DID;
                            kadryTableAdapter1.Insert(DID, true);
                            ggrafikToolStripMenuItem.Enabled = toolStripButtonMoney.Enabled = true;

                        }

                        if (!onCloseF)
                        {
                            loadDelo();

                            comboBoxProf.Visible = dateTimePickerReg.Visible = textBoxPNK.Visible = comboBoxGorod.Visible = comboBoxObl.Visible = comboBoxUl.Visible = comboBoxS.Visible = dateTimePickerBD.Visible = false;
                            labelReg.Visible = labelPNK.Visible = true;
                            textBoxNote.ReadOnly = textBoxF.ReadOnly = textBoxDom.ReadOnly = textBoxKv.ReadOnly = textBoxTD.ReadOnly = textBoxTM.ReadOnly = textBoxTR.ReadOnly = textBoxI.ReadOnly = textBoxO.ReadOnly = true;
                            textBoxVozr.BorderStyle = textBoxF.BorderStyle = textBoxTR.BorderStyle = textBoxTM.BorderStyle = textBoxTD.BorderStyle = textBoxKv.BorderStyle = textBoxDom.BorderStyle = textBoxI.BorderStyle = textBoxO.BorderStyle = BorderStyle.None;
                            toolStripButton_Save.Enabled = false;
                            chengToolStripMenuItem.Enabled = toolStripButton_change.Enabled = true;
                            checkBoxIsDoc.Enabled = toolStripButtonDelPhoto.Enabled = TakePhototoolStripButton.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Сотрудник \"" + textBoxF.Text.ToUpper() + " " + textBoxI.Text.ToUpper() + " " + textBoxO.Text.ToUpper() + " \", проживающий по указанному адресу, уже работает у Вас.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        saveOK = false;
                    }
                }
                else
                {
                    saveOK = false;
                }


            }
            else
            {
                if (!onCloseF)
                {
                    ___BASA__DataSet.Personal.Clear();
                    DID = 0;
                    loadCleanDelo();
                }
            }
            Cursor = Cursors.Default;
            return saveOK;
        }

        bool check_Filds()//проверяем правильность заполнения юзером значений
        {
            bool da = true;
            if (textBoxF.Text == "")
            {
                MessageBox.Show("Пожалуйста, укажите фамилию.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                da = false;
            }
            else if (comboBoxS.Text == "")
            {
                MessageBox.Show("Пожалуйста, укажите пол.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                da = false;
            }
            else if (dateTimePickerBD.Text == "")
            {
                MessageBox.Show("Пожалуйста, укажите дату рождения.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                da = false;
            }


            return da;
        }

        void check_U_G_O_P()//проверка - поля улица. город. ... введены новые или взяты из имеющихся
        {
            string ulica = comboBoxUl.Text;
            bool blUL = false;
            foreach (DataRow dr in ulizaTableAdapter.GetData().Rows)
            {
                if (dr["Uliza"].ToString() == ulica)
                {
                    blUL = true;
                    break;
                }
            }
            if (!blUL)
            {
                ulizaTableAdapter.Insert(ulica);
                ulizaTableAdapter.Fill(___BASA__DataSet.Uliza);

            }
            ulizaBindingSource.Position = ulizaBindingSource.Find("Uliza", ulica);
            /////////////////////////////////////////////////////////////////////////          ////////////
            string prof = comboBoxProf.Text;
            bool blPPr = false;
            foreach (DataRow dr in personalProfessiaTableAdapter.GetData().Rows)
            {
                if (dr["PersProfessia"].ToString() == prof)
                {
                    blPPr = true;
                    break;
                }
            }
            if (!blPPr)
            {
                personalProfessiaTableAdapter.Insert(prof);
                personalProfessiaTableAdapter.Fill(___BASA__DataSet.PersonalProfessia);

            }
            personalProfessiaBindingSource.Position = personalProfessiaBindingSource.Find("PersProfessia", prof);
            /////////////////////////////////////////////////////////////////////////////////////////////////
            string gor = comboBoxGorod.Text;
            string obl = comboBoxObl.Text;
            bool blObl = false;
            foreach (DataRow dr in oblastTableAdapter.GetData().Rows)
            {
                if (dr["Oblast"].ToString() == obl)
                {
                    blObl = true;
                    break;
                }
            }
            if (!blObl)
            {
                oblastTableAdapter.Insert(obl);
                oblastTableAdapter.Fill(___BASA__DataSet.Oblast);
                int pos = oblastBindingSource.Find("Oblast", obl);

                gorodTableAdapter.Insert(gor, (int)((DataRowView)oblastBindingSource[pos])["OblastID"]);
                gorodTableAdapter.Fill(___BASA__DataSet.Gorod);

            }//
            else
            {
                bool blg = false;
                foreach (DataRow dr in gorodTableAdapter.GetData().Rows)
                {
                    if (dr["Gorod"].ToString() == gor && (int)dr["Oblast"] == (int)((DataRowView)oblastBindingSource.Current)["OblastID"])
                    {
                        blg = true;
                        break;
                    }
                }
                if (!blg)
                {
                    gorodTableAdapter.Insert(gor, (int)((DataRowView)oblastBindingSource.Current)["OblastID"]);
                    gorodTableAdapter.Fill(___BASA__DataSet.Gorod);
                }
            }
            oblastBindingSource.Position = oblastBindingSource.Find("Oblast", obl);

            gorodBindingSource.Position = gorodBindingSource.Find("Gorod", gor);
        }


        bool check_Basa()
        {

            bool da = true;
            if (DID == 0)
            {
                ___BASA__DataSet.PersonalRow CurPatrow = ___BASA__DataSet.Personal[0];
                foreach (DataRow Prow in personalTableAdapter.GetDataByAll(CurPatrow.DF, CurPatrow.DI, CurPatrow.DO, CurPatrow.DBD, CurPatrow.Uliza, CurPatrow.Gorod).Rows)
                {
                    if (kadryTableAdapter1.GetDataByDID((int)Prow["DID"]).Count > 0)
                    {
                        da = false;
                        break;
                    }
                }
            }
            return da;
        }

        private void DeloPers_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            if (toolStripButton_Save.Enabled)
            {
                Question Qu = new Question();
                Qu.Text = this.Text;
                DialogResult res = Qu.ShowDialog();
                if (res == DialogResult.Yes)
                {
                    if (!Save(true))
                    {
                        e.Cancel = true;
                        if (this.MdiParent.ActiveMdiChild != this)
                        {
                            ((MainForm)this.MdiParent).checkWin(this);
                        }
                    }
                }
                else if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    if (this.MdiParent.ActiveMdiChild != this)
                    {
                        ((MainForm)this.MdiParent).checkWin(this);
                    }
                }
            }
        }

        private void toolStripButtonMoney_Click(object sender, EventArgs e)
        {
            RaspChenge rc = new RaspChenge();
            if (rc.ShowDialog() == DialogResult.Yes)
            {
                foreach (Form f in this.MdiParent.MdiChildren)
                {
                    if (f.GetType() == typeof(ZapisZur))
                    {
                        MessageBox.Show("В данный момент открыто окно предварительной записи. Не забудте его обновить для учета изменений.");
                    }
                }
            }
        }

        private void oblastBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (((DataRowView)oblastBindingSource.Current) != null)
            { gorodBindingSource.Filter = "Oblast=" + ((DataRowView)oblastBindingSource.Current)["OblastID"].ToString(); }
        }

        private void pictureBoxPhoto_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            pictureBoxPhoto.DataBindings[0].WriteValue();
        }

        private void toolStripButton_Save_EnabledChanged(object sender, EventArgs e)
        {
            saveToolStripMenuItem.Enabled = toolStripButton_Save.Enabled;
        }

        private void dateTimePickerBD_ValueChanged(object sender, EventArgs e)
        {
            textBoxVozr.Text = Vozrast(dateTimePickerBD.Value).ToString();
            toolStripButton_Save.Enabled = true;
        }

        private void DeloPers_Activated(object sender, EventArgs e)
        {
            if (isDeloNotDel())
            {
                DID = 0;
                ___BASA__DataSet.Personal.Clear();
                loadCleanDelo();
            }
        }
    }
}
