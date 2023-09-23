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
using System.Threading;
using System.Data.OleDb;

namespace DSS
{
    public partial class KartaForm : Form
    {
        public KartaForm()
        {
            InitializeComponent();
        }

        int PID;

        void updateHistory()
        {
            panelHistory.Controls.Clear();
            if (PID != 0)
            {
                posesenieTableAdapter.FillByPID(___BASA__DataSet.Posesenie, PID);
                History();
            }
            else
            {
                ___BASA__DataSet.Posesenie.Clear();
            }
        }

        private void KartaForm_Load(object sender, EventArgs e)
        {
            PID = (int)this.Tag;
            ulizaTableAdapter.Adapter.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(ULAdapter_RowUpdated);
            patientsTableAdapter.Adapter.RowUpdated += new OleDbRowUpdatedEventHandler(PATAdapter_RowUpdated);
            patientsRabotaTableAdapter.Adapter.RowUpdated += new OleDbRowUpdatedEventHandler(PATRABAdapter_RowUpdated);
            patientsProfessiaTableAdapter.Adapter.RowUpdated += new OleDbRowUpdatedEventHandler(PATPROFAdapter_RowUpdated);
            gorodTableAdapter.Adapter.RowUpdated += new OleDbRowUpdatedEventHandler(GORAdapter_RowUpdated);
            oblastTableAdapter.Adapter.RowUpdated += new OleDbRowUpdatedEventHandler(OBLAdapter_RowUpdated);

            ///////////////////      добавляем кнопку параметры печати на окно предварительного просмотра перед печатью            ////////////////////
            ToolStripButton Pagesetup = new ToolStripButton("Параметры печати");
            Pagesetup.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            Pagesetup.Click += new EventHandler(Pagesetup_Click);
            ((ToolStrip)printPreviewDialog.Controls.Find("toolStrip1", false)[0]).Items.Insert(1, Pagesetup);
            ((ToolStrip)printPreviewDialog.Controls.Find("toolStrip1", false)[0]).Items.Insert(2, new ToolStripSeparator());
            ((Form)printPreviewDialog).WindowState = FormWindowState.Maximized;
            ((Form)printPreviewDialog).MaximizeBox = false;
            ((Form)printPreviewDialog).ShowInTaskbar = false;
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////          

            patientsRabotaTableAdapter.Fill(___BASA__DataSet.PatientsRabota);
            patientsProfessiaTableAdapter.Fill(___BASA__DataSet.PatientsProfessia);
            gorodTableAdapter.Fill(___BASA__DataSet.Gorod);
            ulizaTableAdapter.Fill(___BASA__DataSet.Uliza);
            sexTableAdapter.Fill(___BASA__DataSet.Sex);
            oblastTableAdapter.Fill(___BASA__DataSet.Oblast);
            sexTableAdapter.Fill(___BASA__DataSet.Sex);

            if (PID != 0)
            {
                if (!isKartaNotDel())
                {
                    loadPatientKarta();
                }
                else
                {
                    loadCleanKarta();
                }
            }
            else
            {
                loadCleanKarta();
            }
        }

        void OBLAdapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            if (e.StatementType == StatementType.Insert)
            {
                OleDbCommand cmdNewID = new OleDbCommand("SELECT @@IDENTITY", oblastTableAdapter.Connection);
                cmdNewID.Transaction = oblastTableAdapter.Transaction;  // Retrieve the Autonumber and store it in the CategoryID column.

                ((___BASA__DataSet.OblastRow)e.Row).OblastID = (int)cmdNewID.ExecuteScalar();
            }
        }

        void GORAdapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            if (e.StatementType == StatementType.Insert)
            {
                OleDbCommand cmdNewID = new OleDbCommand("SELECT @@IDENTITY", gorodTableAdapter.Connection);
                cmdNewID.Transaction = gorodTableAdapter.Transaction;  // Retrieve the Autonumber and store it in the CategoryID column.

                ((___BASA__DataSet.GorodRow)e.Row).GorodID = (int)cmdNewID.ExecuteScalar();
            }
        }

        void PATPROFAdapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            if (e.StatementType == StatementType.Insert)
            {
                OleDbCommand cmdNewID = new OleDbCommand("SELECT @@IDENTITY", patientsProfessiaTableAdapter.Connection);
                cmdNewID.Transaction = patientsProfessiaTableAdapter.Transaction;  // Retrieve the Autonumber and store it in the CategoryID column.

                ((___BASA__DataSet.PatientsProfessiaRow)e.Row).ProfessiaID = (int)cmdNewID.ExecuteScalar();

            }
        }

        void PATRABAdapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            if (e.StatementType == StatementType.Insert)
            {
                OleDbCommand cmdNewID = new OleDbCommand("SELECT @@IDENTITY", patientsRabotaTableAdapter.Connection);
                cmdNewID.Transaction = patientsRabotaTableAdapter.Transaction;  // Retrieve the Autonumber and store it in the CategoryID column.

                ((___BASA__DataSet.PatientsRabotaRow)e.Row).ID = (int)cmdNewID.ExecuteScalar();

            }
        }

        void PATAdapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            if (e.StatementType == StatementType.Insert)
            {
                OleDbCommand cmdNewID = new OleDbCommand("SELECT @@IDENTITY", patientsTableAdapter.Connection);
                cmdNewID.Transaction = patientsTableAdapter.Transaction;  // Retrieve the Autonumber and store it in the CategoryID column.

                ((___BASA__DataSet.PatientsRow)e.Row).PID = (int)cmdNewID.ExecuteScalar();
            }
        }

        void ULAdapter_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.StatementType == StatementType.Insert)
            {
                OleDbCommand cmdNewID = new OleDbCommand("SELECT @@IDENTITY", ulizaTableAdapter.Connection);
                cmdNewID.Transaction = ulizaTableAdapter.Transaction;  // Retrieve the Autonumber and store it in the CategoryID column.

                ((___BASA__DataSet.UlizaRow)e.Row).UlizaID = (int)cmdNewID.ExecuteScalar();

            }
        }



        private bool isKartaNotDel()
        {
            bool b = false;
            if (PID != 0)
            {
                int n = patientsTableAdapter.GetDataBy(PID).Rows.Count;
                if (n == 1 && kartaTableAdapter.ScalarQueryCuontByPID(PID) == 0)
                {
                    PID = 0;
                    MessageBox.Show("Карточка не найдена. Возможно, она была удалена.", this.Text);
                    b = true;
                }
                else if (n > 1)
                {
                    PID = 0;
                    MessageBox.Show("Неопознанная ошибка(>1) базы данных, возможно, вызванная попыткой несанкционированного доступа", this.Text);
                    b = true;
                }
                else if (n == 0)
                {
                    PID = 0;
                    MessageBox.Show("Неопознанная ошибка(=0) базы данных, возможно, вызванная попыткой несанкционированного доступа", this.Text);
                    b = true;
                }
            }
            return b;
        }

        private void loadPatientKarta()
        {

            patientsTableAdapter.FillBy(___BASA__DataSet.Patients, PID);
            ___BASA__DataSet.PatientsRow PatRow = ___BASA__DataSet.Patients[0];
            this.Text = "Карточка: " + PatRow.PFIO;
            if (!PatRow.IsUlizaNull())
            {
                ulizaBindingSource.Position = ulizaBindingSource.Find("UlizaID", PatRow.Uliza);
            }
            else
            {
                ulizaBindingSource.Position = ulizaBindingSource.Find("UlizaID", 1);

            }

            if (!PatRow.IsGorodNull())
            {
                oblastBindingSource.Position = oblastBindingSource.Find("OblastID", ___BASA__DataSet.Gorod.FindByGorodID((int)PatRow.Gorod).Oblast);
                gorodBindingSource.Position = gorodBindingSource.Find("GorodID", PatRow.Gorod);

            }
            else
            {
                oblastBindingSource.Position = oblastBindingSource.Find("OblastID", 1);
                gorodBindingSource.Position = gorodBindingSource.Find("GorodID", 1);

            }
            if (!PatRow.IsRabotaNull())
            {
                patientsRabotaBindingSource.Position = patientsRabotaBindingSource.Find("ID", PatRow.Rabota);
            }
            else
            {
                patientsRabotaBindingSource.Position = patientsRabotaBindingSource.Find("ID", 2);

            }
            if (!PatRow.IsSexNull())
            {
                sexBindingSource.Position = sexBindingSource.Find("ID", PatRow.Sex.ToString());
            }
            else
            {
                textBoxS.Text = "";
                PatRow.SexRow = null;
            }
            if (!PatRow.IsProfessiaNull())
            {
                patientsProfessiaBindingSource.Position = patientsProfessiaBindingSource.Find("ProfessiaID", PatRow.Professia);
            }
            else
            {
                patientsProfessiaBindingSource.Position = patientsProfessiaBindingSource.Find("ProfessiaID", 2);

            }
            if (!PatRow.IsPBDNull())
            {
                textBoxVozr.Text = Vozrast((DateTime)PatRow.PBD).ToString();
            }
            else
            {
                textBoxVozr.Text = "";
            }

            moneyToolStripMenuItem.Enabled = newTRToolStripMenuItem.Enabled = chengToolStripMenuItem.Enabled =
           toolStripButtonMoney.Enabled = toolStripButtonNewTreat.Enabled = toolStripButton_change.Enabled = true;
            saveToolStripMenuItem.Enabled = toolStripButton_Save.Enabled = false;

            if (pictureBoxPhoto.Image != null)
            {
                toolStripDropDownButtonZUMM.Enabled = true;
            }
            posesenieTableAdapter.FillByPID(___BASA__DataSet.Posesenie, PID);
            History();
        }

        void addLabelControl(Label lbDate)
        {
            lbDate.TextAlign = ContentAlignment.MiddleLeft;
            lbDate.AutoSize = false;
            lbDate.Dock = DockStyle.Top;
            panelHistory.Controls.Add(lbDate);
            lbDate.BringToFront();
        }

        void addRichControl(Control con)
        {
            con.Dock = DockStyle.Top;
            panelHistory.Controls.Add(con);
            con.BringToFront();
        }

        void richBoxParam(RichTextBox box)
        {
            box.ShowSelectionMargin = true;
            box.WordWrap = true;
            box.BorderStyle = BorderStyle.None;
            box.ReadOnly = true;
            box.ScrollBars = RichTextBoxScrollBars.None;
            box.ContentsResized += new ContentsResizedEventHandler(box_ContentsResized);
            box.Enabled = false;
            box.ForeColor = Color.MidnightBlue;
        }



        void box_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            if (((RichTextBox)sender).Height != e.NewRectangle.Height)
            {
                ((RichTextBox)sender).Height = e.NewRectangle.Height;
            }
        }



        private void History()
        {
            foreach (DataRow dr in ___BASA__DataSet.Posesenie.Rows)
            {
                LinkLabel lbDate = new LinkLabel();
                lbDate.Text = ((DateTime)dr["Data"]).ToLongDateString() + " " + ((DateTime)dr["Data"]).ToShortTimeString();
                lbDate.LinkColor = Color.Red;
                addLabelControl(lbDate);


                Label doctor = new Label();
                doctor.Text = "Врач- " + dr["DFIO"].ToString();
                addLabelControl(doctor);

                Label zal = new Label();
                zal.Text = "Жалобы";
                addLabelControl(zal);

                RichTextBox zalobiText = new RichTextBox();
                richBoxParam(zalobiText);
                zalobiText.Text = dr["Zaloby"].ToString();
                addRichControl(zalobiText);

                Label anam = new Label();
                anam.Text = "Анамнез";
                addLabelControl(anam);

                RichTextBox anamText = new RichTextBox();
                richBoxParam(anamText);
                anamText.Text = dr["Anamnez"].ToString();
                addRichControl(anamText);

                Label obekt = new Label();
                obekt.Text = "Объективно";
                addLabelControl(obekt);

                RichTextBox obektText = new RichTextBox();
                richBoxParam(obektText);
                obektText.Text = dr["Obekt"].ToString();
                addRichControl(obektText);

                Label ds = new Label();
                ds.Text = "Диагноз";
                addLabelControl(ds);

                RichTextBox dsText = new RichTextBox();
                richBoxParam(dsText);
                dsText.Text = dr["Diagnos"].ToString();
                addRichControl(dsText);

                Label tr = new Label();
                tr.Text = "Лечение";
                addLabelControl(tr);


                RichTextBox trText = new RichTextBox();
                richBoxParam(trText);
                trText.Text = dr["Treat"].ToString();
                addRichControl(trText);

                RichTextBox befor = new RichTextBox();
                befor.Height = 25;
                richBoxParam(befor);
                addRichControl(befor);

            }
        }

        void loadCleanKarta()
        {
            ___BASA__DataSet.Patients.Clear();
            this.Text = "Карточка: Новая";
            ___BASA__DataSet.PatientsRow newPatRow = this.___BASA__DataSet.Patients.AddPatientsRow(null, null, "", "", DateTime.Today, "", "", DateTime.Today, "", "", null, "", "", "", null, null, null, "");
            newPatRow.Uliza = newPatRow.Gorod = 1;
            newPatRow.Rabota = newPatRow.Professia = 2;
            change();
        }

        void change()
        {
            comboBoxProf.Visible = comboBoxRab.Visible = dateTimePickerReg.Visible = textBoxPNK.Visible = comboBoxGorod.Visible = comboBoxObl.Visible = comboBoxUl.Visible = comboBoxS.Visible = dateTimePickerBD.Visible = true;
            labelReg.Visible = labelPNK.Visible = false;
            textBoxNote.ReadOnly = textBoxF.ReadOnly = textBoxDom.ReadOnly = textBoxKv.ReadOnly = textBoxTD.ReadOnly = textBoxTM.ReadOnly = textBoxTR.ReadOnly = textBoxI.ReadOnly = textBoxO.ReadOnly = false;

            textBoxVozr.BorderStyle = textBoxF.BorderStyle = textBoxTR.BorderStyle = textBoxTM.BorderStyle = textBoxTD.BorderStyle = textBoxKv.BorderStyle = textBoxDom.BorderStyle = textBoxI.BorderStyle = textBoxO.BorderStyle = BorderStyle.Fixed3D;
            toolStripButtonDelPhoto.Enabled = TakePhototoolStripButton.Enabled = true;
            saveToolStripMenuItem.Enabled = chengToolStripMenuItem.Enabled =

             toolStripButton_Save.Enabled = toolStripButton_change.Enabled = false;

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

        private bool Save(bool onCloseF)
        {
            this.Validate();
            bool saveOK = true;
            Cursor = Cursors.WaitCursor;
            if (!isKartaNotDel())
            {
                if (check_Filds())
                {
                    check_U_G_O_P();
                    this.patientsBindingSource.EndEdit();
                    oblastBindingSource.EndEdit();
                    gorodBindingSource.EndEdit();
                    ulizaBindingSource.EndEdit();
                    if (check_Basa())
                    {
                        patientsTableAdapter.Update(___BASA__DataSet.Patients);
                        if (PID == 0)
                        {
                            PID = ___BASA__DataSet.Patients[0].PID;
                            this.Tag = PID;
                            kartaTableAdapter.Insert(PID, true);
                            moneyToolStripMenuItem.Enabled = newTRToolStripMenuItem.Enabled =
                            toolStripButtonMoney.Enabled = toolStripButtonNewTreat.Enabled = true;
                        }

                        if (!onCloseF)
                        {
                            // loadPatientKarta();
                            this.Text = "Карточка: " + ___BASA__DataSet.Patients[0].PFIO;
                            comboBoxProf.Visible = comboBoxRab.Visible = dateTimePickerReg.Visible = textBoxPNK.Visible = comboBoxGorod.Visible = comboBoxObl.Visible = comboBoxUl.Visible = comboBoxS.Visible = dateTimePickerBD.Visible = false;
                            labelReg.Visible = labelPNK.Visible = true;
                            textBoxNote.ReadOnly = textBoxF.ReadOnly = textBoxDom.ReadOnly = textBoxKv.ReadOnly = textBoxTD.ReadOnly = textBoxTM.ReadOnly = textBoxTR.ReadOnly = textBoxI.ReadOnly = textBoxO.ReadOnly = true;
                            textBoxVozr.BorderStyle = textBoxF.BorderStyle = textBoxTR.BorderStyle = textBoxTM.BorderStyle = textBoxTD.BorderStyle = textBoxKv.BorderStyle = textBoxDom.BorderStyle = textBoxI.BorderStyle = textBoxO.BorderStyle = BorderStyle.None;
                            saveToolStripMenuItem.Enabled = toolStripButton_Save.Enabled = false;
                            chengToolStripMenuItem.Enabled = toolStripButton_change.Enabled = true;
                            toolStripButtonDelPhoto.Enabled = TakePhototoolStripButton.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Карточка для пациента \" " + textBoxF.Text.ToUpper() + " " + textBoxI.Text.ToUpper() + " " + textBoxO.Text.ToUpper() + "\", проживающего по указанному адресу, была зерегистрирована ранее.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    ___BASA__DataSet.Patients.Clear();
                    PID = 0;
                    loadCleanKarta();
                    updateHistory();
                }
            }

            Cursor = Cursors.Default;
            return saveOK;
        }

        private void comboBoxObl_TextChanged(object sender, EventArgs e)
        {
            saveToolStripMenuItem.Enabled = toolStripButton_Save.Enabled = true;

        }

        private void toolStripButton_change_Click(object sender, EventArgs e)
        {
            change();
        }

        void check_U_G_O_P()//проверка - поля улица. город. ... введены новые или взяты из имеющихся
        {
            string rab = comboBoxRab.Text;
            bool blRab = false;
            foreach (DataRow dr in patientsRabotaTableAdapter.GetData().Rows)
            {

                if (dr["Rabota"].ToString() == rab)
                {
                    blRab = true;
                    break;
                }
            }
            if (!blRab)
            {
                ___BASA__DataSet.PatientsRabota.AddPatientsRabotaRow(rab);
                patientsRabotaTableAdapter.Update(___BASA__DataSet.PatientsRabota);
                patientsRabotaBindingSource.Position = patientsRabotaBindingSource.Find("Rabota", rab);
            }

            /////////////////////////////////////////////////////////////////////////////////  
            string ulica = comboBoxUl.Text;
            bool blUL = false;
            foreach (___BASA__DataSet.UlizaRow dr in ulizaTableAdapter.GetData())
            {
                if (dr.Uliza == ulica)
                {
                    blUL = true;
                    break;
                }
            }
            if (!blUL)
            {
                ___BASA__DataSet.Uliza.AddUlizaRow(ulica);
                ulizaTableAdapter.Update(___BASA__DataSet.Uliza);
                ulizaBindingSource.Position = ulizaBindingSource.Find("Uliza", ulica);


            }
            /////////////////////////////////////////////////////////////////////////          ////////////
            string prof = comboBoxProf.Text;
            bool blPPr = false;
            foreach (DataRow dr in patientsProfessiaTableAdapter.GetData().Rows)
            {
                if (dr["Professia"].ToString() == prof)
                {
                    blPPr = true;
                    break;
                }
            }
            if (!blPPr)
            {
                ___BASA__DataSet.PatientsProfessia.AddPatientsProfessiaRow(prof);
                patientsProfessiaTableAdapter.Update(___BASA__DataSet.PatientsProfessia);
                patientsProfessiaBindingSource.Position = patientsProfessiaBindingSource.Find("Professia", prof);

            }
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
                ___BASA__DataSet.Oblast.AddOblastRow(obl);
                oblastTableAdapter.Update(___BASA__DataSet.Oblast);
                int pos = oblastBindingSource.Find("Oblast", obl);

                ___BASA__DataSet.GorodRow NewG = ___BASA__DataSet.Gorod.NewGorodRow();
                NewG.Gorod = gor;
                NewG.Oblast = (int)((DataRowView)oblastBindingSource[pos])["OblastID"];
                ___BASA__DataSet.Gorod.AddGorodRow(NewG);
                gorodTableAdapter.Update(___BASA__DataSet.Gorod);

                oblastBindingSource.Position = oblastBindingSource.Find("Oblast", obl);

                gorodBindingSource.Position = gorodBindingSource.Find("Gorod", gor);

            }
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
                    ___BASA__DataSet.GorodRow NewG = ___BASA__DataSet.Gorod.NewGorodRow();
                    NewG.Gorod = gor;
                    NewG.Oblast = (int)((DataRowView)oblastBindingSource.Current)["OblastID"];
                    ___BASA__DataSet.Gorod.AddGorodRow(NewG);
                    gorodTableAdapter.Update(___BASA__DataSet.Gorod);
                    oblastBindingSource.Position = oblastBindingSource.Find("Oblast", obl);
                    gorodBindingSource.Position = gorodBindingSource.Find("Gorod", gor);
                }
            }
        }

        bool check_Filds()//проверяем правильность заполнения юзером значений
        {
            bool da = true;
            if (textBoxF.Text == "")
            {
                MessageBox.Show("Пожалуйста, укажите фамилию.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                da = false;
            }
            else if (comboBoxS.Text == "")
            {
                MessageBox.Show("Пожалуйста, укажите пол.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                da = false;
            }
            else if (dateTimePickerBD.Text == "")
            {
                MessageBox.Show("Пожалуйста, укажите дату рождения.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                da = false;
            }
            return da;
        }

        bool check_Basa()
        {
            bool da = true;
            if (PID == 0)
            {
                ___BASA__DataSet.PatientsRow CurPatrow = ___BASA__DataSet.Patients[0];
                foreach (DataRow Prow in patientsTableAdapter.GetDataByAllColumns(CurPatrow.PF, CurPatrow.PI, CurPatrow.PO, CurPatrow.PBD, CurPatrow.Gorod, CurPatrow.Uliza).Rows)
                {
                    if (kartaTableAdapter.ScalarQueryCuontByPID((int)Prow["PID"]) > 0)
                    {
                        da = false;
                        break;
                    }
                }
            }
            return da;
        }

        private void TakePhoto_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxPhoto.ImageLocation = openFileDialog1.FileName;

                    saveToolStripMenuItem.Enabled = toolStripDropDownButtonZUMM.Enabled = toolStripButton_Save.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }

        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog.ShowDialog();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Ошибка печати", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        void Pagesetup_Click(object sender, EventArgs e)
        {
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog.PrintPreviewControl.InvalidatePreview();
            }
        }

        int POSCOUNTcur;
        int ROWCOUNTcur;
        int pageN = 1;

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.HasMorePages = false;
            bool done = true;
            Font mainF = new Font("Arial", 10);
            Font boldF = new Font("Arial", 11, FontStyle.Bold);
            Font mainBold = new Font("Arial", 10, FontStyle.Bold);
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            int wights = e.MarginBounds.Width;
            int heits = e.MarginBounds.Height + e.MarginBounds.Top;
            int reload = 0;
            if (pageN == 1 && kartaTableAdapter.GetDataBy2(PID).Count > 0)
            {
                reload = (int)e.Graphics.MeasureString("Амбулаторная карта №" + ___BASA__DataSet.Patients[0].PNK, boldF, wights).Height;
                e.Graphics.DrawString("Амбулаторная карта №" + ___BASA__DataSet.Patients[0].PNK, boldF, Brushes.DarkGray, new Rectangle(x, y, wights, reload));
                y += reload;
                reload = (int)e.Graphics.MeasureString(___BASA__DataSet.Patients[0].PFIO, boldF, wights).Height;
                e.Graphics.DrawString(___BASA__DataSet.Patients[0].PFIO, boldF, Brushes.DarkGray, new Rectangle(x, y, wights, reload));
                y += reload + 10;
            }
            pageN++;
            for (int posCount = POSCOUNTcur; posCount < Big[0].Length; posCount++)
            {
                for (int N = ROWCOUNTcur; N <= 11; N++)
                {
                    if (N == 0)
                    {
                        e.Graphics.DrawString(Big[N][posCount], boldF, Brushes.Black, x, y);
                        y += 18;
                    }
                    else if ((N == 2 || N == 4 || N == 6 || N == 8 || N == 10))
                    {
                        e.Graphics.DrawString(Big[N][posCount], mainBold, Brushes.Black, x + 5, y);
                        y += 15;
                    }

                    else if ((int)e.Graphics.MeasureString(Big[N][posCount], mainF, wights - 10).Height + y < heits)
                    {
                        reload = (int)e.Graphics.MeasureString(Big[N][posCount], mainF, wights - 10).Height;
                        e.Graphics.DrawString(Big[N][posCount], mainF, Brushes.Black, new Rectangle(x + 10, y, wights - 10, reload));
                        y += reload;
                    }
                    else
                    {
                        string part2 = "";
                        string part = "";
                        for (int ii = 0; ii < Big[N][posCount].Split(' ').Length; ii++)
                        {
                            part2 = part;
                            part += Big[N][posCount].Split(' ')[ii] + " ";
                            if ((int)e.Graphics.MeasureString(part, mainF, wights - 10).Height + y > heits)
                            {
                                reload = (int)e.Graphics.MeasureString(part2, mainF, wights - 10).Height;
                                e.Graphics.DrawString(part2, mainF, Brushes.Black, new Rectangle(x + 10, y, wights - 10, reload));
                                Big[N][posCount] = Big[N][posCount].Substring(part2.Length);
                                break;
                            }
                        }
                        e.HasMorePages = true; POSCOUNTcur = posCount; ROWCOUNTcur = N; done = false;
                        break;
                    }
                }

                if (!done)
                { break; }
                else
                {
                    reload = (int)e.Graphics.MeasureString("\n\n\n", mainF, wights).Height + 1;
                    e.Graphics.DrawString("\n\n", mainF, Brushes.Black, new Rectangle(x, y, wights, reload));
                    y += reload;
                    ROWCOUNTcur = 0;
                }
            }
        }

        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            Save(false);
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

        private void oblastBindingSource_CurrentChanged(object sender, EventArgs e)
        {

            if (((DataRowView)oblastBindingSource.Current) != null)
            { gorodBindingSource.Filter = "Oblast=" + ((DataRowView)oblastBindingSource.Current)["OblastID"].ToString(); }
        }

        private void toolStripButtonNewTreat_Click(object sender, EventArgs e)
        {
            if (PID != 0)
            {
                Posesenie poses = new Posesenie();
                poses.Tag = PID;
                poses.Text = "Лечение: " + ___BASA__DataSet.Patients[0].PFIO;// ((DataRowView)curent)["PFIO"].ToString();
                ((MainForm)this.MdiParent).checkWin(poses);
            }
        }

        private void KartaForm_FormClosing(object sender, FormClosingEventArgs e)
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
            if (PID != 0)
            {
                MoneyMoov nov = (MoneyMoov)((MainForm)this.MdiParent).checkWin(new MoneyMoov());// = PID.ToString(); 
                nov.PatFilter(PID, (string)___BASA__DataSet.Patients[0]["PFIO"]);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab == tabPage2)
            {
                panelHistory.Focus();
            }
        }

        private void toolStripButton_UpdHist_Click(object sender, EventArgs e)
        {
            updateHistory();
        }


        string[][] Big;

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            pageN = 1;
            POSCOUNTcur = 0;
            ROWCOUNTcur = 0;

            int countRow = ___BASA__DataSet.Posesenie.Rows.Count;
            if (countRow == 0)
            {
                e.Cancel = true;
            }
            else
            {
                string[][] Big1 = { new string[countRow], new string[countRow], new string[countRow], new string[countRow], new string[countRow], new string[countRow], new string[countRow], new string[countRow], new string[countRow], new string[countRow], new string[countRow], new string[countRow] };
                Big = Big1;
                int i = 0;
                foreach (DataRow dr in ___BASA__DataSet.Posesenie.Rows)
                {

                    Big[0][i] = ((DateTime)dr["Data"]).ToLongDateString();

                    Big[1][i] = "Врач- " + dr["DFIO"].ToString();

                    Big[2][i] = "Жалобы";

                    Big[3][i] = dr["Zaloby"].ToString();

                    Big[4][i] = "Анамнез";

                    Big[5][i] = dr["Anamnez"].ToString();

                    Big[6][i] = "Объективно";

                    Big[7][i] = dr["Obekt"].ToString();

                    Big[8][i] = "Диагноз";

                    Big[9][i] = dr["Diagnos"].ToString();

                    Big[10][i] = "Лечение";

                    Big[11][i] = dr["Treat"].ToString();

                    i++;
                }
            }
        }

        private void toolStripButtonDelPhoto_Click(object sender, EventArgs e)
        {
            pictureBoxPhoto.Image = null;
            pictureBoxPhoto.DataBindings[0].WriteValue();
            saveToolStripMenuItem.Enabled = toolStripButton_Save.Enabled = true;
        }



        private void pictureBoxPhoto_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            pictureBoxPhoto.DataBindings[0].WriteValue();
        }

        private void dateTimePickerBD_ValueChanged(object sender, EventArgs e)
        {
            textBoxVozr.Text = Vozrast(dateTimePickerBD.Value).ToString();
            toolStripButton_Save.Enabled = true;
        }

        private void KartaForm_Activated(object sender, EventArgs e)
        {
            if (isKartaNotDel())
            {
                PID = 0;
                ___BASA__DataSet.Patients.Clear();
                loadCleanKarta();
                updateHistory();
            }
        }

        private void panelHistory_Resize(object sender, EventArgs e)
        {
            foreach (Control c in panelHistory.Controls)
            {
                if (c.GetType() == typeof(Label))
                {
                }
            }
        }

    }
}
