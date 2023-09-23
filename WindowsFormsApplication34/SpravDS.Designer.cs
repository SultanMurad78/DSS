namespace DSS
{
    partial class SpravDS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpravDS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExpandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CollapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonTREE = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTAB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorA = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExp = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonColl = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEnableEdit = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelDEREVO = new System.Windows.Forms.Panel();
            this.panelTAB = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.___BASA__DataSet = new DSS.___BASA__DataSet();
            this.diagnosisTableAdapter = new DSS.___BASA__DataSetTableAdapters.DiagnosisTableAdapter();
            this.tableAdapterManager = new DSS.___BASA__DataSetTableAdapters.TableAdapterManager();
            this.obektTableAdapter = new DSS.___BASA__DataSetTableAdapters.ObektTableAdapter();
            this.treatTableAdapter = new DSS.___BASA__DataSetTableAdapters.TreatTableAdapter();
            this.zalobyTableAdapter = new DSS.___BASA__DataSetTableAdapters.ZalobyTableAdapter();
            this.anamnezTableAdapter = new DSS.___BASA__DataSetTableAdapters.AnamnezTableAdapter();
            this.diagnosisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zalobyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anamnezBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obektBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.treetoolStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.tabtoolStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelDEREVO.SuspendLayout();
            this.panelTAB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.___BASA__DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zalobyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anamnezBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obektBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.HideSelection = false;
            this.treeView1.HotTracking = true;
            this.treeView1.Location = new System.Drawing.Point(0, 56);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(1013, 269);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem,
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ExpandToolStripMenuItem,
            this.CollapsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 142);
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.addItemToolStripMenuItem.Text = "Добавить дочернюю запись";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.newToolStripMenuItem.Text = "Добавить запись в корень";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.editToolStripMenuItem.Text = "Изменить";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(202, 6);
            // 
            // ExpandToolStripMenuItem
            // 
            this.ExpandToolStripMenuItem.Name = "ExpandToolStripMenuItem";
            this.ExpandToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ExpandToolStripMenuItem.Text = "Развернуть дерево";
            this.ExpandToolStripMenuItem.Click += new System.EventHandler(this.ExpandToolStripMenuItem_Click);
            // 
            // CollapsToolStripMenuItem
            // 
            this.CollapsToolStripMenuItem.Name = "CollapsToolStripMenuItem";
            this.CollapsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.CollapsToolStripMenuItem.Text = "Свернуть дерево";
            this.CollapsToolStripMenuItem.Click += new System.EventHandler(this.CollapsToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripButtonTREE,
            this.toolStripButtonTAB,
            this.toolStripSeparatorA,
            this.toolStripButtonExp,
            this.toolStripButtonColl,
            this.toolStripButtonEnableEdit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1013, 36);
            this.toolStrip1.TabIndex = 1;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dSToolStripMenuItem,
            this.tRToolStripMenuItem,
            this.aNToolStripMenuItem,
            this.zALToolStripMenuItem,
            this.oBToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::DSS.Properties.Resources.book_go;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(126, 33);
            this.toolStripDropDownButton1.Text = "Выбрать справочник";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // dSToolStripMenuItem
            // 
            this.dSToolStripMenuItem.Name = "dSToolStripMenuItem";
            this.dSToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.dSToolStripMenuItem.Text = "Диагнозы";
            this.dSToolStripMenuItem.Click += new System.EventHandler(this.dSToolStripMenuItem_Click);
            // 
            // tRToolStripMenuItem
            // 
            this.tRToolStripMenuItem.Name = "tRToolStripMenuItem";
            this.tRToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.tRToolStripMenuItem.Text = "Лечение";
            this.tRToolStripMenuItem.Click += new System.EventHandler(this.tRToolStripMenuItem_Click);
            // 
            // aNToolStripMenuItem
            // 
            this.aNToolStripMenuItem.Name = "aNToolStripMenuItem";
            this.aNToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.aNToolStripMenuItem.Text = "Анамнезы";
            this.aNToolStripMenuItem.Click += new System.EventHandler(this.aNToolStripMenuItem_Click);
            // 
            // zALToolStripMenuItem
            // 
            this.zALToolStripMenuItem.Name = "zALToolStripMenuItem";
            this.zALToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.zALToolStripMenuItem.Text = "Жалобы";
            this.zALToolStripMenuItem.Click += new System.EventHandler(this.zALToolStripMenuItem_Click);
            // 
            // oBToolStripMenuItem
            // 
            this.oBToolStripMenuItem.Name = "oBToolStripMenuItem";
            this.oBToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.oBToolStripMenuItem.Text = "Объективные данные";
            this.oBToolStripMenuItem.Click += new System.EventHandler(this.oBToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripButtonTREE
            // 
            this.toolStripButtonTREE.Checked = true;
            this.toolStripButtonTREE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonTREE.Image = global::DSS.Properties.Resources.chart_organisation;
            this.toolStripButtonTREE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTREE.Name = "toolStripButtonTREE";
            this.toolStripButtonTREE.Size = new System.Drawing.Size(43, 33);
            this.toolStripButtonTREE.Text = "Древо";
            this.toolStripButtonTREE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonTREE.CheckStateChanged += new System.EventHandler(this.toolStripButtonTREE_CheckStateChanged);
            this.toolStripButtonTREE.Click += new System.EventHandler(this.toolStripButtonTREE_Click);
            // 
            // toolStripButtonTAB
            // 
            this.toolStripButtonTAB.Image = global::DSS.Properties.Resources.table;
            this.toolStripButtonTAB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTAB.Name = "toolStripButtonTAB";
            this.toolStripButtonTAB.Size = new System.Drawing.Size(53, 33);
            this.toolStripButtonTAB.Text = "Таблица";
            this.toolStripButtonTAB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonTAB.CheckStateChanged += new System.EventHandler(this.toolStripButtonTAB_CheckStateChanged);
            this.toolStripButtonTAB.Click += new System.EventHandler(this.toolStripButtonTAB_Click);
            // 
            // toolStripSeparatorA
            // 
            this.toolStripSeparatorA.Name = "toolStripSeparatorA";
            this.toolStripSeparatorA.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripButtonExp
            // 
            this.toolStripButtonExp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonExp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExp.Image")));
            this.toolStripButtonExp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExp.Name = "toolStripButtonExp";
            this.toolStripButtonExp.Size = new System.Drawing.Size(110, 33);
            this.toolStripButtonExp.Text = "Развернуть дерево";
            this.toolStripButtonExp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonExp.Click += new System.EventHandler(this.ExpandToolStripMenuItem_Click);
            // 
            // toolStripButtonColl
            // 
            this.toolStripButtonColl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonColl.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonColl.Image")));
            this.toolStripButtonColl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColl.Name = "toolStripButtonColl";
            this.toolStripButtonColl.Size = new System.Drawing.Size(100, 33);
            this.toolStripButtonColl.Text = "Свернуть дерево";
            this.toolStripButtonColl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonColl.Click += new System.EventHandler(this.CollapsToolStripMenuItem_Click);
            // 
            // toolStripButtonEnableEdit
            // 
            this.toolStripButtonEnableEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEnableEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEnableEdit.Image")));
            this.toolStripButtonEnableEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEnableEdit.Name = "toolStripButtonEnableEdit";
            this.toolStripButtonEnableEdit.Size = new System.Drawing.Size(105, 33);
            this.toolStripButtonEnableEdit.Text = "Разрешить правку";
            this.toolStripButtonEnableEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonEnableEdit.Visible = false;
            this.toolStripButtonEnableEdit.Click += new System.EventHandler(this.toolStripButtonEnableEdit_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1013, 56);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // panelDEREVO
            // 
            this.panelDEREVO.AutoScroll = true;
            this.panelDEREVO.Controls.Add(this.treeView1);
            this.panelDEREVO.Controls.Add(this.richTextBox1);
            this.panelDEREVO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDEREVO.Location = new System.Drawing.Point(0, 49);
            this.panelDEREVO.Name = "panelDEREVO";
            this.panelDEREVO.Size = new System.Drawing.Size(1013, 325);
            this.panelDEREVO.TabIndex = 4;
            // 
            // panelTAB
            // 
            this.panelTAB.Controls.Add(this.dataGridView1);
            this.panelTAB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTAB.Location = new System.Drawing.Point(0, 49);
            this.panelTAB.Name = "panelTAB";
            this.panelTAB.Size = new System.Drawing.Size(1013, 325);
            this.panelTAB.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1013, 325);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnAdded);
            // 
            // ___BASA__DataSet
            // 
            this.___BASA__DataSet.DataSetName = "___BASA__DataSet";
            this.___BASA__DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diagnosisTableAdapter
            // 
            this.diagnosisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnamnezTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DiagnosisTableAdapter = this.diagnosisTableAdapter;
            this.tableAdapterManager.DolgTableAdapter = null;
            this.tableAdapterManager.GorodTableAdapter = null;
            this.tableAdapterManager.KadryTableAdapter = null;
            this.tableAdapterManager.KartaTableAdapter = null;
            this.tableAdapterManager.KartyTableAdapter = null;
            this.tableAdapterManager.ObektTableAdapter = this.obektTableAdapter;
            this.tableAdapterManager.OblastTableAdapter = null;
            this.tableAdapterManager.PatientsProfessiaTableAdapter = null;
            this.tableAdapterManager.PatientsRabotaTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.PersonalProfessiaTableAdapter = null;
            this.tableAdapterManager.PersonalTableAdapter = null;
            this.tableAdapterManager.PlataTableAdapter = null;
            this.tableAdapterManager.PosesenieTableAdapter = null;
            this.tableAdapterManager.PredoplataTableAdapter = null;
            this.tableAdapterManager.raspisanieTableAdapter = null;
            this.tableAdapterManager.SexTableAdapter = null;
            this.tableAdapterManager.TreatDSTableAdapter = null;
            this.tableAdapterManager.TreatTableAdapter = this.treatTableAdapter;
            this.tableAdapterManager.TreatTreatTableAdapter = null;
            this.tableAdapterManager.UlizaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DSS.___BASA__DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.whenDatesTableAdapter = null;
            this.tableAdapterManager.ZalobyTableAdapter = this.zalobyTableAdapter;
            this.tableAdapterManager.ZurnalTableAdapter = null;
            // 
            // obektTableAdapter
            // 
            this.obektTableAdapter.ClearBeforeFill = true;
            // 
            // treatTableAdapter
            // 
            this.treatTableAdapter.ClearBeforeFill = true;
            // 
            // zalobyTableAdapter
            // 
            this.zalobyTableAdapter.ClearBeforeFill = true;
            // 
            // anamnezTableAdapter
            // 
            this.anamnezTableAdapter.ClearBeforeFill = true;
            // 
            // diagnosisBindingSource
            // 
            this.diagnosisBindingSource.DataMember = "Diagnosis";
            this.diagnosisBindingSource.DataSource = this.___BASA__DataSet;
            this.diagnosisBindingSource.Sort = "Texts";
            // 
            // treatBindingSource
            // 
            this.treatBindingSource.DataMember = "Treat";
            this.treatBindingSource.DataSource = this.___BASA__DataSet;
            this.treatBindingSource.Sort = "Texts";
            // 
            // zalobyBindingSource
            // 
            this.zalobyBindingSource.DataMember = "Zaloby";
            this.zalobyBindingSource.DataSource = this.___BASA__DataSet;
            this.zalobyBindingSource.Sort = "Texts";
            // 
            // anamnezBindingSource
            // 
            this.anamnezBindingSource.DataMember = "Anamnez";
            this.anamnezBindingSource.DataSource = this.___BASA__DataSet;
            this.anamnezBindingSource.Sort = "Texts";
            // 
            // obektBindingSource
            // 
            this.obektBindingSource.DataMember = "Obekt";
            this.obektBindingSource.DataSource = this.___BASA__DataSet;
            this.obektBindingSource.Sort = "Texts";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1013, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выберите Справочник";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.toolStripMenuItem7,
            this.treetoolStripButton,
            this.tabtoolStripButton});
            this.toolsToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolsToolStripMenuItem.MergeIndex = 0;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.toolsToolStripMenuItem.Text = "Действия";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.toolStripDropDownButton2.Image = global::DSS.Properties.Resources.book_go;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(191, 22);
            this.toolStripDropDownButton2.Text = "Выбрать справочник";
            this.toolStripDropDownButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItem2.Text = "Диагнозы";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.dSToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItem3.Text = "Лечение";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.tRToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItem4.Text = "Анамнезы";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.aNToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItem5.Text = "Жалобы";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.zALToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItem6.Text = "Объективные данные";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.oBToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(188, 6);
            // 
            // treetoolStripButton
            // 
            this.treetoolStripButton.Checked = true;
            this.treetoolStripButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.treetoolStripButton.Image = global::DSS.Properties.Resources.chart_organisation;
            this.treetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.treetoolStripButton.Name = "treetoolStripButton";
            this.treetoolStripButton.Size = new System.Drawing.Size(191, 22);
            this.treetoolStripButton.Text = "Древо";
            this.treetoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.treetoolStripButton.Click += new System.EventHandler(this.toolStripButtonTREE_Click);
            // 
            // tabtoolStripButton
            // 
            this.tabtoolStripButton.Image = global::DSS.Properties.Resources.table;
            this.tabtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tabtoolStripButton.Name = "tabtoolStripButton";
            this.tabtoolStripButton.Size = new System.Drawing.Size(191, 22);
            this.tabtoolStripButton.Text = "Таблица";
            this.tabtoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tabtoolStripButton.Click += new System.EventHandler(this.toolStripButtonTAB_Click);
            // 
            // SpravDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1013, 374);
            this.Controls.Add(this.panelDEREVO);
            this.Controls.Add(this.panelTAB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SpravDS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Tag = "Справочники";
            this.Text = "Справочники";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SpravDS_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SpravDS_FormClosed);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelDEREVO.ResumeLayout(false);
            this.panelTAB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.___BASA__DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zalobyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anamnezBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obektBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private ___BASA__DataSet ___BASA__DataSet;
        private DSS.___BASA__DataSetTableAdapters.DiagnosisTableAdapter diagnosisTableAdapter;
        private DSS.___BASA__DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private DSS.___BASA__DataSetTableAdapters.ZalobyTableAdapter zalobyTableAdapter;
        private DSS.___BASA__DataSetTableAdapters.TreatTableAdapter treatTableAdapter;
        private DSS.___BASA__DataSetTableAdapters.ObektTableAdapter obektTableAdapter;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem dSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oBToolStripMenuItem;
        private DSS.___BASA__DataSetTableAdapters.AnamnezTableAdapter anamnezTableAdapter;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButtonTREE;
        private System.Windows.Forms.ToolStripButton toolStripButtonTAB;
        private System.Windows.Forms.Panel panelDEREVO;
        private System.Windows.Forms.Panel panelTAB;
        private System.Windows.Forms.DataGridView dataGridView1;
       
        private System.Windows.Forms.BindingSource anamnezBindingSource;
        private System.Windows.Forms.BindingSource diagnosisBindingSource;
        private System.Windows.Forms.BindingSource treatBindingSource;
        private System.Windows.Forms.BindingSource zalobyBindingSource;
        private System.Windows.Forms.BindingSource obektBindingSource;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem ExpandToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorA;
        private System.Windows.Forms.ToolStripButton toolStripButtonExp;
        private System.Windows.Forms.ToolStripButton toolStripButtonColl;
        private System.Windows.Forms.ToolStripMenuItem CollapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonEnableEdit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem treetoolStripButton;
        private System.Windows.Forms.ToolStripMenuItem tabtoolStripButton;
    }
}