namespace DSS
{
    partial class StatDiagn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatDiagn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripFILTR = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDATA = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDOC = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPAT = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBUILD = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonFiltrTR = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFiltrDOC = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFiltrPAT = new System.Windows.Forms.ToolStripButton();
            this.statDiagnosisDataGridView = new System.Windows.Forms.DataGridView();
            this.Texts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Many = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statDiagnosisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.___BASA__DataSet = new DSS.___BASA__DataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelData = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelALL = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTOD = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMONTH = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPERIOD = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.statDiagnosisTableAdapter = new DSS.___BASA__DataSetTableAdapters.StatDiagnosisTableAdapter();
            this.tableAdapterManager = new DSS.___BASA__DataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripFILTR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statDiagnosisDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statDiagnosisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.___BASA__DataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelData.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripFILTR
            // 
            this.toolStripFILTR.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.toolStripFILTR, 2);
            this.toolStripFILTR.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripFILTR.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDATA,
            this.toolStripButtonDOC,
            this.toolStripButtonPAT,
            this.toolStripButtonBUILD,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripButtonFiltrTR,
            this.toolStripButtonFiltrDOC,
            this.toolStripButtonFiltrPAT});
            this.toolStripFILTR.Location = new System.Drawing.Point(0, 0);
            this.toolStripFILTR.Name = "toolStripFILTR";
            this.toolStripFILTR.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripFILTR.Size = new System.Drawing.Size(984, 25);
            this.toolStripFILTR.TabIndex = 2;
            this.toolStripFILTR.Text = "toolStrip1";
            // 
            // toolStripButtonDATA
            // 
            this.toolStripButtonDATA.AutoToolTip = false;
            this.toolStripButtonDATA.CheckOnClick = true;
            this.toolStripButtonDATA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDATA.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDATA.Image")));
            this.toolStripButtonDATA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDATA.Name = "toolStripButtonDATA";
            this.toolStripButtonDATA.Size = new System.Drawing.Size(39, 22);
            this.toolStripButtonDATA.Text = "Даты";
            this.toolStripButtonDATA.Click += new System.EventHandler(this.toolStripButtonDATA_Click);
            // 
            // toolStripButtonDOC
            // 
            this.toolStripButtonDOC.AutoToolTip = false;
            this.toolStripButtonDOC.CheckOnClick = true;
            this.toolStripButtonDOC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDOC.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDOC.Image")));
            this.toolStripButtonDOC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDOC.Name = "toolStripButtonDOC";
            this.toolStripButtonDOC.Size = new System.Drawing.Size(49, 22);
            this.toolStripButtonDOC.Text = "Доктор";
            this.toolStripButtonDOC.Click += new System.EventHandler(this.toolStripButtonDATA_Click);
            // 
            // toolStripButtonPAT
            // 
            this.toolStripButtonPAT.AutoToolTip = false;
            this.toolStripButtonPAT.CheckOnClick = true;
            this.toolStripButtonPAT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonPAT.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPAT.Image")));
            this.toolStripButtonPAT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPAT.Name = "toolStripButtonPAT";
            this.toolStripButtonPAT.Size = new System.Drawing.Size(54, 22);
            this.toolStripButtonPAT.Text = "Пациент";
            this.toolStripButtonPAT.Click += new System.EventHandler(this.toolStripButtonDATA_Click);
            // 
            // toolStripButtonBUILD
            // 
            this.toolStripButtonBUILD.BackColor = System.Drawing.Color.LightBlue;
            this.toolStripButtonBUILD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonBUILD.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBUILD.Image")));
            this.toolStripButtonBUILD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBUILD.Name = "toolStripButtonBUILD";
            this.toolStripButtonBUILD.Size = new System.Drawing.Size(65, 22);
            this.toolStripButtonBUILD.Text = "Построить";
            this.toolStripButtonBUILD.Click += new System.EventHandler(this.toolStripButtonBUILD_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel1.Text = "Фильтры:";
            // 
            // toolStripButtonFiltrTR
            // 
            this.toolStripButtonFiltrTR.AutoToolTip = false;
            this.toolStripButtonFiltrTR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFiltrTR.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFiltrTR.Image")));
            this.toolStripButtonFiltrTR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFiltrTR.Name = "toolStripButtonFiltrTR";
            this.toolStripButtonFiltrTR.Size = new System.Drawing.Size(53, 22);
            this.toolStripButtonFiltrTR.Text = "Диагноз";
            this.toolStripButtonFiltrTR.Click += new System.EventHandler(this.toolStripButtonFiltrTR_Click);
            // 
            // toolStripButtonFiltrDOC
            // 
            this.toolStripButtonFiltrDOC.AutoToolTip = false;
            this.toolStripButtonFiltrDOC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFiltrDOC.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFiltrDOC.Image")));
            this.toolStripButtonFiltrDOC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFiltrDOC.Name = "toolStripButtonFiltrDOC";
            this.toolStripButtonFiltrDOC.Size = new System.Drawing.Size(49, 22);
            this.toolStripButtonFiltrDOC.Text = "Доктор";
            this.toolStripButtonFiltrDOC.Visible = false;
            this.toolStripButtonFiltrDOC.Click += new System.EventHandler(this.toolStripButtonFiltrDOC_Click);
            // 
            // toolStripButtonFiltrPAT
            // 
            this.toolStripButtonFiltrPAT.AutoToolTip = false;
            this.toolStripButtonFiltrPAT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFiltrPAT.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFiltrPAT.Image")));
            this.toolStripButtonFiltrPAT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFiltrPAT.Name = "toolStripButtonFiltrPAT";
            this.toolStripButtonFiltrPAT.Size = new System.Drawing.Size(54, 22);
            this.toolStripButtonFiltrPAT.Text = "Пациент";
            this.toolStripButtonFiltrPAT.Visible = false;
            this.toolStripButtonFiltrPAT.Click += new System.EventHandler(this.toolStripButtonFiltrPAT_Click);
            // 
            // statDiagnosisDataGridView
            // 
            this.statDiagnosisDataGridView.AllowUserToAddRows = false;
            this.statDiagnosisDataGridView.AllowUserToDeleteRows = false;
            this.statDiagnosisDataGridView.AllowUserToOrderColumns = true;
            this.statDiagnosisDataGridView.AllowUserToResizeRows = false;
            this.statDiagnosisDataGridView.AutoGenerateColumns = false;
            this.statDiagnosisDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.statDiagnosisDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.statDiagnosisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statDiagnosisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Texts,
            this.DFIO,
            this.PFIO,
            this.Datas,
            this.Many});
            this.statDiagnosisDataGridView.DataSource = this.statDiagnosisBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.statDiagnosisDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.statDiagnosisDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statDiagnosisDataGridView.Location = new System.Drawing.Point(0, 51);
            this.statDiagnosisDataGridView.Name = "statDiagnosisDataGridView";
            this.statDiagnosisDataGridView.ReadOnly = true;
            this.statDiagnosisDataGridView.RowHeadersVisible = false;
            this.statDiagnosisDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.statDiagnosisDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.statDiagnosisDataGridView.Size = new System.Drawing.Size(984, 398);
            this.statDiagnosisDataGridView.TabIndex = 2;
            this.statDiagnosisDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.statDiagnosisDataGridView_CellMouseDown);
            // 
            // Texts
            // 
            this.Texts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Texts.DataPropertyName = "DS";
            this.Texts.HeaderText = "Диагноз";
            this.Texts.MinimumWidth = 200;
            this.Texts.Name = "Texts";
            this.Texts.ReadOnly = true;
            // 
            // DFIO
            // 
            this.DFIO.HeaderText = "Доктор";
            this.DFIO.Name = "DFIO";
            this.DFIO.ReadOnly = true;
            this.DFIO.Visible = false;
            // 
            // PFIO
            // 
            this.PFIO.HeaderText = "Пациент";
            this.PFIO.Name = "PFIO";
            this.PFIO.ReadOnly = true;
            this.PFIO.Visible = false;
            // 
            // Datas
            // 
            this.Datas.HeaderText = "Дата";
            this.Datas.MinimumWidth = 60;
            this.Datas.Name = "Datas";
            this.Datas.ReadOnly = true;
            this.Datas.Visible = false;
            // 
            // Many
            // 
            this.Many.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Many.DataPropertyName = "Many";
            this.Many.HeaderText = "Количество";
            this.Many.MinimumWidth = 70;
            this.Many.Name = "Many";
            this.Many.ReadOnly = true;
            // 
            // statDiagnosisBindingSource
            // 
            this.statDiagnosisBindingSource.DataMember = "StatDiagnosis";
            this.statDiagnosisBindingSource.DataSource = this.___BASA__DataSet;
            // 
            // ___BASA__DataSet
            // 
            this.___BASA__DataSet.DataSetName = "___BASA__DataSet";
            this.___BASA__DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.75203F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.24797F));
            this.tableLayoutPanel1.Controls.Add(this.toolStripFILTR, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 25);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanelData
            // 
            this.tableLayoutPanelData.AutoSize = true;
            this.tableLayoutPanelData.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanelData.ColumnCount = 6;
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 453F));
            this.tableLayoutPanelData.Controls.Add(this.toolStrip2, 0, 0);
            this.tableLayoutPanelData.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanelData.Controls.Add(this.dateTimePicker2, 4, 0);
            this.tableLayoutPanelData.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanelData.Controls.Add(this.dateTimePicker1, 2, 0);
            this.tableLayoutPanelData.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelData.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanelData.Name = "tableLayoutPanelData";
            this.tableLayoutPanelData.RowCount = 1;
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelData.Size = new System.Drawing.Size(984, 26);
            this.tableLayoutPanelData.TabIndex = 4;
            this.tableLayoutPanelData.Visible = false;
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
            this.toolStripButtonTOD.Click += new System.EventHandler(this.toolStripButtonTOD_Click);
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
            this.toolStripButtonPERIOD.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
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
            // statDiagnosisTableAdapter
            // 
            this.statDiagnosisTableAdapter.ClearBeforeFill = true;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DS";
            this.dataGridViewTextBoxColumn1.HeaderText = "Диагноз";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Many";
            this.dataGridViewTextBoxColumn2.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 70;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle2.Format = "d";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Доктор";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Many";
            this.dataGridViewTextBoxColumn5.HeaderText = "Пациент";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 70;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // StatDiagn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 449);
            this.Controls.Add(this.statDiagnosisDataGridView);
            this.Controls.Add(this.tableLayoutPanelData);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatDiagn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Tag = "Статистика диагнозов";
            this.Text = "Статистика диагнозов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StatDiagn_Load);
            this.toolStripFILTR.ResumeLayout(false);
            this.toolStripFILTR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statDiagnosisDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statDiagnosisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.___BASA__DataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelData.ResumeLayout(false);
            this.tableLayoutPanelData.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ___BASA__DataSet ___BASA__DataSet;
        private System.Windows.Forms.ToolStrip toolStripFILTR;
       
        private System.Windows.Forms.ToolStripButton toolStripButtonDATA;
        private System.Windows.Forms.ToolStripButton toolStripButtonDOC;
        private System.Windows.Forms.ToolStripButton toolStripButtonBUILD;
        private System.Windows.Forms.BindingSource statDiagnosisBindingSource;
        private DSS.___BASA__DataSetTableAdapters.StatDiagnosisTableAdapter statDiagnosisTableAdapter;
        private DSS.___BASA__DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView statDiagnosisDataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButtonPAT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelData;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripLabelALL;
        private System.Windows.Forms.ToolStripButton toolStripButtonTOD;
        private System.Windows.Forms.ToolStripButton toolStripButtonMONTH;
        private System.Windows.Forms.ToolStripButton toolStripButtonPERIOD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonFiltrTR;
        private System.Windows.Forms.ToolStripButton toolStripButtonFiltrDOC;
        private System.Windows.Forms.ToolStripButton toolStripButtonFiltrPAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Texts;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Many;
    }
}