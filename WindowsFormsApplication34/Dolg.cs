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
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DSS
{
    public partial class Dolg : Form
    {
        public Dolg()
        {
            InitializeComponent();
        }

      

        private void takeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakeMoney Tm = new TakeMoney();
            Tm.Text = "Оплата Долга";
            Tm.Tag = "pay1";
            Tm.PID = ((___BASA__DataSet.DolgViewRow)((DataRowView)dolgDataGridView.CurrentRow.DataBoundItem).Row).PID;
            Tm.dolgOneID = ((___BASA__DataSet.DolgViewRow)((DataRowView)dolgDataGridView.CurrentRow.DataBoundItem).Row).ID;
            Tm.PFIO = ((___BASA__DataSet.DolgViewRow)((DataRowView)dolgDataGridView.CurrentRow.DataBoundItem).Row).PFIO;
            Tm.ShowDialog();
            dolgViewTableAdapter.Fill(___BASA__DataSet.DolgView);
            predoplataViewTableAdapter.Fill(___BASA__DataSet.PredoplataView);
        }

        private void dolgDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.RowIndex != -1 & e.ColumnIndex != -1 ) )
            {
                dolgDataGridView.CurrentCell = dolgDataGridView[e.ColumnIndex, e.RowIndex];
                dolgDataGridView[e.ColumnIndex, e.RowIndex].ContextMenuStrip = dolgCellContextMenuStrip;
            }
        }

        private void prostitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakeMoney Tm = new TakeMoney();
            Tm.Text = "ПРОЩАЕМ ДОЛГ";
            Tm.Tag = "pay0";
            Tm.PID = ((___BASA__DataSet.DolgViewRow)((DataRowView)dolgDataGridView.CurrentRow.DataBoundItem).Row).PID;
            Tm.dolgOneID = ((___BASA__DataSet.DolgViewRow)((DataRowView)dolgDataGridView.CurrentRow.DataBoundItem).Row).ID;
            Tm.PFIO = ((___BASA__DataSet.DolgViewRow)((DataRowView)dolgDataGridView.CurrentRow.DataBoundItem).Row).PFIO;
           Tm.ShowDialog();
            dolgViewTableAdapter.Fill(___BASA__DataSet.DolgView);
            predoplataViewTableAdapter.Fill(___BASA__DataSet.PredoplataView);
        }

        private void predDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.RowIndex != -1 & e.ColumnIndex != -1))
            {
                predDataGridView.CurrentCell = predDataGridView[e.ColumnIndex, e.RowIndex];
                predDataGridView[e.ColumnIndex, e.RowIndex].ContextMenuStrip = predContextMenuStrip;
            }
        }

       
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TakeMoney Tm = new TakeMoney();
            Tm.Text = "Возврат Предоплаты";
            Tm.Tag = "pred";
            Tm.PID = ((___BASA__DataSet.PredoplataViewRow)((DataRowView)predDataGridView. CurrentRow.DataBoundItem).Row).PID;
            Tm.dolgOneID = ((___BASA__DataSet.PredoplataViewRow)((DataRowView)predDataGridView.CurrentRow.DataBoundItem).Row).ID;
            Tm.PFIO = ((___BASA__DataSet.PredoplataViewRow)((DataRowView)predDataGridView.CurrentRow.DataBoundItem).Row).PFIO;
            Tm.dolgSumma = ((___BASA__DataSet.PredoplataViewRow)((DataRowView)predDataGridView.CurrentRow.DataBoundItem).Row).Predoplata;
           Tm.ShowDialog();
           dolgViewTableAdapter.Fill(___BASA__DataSet.DolgView);
           predoplataViewTableAdapter.Fill(___BASA__DataSet.PredoplataView);
        }

        private void takeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakeMoney Tm = new TakeMoney();
            Tm.Text = "Оплата Долгов";
            Tm.Tag = "payAll";
            int tmPID = ((___BASA__DataSet.DolgViewRow)((DataRowView)dolgDataGridView.CurrentRow.DataBoundItem).Row).PID;
            Tm.PID = tmPID;
            Tm.dolgManyIDS = new int[___BASA__DataSet.DolgView.Select("PID=" + tmPID.ToString()).Length];
            int iii = 0;
            foreach (___BASA__DataSet.DolgViewRow dr in ___BASA__DataSet.DolgView.Select("PID=" + tmPID.ToString()))
            {
                Tm.dolgSumma += dr.dolg;
                Tm.dolgManyIDS[iii] = dr.ID;
                iii++;
            }
            Tm.PFIO = ((___BASA__DataSet.DolgViewRow)((DataRowView)dolgDataGridView.CurrentRow.DataBoundItem).Row).PFIO;
            Tm.ShowDialog();
            dolgViewTableAdapter.Fill(___BASA__DataSet.DolgView);
            predoplataViewTableAdapter.Fill(___BASA__DataSet.PredoplataView);
        }

        private void dolgContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            int tmPID = ((___BASA__DataSet.DolgViewRow)((DataRowView)dolgDataGridView.CurrentRow.DataBoundItem).Row).PID;
            if (___BASA__DataSet.DolgView.Select("PID=" + tmPID.ToString()).Length > 1)
            {
                takeAllToolStripMenuItem.Enabled = true;
            }
            else
            {
                takeAllToolStripMenuItem.Enabled = false;
            }
            if (___BASA__DataSet.PredoplataView.Select("PID=" + tmPID.ToString()).Length > 0)
            {
                fromPredToolStripMenuItem.Enabled = true;
            }
            else
            {
                fromPredToolStripMenuItem.Enabled = false;
            }
        }

        private void fromPredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakeMoney Tm = new TakeMoney();
            Tm.dolgOneID = ((___BASA__DataSet.DolgViewRow)((DataRowView)dolgDataGridView.CurrentRow.DataBoundItem).Row).ID;
            Tm.Text = "Списание Долга из Предоплаты";
            Tm.Tag = "from";
            int tmPID = ((___BASA__DataSet.DolgViewRow)((DataRowView)dolgDataGridView.CurrentRow.DataBoundItem).Row).PID;
            Tm.PID = tmPID;
            Tm.dolgManyIDS = new int[___BASA__DataSet.PredoplataView.Select("PID=" + tmPID.ToString()).Length];
            int iii = 0;
            foreach (___BASA__DataSet.PredoplataViewRow dr in ___BASA__DataSet.PredoplataView.Select("PID=" + tmPID.ToString()))
            {
                Tm.predSumma += dr.Predoplata;
                Tm.dolgSumma = ((___BASA__DataSet.DolgViewRow)((DataRowView)dolgDataGridView.CurrentRow.DataBoundItem).Row).dolg;
                Tm.dolgManyIDS[iii] = dr.ID;
                iii++;
            }
            Tm.PFIO = ((___BASA__DataSet.DolgViewRow)((DataRowView)dolgDataGridView.CurrentRow.DataBoundItem).Row).PFIO;
            Tm.ShowDialog();
            dolgViewTableAdapter.Fill(___BASA__DataSet.DolgView);
            predoplataViewTableAdapter.Fill(___BASA__DataSet.PredoplataView);
        }

        private void Dolg_Activated(object sender, EventArgs e)
        {
            this.kartyTableAdapter1.Fill(this.___BASA__DataSet.Karty,true);
            this.predoplataViewTableAdapter.Fill(this.___BASA__DataSet.PredoplataView);
            this.dolgViewTableAdapter.Fill(this.___BASA__DataSet.DolgView);
        }

        private void todayDolgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!todayDolgToolStripMenuItem.Checked)
            {
                dolgViewBindingSource.Filter = "Data>='" + DateTime.Today.Date.ToString() + "' AND Data<'" + DateTime.Today.Date.AddDays(1).ToString() + "'";
                toolStripMenuItemTodDolg.CheckState = CheckState.Checked;
                toolStripMenuItemTodayDolg.Checked = todayDolgToolStripMenuItem.Checked = true;
                toolStripMenuItemDolgPred.CheckState = CheckState.Unchecked;
                toolStripMenuItemOnlyPred.Checked = onlToolStripMenuItem.Checked = false;
            }
            else
            {
                dolgViewBindingSource.Filter = "";
                toolStripMenuItemTodDolg.CheckState = CheckState.Unchecked;
                toolStripMenuItemTodayDolg.Checked = todayDolgToolStripMenuItem.Checked = false;
            }
        }

        private void onlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!onlToolStripMenuItem.Checked)
            {
                string filter = "PID=0";
                foreach (___BASA__DataSet.DolgViewRow dr in ___BASA__DataSet.DolgView.Rows)
                {
                    if (___BASA__DataSet.PredoplataView.Select("PID=" + dr.PID.ToString()).Length > 0)
                    {
                        filter += " OR PID=" + dr.PID.ToString();
                    }
                }
                dolgViewBindingSource.Filter = filter;
                toolStripMenuItemDolgPred.CheckState = CheckState.Checked;
                toolStripMenuItemOnlyPred.Checked = onlToolStripMenuItem.Checked = true;
                toolStripMenuItemTodDolg.Checked = toolStripMenuItemTodayDolg.Checked = todayDolgToolStripMenuItem.Checked = false;
            }
            else
            {
                dolgViewBindingSource.Filter = "";
                toolStripMenuItemDolgPred.CheckState = CheckState.Unchecked;
                toolStripMenuItemOnlyPred.Checked = onlToolStripMenuItem.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TakeMoney Tm = new TakeMoney();
            Tm.Text = "Прием Предоплаты";
            Tm.Tag = "take";
            Tm.PID = (int)pFIOComboBox.SelectedValue;
            Tm.PFIO = pFIOComboBox.Text;
            Tm.ShowDialog();
            dolgViewTableAdapter.Fill(___BASA__DataSet.DolgView);
            predoplataViewTableAdapter.Fill(___BASA__DataSet.PredoplataView);

        }

        private void openKartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KartaForm pat = new KartaForm();
            pat.Tag = ((___BASA__DataSet.DolgViewRow)((DataRowView)dolgDataGridView.CurrentRow.DataBoundItem).Row).PID;
            pat.Text = "Карточка: " + ((___BASA__DataSet.DolgViewRow)((DataRowView)dolgDataGridView.CurrentRow.DataBoundItem).Row).PFIO;
            ((MainForm)this.MdiParent).checkWin(pat);
        }

        private void OpenKartPredtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            int patID = ((___BASA__DataSet.PredoplataViewRow)((DataRowView)predDataGridView.CurrentRow.DataBoundItem).Row).PID;
            if (kartaTableAdapter1.ScalarQueryCuontByPID(patID) == 1)
            {
                KartaForm pat = new KartaForm();
                pat.Tag = patID;
                pat.Text = "Карточка: " + ((___BASA__DataSet.PredoplataViewRow)((DataRowView)predDataGridView.CurrentRow.DataBoundItem).Row).PFIO;
            ((MainForm)this.MdiParent).checkWin(pat);
            }
            else
            {
                MessageBox.Show("Карточка не найдена. Возможно, она была удалена.");
            }
        }
    }
}
