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
using System.Drawing;
using System.Windows.Forms;

namespace DSS
{
    public partial class ZapisZur : Form
    {
        public ZapisZur()
        {
            InitializeComponent();
        }

        int vid = 1;
        bool isKalendarOpen = false;

        private void setupDATESadd(DateTime dates,int DID)
        {
            if (___BASA__DataSet.setupDates.Select("dataZap='" + dates.Date + "' AND DID=" + DID.ToString()).Length == 0)
            {
                ___BASA__DataSet.setupDatesRow nR = ___BASA__DataSet.setupDates.NewsetupDatesRow();
                nR.DID = DID;
                nR.dataZap = dates.Date;
                ___BASA__DataSet.setupDates.AddsetupDatesRow(nR);
            }
        }

        private void ZapisZur_Load(object sender, EventArgs e)
        {
            this.setupDatesTableAdapter1.Fill(this.___BASA__DataSet.setupDates);
            whenDatesTableAdapter.Fill(___BASA__DataSet.whenDates);
            this.raspisanieTableAdapter.Fill(this.___BASA__DataSet.raspisanie);
            personalVievTableAdapter1.FillBy(___BASA__DataSet.PersonalViev, true, true);
            if (comboBoxDoctor.SelectedValue != null)
            {
                timeChenge1(DateTime.Today, (int)comboBoxDoctor.SelectedValue);
            }
        }      
                   

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            isKalendarOpen = false;
            if (vid == 1)
            {
                if (comboBoxDoctor.SelectedValue != null)
                {
                    timeChenge1(dateTimePickerMy.Value.Date, (int)comboBoxDoctor.SelectedValue);
                }
                else
                {
                    timeChenge1(dateTimePickerMy.Value.Date, 0);
                }
            }
            else if (vid == 2)
            {
                timeChenge2(dateTimePickerMy.Value.Date);
            }
        }


        string dow(DateTime dta)
        {
            DayOfWeek wd = dta.DayOfWeek;
            string day = "";
            switch (wd)
            {
                case DayOfWeek.Friday:
                    day = "ПТ";
                    break;
                case DayOfWeek.Monday:
                    day = "ПН";
                    break;
                case DayOfWeek.Saturday:
                    day = "СБ";
                    break;
                case DayOfWeek.Sunday:
                    day = "ВС";
                    break;
                case DayOfWeek.Thursday:
                    day = "ЧТ";
                    break;
                case DayOfWeek.Tuesday:
                    day = "ВТ";
                    break;
                case DayOfWeek.Wednesday:
                    day = "СР";
                    break;
            }
            return day;
        }


        private void cleanZapisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((DataGridView)contextMenuStripCELL.SourceControl).SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow dgvr in ((DataGridView)contextMenuStripCELL.SourceControl).SelectedRows)
                {
                    addZap((___BASA__DataSet.ZurnalRow)((DataRowView)dgvr.DataBoundItem).Row, 0, "", "", "");
                }
            }
        }  

        public DateTime data_new_delim = new DateTime();
       public int new_per_delim = new int();
        public bool where_zap_whill_delim = true;
     
        private void razdelitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView grid = (DataGridView)contextMenuStripCELL.SourceControl;
           if (grid.SelectedRows.Count == 1)
           {
               DataRowView curent_row = (DataRowView)grid.SelectedRows[0].DataBoundItem;
               ___BASA__DataSet.ZurnalRow cr = (___BASA__DataSet.ZurnalRow)curent_row.Row;   
                DelimVremya dv = new DelimVremya();
                int curent_per = dv.periodDefault = cr.period;
                dv.startTime = cr.time;
                dv.Tag = this;
                if (dv.ShowDialog() == DialogResult.OK)
                {
                    cr.period = new_per_delim;
                    if (where_zap_whill_delim)
                    {                     
                        ___BASA__DataSet.Zurnal.AddZurnalRow(data_new_delim, curent_per - new_per_delim, (int)grid.Tag, "",cr.dataZap, 0, "", "");
                    }
                    else
                    {
                        ___BASA__DataSet.Zurnal.AddZurnalRow(data_new_delim, curent_per - new_per_delim, (int)grid.Tag, cr.zap, cr.dataZap, cr.PID, cr.PS,cr.zapTag);
                        cr.PID = 0; cr.zapTag = ""; cr.zap = ""; cr.PS = "";
                      
                    }
                    setupDATESadd(cr.dataZap,cr.DID);
                }                
            }
        }

       

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                              toolStripSplitButtonVid.Visible = false;
                vid = 1;
                if (___BASA__DataSet.PersonalViev.Rows.Count != personalVievTableAdapter1.GetDataBy(true, true).Rows.Count)
                {

                    int thisDID = 0;
                    if (comboBoxDoctor.SelectedValue != null)
                    {
                        thisDID = (int)comboBoxDoctor.SelectedValue;
                    }
                    personalVievTableAdapter1.FillBy(___BASA__DataSet.PersonalViev, true, true);
                    personSource.Position = personSource.Find("DID", thisDID);
                }
                else
                {
                    if (comboBoxDoctor.SelectedValue != null)
                    {
                        timeChenge1(dateTimePickerMy.Value.Date, (int)comboBoxDoctor.SelectedValue);
                    }
                    else
                    {
                        timeChenge1(dateTimePickerMy.Value.Date, 0);
                    }
                }
                buttonS.Enabled = buttonSB.Enabled = true;
            }

            if (tabControl1.SelectedTab == tabPage2)
            {
                              vid = 2;
                toolStripSplitButtonVid.Visible = true;
                buttonS.Enabled = buttonSB.Enabled = false;

                if (grids.Length != personalVievTableAdapter1.GetDataBy(true, true).Rows.Count)
                {
                    Tab2Make();
                                  }
                timeChenge2(dateTimePickerMy.Value.Date);
                            }
        }

        private bool Tab2MakeDo = false;
        DataGridView[] grids=new DataGridView[0];
        private void Tab2Make()
        {
            Tab2MakeDo = true;
            int i = 0;
            tableLayoutPanel2.Controls.Clear();
            personalVievTableAdapter1.FillBy(___BASA__DataSet.PersonalViev, true, true);
            int numOfPers = ___BASA__DataSet.PersonalViev.Rows.Count;
           grids = new DataGridView[numOfPers];
            tableLayoutPanel2.ColumnCount = numOfPers;
            tableLayoutPanel2.ColumnStyles.Clear();
            foreach (DataRow dr in ___BASA__DataSet.PersonalViev.Rows)
            {
                i++;
                DataGridView dgr = new DataGridView();               
                dgr.Dock = DockStyle.Fill;
                dgr.BackgroundColor = Color.White;
                dgr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgr.AllowUserToResizeRows = true;
                dgr.AllowUserToAddRows = dgr.AllowUserToDeleteRows = dgr.AllowUserToOrderColumns =
                     dgr.RowHeadersVisible = false;
                dgr.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgr.Tag = (int)dr["DID"];
                dgr.ReadOnly = true;
               dgr.DefaultCellStyle.SelectionBackColor =Color.Gainsboro;
               dgr.DefaultCellStyle.SelectionForeColor = Color.MidnightBlue;
                tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / numOfPers));
                BindingSource bs = new BindingSource(this.___BASA__DataSet, "Zurnal");
                dgr.DataSource = bs;
                bs.Filter = "DID=" + dr["DID"].ToString() + " AND dataZap='" + dateTimePickerMy.Value.Date. ToString() + "'";
                bs.Sort = "time";
                dgr.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgr.ColumnAdded += new DataGridViewColumnEventHandler(dgr_ColumnAdded);
                dgr.CellMouseEnter += zurnalDataGridView1_CellMouseEnter;
                dgr.CellMouseDoubleClick += zurnalDataGridView1_CellMouseDoubleClick;
                dgr.CellMouseDown += zurnalDataGridView1_CellMouseDown;
                               dgr.ContextMenuStrip = contextMenuStripGRID;
                grids[i - 1] = dgr;
                tableLayoutPanel2.Controls.Add(dgr, (i - 1), 1);
                
                Label labDoc = new Label();
                labDoc.Text = dr["DF"].ToString();
                labDoc.AutoSize = true;
                labDoc.TextAlign = ContentAlignment.MiddleCenter;
                labDoc.Dock = DockStyle.Fill;
                tableLayoutPanel2.Controls.Add(labDoc, i - 1, 0); 
            }
           
        }

       
        void dgr_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {           
            if (e.Column.DataPropertyName != "time"  & e.Column.DataPropertyName != "period" & e.Column.DataPropertyName != "zap")
            {
                 e.Column.Visible = false;
            }
            else
            {
                e.Column.SortMode = DataGridViewColumnSortMode.Programmatic;
                if (e.Column.DataPropertyName == "time")
                {
                    e.Column.HeaderText = "Время";
                   e.Column.DefaultCellStyle.Format = "t";
                }
                if (e.Column.DataPropertyName == "zap")
                {
                    e.Column.HeaderText = "Запись";
                    e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    e.Column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                else
                {
                    if (e.Column.DataPropertyName == "period")
                    {
                        e.Column.HeaderText = "Длит";
                    }                   
                    e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            } 
        }


        private void comboBoxDoctor_SelectedValueChanged(object sender, EventArgs e)
        {           
            if (comboBoxDoctor.SelectedValue != null)
            {
                timeChenge1(dateTimePickerMy.Value.Date, (int)comboBoxDoctor.SelectedValue);
                zurnalDataGridView4.Tag = zurnalDataGridView3.Tag = zurnalDataGridView2.Tag = zurnalDataGridView1.Tag = (int)comboBoxDoctor.SelectedValue;
            }
        }

        void timeChenge1(DateTime val, int doc)
        {
            string doctor = doc.ToString();
            foreach (DataGridView dgr in new DataGridView[] { zurnalDataGridView1, zurnalDataGridView2, zurnalDataGridView3, zurnalDataGridView4 })
            {
                if (dgr.Rows.Count != 0)
                {
                    string docthis = ((___BASA__DataSet.ZurnalRow)((DataRowView)dgr.Rows[0].DataBoundItem).Row).DID.ToString();
                    string datsZ = ((___BASA__DataSet.ZurnalRow)((DataRowView)dgr.Rows[0].DataBoundItem).Row).dataZap.ToString();
                    if (___BASA__DataSet.setupDates.Select("dataZap='" + datsZ + "'" + " AND DID=" + docthis).Length == 0)
                    {
                        foreach (DataRow r in ___BASA__DataSet.Zurnal.Select("dataZap= '" + datsZ + "'" + " AND DID=" + docthis))
                        {
                            r.Delete();
                        }
                    }
                }
            }           
            zurnalBindingSource1.Filter = "DID=" + doctor + " AND dataZap= '" + val.ToString() + "'";
            // 
            zurnalBindingSource2.Filter = "DID=" + doctor + " AND dataZap= '" + val.AddDays(1).ToString() + "'";
            // 
            zurnalBindingSource3.Filter = "DID=" + doctor + " AND dataZap= '" + val.AddDays(2).ToString() + "'";
            // 
            zurnalBindingSource4.Filter = "DID=" + doctor + " AND dataZap= '" + val.AddDays(3).ToString() + "'";
                /////////////////////////////////////////////////////////////////////////////////////////////////

                for (int i = 0; i <= 3; i++)// 4 таблицы просмотра
                {
                    if (  ___BASA__DataSet.Zurnal.Select("dataZap= '" + val.AddDays(i).ToString() + "'" + " AND DID=" + doctor,"", DataViewRowState.CurrentRows ).Length == 0   )
                    {
                        if (zurnalTableAdapter1.GetDataByDATE_DID(val.AddDays(i).Date, doc).Count != 0
                             && ___BASA__DataSet.setupDates.Select("dataZap='" + val.AddDays(i).Date + "'" + " AND DID=" + doctor).Length != 0)
                        {
                            zurnalTableAdapter1.FillByDATE_DID(___BASA__DataSet.Zurnal, val.AddDays(i).Date, doc);                          
                        }
                        else
                        {
                            string when = "0";
                            ___BASA__DataSet.whenDatesRow[] rr = (___BASA__DataSet.whenDatesRow[])___BASA__DataSet.whenDates.Select("end>='" + val.AddDays(i).ToString() + "' AND begin<='" + val.AddDays(i).ToString() + "' AND DID=" + doctor);
                            if (rr.Length == 1)
                            {
                                when = rr[0].ID.ToString();
                            }
                            else if (rr.Length > 1)
                            {
                                MessageBox.Show("ERROR (>1)! - ожидалась одна строка whenDates!");
                            }
                            foreach (___BASA__DataSet.raspisanieRow r in ___BASA__DataSet.raspisanie.Select("dow=" + Convert.ToInt32(val.AddDays(i).DayOfWeek) + " AND DID=" + doctor + " AND whenID=" + when))
                            {
                                this.___BASA__DataSet.Zurnal.AddZurnalRow(r.time, r.period, doc, r["zap"].ToString(), val.AddDays(i), 0, "", r["zapTag"].ToString());
                            }
                        }
                    }
                }
                          
                string s4 = val.AddDays(3).ToLongDateString() + ", " + dow(val.AddDays(3));
                string s1 = val.ToLongDateString() + ", " + dow(val);
                string s3 = val.AddDays(2).ToLongDateString() + ", " + dow(val.AddDays(2));
                string s2 = val.AddDays(1).ToLongDateString() + ", " + dow(val.AddDays(1));

                label_4.Text = s4;
                label_1.Text = s1;
                label_3.Text = s3;
                label_2.Text = s2;
                           griddColors();
        }

        void timeChenge2(DateTime dat)
        {
                     foreach (DataGridView dgr in grids)
            {
                if (dgr.Rows.Count != 0)
                {
                    string docThis = ((___BASA__DataSet.ZurnalRow)((DataRowView)dgr.Rows[0].DataBoundItem).Row).DID.ToString();
                    string datsZ = ((___BASA__DataSet.ZurnalRow)((DataRowView)dgr.Rows[0].DataBoundItem).Row).dataZap.ToString();
                    if (___BASA__DataSet.setupDates.Select("dataZap='" + datsZ + "'" + " AND DID=" + docThis).Length == 0)
                    {
                        foreach (DataRow r in (___BASA__DataSet.Zurnal.Select("dataZap= '" + datsZ + "'" + " AND DID=" + docThis)))
                        {
                            r.Delete();
                        }
                    }
                }
                ((BindingSource)((DataGridView)dgr).DataSource).Filter = "DID=" + dgr.Tag.ToString() + " AND dataZap='" + dat.Date.ToString() + "'";
                if (___BASA__DataSet.Zurnal.Select("dataZap= '" + dat.ToString() + "'" + " AND DID=" + dgr.Tag.ToString(), "", DataViewRowState.CurrentRows).Length == 0)
                {
                    if (zurnalTableAdapter1.GetDataByDATE_DID(dat.Date, (int)dgr.Tag).Count != 0
                        && ___BASA__DataSet.setupDates.Select("dataZap='" + dat.Date + "'" + " AND DID=" + dgr.Tag.ToString()).Length != 0)
                    {
                        zurnalTableAdapter1.FillByDATE_DID(___BASA__DataSet.Zurnal, dat, (int)dgr.Tag);
                    }
                    else
                    {
                        string when = "0";
                        ___BASA__DataSet.whenDatesRow[] rr = (___BASA__DataSet.whenDatesRow[])___BASA__DataSet.whenDates.Select("end>='" + dat.ToString() + "' AND begin<='" + dat.ToString() + "' AND DID=" + dgr.Tag.ToString());
                        if (rr.Length == 1)
                        {
                            when = rr[0].ID.ToString();
                        }
                        else if (rr.Length > 1)
                        {
                            MessageBox.Show("ERROR (>1)! - ожидалась одна строка whenDates!");
                        }
                        foreach (___BASA__DataSet.raspisanieRow r in ___BASA__DataSet.raspisanie.Select("dow=" + Convert.ToInt32(dat.DayOfWeek) + " AND DID=" + dgr.Tag.ToString() + " AND whenID=" + when))
                        {
                            this.___BASA__DataSet.Zurnal.AddZurnalRow(r.time, r.period, (int)dgr.Tag, r["zap"].ToString(), dat, 0, "", r["zapTag"].ToString());
                        }
                    }
                }
                
                       }
                      griddColors();
       }
               

        private void buttonRaspis_Click(object sender, EventArgs e)
        {
            RaspChenge rc = new RaspChenge();
            if (rc.ShowDialog() == DialogResult.Yes)
            {
                Cursor = Cursors.WaitCursor;
               whenDatesTableAdapter.Fill(___BASA__DataSet.whenDates);
               raspisanieTableAdapter.Fill(___BASA__DataSet.raspisanie);
                if (vid == 1)
                {
                    if (comboBoxDoctor.SelectedValue != null)
                    {

                        timeChenge1(dateTimePickerMy.Value.Date, (int)comboBoxDoctor.SelectedValue);
                    }
                    else
                    {
                        timeChenge1(dateTimePickerMy.Value.Date, 0);
                    }
                }
                if (vid == 2)
                {
                    timeChenge2(dateTimePickerMy.Value.Date);
                }
                Cursor = Cursors.Default;
            }
        }


        private void zurnalDataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView grd = (DataGridView)sender;
            grd.Focus();
            if (e.RowIndex >= 0)
            {
                if (!grd.Rows[ e.RowIndex].Selected)
                {
                    grd.ClearSelection();
                    grd.Rows[e.RowIndex].Selected = true;
                }
            }
            if (e.Button == MouseButtons.Right & e.RowIndex != -1)
            {
                grd[e.ColumnIndex, e.RowIndex].ContextMenuStrip = contextMenuStripCELL;
            }
        }



        private void sumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView gri = (DataGridView)contextMenuStripCELL.SourceControl;
            if (gri.SelectedRows.Count > 1)
            {
                bool pusto = isGridHasZap(gri);
                if (pusto ||
                    (!pusto & MessageBox.Show("Выбранные строки содержат записи. Объединение приведет к потере всех записей, кроме верхней.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes))
                {
                    DataGridViewRow notDel = new DataGridViewRow();
                    int per = 0;
                    findMinTimeForSum(gri, out notDel, out per);
                    foreach (DataGridViewRow r in gri.SelectedRows)
                    {
                        if (r != notDel)
                        {
                            ((DataRowView)r.DataBoundItem).Row.Delete();
                        }
                    }
                    ((DataRowView)notDel.DataBoundItem).Row["period"] = per;
                    setupDATESadd((DateTime)((DataRowView)notDel.DataBoundItem).Row["dataZap"], (int)((DataRowView)notDel.DataBoundItem).Row["DID"]);
                }
            }
        }


        private static bool isGridHasZap(DataGridView gri)
        {
            bool pusto = true;
            foreach (DataGridViewRow r in gri.SelectedRows)
            {
                if (((___BASA__DataSet.ZurnalRow)  ((DataRowView)r.DataBoundItem).Row).zap != "")
                {
                    pusto = false;
                    break;
                }
            }
            return pusto;
        }


        void zapisat(DataGridView curDGr)
        {           
            if (curDGr.SelectedRows.Count > 0)
            {
                bool pusto = isGridHasZap(curDGr);

                if (pusto ||
                    (!pusto & MessageBox.Show("Выбранные строки содержат записи. Переписать все?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes))
                {
                    DataGridViewRow notDel;
                    int per;
                    findMinTimeForSum(curDGr, out notDel, out per);

                    AddZapis az = new AddZapis();
                    az.Tag = this;
                    pid = (int)((DataRowView)notDel.DataBoundItem)["PID"];
                    postS = (string)((DataRowView)notDel.DataBoundItem)["PS"];
                    if (az.ShowDialog() == DialogResult.OK)
                    {                        
                            foreach (DataGridViewRow r in curDGr.SelectedRows)
                            {
                                if (r != notDel)
                                {
                                    ((DataRowView)r.DataBoundItem).Row.Delete();
                               }
                            }
                            ((DataRowView)notDel.DataBoundItem).Row["period"] = per;
                            addZap((___BASA__DataSet.ZurnalRow)((DataRowView)notDel.DataBoundItem).Row, pid, zapis, postS, "zap");
                    }
                }
            }
        }


        private static void findMinTimeForSum(DataGridView curDGr, out DataGridViewRow notDel, out int per)
        {
            notDel = new DataGridViewRow();
            per = 0;
            TimeSpan min = new TimeSpan(0, 23, 59, 59, 999);
            foreach (DataGridViewRow roww in curDGr.SelectedRows)
            {
                per += (int)((DataRowView)roww.DataBoundItem)["period"];
                if (((DateTime)((DataRowView)roww.DataBoundItem)["time"]).TimeOfDay < min)
                {
                    notDel = roww;
                    min = ((___BASA__DataSet.ZurnalRow)((DataRowView)roww.DataBoundItem).Row).time.TimeOfDay;
                }
            }
        }


        public int pid;
        public string zapis;
        public string postS;
        private void zapisatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zapisat((DataGridView)contextMenuStripCELL.SourceControl);           
        }
         


    
        void addZap(___BASA__DataSet.ZurnalRow row, int pid, string z,string ps,string zapTag)
        {
            row.PID = pid;
            if (z.Length > 255)
            {
                MessageBox.Show("Длина записи превышает допустимые 255 символов. Запись будет усечена.");
             z=  z.Remove(255);
            }
            if (ps.Length > 255)
            {
            ps=   ps.Remove(255);
            }

            row.zap = z;
            row.PS = ps;
            row.zapTag = zapTag;

            setupDATESadd(row.dataZap,row.DID);
            
            griddColors();

        }

        private void griddColors()
        {
                     DataGridView[] allGrids = new DataGridView[0];
            if (tabControl1.SelectedTab==tabPage1)
            {
                allGrids = new DataGridView[] { zurnalDataGridView1, zurnalDataGridView2, zurnalDataGridView3, zurnalDataGridView4 };
                
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                 allGrids = grids;
               
            }
            foreach (DataGridView dgr in allGrids)
            {
                foreach (DataGridViewRow dgvr in dgr.Rows)
                {
                    if (((DataRowView)dgvr.DataBoundItem)["zapTag"].ToString() == "zapDef")
                    {
                       
                        dgvr.DefaultCellStyle.BackColor = Color.Khaki;//.LightGoldenrodYellow;
                       dgvr.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                       
                    }
                    else
                    {
                        dgvr.DefaultCellStyle.BackColor = Color.White;
                        dgvr.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
                    }
                }
            }
            
        }

        private void buttonUPD_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            whenDatesTableAdapter.Fill(___BASA__DataSet.whenDates);
            raspisanieTableAdapter.Fill(___BASA__DataSet.raspisanie);
          
                if (vid == 1)
                {
                   int thisDID = 0;
                    if (comboBoxDoctor.SelectedValue != null)
                        {
                            thisDID = (int)comboBoxDoctor.SelectedValue;
                        }                       
                        personalVievTableAdapter1.FillBy(___BASA__DataSet.PersonalViev, true, true);
                        personSource.Position = personSource.Find("DID", thisDID);
                      
                }
               else if (vid == 2)
                {
                   Tab2Make();
                    timeChenge2(dateTimePickerMy.Value.Date);
                    Tab2MakeDo = false;
                }
                Cursor = Cursors.Default;
        }
       

       

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            DataGridView grd = (DataGridView) ((ContextMenuStrip)   sender).SourceControl;
            if (grd.SelectedRows.Count > 1)
            {
                sumToolStripMenuItem.Enabled = true;
                openKartaToolStripMenuItem.Visible = cutToolStripMenuItem.Enabled = pasteToolStripMenuItem.Enabled = razdelitToolStripMenuItem.Enabled = false;
            }
            if (grd.SelectedRows.Count == 1)
            {
              sumToolStripMenuItem.Enabled = false;
           cutToolStripMenuItem.Enabled=  razdelitToolStripMenuItem.Enabled = true;
              if ((int)((DataRowView)grd.SelectedRows[0].DataBoundItem)["PID"] != 0)
              {
                  openKartaToolStripMenuItem.Visible = true;
              }
              else
              {
                  openKartaToolStripMenuItem.Visible = false;
              }
            }  
        }


        private void zurnalDataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                ((DataGridView)sender)[e.ColumnIndex, e.RowIndex].ToolTipText = ((DataRowView)((DataGridView)sender).Rows[e.RowIndex].DataBoundItem)["zap"].ToString();
             }           
        }

        private void zurnalDataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                zapisat((DataGridView)       sender);
            }
        }


     
        private void dateTimePicker1_DropDown(object sender, EventArgs e)
        {
            isKalendarOpen = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (!isKalendarOpen)
            {
                if (vid == 1)
                {
                    if (comboBoxDoctor.SelectedValue != null)
                    {

                        timeChenge1(dateTimePickerMy.Value.Date, (int)comboBoxDoctor.SelectedValue);
                    }
                    else
                    {
                        timeChenge1(dateTimePickerMy.Value.Date, 0);
                    }
                }
                else if (vid == 2)
                {
                    timeChenge2(dateTimePickerMy.Value.Date);
                }
            }
        }

        private void buttonOneDOC_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != tabPage1)
            {
                tabControl1.SelectTab(tabPage1); 
                toolStripButtonOneDOC.Checked = true;
                toolStripButtonAllDOC.Checked = false;
            }
        }

        private void buttonAllDOC_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != tabPage2)
            {

                tabControl1.SelectTab( tabPage2); 
                toolStripButtonOneDOC.Checked =   false;
                toolStripButtonAllDOC.Checked = true;
            }
        }

        private void buttonDB_Click(object sender, EventArgs e)
        {
            try
            {
                dateTimePickerMy.Value = dateTimePickerMy.Value.Date.AddDays(-1);
            }
            catch (ArgumentOutOfRangeException )
            {
                MessageBox.Show("Уменьшать дату далее невозможно.");
            }
        }

        private void buttonSB_Click(object sender, EventArgs e)
        {
            try{
            dateTimePickerMy.Value = dateTimePickerMy.Value.Date.AddDays(-4);}
             catch (ArgumentOutOfRangeException )
            {
                MessageBox.Show("Уменьшать дату далее невозможно.");
            }
        }

        private void buttonWB_Click(object sender, EventArgs e)
        {
            try
            {
                dateTimePickerMy.Value = dateTimePickerMy.Value.Date.AddDays(-7);
            }
            catch (ArgumentOutOfRangeException )
            {
                MessageBox.Show("Уменьшать дату далее невозможно.");
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            try
            {
                dateTimePickerMy.Value = dateTimePickerMy.Value.Date.AddDays(1);
            }
            catch (ArgumentOutOfRangeException )
            {
                MessageBox.Show("Увеличивать дату далее невозможно.");
            }
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            try
            {
                dateTimePickerMy.Value = dateTimePickerMy.Value.Date.AddDays(4);
            }
            catch (ArgumentOutOfRangeException )
            {
                MessageBox.Show("Увеличивать дату далее невозможно.");
            }
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            try
            {
                dateTimePickerMy.Value = dateTimePickerMy.Value.Date.AddDays(7);
            }
            catch (ArgumentOutOfRangeException )
            {
                MessageBox.Show("Увеличивать дату далее невозможно.");
            }
        
        }

       
               private void openKartaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView curGrid=(DataGridView)contextMenuStripCELL.SourceControl;
            if (curGrid.SelectedRows.Count == 1 
                && ((___BASA__DataSet.ZurnalRow)((DataRowView)curGrid.SelectedRows[0].DataBoundItem).Row).PID != 0)
            {
                if (patientsTableAdapter1.GetDataBy((int)((DataRowView)curGrid.SelectedRows[0].DataBoundItem)["PID"]).Rows.Count == 1)
                {
                    int patID =  ((___BASA__DataSet.ZurnalRow)((DataRowView)curGrid.SelectedRows[0].DataBoundItem).Row).PID;
                    if (kartaTableAdapter1.ScalarQueryCuontByPID(patID) == 1)
                    {
                        KartaForm pat = new KartaForm();
                        pat.Tag = patID;
                        pat.Text = "Карточка: " + patientsTableAdapter1.GetDataBy(patID)[0]["PFIO"].ToString();
                        ((MainForm)this.MdiParent).checkWin(pat);
                    }
                    else if (kartaTableAdapter1.ScalarQueryCuontByPID(patID) == 0)
                    {
                        {
                            MessageBox.Show("Карточка не найдена. Возможно, она была удалена.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неопознанная ошибка(>1) базы данных, возможно, вызванная попыткой несанкционированного доступа.");
               
                    }
                }
                else
                {
                    MessageBox.Show("Неопознанная ошибка(>1<1) базы данных, возможно, вызванная попыткой несанкционированного доступа.");
                }
            }
        }



        private void ZapisZur_FormClosing(object sender, FormClosingEventArgs e)
        {
            int countChengeRows = 0;
            Cursor = Cursors.WaitCursor;
            setupDatesTableAdapter1.Adapter.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(SDAdapter_RowUpdated);
            zurnalTableAdapter1.Adapter.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(SDAdapter_RowUpdated);
            this.Validate();
            
            toolStripLabelProgress.Visible = true;
            toolStripMain.Refresh();
         
            foreach (___BASA__DataSet.ZurnalRow r in ___BASA__DataSet.Zurnal.Select("", "", DataViewRowState.CurrentRows))
            {
                if (___BASA__DataSet.setupDates.Select("dataZap='" + r.dataZap + "'" + " AND DID=" + r.DID).Length == 0)
                {
                    r.Delete();
                }
            }
            DataTable Zch = ___BASA__DataSet.Zurnal.GetChanges();
            DataTable SDch = ___BASA__DataSet.setupDates.GetChanges();
            if (SDch != null)
            {
                countChengeRows += SDch.Rows.Count;
            }
            if (Zch != null)
            {
                countChengeRows += Zch.Rows.Count;
            }
            toolStripProgressBar.Maximum = countChengeRows;
            toolStripProgressBar.Visible = true;
            setupDatesTableAdapter1.Update(___BASA__DataSet);
            zurnalTableAdapter1.Update(___BASA__DataSet.Zurnal);
        }

       

        void SDAdapter_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {
            toolStripProgressBar.Value+=1;
            toolStripMain.Update();
        }


       
      
        ___BASA__DataSet.ZurnalRow cutRow;
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView curGrid = (DataGridView)contextMenuStripCELL.SourceControl;
            if (curGrid.SelectedRows.Count == 1)
            {
                cutRow = (___BASA__DataSet.ZurnalRow)((DataRowView)((DataGridView)contextMenuStripCELL.SourceControl).SelectedRows[0].DataBoundItem).Row;
               pasteToolStripMenuItem.Enabled = true;
               setupDATESadd(cutRow.dataZap, cutRow.DID);

            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView curGrid = (DataGridView)contextMenuStripCELL.SourceControl;
            if (curGrid.SelectedRows.Count == 1 && cutRow!=null )
            {
                DataGridViewRow r = curGrid.SelectedRows[0];
                             addZap((___BASA__DataSet.ZurnalRow)((DataRowView)r.DataBoundItem).Row, cutRow.PID,cutRow.zap,cutRow.PS,cutRow.zapTag);
                addZap(cutRow, 0, "", "", "");
                cutRow = null;
                pasteToolStripMenuItem.Enabled = false;
            }
        }

       

        private void AllTabsViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!AllTabsToolStripMenuItem.Checked)
            {
                tabPage2.AutoScrollMinSize = new Size(SystemInformation.WorkingArea.Width * 2, tabPage2.AutoScrollMinSize.Height);
                AllTabsToolStripMenuItem.Checked = true;
                OnScreenToolStripMenuItem.Checked = false;
            }
        }

        private void OnScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnScreenToolStripMenuItem.Checked)
            {
                tabPage2.AutoScrollMinSize = new Size(0, 0);
                OnScreenToolStripMenuItem.Checked = true;
                AllTabsToolStripMenuItem.Checked = false;
            }
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            if (AllTabsToolStripMenuItem.Checked)
            {
                tabPage2.AutoScrollMinSize = new Size(0, 0);
                OnScreenToolStripMenuItem.Checked = true;
                AllTabsToolStripMenuItem.Checked = false;
            }
            else
            {
                tabPage2.AutoScrollMinSize = new Size(SystemInformation.WorkingArea.Width * 2, tabPage2.AutoScrollMinSize.Height);
                AllTabsToolStripMenuItem.Checked = true;
                OnScreenToolStripMenuItem.Checked = false;
            }
        }

        private void toolStripButtonClean_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите очистить журнал записи до " + DateTime.Today.ToShortDateString() + " ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Cursor = Cursors.WaitCursor;
                foreach (___BASA__DataSet.ZurnalRow zr in ___BASA__DataSet.Zurnal.Select("dataZap<'" + DateTime.Today.ToString() + "'"))
                {
                    ___BASA__DataSet.Zurnal.RemoveZurnalRow(zr);
                }
                zurnalTableAdapter1.DeleteQuery(DateTime.Today);
                foreach (___BASA__DataSet.setupDatesRow sr in ___BASA__DataSet.setupDates.Select("dataZap<'" + DateTime.Today.ToString() + "'"))
                {
                    sr.Delete();
                }
                if (vid == 1)
                {
                    timeChenge1(dateTimePickerMy.Value.Date, (int)comboBoxDoctor.SelectedValue);
                }
                else if (vid == 2)
                {
                    timeChenge2(dateTimePickerMy.Value.Date);
                }
                Cursor = Cursors.Default;
            }
        }


        public DateTime begDay;
        public DateTime endDay;
        public int perDay;
        private void dayParamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView curGrid=(DataGridView)((ContextMenuStrip) ((ToolStripMenuItem)sender).Owner).SourceControl;
            bool pusto = true;
            foreach (DataGridViewRow r in curGrid.Rows)
            {
                if (((DataRowView)r.DataBoundItem)["zap"].ToString() != "")
                {
                    pusto = false;
                    break;
                }
            }
                                                 
                if (pusto ||
                    (!pusto & MessageBox.Show("Выбранный день содержат записи. Изменение параметров дня приведет к потере всех записей.\rДля изменения продолжительности смены с сохранением записей воспользуйтесь функциями \"Объединить\\разделить время\", \"Продлить смену\".\rПродолжить?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes))
                {
                    DateTime dateOfDay = findDataForGrid(curGrid);

                    dayParam dp = new dayParam();
                    dp.Tag = this;
                    if (dp.ShowDialog() == DialogResult.Yes)
                    {
                        foreach (DataRow ddrr in ___BASA__DataSet.Zurnal.Select("DID=" + curGrid.Tag.ToString() + " AND dataZap='" + dateOfDay + "'"))
                        {
                            ddrr.Delete();
                        }
                        int N_ofDayItem = (int)(endDay.TimeOfDay.TotalMinutes - begDay.TimeOfDay.TotalMinutes) / perDay;

                        DateTime ts = begDay;
                        for (int i = 1; i <= N_ofDayItem; i++)
                        {
                            ___BASA__DataSet.ZurnalRow r = ___BASA__DataSet.Zurnal.NewZurnalRow();
                            r.time = ts;
                            r.period = perDay;
                            r.DID = (int)curGrid.Tag;
                            r.PS = r.zapTag = r.zap = "";
                            r.dataZap = dateOfDay;
                            r.PID = 0;
                            ___BASA__DataSet.Zurnal.AddZurnalRow(r);

                            ts = ts.AddMinutes(perDay);
                        }
                        setupDATESadd(dateOfDay, (int)curGrid.Tag);
                    }
                }
        }

        private DateTime findDataForGrid(DataGridView curGrid)
        {
            DateTime dateOfDay = dateTimePickerMy.Value.Date;
            if (vid == 1)
            {
                switch (curGrid.Name)
                {
                    case "zurnalDataGridView2":
                        dateOfDay = dateOfDay.AddDays(1);
                        break;
                    case "zurnalDataGridView3":
                        dateOfDay = dateOfDay.AddDays(2);
                        break;
                    case "zurnalDataGridView4":
                        dateOfDay = dateOfDay.AddDays(3);
                        break;
                }
            }
            return dateOfDay;
        }


        public int addedPeriodToBegin = 0;
        public int addedPeriodToEnd = 0; 
        private void addTimeEndToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            addedPeriodToBegin = 0;
        addedPeriodToEnd = 0; 
       
            DataGridView curGrid = (DataGridView)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl;
            if (curGrid.Rows.Count > 0)
            {
                DateTime dateOfDay = findDataForGrid(curGrid);
                
                DateTime minT = DateTime.MaxValue;
                DateTime maxT = DateTime.MinValue;
                int maxPer=0;
                foreach (___BASA__DataSet.ZurnalRow dr in ___BASA__DataSet.Zurnal.Select("DID=" + curGrid.Tag.ToString() + " AND dataZap='" + dateOfDay + "'"))
                {
                    if (dr.time.TimeOfDay.TotalMinutes > maxT.TimeOfDay.TotalMinutes)
                    {
                        maxT = dr.time;
                        maxPer=dr.period;
                    }
                    if (dr.time.TimeOfDay.TotalMinutes < minT.TimeOfDay.TotalMinutes)
                    {
                        minT = dr.time;
                    }

                }
                AddTime at = new AddTime();
                at.Tag = this;
                at.endTime = maxT.AddMinutes(maxPer);
                at.beginTime = minT;
                if (at.ShowDialog() == DialogResult.Yes)
                {
                    if (addedPeriodToEnd != 0)
                    {
                        ___BASA__DataSet.ZurnalRow addedRow = ___BASA__DataSet.Zurnal.NewZurnalRow();
                        addedRow.dataZap = dateOfDay;
                        addedRow.PID = 0;
                        addedRow.zap = addedRow.zapTag = addedRow.PS = "";
                        addedRow.DID = (int)curGrid.Tag;
                        addedRow.period = addedPeriodToEnd;
                        addedRow.time = maxT.AddMinutes(maxPer);
                        ___BASA__DataSet.Zurnal.AddZurnalRow(addedRow);
                        setupDATESadd(addedRow.dataZap, (int)curGrid.Tag);
                    }
                    if (addedPeriodToBegin != 0)
                    {
                        ___BASA__DataSet.ZurnalRow addedRow = ___BASA__DataSet.Zurnal.NewZurnalRow();
                        addedRow.dataZap = dateOfDay;
                        addedRow.PID = 0;
                        addedRow.zap = addedRow.zapTag = addedRow.PS = "";
                        addedRow.DID = (int)curGrid.Tag;
                        addedRow.period = addedPeriodToBegin;
                        addedRow.time = minT.AddMinutes(-addedPeriodToBegin);
                        ___BASA__DataSet.Zurnal.AddZurnalRow(addedRow);
                        setupDATESadd(addedRow.dataZap, (int)curGrid.Tag);                  
                    }

                }
            }
        }

        private void contextMenuStripGRID_Opening(object sender, CancelEventArgs e)
        {
            if (((DataGridView)contextMenuStripGRID.SourceControl).Rows.Count > 0)
            {
                addTimeEndToolStripMenuItem.Enabled = true;
            }
            else
            {
                addTimeEndToolStripMenuItem.Enabled = false;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                if (Tab2MakeDo)
                {
                    griddColors();
                    Tab2MakeDo = false;
                }
            }                       
        }
      
        
    }


}
