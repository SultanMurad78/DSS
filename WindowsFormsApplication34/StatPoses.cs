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
    public partial class StatPoses : Form
    {
        public StatPoses()
        {
            InitializeComponent();
        }

        string fil_time1 = "  Дата>'" + DateTimePicker.MinimumDateTime + "' ";
        string fil_time2 = " AND Дата<'" + DateTimePicker.MaximumDateTime + "' ";
        string filDOC = "Personal<>0";
        string filPAT = " Patient<>0";


        private void FILTR()
        {
            posesenieViewBindingSource.Filter = "( " + filDOC + ")" + " AND ( " + filPAT + " ) AND " + fil_time1 + fil_time2;
        }

        private void openDeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (posesenieDataGridView.SelectedRows.Count == 1)
            {
                DeloPers delo = new DeloPers();
                delo.Tag = (int)((DataRowView)posesenieDataGridView.SelectedRows[0].DataBoundItem)["Personal"];
                delo.Text = "Персонал: " + ((DataRowView)posesenieDataGridView.SelectedRows[0].DataBoundItem)["Доктор"].ToString();
                ((MainForm)this.MdiParent).checkWin(delo);
            }
        }

        private void posesenieDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                if (!posesenieDataGridView.Rows[e.RowIndex].Selected)
                {
                    posesenieDataGridView.ClearSelection();
                    posesenieDataGridView.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void oneDOCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (posesenieDataGridView.SelectedRows.Count == 1)
            {
                if (oneDOCToolStripMenuItem.CheckState == CheckState.Unchecked)
                {
                    oneDOCToolStripMenuItem.CheckState = CheckState.Checked;
                    posesenieDataGridView.Columns["DOCColumn"].HeaderCell.ToolTipText = "Двойной щелчек для удаления фильтра";
                    posesenieDataGridView.Columns["DOCColumn"].HeaderText = "Фильтр : " + ((DataRowView)posesenieDataGridView.SelectedRows[0].DataBoundItem)["Доктор"].ToString();
                    filDOC = "  Personal=" + ((DataRowView)posesenieDataGridView.SelectedRows[0].DataBoundItem)["Personal"].ToString();
                }
                else
                {
                    oneDOCToolStripMenuItem.CheckState = CheckState.Unchecked;
                    posesenieDataGridView.Columns["DOCColumn"].HeaderCell.ToolTipText = "";
                    posesenieDataGridView.Columns["DOCColumn"].HeaderText = "Доктор";
                    filDOC = "Personal<>0";
                }
                FILTR();
            }
        }

        private void onePATtoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (posesenieDataGridView.SelectedRows.Count == 1)
            {
                if (onePATtoolStripMenuItem2.CheckState == CheckState.Unchecked)
                {
                    posesenieDataGridView.Columns["PATColumn"].HeaderCell.ToolTipText = "Двойной щелчек для удаления фильтра";
                    posesenieDataGridView.Columns["PATColumn"].HeaderText = "Фильтр : " + ((DataRowView)posesenieDataGridView.SelectedRows[0].DataBoundItem)["Пациент"].ToString();

                    onePATtoolStripMenuItem2.CheckState = CheckState.Checked;
                    filPAT = "  Patient=" + ((DataRowView)posesenieDataGridView.SelectedRows[0].DataBoundItem)["Patient"].ToString();
                }
                else
                {
                    posesenieDataGridView.Columns["PATColumn"].HeaderCell.ToolTipText = "";
                    posesenieDataGridView.Columns["PATColumn"].HeaderText = "Пациент";

                    onePATtoolStripMenuItem2.CheckState = CheckState.Unchecked;
                    filPAT = " Patient<>0";
                }
                FILTR();
            }
        }

        private void openKarttoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (posesenieDataGridView.SelectedRows.Count == 1)
            {
                int patID = (int)((DataRowView)posesenieDataGridView.SelectedRows[0].DataBoundItem)["Patient"];
                if (kartaTableAdapter1.ScalarQueryCuontByPID(patID) == 1)
                {
                    KartaForm pat = new KartaForm();
                    pat.Tag = patID;
                    pat.Text = "Карточка: " + ((DataRowView)posesenieDataGridView.SelectedRows[0].DataBoundItem)["Пациент"].ToString();
                    ((MainForm)this.MdiParent).checkWin(pat);
                }
                else
                {
                    MessageBox.Show("Карточка не найдена. Возможно, она была удалена.");
                }
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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
                fil_time2 = " AND Дата<'" + DateTime.Today.Date.AddDays(1) + "' ";
                fil_time1 = "Дата>='" + DateTime.Today.Date + "' ";
                FILTR();
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
                fil_time2 = " AND Дата<'" + DateTime.Today.Date.AddDays(-DateTime.Today.Date.Day + 1).AddMonths(1) + "' ";
                fil_time1 = "Дата>='" + DateTime.Today.Date.AddDays(-DateTime.Today.Date.Day + 1) + "' ";
                FILTR();
            }
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fil_time1 = "Дата>='" + dateTimePicker1.Value.Date.ToString() + "' ";
            FILTR();
            dateTimePicker2.MinDate = dateTimePicker1.Value.Date;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            fil_time2 = " AND Дата<'" + dateTimePicker2.Value.Date.AddDays(1).ToString() + "' ";
            FILTR();// filter();
            dateTimePicker1.MaxDate = dateTimePicker2.Value.Date;
        }

        private void toolStripLabelALL_Click(object sender, EventArgs e)
        {
            if (toolStripLabelALL.Enabled)
            {
                toolStripButtonPERIOD.Checked = toolStripButtonMONTH.Checked = toolStripButtonTOD.Checked = false;
                fil_time1 = "  Дата>'" + DateTime.MinValue + "' ";
                fil_time2 = " AND Дата<'" + DateTime.MaxValue + "' ";
                FILTR();
                toolStripLabelALL.Text = "Даты";
                toolStripLabelALL.Enabled = false;
            }
        }

        private void StatPoses_Activated(object sender, EventArgs e)
        {
            posesenieViewTableAdapter.Fill(___BASA__DataSet.PosesenieView);
        }

        private void posesenieDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == posesenieDataGridView.Columns["DOCColumn"].Index)
            {
                filDOC = "Personal<>0";
                posesenieDataGridView.Columns["DOCColumn"].HeaderText = "Доктор";
                posesenieDataGridView.Columns["DOCColumn"].HeaderCell.ToolTipText = "";
                oneDOCToolStripMenuItem.CheckState = CheckState.Unchecked;
                FILTR();
            }

            else if (e.ColumnIndex == posesenieDataGridView.Columns["PATColumn"].Index)
            {
                filPAT = " Patient<>0";
                posesenieDataGridView.Columns["PATColumn"].HeaderCell.ToolTipText = "";
                posesenieDataGridView.Columns["PATColumn"].HeaderText = "Пациент";
                onePATtoolStripMenuItem2.CheckState = CheckState.Unchecked;
                FILTR();
            }
        }

        private void posesenieViewBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            labelSUM.Text = ___BASA__DataSet.PosesenieView.Compute("SUM(Сумма)", "( " + filDOC + ")" + " AND ( " + filPAT + " ) AND " + fil_time1 + fil_time2).ToString();
            labelPoses.Text = posesenieViewBindingSource.List.Count.ToString();
        }

        private void posesenieDataGridView_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column == posesenieDataGridView.Columns["SUMColumn"])
            {
                labelSUM.Width = e.Column.Width;
            }
        }

    }
}
