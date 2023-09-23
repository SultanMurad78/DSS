namespace DSS
{
    partial class StatPoses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatPoses));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonUPD = new System.Windows.Forms.ToolStripButton();
            this.posesenieDataGridView = new System.Windows.Forms.DataGridView();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripDOC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openDeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneDOCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PATColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripPAT = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openKarttoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.onePATtoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.нарядDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUMColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posesenieViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.___BASA__DataSet = new DSS.___BASA__DataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelALL = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTOD = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMONTH = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPERIOD = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPoses = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSUM = new System.Windows.Forms.Label();
            this.tableAdapterManager = new DSS.___BASA__DataSetTableAdapters.TableAdapterManager();
            this.posesenieViewTableAdapter = new DSS.___BASA__DataSetTableAdapters.PosesenieViewTableAdapter();
            this.kartaTableAdapter1 = new DSS.___BASA__DataSetTableAdapters.KartaTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posesenieDataGridView)).BeginInit();
            this.contextMenuStripDOC.SuspendLayout();
            this.contextMenuStripPAT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posesenieViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.___BASA__DataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonUPD});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(953, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonUPD
            // 
            this.toolStripButtonUPD.Image = global::DSS.Properties.Resources.table_refresh;
            this.toolStripButtonUPD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUPD.Name = "toolStripButtonUPD";
            this.toolStripButtonUPD.Size = new System.Drawing.Size(77, 22);
            this.toolStripButtonUPD.Text = "Обновить";
            this.toolStripButtonUPD.Click += new System.EventHandler(this.StatPoses_Activated);
            // 
            // posesenieDataGridView
            // 
            this.posesenieDataGridView.AllowUserToAddRows = false;
            this.posesenieDataGridView.AllowUserToDeleteRows = false;
            this.posesenieDataGridView.AllowUserToOrderColumns = true;
            this.posesenieDataGridView.AllowUserToResizeRows = false;
            this.posesenieDataGridView.AutoGenerateColumns = false;
            this.posesenieDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.posesenieDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.posesenieDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.posesenieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.posesenieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.датаDataGridViewTextBoxColumn,
            this.DOCColumn,
            this.PATColumn,
            this.нарядDataGridViewTextBoxColumn,
            this.SUMColumn});
            this.posesenieDataGridView.DataSource = this.posesenieViewBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.posesenieDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.posesenieDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.posesenieDataGridView.Location = new System.Drawing.Point(3, 60);
            this.posesenieDataGridView.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.posesenieDataGridView.MultiSelect = false;
            this.posesenieDataGridView.Name = "posesenieDataGridView";
            this.posesenieDataGridView.ReadOnly = true;
            this.posesenieDataGridView.RowHeadersVisible = false;
            this.posesenieDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.posesenieDataGridView.Size = new System.Drawing.Size(947, 348);
            this.posesenieDataGridView.TabIndex = 2;
            this.posesenieDataGridView.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.posesenieDataGridView_ColumnHeaderMouseDoubleClick);
            this.posesenieDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.posesenieDataGridView_CellMouseDown);
            this.posesenieDataGridView.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.posesenieDataGridView_ColumnWidthChanged);
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.датаDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаDataGridViewTextBoxColumn.Width = 58;
            // 
            // DOCColumn
            // 
            this.DOCColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DOCColumn.ContextMenuStrip = this.contextMenuStripDOC;
            this.DOCColumn.DataPropertyName = "Доктор";
            this.DOCColumn.HeaderText = "Доктор";
            this.DOCColumn.Name = "DOCColumn";
            this.DOCColumn.ReadOnly = true;
            // 
            // contextMenuStripDOC
            // 
            this.contextMenuStripDOC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDeloToolStripMenuItem,
            this.oneDOCToolStripMenuItem});
            this.contextMenuStripDOC.Name = "contextMenuStripDOC";
            this.contextMenuStripDOC.Size = new System.Drawing.Size(220, 48);
            // 
            // openDeloToolStripMenuItem
            // 
            this.openDeloToolStripMenuItem.Image = global::DSS.Properties.Resources.user_suit;
            this.openDeloToolStripMenuItem.Name = "openDeloToolStripMenuItem";
            this.openDeloToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.openDeloToolStripMenuItem.Text = "Открыть личное дело";
            this.openDeloToolStripMenuItem.Click += new System.EventHandler(this.openDeloToolStripMenuItem_Click);
            // 
            // oneDOCToolStripMenuItem
            // 
            this.oneDOCToolStripMenuItem.Image = global::DSS.Properties.Resources.fillter;
            this.oneDOCToolStripMenuItem.Name = "oneDOCToolStripMenuItem";
            this.oneDOCToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.oneDOCToolStripMenuItem.Text = "Посещения этого доктора";
            this.oneDOCToolStripMenuItem.Click += new System.EventHandler(this.oneDOCToolStripMenuItem_Click);
            // 
            // PATColumn
            // 
            this.PATColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PATColumn.ContextMenuStrip = this.contextMenuStripPAT;
            this.PATColumn.DataPropertyName = "Пациент";
            this.PATColumn.HeaderText = "Пациент";
            this.PATColumn.Name = "PATColumn";
            this.PATColumn.ReadOnly = true;
            // 
            // contextMenuStripPAT
            // 
            this.contextMenuStripPAT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openKarttoolStripMenuItem1,
            this.onePATtoolStripMenuItem2});
            this.contextMenuStripPAT.Name = "contextMenuStripDOC";
            this.contextMenuStripPAT.Size = new System.Drawing.Size(225, 48);
            // 
            // openKarttoolStripMenuItem1
            // 
            this.openKarttoolStripMenuItem1.Image = global::DSS.Properties.Resources.user;
            this.openKarttoolStripMenuItem1.Name = "openKarttoolStripMenuItem1";
            this.openKarttoolStripMenuItem1.Size = new System.Drawing.Size(224, 22);
            this.openKarttoolStripMenuItem1.Text = "Открыть карточку";
            this.openKarttoolStripMenuItem1.Click += new System.EventHandler(this.openKarttoolStripMenuItem1_Click);
            // 
            // onePATtoolStripMenuItem2
            // 
            this.onePATtoolStripMenuItem2.Image = global::DSS.Properties.Resources.fillter;
            this.onePATtoolStripMenuItem2.Name = "onePATtoolStripMenuItem2";
            this.onePATtoolStripMenuItem2.Size = new System.Drawing.Size(224, 22);
            this.onePATtoolStripMenuItem2.Text = "Посещения этого пациента";
            this.onePATtoolStripMenuItem2.Click += new System.EventHandler(this.onePATtoolStripMenuItem2_Click);
            // 
            // нарядDataGridViewTextBoxColumn
            // 
            this.нарядDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.нарядDataGridViewTextBoxColumn.DataPropertyName = "Наряд";
            this.нарядDataGridViewTextBoxColumn.HeaderText = "Наряд";
            this.нарядDataGridViewTextBoxColumn.Name = "нарядDataGridViewTextBoxColumn";
            this.нарядDataGridViewTextBoxColumn.ReadOnly = true;
            this.нарядDataGridViewTextBoxColumn.Width = 64;
            // 
            // SUMColumn
            // 
            this.SUMColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SUMColumn.DataPropertyName = "Сумма";
            this.SUMColumn.HeaderText = "Сумма";
            this.SUMColumn.Name = "SUMColumn";
            this.SUMColumn.ReadOnly = true;
            this.SUMColumn.Width = 66;
            // 
            // posesenieViewBindingSource
            // 
            this.posesenieViewBindingSource.DataMember = "PosesenieView";
            this.posesenieViewBindingSource.DataSource = this.___BASA__DataSet;
            this.posesenieViewBindingSource.Filter = "";
            this.posesenieViewBindingSource.Sort = "Дата,Доктор,Пациент";
            this.posesenieViewBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.posesenieViewBindingSource_ListChanged);
            // 
            // ___BASA__DataSet
            // 
            this.___BASA__DataSet.DataSetName = "___BASA__DataSet";
            this.___BASA__DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.posesenieDataGridView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(953, 431);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.toolStrip2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker2, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(947, 26);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelALL,
            this.toolStripButtonTOD,
            this.toolStripButtonMONTH,
            this.toolStripButtonPERIOD});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(239, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabelALL
            // 
            this.toolStripLabelALL.AutoToolTip = false;
            this.toolStripLabelALL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabelALL.Enabled = false;
            this.toolStripLabelALL.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripLabelALL.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripLabelALL.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabelALL.Image")));
            this.toolStripLabelALL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabelALL.Name = "toolStripLabelALL";
            this.toolStripLabelALL.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabelALL.Text = "Даты";
            this.toolStripLabelALL.Click += new System.EventHandler(this.toolStripLabelALL_Click);
            // 
            // toolStripButtonTOD
            // 
            this.toolStripButtonTOD.AutoToolTip = false;
            this.toolStripButtonTOD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonTOD.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTOD.Image")));
            this.toolStripButtonTOD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTOD.Name = "toolStripButtonTOD";
            this.toolStripButtonTOD.Size = new System.Drawing.Size(54, 22);
            this.toolStripButtonTOD.Text = "Сегодня";
            this.toolStripButtonTOD.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonMONTH
            // 
            this.toolStripButtonMONTH.AutoToolTip = false;
            this.toolStripButtonMONTH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonMONTH.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMONTH.Image")));
            this.toolStripButtonMONTH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMONTH.Name = "toolStripButtonMONTH";
            this.toolStripButtonMONTH.Size = new System.Drawing.Size(88, 22);
            this.toolStripButtonMONTH.Text = "Текущий месяц";
            this.toolStripButtonMONTH.Click += new System.EventHandler(this.toolStripButtonMONTH_Click);
            // 
            // toolStripButtonPERIOD
            // 
            this.toolStripButtonPERIOD.AutoToolTip = false;
            this.toolStripButtonPERIOD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonPERIOD.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPERIOD.Image")));
            this.toolStripButtonPERIOD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPERIOD.Name = "toolStripButtonPERIOD";
            this.toolStripButtonPERIOD.Size = new System.Drawing.Size(49, 22);
            this.toolStripButtonPERIOD.Text = "Период";
            this.toolStripButtonPERIOD.CheckedChanged += new System.EventHandler(this.toolStripButtonPERIOD_CheckedChanged);
            this.toolStripButtonPERIOD.Click += new System.EventHandler(this.toolStripButtonPERIOD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(382, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "по";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(404, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(124, 20);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(239, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "с";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(255, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelPoses);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelSUM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 408);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 20);
            this.panel1.TabIndex = 4;
            // 
            // labelPoses
            // 
            this.labelPoses.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPoses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPoses.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelPoses.Location = new System.Drawing.Point(76, 0);
            this.labelPoses.Name = "labelPoses";
            this.labelPoses.Size = new System.Drawing.Size(61, 20);
            this.labelPoses.TabIndex = 7;
            this.labelPoses.Text = "0";
            this.labelPoses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Посещений";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(825, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сумма";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSUM
            // 
            this.labelSUM.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSUM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSUM.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelSUM.Location = new System.Drawing.Point(886, 0);
            this.labelSUM.Name = "labelSUM";
            this.labelSUM.Size = new System.Drawing.Size(61, 20);
            this.labelSUM.TabIndex = 4;
            this.labelSUM.Text = "0";
            this.labelSUM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnamnezTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DiagnosisTableAdapter = null;
            this.tableAdapterManager.DolgTableAdapter = null;
            this.tableAdapterManager.GorodTableAdapter = null;
            this.tableAdapterManager.KadryTableAdapter = null;
            this.tableAdapterManager.KartaTableAdapter = null;
            this.tableAdapterManager.KartyTableAdapter = null;
            this.tableAdapterManager.ObektTableAdapter = null;
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
            this.tableAdapterManager.TreatTableAdapter = null;
            this.tableAdapterManager.TreatTreatTableAdapter = null;
            this.tableAdapterManager.UlizaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DSS.___BASA__DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.whenDatesTableAdapter = null;
            this.tableAdapterManager.ZalobyTableAdapter = null;
            this.tableAdapterManager.ZurnalTableAdapter = null;
            // 
            // posesenieViewTableAdapter
            // 
            this.posesenieViewTableAdapter.ClearBeforeFill = true;
            // 
            // kartaTableAdapter1
            // 
            this.kartaTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Дата";
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.ContextMenuStrip = this.contextMenuStripDOC;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Доктор";
            this.dataGridViewTextBoxColumn2.HeaderText = "Доктор";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.ContextMenuStrip = this.contextMenuStripPAT;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Пациент";
            this.dataGridViewTextBoxColumn3.HeaderText = "Пациент";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Наряд";
            this.dataGridViewTextBoxColumn4.HeaderText = "Наряд";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Сумма";
            this.dataGridViewTextBoxColumn5.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // StatPoses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(953, 431);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatPoses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Tag = "Статистика Посещений";
            this.Text = "Статистика Посещений";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.StatPoses_Activated);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posesenieDataGridView)).EndInit();
            this.contextMenuStripDOC.ResumeLayout(false);
            this.contextMenuStripPAT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.posesenieViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.___BASA__DataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private ___BASA__DataSet ___BASA__DataSet;
        private DSS.___BASA__DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView posesenieDataGridView;
        private System.Windows.Forms.BindingSource posesenieViewBindingSource;
        private DSS.___BASA__DataSetTableAdapters.PosesenieViewTableAdapter posesenieViewTableAdapter;
       
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDOC;
        private System.Windows.Forms.ToolStripMenuItem openDeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneDOCToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPAT;
        private System.Windows.Forms.ToolStripMenuItem openKarttoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem onePATtoolStripMenuItem2;
        private DSS.___BASA__DataSetTableAdapters.KartaTableAdapter kartaTableAdapter1;
        private System.Windows.Forms.ToolStripButton toolStripButtonUPD;
        private System.Windows.Forms.Label labelSUM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPoses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn нарядDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUMColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripLabelALL;
        private System.Windows.Forms.ToolStripButton toolStripButtonTOD;
        private System.Windows.Forms.ToolStripButton toolStripButtonMONTH;
        private System.Windows.Forms.ToolStripButton toolStripButtonPERIOD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}