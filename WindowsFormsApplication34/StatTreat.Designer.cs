namespace DSS
{
    partial class StatTreat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatTreat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statDiagnosisDataGridView = new System.Windows.Forms.DataGridView();
            this.Datas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Texts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Many = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statTreatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.___BASA__DataSet = new DSS.___BASA__DataSet();
            this.tableLayoutPanelUP = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripFILTR = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonFiltrTR = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFiltrDOC = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFiltrPAT = new System.Windows.Forms.ToolStripButton();
            this.toolStripUP = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDATA = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDOC = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPAT = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBUILD = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.labelSUM = new System.Windows.Forms.Label();
            this.labelMany = new System.Windows.Forms.Label();
            this.labelManip = new System.Windows.Forms.Label();
            this.tableLayoutPanelDown = new System.Windows.Forms.TableLayoutPanel();
            this.labelMoneyTxt = new System.Windows.Forms.Label();
            this.statTreatTableAdapter = new DSS.___BASA__DataSetTableAdapters.StatTreatTableAdapter();
            this.tableAdapterManager = new DSS.___BASA__DataSetTableAdapters.TableAdapterManager();
            this.tableLayoutPanelData = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripDatas = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelALL = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTOD = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMONTH = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPERIOD = new System.Windows.Forms.ToolStripButton();
            this.label_PO = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label_S = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.statDiagnosisDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statTreatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.___BASA__DataSet)).BeginInit();
            this.tableLayoutPanelUP.SuspendLayout();
            this.toolStripFILTR.SuspendLayout();
            this.toolStripUP.SuspendLayout();
            this.tableLayoutPanelDown.SuspendLayout();
            this.tableLayoutPanelData.SuspendLayout();
            this.toolStripDatas.SuspendLayout();
            this.SuspendLayout();
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
            this.Datas,
            this.DFIO,
            this.PFIO,
            this.Texts,
            this.Many,
            this.Suma});
            this.statDiagnosisDataGridView.DataSource = this.statTreatBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.statDiagnosisDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.statDiagnosisDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statDiagnosisDataGridView.Location = new System.Drawing.Point(0, 51);
            this.statDiagnosisDataGridView.Name = "statDiagnosisDataGridView";
            this.statDiagnosisDataGridView.ReadOnly = true;
            this.statDiagnosisDataGridView.RowHeadersVisible = false;
            this.statDiagnosisDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.statDiagnosisDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.statDiagnosisDataGridView.Size = new System.Drawing.Size(912, 342);
            this.statDiagnosisDataGridView.TabIndex = 3;
            this.statDiagnosisDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.statDiagnosisDataGridView_CellMouseDown);
            // 
            // Datas
            // 
            this.Datas.HeaderText = "Дата";
            this.Datas.MinimumWidth = 20;
            this.Datas.Name = "Datas";
            this.Datas.ReadOnly = true;
            this.Datas.Visible = false;
            // 
            // DFIO
            // 
            this.DFIO.HeaderText = "Доктор";
            this.DFIO.MinimumWidth = 30;
            this.DFIO.Name = "DFIO";
            this.DFIO.ReadOnly = true;
            this.DFIO.Visible = false;
            // 
            // PFIO
            // 
            this.PFIO.HeaderText = "Пациент";
            this.PFIO.MinimumWidth = 30;
            this.PFIO.Name = "PFIO";
            this.PFIO.ReadOnly = true;
            this.PFIO.Visible = false;
            // 
            // Texts
            // 
            this.Texts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Texts.DataPropertyName = "TR";
            this.Texts.HeaderText = "Лечение";
            this.Texts.MinimumWidth = 250;
            this.Texts.Name = "Texts";
            this.Texts.ReadOnly = true;
            // 
            // Many
            // 
            this.Many.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Many.DataPropertyName = "Many";
            this.Many.HeaderText = "Количество";
            this.Many.MinimumWidth = 50;
            this.Many.Name = "Many";
            this.Many.ReadOnly = true;
            // 
            // Suma
            // 
            this.Suma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Suma.DataPropertyName = "Suma";
            dataGridViewCellStyle1.NullValue = null;
            this.Suma.DefaultCellStyle = dataGridViewCellStyle1;
            this.Suma.HeaderText = "Сумма";
            this.Suma.Name = "Suma";
            this.Suma.ReadOnly = true;
            this.Suma.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Suma.Width = 66;
            // 
            // statTreatBindingSource
            // 
            this.statTreatBindingSource.DataMember = "StatTreat";
            this.statTreatBindingSource.DataSource = this.___BASA__DataSet;
            this.statTreatBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.statTreatBindingSource_ListChanged);
            // 
            // ___BASA__DataSet
            // 
            this.___BASA__DataSet.DataSetName = "___BASA__DataSet";
            this.___BASA__DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanelUP
            // 
            this.tableLayoutPanelUP.AutoSize = true;
            this.tableLayoutPanelUP.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanelUP.ColumnCount = 2;
            this.tableLayoutPanelUP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelUP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUP.Controls.Add(this.toolStripFILTR, 1, 0);
            this.tableLayoutPanelUP.Controls.Add(this.toolStripUP, 0, 0);
            this.tableLayoutPanelUP.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelUP.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelUP.Name = "tableLayoutPanelUP";
            this.tableLayoutPanelUP.RowCount = 1;
            this.tableLayoutPanelUP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelUP.Size = new System.Drawing.Size(912, 25);
            this.tableLayoutPanelUP.TabIndex = 4;
            // 
            // toolStripFILTR
            // 
            this.toolStripFILTR.BackColor = System.Drawing.Color.LightBlue;
            this.toolStripFILTR.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripFILTR.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButtonFiltrTR,
            this.toolStripButtonFiltrDOC,
            this.toolStripButtonFiltrPAT});
            this.toolStripFILTR.Location = new System.Drawing.Point(216, 0);
            this.toolStripFILTR.Name = "toolStripFILTR";
            this.toolStripFILTR.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripFILTR.Size = new System.Drawing.Size(696, 25);
            this.toolStripFILTR.TabIndex = 3;
            this.toolStripFILTR.Text = "toolStrip2";
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
            this.toolStripButtonFiltrTR.Size = new System.Drawing.Size(54, 22);
            this.toolStripButtonFiltrTR.Text = "Лечение";
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
            // toolStripUP
            // 
            this.toolStripUP.BackColor = System.Drawing.Color.LightBlue;
            this.toolStripUP.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripUP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDATA,
            this.toolStripButtonDOC,
            this.toolStripButtonPAT,
            this.toolStripButtonBUILD,
            this.toolStripSeparator2});
            this.toolStripUP.Location = new System.Drawing.Point(0, 0);
            this.toolStripUP.Name = "toolStripUP";
            this.toolStripUP.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripUP.Size = new System.Drawing.Size(216, 25);
            this.toolStripUP.TabIndex = 2;
            this.toolStripUP.Text = "toolStrip2";
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
            this.toolStripButtonBUILD.AutoToolTip = false;
            this.toolStripButtonBUILD.BackColor = System.Drawing.Color.LightBlue;
            this.toolStripButtonBUILD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonBUILD.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBUILD.Image")));
            this.toolStripButtonBUILD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBUILD.Name = "toolStripButtonBUILD";
            this.toolStripButtonBUILD.Size = new System.Drawing.Size(65, 22);
            this.toolStripButtonBUILD.Text = "Построить";
            this.toolStripButtonBUILD.Click += new System.EventHandler(this.toolStripButtonBUILD_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // labelSUM
            // 
            this.labelSUM.AutoSize = true;
            this.labelSUM.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSUM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSUM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSUM.Location = new System.Drawing.Point(894, 0);
            this.labelSUM.Name = "labelSUM";
            this.labelSUM.Size = new System.Drawing.Size(15, 18);
            this.labelSUM.TabIndex = 0;
            this.labelSUM.Text = "0";
            this.labelSUM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMany
            // 
            this.labelMany.AutoSize = true;
            this.labelMany.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMany.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMany.Location = new System.Drawing.Point(828, 0);
            this.labelMany.Name = "labelMany";
            this.labelMany.Size = new System.Drawing.Size(15, 18);
            this.labelMany.TabIndex = 1;
            this.labelMany.Text = "0";
            this.labelMany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelManip
            // 
            this.labelManip.AutoSize = true;
            this.labelManip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelManip.Location = new System.Drawing.Point(747, 0);
            this.labelManip.Name = "labelManip";
            this.labelManip.Size = new System.Drawing.Size(75, 18);
            this.labelManip.TabIndex = 2;
            this.labelManip.Text = "Манипуляций";
            this.labelManip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanelDown
            // 
            this.tableLayoutPanelDown.ColumnCount = 5;
            this.tableLayoutPanelDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelDown.Controls.Add(this.labelMoneyTxt, 3, 0);
            this.tableLayoutPanelDown.Controls.Add(this.labelMany, 2, 0);
            this.tableLayoutPanelDown.Controls.Add(this.labelManip, 1, 0);
            this.tableLayoutPanelDown.Controls.Add(this.labelSUM, 4, 0);
            this.tableLayoutPanelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelDown.Location = new System.Drawing.Point(0, 393);
            this.tableLayoutPanelDown.MinimumSize = new System.Drawing.Size(0, 18);
            this.tableLayoutPanelDown.Name = "tableLayoutPanelDown";
            this.tableLayoutPanelDown.RowCount = 1;
            this.tableLayoutPanelDown.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDown.Size = new System.Drawing.Size(912, 18);
            this.tableLayoutPanelDown.TabIndex = 6;
            // 
            // labelMoneyTxt
            // 
            this.labelMoneyTxt.AutoSize = true;
            this.labelMoneyTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMoneyTxt.Location = new System.Drawing.Point(849, 0);
            this.labelMoneyTxt.Name = "labelMoneyTxt";
            this.labelMoneyTxt.Size = new System.Drawing.Size(39, 18);
            this.labelMoneyTxt.TabIndex = 3;
            this.labelMoneyTxt.Text = "Денег";
            this.labelMoneyTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statTreatTableAdapter
            // 
            this.statTreatTableAdapter.ClearBeforeFill = true;
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
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 471F));
            this.tableLayoutPanelData.Controls.Add(this.toolStripDatas, 0, 0);
            this.tableLayoutPanelData.Controls.Add(this.label_PO, 3, 0);
            this.tableLayoutPanelData.Controls.Add(this.dateTimePicker2, 4, 0);
            this.tableLayoutPanelData.Controls.Add(this.label_S, 1, 0);
            this.tableLayoutPanelData.Controls.Add(this.dateTimePicker1, 2, 0);
            this.tableLayoutPanelData.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelData.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanelData.Name = "tableLayoutPanelData";
            this.tableLayoutPanelData.RowCount = 1;
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelData.Size = new System.Drawing.Size(912, 26);
            this.tableLayoutPanelData.TabIndex = 7;
            this.tableLayoutPanelData.Visible = false;
            // 
            // toolStripDatas
            // 
            this.toolStripDatas.BackColor = System.Drawing.Color.LightBlue;
            this.toolStripDatas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripDatas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelALL,
            this.toolStripButtonTOD,
            this.toolStripButtonMONTH,
            this.toolStripButtonPERIOD});
            this.toolStripDatas.Location = new System.Drawing.Point(0, 0);
            this.toolStripDatas.Name = "toolStripDatas";
            this.toolStripDatas.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripDatas.Size = new System.Drawing.Size(239, 25);
            this.toolStripDatas.TabIndex = 5;
            this.toolStripDatas.Text = "toolStrip1";
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
            // label_PO
            // 
            this.label_PO.AutoSize = true;
            this.label_PO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_PO.Location = new System.Drawing.Point(382, 0);
            this.label_PO.Margin = new System.Windows.Forms.Padding(0);
            this.label_PO.Name = "label_PO";
            this.label_PO.Size = new System.Drawing.Size(19, 26);
            this.label_PO.TabIndex = 4;
            this.label_PO.Text = "по";
            this.label_PO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // label_S
            // 
            this.label_S.AutoSize = true;
            this.label_S.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_S.Location = new System.Drawing.Point(239, 0);
            this.label_S.Margin = new System.Windows.Forms.Padding(0);
            this.label_S.Name = "label_S";
            this.label_S.Size = new System.Drawing.Size(13, 26);
            this.label_S.TabIndex = 3;
            this.label_S.Text = "с";
            this.label_S.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Доктор";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Пациент";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TR";
            this.dataGridViewTextBoxColumn4.HeaderText = "Лечение";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 250;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Many";
            this.dataGridViewTextBoxColumn5.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Suma";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn6.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // StatTreat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 411);
            this.Controls.Add(this.statDiagnosisDataGridView);
            this.Controls.Add(this.tableLayoutPanelData);
            this.Controls.Add(this.tableLayoutPanelDown);
            this.Controls.Add(this.tableLayoutPanelUP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatTreat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Tag = "Статистика лечений";
            this.Text = "Статистика лечений";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StatTreat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statDiagnosisDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statTreatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.___BASA__DataSet)).EndInit();
            this.tableLayoutPanelUP.ResumeLayout(false);
            this.tableLayoutPanelUP.PerformLayout();
            this.toolStripFILTR.ResumeLayout(false);
            this.toolStripFILTR.PerformLayout();
            this.toolStripUP.ResumeLayout(false);
            this.toolStripUP.PerformLayout();
            this.tableLayoutPanelDown.ResumeLayout(false);
            this.tableLayoutPanelDown.PerformLayout();
            this.tableLayoutPanelData.ResumeLayout(false);
            this.tableLayoutPanelData.PerformLayout();
            this.toolStripDatas.ResumeLayout(false);
            this.toolStripDatas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ___BASA__DataSet ___BASA__DataSet;
        private System.Windows.Forms.BindingSource statTreatBindingSource;
        private DSS.___BASA__DataSetTableAdapters.StatTreatTableAdapter statTreatTableAdapter;
        private DSS.___BASA__DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView statDiagnosisDataGridView;
       
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUP;
        private System.Windows.Forms.ToolStrip toolStripUP;
        private System.Windows.Forms.ToolStripButton toolStripButtonDATA;
        private System.Windows.Forms.ToolStripButton toolStripButtonDOC;
        private System.Windows.Forms.ToolStripButton toolStripButtonPAT;
        private System.Windows.Forms.ToolStripButton toolStripButtonBUILD;
     
        private System.Windows.Forms.Label labelSUM;
        // private System.Windows.Forms.DataGridViewTextBoxColumn Texts;
        private System.Windows.Forms.Label labelMany;
        private System.Windows.Forms.Label labelManip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDown;
        private System.Windows.Forms.Label labelMoneyTxt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelData;
        private System.Windows.Forms.ToolStrip toolStripDatas;
        private System.Windows.Forms.ToolStripButton toolStripLabelALL;
        private System.Windows.Forms.ToolStripButton toolStripButtonTOD;
        private System.Windows.Forms.ToolStripButton toolStripButtonMONTH;
        private System.Windows.Forms.ToolStripButton toolStripButtonPERIOD;
        private System.Windows.Forms.Label label_PO;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label_S;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Texts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Many;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suma;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip toolStripFILTR;
        private System.Windows.Forms.ToolStripButton toolStripButtonFiltrTR;
        private System.Windows.Forms.ToolStripButton toolStripButtonFiltrDOC;
        private System.Windows.Forms.ToolStripButton toolStripButtonFiltrPAT;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}