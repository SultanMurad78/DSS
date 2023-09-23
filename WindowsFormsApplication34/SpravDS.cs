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
    public partial class SpravDS : Form
    {
        public SpravDS()
        {
            InitializeComponent();
        }

        private void SpravDS_Load(object sender, EventArgs e)
        {
            this.anamnezTableAdapter.FillByReal(this.___BASA__DataSet.Anamnez, true);
            this.zalobyTableAdapter.FillByReal(this.___BASA__DataSet.Zaloby, true);
            this.diagnosisTableAdapter.FillByReal(this.___BASA__DataSet.Diagnosis, true);
            this.obektTableAdapter.FillByReal(this.___BASA__DataSet.Obekt, true);
            this.treatTableAdapter.FillByReal(this.___BASA__DataSet.Treat, true);

        }
        string filtr = "";
        private void FirstTreeNode(DataTable table)
        {
            filtr = "isReal<>FALSE";
            treeView1.Nodes.Clear();
            DataRow[] firstRow = table.Select("ParID=0  AND isReal<>FALSE");
            foreach (DataRow f in firstRow)
            {
                if (f.RowState != DataRowState.Deleted && f.RowState != DataRowState.Detached)
                {
                    TreeNode tn = new TreeNode();

                    DataRow[] secondRow = table.Select("ParID=" + f["ID"].ToString());
                    int len = secondRow.Length;
                    if (table == ___BASA__DataSet.Treat)
                    {
                        if (len == 0)
                        {

                            tn = treeView1.Nodes.Add(f["ID"].ToString(), f["Names"].ToString() + " (цена:" + f["Money"].ToString() + ")");
                        }
                        else
                        {
                            tn = treeView1.Nodes.Add(f["ID"].ToString(), f["Names"].ToString());
                        }
                    }
                    else
                    {
                        tn = treeView1.Nodes.Add(f["ID"].ToString(), f["Names"].ToString());
                    }
                    if (len != 0)
                    {
                        filtr += " AND ID<>" + f["ID"].ToString();
                        AddTreeNodes(tn, secondRow, table);
                    }
                    tn.Tag = f;
                    tn.ContextMenuStrip = contextMenuStrip1;
                }
            }
        }

        private void AddTreeNodes(TreeNode tn, DataRow[] secondRow, DataTable table)
        {

            foreach (DataRow f in secondRow)
            {
                if (f.RowState != DataRowState.Deleted && f.RowState != DataRowState.Detached)
                {
                    TreeNode lactNode = new TreeNode();

                    DataRow[] last = table.Select("ParID=" + f["ID"].ToString() + "  AND isReal<>FALSE");
                    int len = last.Length;
                    if (table == ___BASA__DataSet.Treat)
                    {
                        if (len == 0)
                        {
                            lactNode = tn.Nodes.Add(f["ID"].ToString(), f["Names"].ToString() + " (цена:" + f["Money"].ToString() + ")");
                        }
                        else
                        {
                            lactNode = tn.Nodes.Add(f["ID"].ToString(), f["Names"].ToString());
                        }
                    }
                    else
                    {
                        lactNode = tn.Nodes.Add(f["ID"].ToString(), f["Names"].ToString());
                    }
                    if (len != 0)
                    {
                        filtr += " AND ID<>" + f["ID"].ToString();
                        AddTreeNodes(lactNode, last, table);
                    }
                    lactNode.Tag = f;
                    lactNode.ContextMenuStrip = contextMenuStrip1;
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (((DataRow)e.Node.Tag).RowState != DataRowState.Detached && ((DataRow)e.Node.Tag).RowState != DataRowState.Deleted)
            {
                richTextBox1.Text = ((DataRow)e.Node.Tag)["Texts"].ToString();
                ((BindingSource)dataGridView1.DataSource).Position = ((BindingSource)dataGridView1.DataSource).Find("ID", ((DataRow)e.Node.Tag)["ID"]);
            }
        }

        private void dSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Диагнозы";
            treeView1.Tag = ___BASA__DataSet.Diagnosis;
            FirstTreeNode(___BASA__DataSet.Diagnosis);
            diagnosisBindingSource.Filter = filtr;
            dataGridView1.DataSource = diagnosisBindingSource;
        }

        private void tRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Tag = ___BASA__DataSet.Treat;
            label2.Text = "Лечение";
            FirstTreeNode(___BASA__DataSet.Treat);
            treatBindingSource.Filter = filtr;
            dataGridView1.DataSource = treatBindingSource;
        }

        private void aNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Tag = ___BASA__DataSet.Anamnez;
            label2.Text = "Анамнезы";
            FirstTreeNode(___BASA__DataSet.Anamnez);
            anamnezBindingSource.Filter = filtr;
            dataGridView1.DataSource = anamnezBindingSource;
        }

        private void zALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Tag = ___BASA__DataSet.Zaloby;
            label2.Text = "Жалобы";
            FirstTreeNode(___BASA__DataSet.Zaloby);
            zalobyBindingSource.Filter = filtr;
            dataGridView1.DataSource = zalobyBindingSource;
        }

        private void oBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Tag = ___BASA__DataSet.Obekt;
            label2.Text = "Объективные данные";
            FirstTreeNode(___BASA__DataSet.Obekt);
            obektBindingSource.Filter = filtr;
            dataGridView1.DataSource = obektBindingSource;
        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            switch (e.Column.DataPropertyName)
            {
                case "Texts":
                    e.Column.HeaderText = "Полный текст";
                    e.Column.DisplayIndex = 0;
                    break;
                case "Names":
                    e.Column.HeaderText = "Текст, отображаемый в древе";
                    break;
                case "Money":
                    e.Column.HeaderText = "Стоимость манипуляции";
                    e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    //   e.Column.e
                    break;
                case "ID":
                    e.Column.Visible = false;
                    break;
                case "ParID":
                    e.Column.Visible = false;
                    break;
                case "isReal":
                    e.Column.Visible = false;
                    break;
            }

        }

        private void toolStripButtonTAB_Click(object sender, EventArgs e)
        {
            if (!toolStripButtonTAB.Checked)
            {
                toolStripButtonTAB.Checked = true;
                toolStripButtonTREE.Checked = false;
                toolStripButtonColl.Visible = toolStripButtonExp.Visible = false;
                toolStripButtonEnableEdit.Visible = true;
                panelTAB.BringToFront();
            }
        }

        private void toolStripButtonTREE_Click(object sender, EventArgs e)
        {
            if (!toolStripButtonTREE.Checked)
            {
                toolStripButtonTAB.Checked = false;
                toolStripButtonTREE.Checked = true;
                toolStripButtonEnableEdit.Visible = false;
                toolStripButtonColl.Visible = toolStripButtonExp.Visible = true;
                panelDEREVO.BringToFront();
                treeView1.Focus();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            FirstTreeNode((DataTable)treeView1.Tag);
        }


        public decimal newCena = 0;
        public string newTexts = "";
        public string newNames = "";
        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                DataTable tab = (DataTable)treeView1.Tag;
                int ID = (int)((DataRow)treeView1.SelectedNode.Tag)["ID"];
                SpravAddItem sa = new SpravAddItem();
                sa.texts = ((DataRow)treeView1.SelectedNode.Tag)["Texts"].ToString();
                sa.names = ((DataRow)treeView1.SelectedNode.Tag)["Names"].ToString();
                sa.Tag = this;
                switch (tab.TableName)
                {
                    case "Diagnosis":
                        sa.Text = "Новый Диагноз";
                        break;
                    case "Obekt":
                        sa.Text = "Новые данные Объективного осмотра";
                        break;
                    case "Anamnez":
                        sa.Text = "Новый Анамнез";
                        break;
                    case "Zaloby":
                        sa.Text = "Новые Жалобы";
                        break;
                    case "Treat":
                        sa.Text = "Новое Лечение";
                        sa.labelCena.Visible = true;
                        sa.numericUpDownCena.Visible = true;
                        break;
                }

                if (sa.ShowDialog() == DialogResult.Yes)
                {
                    AddRootItem(tab, ID);
                }
            }
        }

        private void AddRootItem(DataTable tab, int ID)
        {

            if (tab == ___BASA__DataSet.Diagnosis)
            {
                ___BASA__DataSet.Diagnosis.AddDiagnosisRow(ID, newNames, newTexts, true);
                diagnosisTableAdapter.Update(___BASA__DataSet);
                diagnosisTableAdapter.FillByReal(___BASA__DataSet.Diagnosis, true);
                FindNewNode(tab, ID, diagnosisBindingSource);
            }
            else if (tab == ___BASA__DataSet.Zaloby)
            {
                ___BASA__DataSet.Zaloby.AddZalobyRow(ID, newNames, newTexts, true);
                zalobyTableAdapter.Update(___BASA__DataSet);
                zalobyTableAdapter.FillByReal(___BASA__DataSet.Zaloby, true);
                FindNewNode(tab, ID, zalobyBindingSource);
            }
            else if (tab == ___BASA__DataSet.Anamnez)
            {
                ___BASA__DataSet.Anamnez.AddAnamnezRow(ID, newNames, newTexts, true);
                anamnezTableAdapter.Update(___BASA__DataSet);
                anamnezTableAdapter.FillByReal(___BASA__DataSet.Anamnez, true);
                FindNewNode(tab, ID, anamnezBindingSource);
            }
            else if (tab == ___BASA__DataSet.Obekt)
            {
                ___BASA__DataSet.Obekt.AddObektRow(ID, newNames, newTexts, true);
                obektTableAdapter.Update(___BASA__DataSet);
                obektTableAdapter.FillByReal(___BASA__DataSet.Obekt, true);
                FindNewNode(tab, ID, obektBindingSource);
            }
            else if (tab == ___BASA__DataSet.Treat)
            {
                ___BASA__DataSet.Treat.AddTreatRow(ID, newNames, newTexts, newCena, true);
                treatTableAdapter.Update(___BASA__DataSet);
                treatTableAdapter.FillByReal(___BASA__DataSet.Treat, true);
                FindNewNode(tab, ID, treatBindingSource);
            }
        }

        private void FindNewNode(DataTable tab, int ID, BindingSource bind)
        {
            FirstTreeNode(tab);
            bind.Filter = filtr;
            DataRow[] drs = tab.Select("ParID=" + ID.ToString() + " AND [Texts]='" + newTexts + "' AND [Names]='" + newNames + "'");
            if (drs.Length > 0)
            {
                int newID = (int)drs[0]["ID"];
                if (treeView1.Nodes.Find(newID.ToString(), true).Length != 0)
                {
                    TreeNode novNparent = treeView1.Nodes.Find(newID.ToString(), true)[0];
                    treeView1.SelectedNode = novNparent;
                }
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView1.SelectedNode = e.Node;
        }


        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Focused)
            {
                if (treeView1.Nodes.Find(((DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem)["ID"].ToString(), true).Length > 0)
                {
                    treeView1.SelectedNode = treeView1.Nodes.Find(((DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem)["ID"].ToString(), true)[0];
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable tab = (DataTable)treeView1.Tag;
            int ID = 0;
            SpravAddItem sa = new SpravAddItem();
            sa.texts = "Корень";
            sa.names = "Корень";
            sa.Tag = this;
            switch (tab.TableName)
            {
                case "Diagnosis":
                    sa.Text = "Новый Диагноз";
                    break;
                case "Obekt":
                    sa.Text = "Новые данные Объективного осмотра";
                    break;
                case "Anamnez":
                    sa.Text = "Новый Анамнез";
                    break;
                case "Zaloby":
                    sa.Text = "Новые Жалобы";
                    break;
                case "Treat":
                    sa.Text = "Новое Лечение";
                    sa.labelCena.Visible = true;
                    sa.numericUpDownCena.Visible = true;
                    break;
            }

            if (sa.ShowDialog() == DialogResult.Yes)
            {
                AddRootItem(tab, ID);
            }

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                DataTable tab = (DataTable)treeView1.Tag;
                int ID = (int)((DataRow)treeView1.SelectedNode.Tag)["ParID"];
                SpravAddItem sa = new SpravAddItem();
                sa.texts = ((DataRow)treeView1.SelectedNode.Tag)["Texts"].ToString();
                sa.names = ((DataRow)treeView1.SelectedNode.Tag)["Names"].ToString();
                sa.labelParent.Text = "Текущие параметры";
                sa.Tag = this;
                switch (tab.TableName)
                {
                    case "Diagnosis":
                        sa.Text = "Изменить Диагноз";
                        break;
                    case "Obekt":
                        sa.Text = "Изменить данные Объективного осмотра";
                        break;
                    case "Anamnez":
                        sa.Text = "Изменить Анамнез";
                        break;
                    case "Zaloby":
                        sa.Text = "Изменить Жалобы";
                        break;
                    case "Treat":
                        sa.Text = "Изменить Лечение";
                        sa.labelCena.Visible = true;
                        sa.numericUpDownCena.Visible = true;
                        break;
                }

                if (sa.ShowDialog() == DialogResult.Yes)
                {
                    if (tab == ___BASA__DataSet.Treat)
                    {
                        ((DataRow)treeView1.SelectedNode.Tag)["Money"] = newCena;
                        treeView1.SelectedNode.Text = newNames + " (цена:" + newCena.ToString() + ")";

                    }
                    else
                    {
                        treeView1.SelectedNode.Text = newNames;
                    }
                    ((DataRow)treeView1.SelectedNode.Tag)["Texts"] = newTexts;
                    ((DataRow)treeView1.SelectedNode.Tag)["Names"] = newNames;
                }
            }
        }

        private void SpravDS_FormClosed(object sender, FormClosedEventArgs e)
        {
            diagnosisBindingSource.EndEdit();
            treatBindingSource.EndEdit();
            anamnezBindingSource.EndEdit();
            obektBindingSource.EndEdit();
            zalobyBindingSource.EndEdit();
            this.Validate();
            diagnosisTableAdapter.Update(___BASA__DataSet);
            try
            {
                treatTableAdapter.Update(___BASA__DataSet);
            }
            catch (Exception q)
            {
                MessageBox.Show(q.Message);
            }
            anamnezTableAdapter.Update(___BASA__DataSet);
            obektTableAdapter.Update(___BASA__DataSet);
            zalobyTableAdapter.Update(___BASA__DataSet);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                DataRow[] rs = ((DataTable)treeView1.Tag).Select("ParID=" + ((DataRow)treeView1.SelectedNode.Tag)["ID"].ToString());
                if (rs.Length > 0)
                {
                    if (MessageBox.Show("Внимание! Выбранный узел и все дочерние будут удалены без возможности восстановления.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        ((DataRow)treeView1.SelectedNode.Tag)["isReal"] = false;
                        treeView1.SelectedNode.Remove();
                        rowDelete(rs);
                    }
                }
                else
                {
                    if (MessageBox.Show("Внимание! Выбранный узел будет удалён без возможности восстановления.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        ((DataRow)treeView1.SelectedNode.Tag)["isReal"] = false;
                        treeView1.SelectedNode.Remove();
                    }
                }
            }
        }

        private void rowDelete(DataRow[] rs)
        {
            foreach (DataRow r in rs)
            {
                if (((DataTable)treeView1.Tag).Select("ParID=" + r["ID"].ToString()).Length > 0)
                {
                    rowDelete(((DataTable)treeView1.Tag).Select("ParID=" + r["ID"].ToString()));
                }
                r["isReal"] = false;
            }
        }

        private void ExpandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void CollapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void toolStripButtonEnableEdit_Click(object sender, EventArgs e)
        {
            if (toolStripButtonEnableEdit.Checked)
            {
                toolStripButtonEnableEdit.Checked = false;
                dataGridView1.ReadOnly = true;
            }
            else
            {
                toolStripButtonEnableEdit.Checked = true;
                dataGridView1.ReadOnly = false;
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
            e.Cancel = true;
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Money" && dataGridView1[e.ColumnIndex, e.RowIndex].IsInEditMode)
            {
                bool b = false;
                decimal m = (decimal)dataGridView1[e.ColumnIndex, e.RowIndex].Value; ;
                try
                {
                    m = Convert.ToDecimal(dataGridView1[e.ColumnIndex, e.RowIndex].EditedFormattedValue);
                }

                catch (Exception ex)
                {
                    b = true;
                    MessageBox.Show(ex.Message);
                    e.Cancel = true;
                }


                if (!b)
                {
                    if (m < 0)
                    {
                        MessageBox.Show("Стоимость не может быть меньше 0.");
                        e.Cancel = true;

                    }
                    else if (m > 1000000000000)
                    {
                        MessageBox.Show("Стоимость не может быть больше 1.000.000.000.000.");
                        e.Cancel = true;
                    }
                }
            }
        }

        private void toolStripButtonTREE_CheckStateChanged(object sender, EventArgs e)
        {
            treetoolStripButton.CheckState = toolStripButtonTREE.CheckState;
        }

        private void toolStripButtonTAB_CheckStateChanged(object sender, EventArgs e)
        {
            tabtoolStripButton.CheckState = toolStripButtonTAB.CheckState;
        }

    }
}
