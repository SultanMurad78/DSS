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
    public partial class StatDiagn : Form
    {
        public StatDiagn()
        {
            InitializeComponent();
        }

        string[] CheckTR = new string[0];
        string[] trs = new string[0];
        string fil_tr = "";
        string[] pts = new string[0];
        string[] CheckPts = new string[0];
        string[] drs = new string[0];
        string[] CheckDrs = new string[0];
        string fil_doc = "";
        string fil_pat = "";
        string fil_time1 = "";
        string fil_time2 = "";
        string select = "";
        string group = "";

        private void StatDiagn_Load(object sender, EventArgs e)
        {
            statDiagnosisTableAdapter.Fill(___BASA__DataSet.StatDiagnosis);
            trsMake();
        }

        void Fill2(___BASA__DataSet.StatDiagnosisDataTable dataTable)
        {
            statDiagnosisTableAdapter.Adapter.SelectCommand = new System.Data.OleDb.OleDbCommand();

            statDiagnosisTableAdapter.Adapter.SelectCommand.Connection = new System.Data.OleDb.OleDbConnection(DSS.Properties.Settings.Default.__BASA__ConnectionString1);
            statDiagnosisTableAdapter.Adapter.SelectCommand.CommandType = System.Data.CommandType.Text;

            statDiagnosisTableAdapter.Adapter.SelectCommand.CommandText = "SELECT Diagnosis.Texts AS DS, COUNT(Diagnosis.ID) AS Many " + select +
" FROM ((((TreatDS LEFT OUTER JOIN Diagnosis ON TreatDS.Diagnos = Diagnosis.ID) LEFT OUTER JOIN Posesenie ON TreatDS.Posesenie = Posesenie.ID) LEFT OUTER JOIN Patients ON Posesenie.Patient = Patients.PID) LEFT OUTER JOIN Personal ON Posesenie.Personal = Personal.DID) " +
" GROUP BY Diagnosis.Texts " + group
                                ;

            dataTable.Clear();
            statDiagnosisTableAdapter.Adapter.Fill(dataTable);
        }

        private void trsMake()
        {
            ___BASA__DataSet.StatDiagnosisDataTable tabTR = statDiagnosisTableAdapter.GetDataByDSDist();
            trs = new string[tabTR.Rows.Count];
            int ii = 0;
            foreach (DataRow dr in tabTR.Rows)
            {
                trs[ii] = dr["DS"].ToString();
                ii++;
            }
        }

        private void toolStripButtonBUILD_Click(object sender, EventArgs e)
        {
            toolStripButtonBUILD.BackColor = Color.LightBlue;
            select = "";
            group = "";

            if (toolStripButtonDATA.Checked)
            {
                tableLayoutPanelData.Visible = true;
                Datas.Visible = true;
                select = " , datevalue(Posesenie.Data) AS Datas ";
                group = " , datevalue(Posesenie.Data) ";
            }
            else
            {
                Datas.Visible = false;
                tableLayoutPanelData.Visible = false;
                fil_time1 = "";
                fil_time2 = "";

            }
            if (toolStripButtonDOC.Checked)
            {
                DataTable tab = statDiagnosisTableAdapter.GetDataByDFIOdist();
                drs = new string[tab.Rows.Count];
                int i = 0;
                foreach (DataRow dr in tab.Rows)
                {
                    drs[i] = dr["DFIO"].ToString();
                    i++;
                }

                DFIO.Visible = toolStripButtonFiltrDOC.Visible = true;
                select += " , Personal.DF + ' ' + Personal.DI + ' ' + Personal.DO AS DFIO ";
                group += " , Personal.DF + ' ' + Personal.DI + ' ' + Personal.DO ";
            }
            else
            {
                toolStripButtonFiltrDOC.Visible = DFIO.Visible = false;
                CheckDrs = new string[0]; drs = new string[0]; fil_doc = "";
            }

            if (toolStripButtonPAT.Checked)
            {
                DataTable tab = statDiagnosisTableAdapter.GetDataByPFIO();
                pts = new string[tab.Rows.Count];
                int i = 0;
                foreach (DataRow dr in tab.Rows)
                {
                    pts[i] = dr["PFIO"].ToString();
                    i++;
                }
                toolStripButtonFiltrPAT.Visible = PFIO.Visible = true;
                select += " , Patients.PF + ' ' + Patients.PI + ' ' + Patients.PO AS PFIO ";
                group += " , Patients.PF + ' ' + Patients.PI + ' ' + Patients.PO ";
            }
            else
            {
                toolStripButtonFiltrPAT.Visible = PFIO.Visible = false;
                pts = new string[0];
                fil_pat = "";
                CheckPts = new string[0];
            }

            trsMake();

            Fill2(___BASA__DataSet.StatDiagnosis);
            foreach (DataColumn dc in ___BASA__DataSet.StatDiagnosis.Columns)
            {
                if (dc.ColumnName == "PFIO")
                {
                    PFIO.DataPropertyName = dc.ColumnName;
                }
                else if (dc.ColumnName == "DFIO")
                {
                    DFIO.DataPropertyName = dc.ColumnName;
                }
                else if (dc.ColumnName == "Datas")
                {
                    Datas.DataPropertyName = dc.ColumnName;
                }
                else if (dc.ColumnName == "DS")
                {
                    Texts.DataPropertyName = dc.ColumnName;
                }

            }
            statDiagnosisDataGridView.Focus();
            FILTR();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fil_time1 = "Datas>='" + dateTimePicker1.Value.Date.ToString() + "' ";
            FILTR();
            dateTimePicker2.MinDate = dateTimePicker1.Value.Date;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            fil_time2 = " AND Datas<'" + dateTimePicker2.Value.Date.AddDays(1).ToString() + "' ";
            FILTR();
            dateTimePicker1.MaxDate = dateTimePicker2.Value.Date;
        }

        private void toolStripButtonPERIOD_Click(object sender, EventArgs e)
        {
            if (!toolStripButtonPERIOD.Checked)
            {
                if (!toolStripLabelALL.Enabled)
                {
                    toolStripLabelALL.Enabled = true;
                    toolStripLabelALL.Text = "Всегда";
                }
                toolStripButtonPERIOD.Checked = true;
                toolStripButtonTOD.Checked = toolStripButtonMONTH.Checked = false;
            }
        }

        private void toolStripButtonPERIOD_CheckedChanged(object sender, EventArgs e)
        {
            if (!toolStripButtonPERIOD.Checked)
            {
                dateTimePicker1.Enabled = dateTimePicker2.Enabled = false;
            }
            else
            {
                dateTimePicker1.Enabled = dateTimePicker2.Enabled = true;
            }
        }

        private void toolStripButtonMONTH_Click(object sender, EventArgs e)
        {
            if (!toolStripButtonMONTH.Checked)
            {
                if (!toolStripLabelALL.Enabled)
                {
                    toolStripLabelALL.Enabled = true;
                    toolStripLabelALL.Text = "Всегда";
                }
                toolStripButtonMONTH.Checked = true;
                toolStripButtonTOD.Checked = toolStripButtonPERIOD.Checked = false;
                fil_time2 = " AND Datas<'" + DateTime.Today.Date.AddDays(-DateTime.Today.Date.Day + 1).AddMonths(1) + "' ";
                fil_time1 = "Datas>='" + DateTime.Today.Date.AddDays(-DateTime.Today.Date.Day + 1) + "' ";
                FILTR();
            }
        }

        private void toolStripButtonTOD_Click(object sender, EventArgs e)
        {
            if (!toolStripButtonTOD.Checked)
            {
                if (!toolStripLabelALL.Enabled)
                {
                    toolStripLabelALL.Enabled = true;
                    toolStripLabelALL.Text = "Всегда";
                }
                toolStripButtonTOD.Checked = true;
                toolStripButtonMONTH.Checked = toolStripButtonPERIOD.Checked = false;
                fil_time2 = " AND Datas<'" + DateTime.Today.Date.AddDays(1) + "' ";
                fil_time1 = "Datas>='" + DateTime.Today.Date + "' ";
                FILTR();
            }
        }

        private void toolStripLabelALL_Click(object sender, EventArgs e)
        {
            if (toolStripLabelALL.Enabled)
            {

                toolStripButtonPERIOD.Checked = toolStripButtonMONTH.Checked = toolStripButtonTOD.Checked = false;
                fil_time1 = "  Datas>'" + DateTime.MinValue + "' ";
                fil_time2 = " AND Datas<'" + DateTime.MaxValue + "' ";
                FILTR();
                toolStripLabelALL.Text = "Даты";
                toolStripLabelALL.Enabled = false;
            }
        }

        private void FILTR()
        {
            string fullFiltr = "";
            fullFiltr += fil_time1 + fil_time2;
            if (fullFiltr != "" && fil_doc != "")
            {
                fullFiltr += " AND " + fil_doc;
            }
            else if (fullFiltr == "" && fil_doc != "")
            {
                fullFiltr += fil_doc;
            }
            if (fullFiltr != "" && fil_pat != "")
            {
                fullFiltr += " AND " + fil_pat;
            }
            else if (fullFiltr == "" && fil_pat != "")
            {
                fullFiltr += fil_pat;
            }
            if (fullFiltr != "" && fil_tr != "")
            {
                fullFiltr += " AND " + fil_tr;
            }
            else if (fullFiltr == "" && fil_tr != "")
            {
                fullFiltr += fil_tr;
            }

            statDiagnosisBindingSource.Filter = fullFiltr;
        }

        private void toolStripButtonDATA_Click(object sender, EventArgs e)
        {
            toolStripButtonBUILD.BackColor = Color.Azure;// SystemColors.InactiveCaption;
        }

        private void statDiagnosisDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1 && e.Button == MouseButtons.Right)
            {
                if (statDiagnosisDataGridView.Columns[e.ColumnIndex] == PFIO || statDiagnosisDataGridView.Columns[e.ColumnIndex] == DFIO ||
                    statDiagnosisDataGridView.Columns[e.ColumnIndex] == Texts)
                {
                    int x = e.Location.X + statDiagnosisDataGridView.Location.X + statDiagnosisDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Location.X;
                    int y = e.Location.Y + statDiagnosisDataGridView.Location.Y + statDiagnosisDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Location.Y;
                    CheckedListBox list = listParam(ref x, y);

                    if (statDiagnosisDataGridView.Columns[e.ColumnIndex] == DFIO)
                    {
                        list.Leave += new EventHandler(list_DisposedDOC);
                        list.KeyDown += new KeyEventHandler(list_KeyDownDOC);
                        list.GotFocus += new EventHandler(list_GotFocusDOC);
                    }

                    else if (statDiagnosisDataGridView.Columns[e.ColumnIndex] == PFIO)
                    {
                        list.Leave += new EventHandler(list_LostFocusPAT);
                        list.KeyDown += new KeyEventHandler(list_KeyDownPAT);
                        list.GotFocus += new EventHandler(list_GotFocusPAT);
                    }
                    else if (statDiagnosisDataGridView.Columns[e.ColumnIndex] == Texts)
                    {
                        list.Leave += new EventHandler(list_LostFocusTR);
                        list.KeyDown += new KeyEventHandler(list_KeyDownTR);
                        list.GotFocus += new EventHandler(list_GotFocusTR);
                    }
                    this.Controls.Add(list);
                    list.BringToFront();
                    list.Focus();
                }
            }
        }


        void list_GotFocusTR(object sender, EventArgs e)
        {
            foreach (string s in trs)
            {
                bool b = false;
                foreach (string sf in CheckTR)
                {
                    if (s == sf)
                    {
                        ((CheckedListBox)sender).Items.Add(s, true);
                        b = true;
                        break;
                    }
                }
                if (!b)
                {
                    ((CheckedListBox)sender).Items.Add(s, false);
                }
            }
        }


        void list_KeyDownTR(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                statDiagnosisDataGridView.Focus();
            }
        }


        void list_LostFocusTR(object sender, EventArgs e)
        {
            TRclosing(sender);
        }


        private void TRclosing(object sender)
        {
            int leng = ((CheckedListBox)sender).CheckedItems.Count;
            CheckTR = new string[leng];
            int i = 0;
            fil_tr = "";
            foreach (object it in ((CheckedListBox)sender).CheckedItems)
            {
                CheckTR[i] = it.ToString();
                if (i == 0)
                {
                    fil_tr = " (DS='" + it.ToString() + "'";
                }
                else
                {
                    fil_tr += " OR DS='" + it.ToString() + "'";
                }
                if (i == leng - 1)
                {
                    fil_tr += ")";
                }
                i++;

            }
            ((CheckedListBox)sender).Dispose();
            toolStripButtonFiltrTR.Tag = null;
            FILTR();
        }


        void list_GotFocusPAT(object sender, EventArgs e)
        {
            foreach (string s in pts)
            {
                bool b = false;
                foreach (string sf in CheckPts)
                {
                    if (s == sf)
                    {
                        ((CheckedListBox)sender).Items.Add(s, true);
                        b = true;
                        break;
                    }
                }
                if (!b)
                {
                    ((CheckedListBox)sender).Items.Add(s, false);
                }
            }
        }


        void list_LostFocusPAT(object sender, EventArgs e)
        {
            PATclosing(sender);
        }


        void list_KeyDownPAT(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                statDiagnosisDataGridView.Focus();
            }
        }



        private void PATclosing(object sender)
        {
            int leng = ((CheckedListBox)sender).CheckedItems.Count;
            CheckPts = new string[leng];
            int i = 0;
            fil_pat = "";
            foreach (object it in ((CheckedListBox)sender).CheckedItems)
            {
                CheckPts[i] = it.ToString();
                if (i == 0)
                {
                    fil_pat = " (PFIO='" + it.ToString() + "'";
                }
                else
                {
                    fil_pat += " OR PFIO='" + it.ToString() + "'";
                }
                if (i == leng - 1)
                {
                    fil_pat += ")";
                }
                i++;

            }
            ((CheckedListBox)sender).Dispose();
            toolStripButtonFiltrPAT.Tag = null;
            FILTR();

        }

        private CheckedListBox listParam(ref int x, int y)
        {
            CheckedListBox list = new CheckedListBox();
            list.Size = new System.Drawing.Size(250, 200);

            if (x + list.Width > this.Width)
            {
                x = this.Width - list.Width - 5;
            }

            list.Location = new Point(x, y);

            list.CheckOnClick = true;
            list.Items.Add("Все");
            list.HorizontalScrollbar = true;
            list.ItemCheck += new ItemCheckEventHandler(list_ItemCheck);
            return list;
        }


        void list_DisposedDOC(object sender, EventArgs e)
        {
            DOCclosing(sender); ;
        }

        private void DOCclosing(object sender)
        {
            int leng = ((CheckedListBox)sender).CheckedItems.Count;
            CheckDrs = new string[leng];
            int i = 0;
            fil_doc = "";
            foreach (object it in ((CheckedListBox)sender).CheckedItems)
            {
                CheckDrs[i] = it.ToString();
                if (i == 0)
                {
                    fil_doc = " (DFIO='" + it.ToString() + "'";
                }
                else
                {
                    fil_doc += " OR DFIO='" + it.ToString() + "'";
                }
                if (i == leng - 1)
                {
                    fil_doc += ")";
                }
                i++;

            }
            FILTR();
            toolStripButtonFiltrDOC.Tag = null;
            ((CheckedListBox)sender).Dispose();
        }


        void list_KeyDownDOC(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                statDiagnosisDataGridView.Focus();
            }

        }


        void list_GotFocusDOC(object sender, EventArgs e)
        {
            foreach (string s in drs)
            {
                bool b = false;
                foreach (string sf in CheckDrs)
                {
                    if (s == sf)
                    {
                        ((CheckedListBox)sender).Items.Add(s, true);
                        b = true;
                        break;
                    }
                }
                if (!b)
                {
                    ((CheckedListBox)sender).Items.Add(s, false);
                }
            }
        }


        void list_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0)
            {

                if (e.CurrentValue == CheckState.Checked)
                {
                    int count = ((CheckedListBox)sender).Items.Count;
                    for (int i = 1; i < count; i++)
                    {
                        ((CheckedListBox)sender).SetItemCheckState(i, CheckState.Unchecked);
                    }
                }
                else if (e.CurrentValue == CheckState.Unchecked)
                {
                    int count = ((CheckedListBox)sender).Items.Count;
                    for (int i = 1; i < count; i++)
                    {
                        ((CheckedListBox)sender).SetItemCheckState(i, CheckState.Checked);
                    }
                }
            }
        }

        private void toolStripButtonFiltrTR_Click(object sender, EventArgs e)
        {
            if (toolStripButtonFiltrTR.Tag == null)
            {
                int x = toolStripFILTR.Location.X + toolStripButtonFiltrTR.Bounds.Location.X;
                int y = toolStripFILTR.Location.Y + toolStripButtonFiltrTR.Bounds.Location.Y + toolStripButtonFiltrTR.Height;

                CheckedListBox list = listParam(ref x, y);
                toolStripButtonFiltrTR.Tag = list;
                list.Leave += new EventHandler(list_LostFocusTR);
                list.KeyDown += new KeyEventHandler(list_KeyDownTR);
                list.GotFocus += new EventHandler(list_GotFocusTR);

                this.Controls.Add(list);
                list.BringToFront();
                list.Focus();
            }
            else
            {
                statDiagnosisDataGridView.Focus();
            }
        }

        private void toolStripButtonFiltrDOC_Click(object sender, EventArgs e)
        {

            if (toolStripButtonFiltrDOC.Tag == null)
            {
                int x = toolStripFILTR.Location.X + toolStripButtonFiltrDOC.Bounds.Location.X;
                int y = toolStripFILTR.Location.Y + toolStripButtonFiltrDOC.Bounds.Location.Y + toolStripButtonFiltrDOC.Height;
                CheckedListBox list = listParam(ref x, y);

                list.Leave += new EventHandler(list_DisposedDOC);
                list.GotFocus += new EventHandler(list_GotFocusDOC);
                list.KeyDown += new KeyEventHandler(list_KeyDownDOC);

                this.Controls.Add(list);
                toolStripButtonFiltrDOC.Tag = list;
                list.BringToFront();
                list.Focus();

            }
            else
            {
                statDiagnosisDataGridView.Focus();
            }
        }

        private void toolStripButtonFiltrPAT_Click(object sender, EventArgs e)
        {
            if (toolStripButtonFiltrPAT.Tag == null)
            {
                int x = toolStripFILTR.Location.X + toolStripButtonFiltrPAT.Bounds.Location.X;
                int y = toolStripFILTR.Location.Y + toolStripButtonFiltrPAT.Bounds.Location.Y + toolStripButtonFiltrPAT.Height;
                CheckedListBox list = listParam(ref x, y);// new CheckedListBox();
                toolStripButtonFiltrPAT.Tag = list;
                list.Leave += new EventHandler(list_LostFocusPAT);
                list.KeyDown += new KeyEventHandler(list_KeyDownPAT);
                list.GotFocus += new EventHandler(list_GotFocusPAT);
                this.Controls.Add(list);
                list.BringToFront();
                list.Focus();
            }
            else
            {
                statDiagnosisDataGridView.Focus();
            }
        }

    }
}
