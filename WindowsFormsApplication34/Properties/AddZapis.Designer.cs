namespace DSS
{
    partial class AddZapis
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
            this.___BASA__DataSet = new DSS.___BASA__DataSet();
            this.tableAdapterManager = new DSS.___BASA__DataSetTableAdapters.TableAdapterManager();
            this.comboBoxPat = new System.Windows.Forms.ComboBox();
            this.kartyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelPS = new System.Windows.Forms.Label();
            this.richTextBoxTXT = new System.Windows.Forms.RichTextBox();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.labelFind = new System.Windows.Forms.Label();
            this.radioButtonTXT = new System.Windows.Forms.RadioButton();
            this.richTextBoxPS = new System.Windows.Forms.RichTextBox();
            this.radioButtonPAT = new System.Windows.Forms.RadioButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelMax1 = new System.Windows.Forms.Label();
            this.labelMax2 = new System.Windows.Forms.Label();
            this.kartyTableAdapter = new DSS.___BASA__DataSetTableAdapters.KartyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.___BASA__DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartyBindingSource)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ___BASA__DataSet
            // 
            this.___BASA__DataSet.DataSetName = "___BASA__DataSet";
            this.___BASA__DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // comboBoxPat
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.comboBoxPat, 3);
            this.comboBoxPat.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kartyBindingSource, "PFIO", true));
            this.comboBoxPat.DataSource = this.kartyBindingSource;
            this.comboBoxPat.DisplayMember = "PFIO";
            this.comboBoxPat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxPat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPat.FormattingEnabled = true;
            this.comboBoxPat.Location = new System.Drawing.Point(81, 12);
            this.comboBoxPat.Name = "comboBoxPat";
            this.comboBoxPat.Size = new System.Drawing.Size(341, 21);
            this.comboBoxPat.TabIndex = 0;
            this.comboBoxPat.ValueMember = "PID";
            // 
            // kartyBindingSource
            // 
            this.kartyBindingSource.DataMember = "Karty";
            this.kartyBindingSource.DataSource = this.___BASA__DataSet;
            this.kartyBindingSource.Filter = "";
            this.kartyBindingSource.Sort = "PFIO";
            // 
            // labelPS
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.labelPS, 2);
            this.labelPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPS.Location = new System.Drawing.Point(3, 111);
            this.labelPS.Name = "labelPS";
            this.labelPS.Size = new System.Drawing.Size(72, 86);
            this.labelPS.TabIndex = 2;
            this.labelPS.Text = "Заметка";
            this.labelPS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // richTextBoxTXT
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.richTextBoxTXT, 3);
            this.richTextBoxTXT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxTXT.Enabled = false;
            this.richTextBoxTXT.Location = new System.Drawing.Point(81, 238);
            this.richTextBoxTXT.MaxLength = 200;
            this.richTextBoxTXT.Name = "richTextBoxTXT";
            this.richTextBoxTXT.Size = new System.Drawing.Size(341, 80);
            this.richTextBoxTXT.TabIndex = 3;
            this.richTextBoxTXT.Text = "";
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(428, 359);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(72, 23);
            this.buttonYes.TabIndex = 4;
            this.buttonYes.Text = "Да";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonNo.Location = new System.Drawing.Point(333, 359);
            this.buttonNo.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(72, 23);
            this.buttonNo.TabIndex = 5;
            this.buttonNo.Text = "Нет";
            this.buttonNo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 7;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanelMain.Controls.Add(this.labelFind, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.radioButtonTXT, 0, 7);
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxPat, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelPS, 0, 5);
            this.tableLayoutPanelMain.Controls.Add(this.richTextBoxPS, 2, 5);
            this.tableLayoutPanelMain.Controls.Add(this.radioButtonPAT, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.richTextBoxTXT, 2, 7);
            this.tableLayoutPanelMain.Controls.Add(this.buttonYes, 5, 9);
            this.tableLayoutPanelMain.Controls.Add(this.buttonNo, 4, 9);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxSearch, 2, 3);
            this.tableLayoutPanelMain.Controls.Add(this.labelMax1, 5, 5);
            this.tableLayoutPanelMain.Controls.Add(this.labelMax2, 5, 7);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 10;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(516, 385);
            this.tableLayoutPanelMain.TabIndex = 8;
            // 
            // labelFind
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.labelFind, 2);
            this.labelFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFind.Location = new System.Drawing.Point(3, 63);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(72, 26);
            this.labelFind.TabIndex = 7;
            this.labelFind.Text = "Искать";
            this.labelFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioButtonTXT
            // 
            this.radioButtonTXT.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tableLayoutPanelMain.SetColumnSpan(this.radioButtonTXT, 2);
            this.radioButtonTXT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonTXT.Location = new System.Drawing.Point(3, 238);
            this.radioButtonTXT.Name = "radioButtonTXT";
            this.radioButtonTXT.Size = new System.Drawing.Size(72, 80);
            this.radioButtonTXT.TabIndex = 5;
            this.radioButtonTXT.Text = "Текст";
            this.radioButtonTXT.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.radioButtonTXT.UseVisualStyleBackColor = true;
            // 
            // richTextBoxPS
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.richTextBoxPS, 3);
            this.richTextBoxPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxPS.Location = new System.Drawing.Point(81, 114);
            this.richTextBoxPS.MaxLength = 200;
            this.richTextBoxPS.Name = "richTextBoxPS";
            this.richTextBoxPS.Size = new System.Drawing.Size(341, 80);
            this.richTextBoxPS.TabIndex = 4;
            this.richTextBoxPS.Text = "";
            // 
            // radioButtonPAT
            // 
            this.radioButtonPAT.Checked = true;
            this.tableLayoutPanelMain.SetColumnSpan(this.radioButtonPAT, 2);
            this.radioButtonPAT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonPAT.Location = new System.Drawing.Point(3, 12);
            this.radioButtonPAT.Name = "radioButtonPAT";
            this.radioButtonPAT.Size = new System.Drawing.Size(72, 21);
            this.radioButtonPAT.TabIndex = 1;
            this.radioButtonPAT.TabStop = true;
            this.radioButtonPAT.Text = "Пациент";
            this.radioButtonPAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonPAT.UseVisualStyleBackColor = true;
            this.radioButtonPAT.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanelMain.SetColumnSpan(this.textBoxSearch, 3);
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearch.Location = new System.Drawing.Point(81, 66);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(341, 20);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelMax1
            // 
            this.labelMax1.Location = new System.Drawing.Point(428, 111);
            this.labelMax1.Name = "labelMax1";
            this.labelMax1.Size = new System.Drawing.Size(83, 83);
            this.labelMax1.TabIndex = 8;
            this.labelMax1.Text = "Максимум 200 символов";
            this.labelMax1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMax2
            // 
            this.labelMax2.Location = new System.Drawing.Point(428, 235);
            this.labelMax2.Name = "labelMax2";
            this.labelMax2.Size = new System.Drawing.Size(83, 83);
            this.labelMax2.TabIndex = 9;
            this.labelMax2.Text = "Максимум 200 символов";
            this.labelMax2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kartyTableAdapter
            // 
            this.kartyTableAdapter.ClearBeforeFill = true;
            // 
            // AddZapis
            // 
            this.AcceptButton = this.buttonYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonNo;
            this.ClientSize = new System.Drawing.Size(516, 385);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddZapis";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить запись";
            this.Load += new System.EventHandler(this.AddZapis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.___BASA__DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartyBindingSource)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ___BASA__DataSet ___BASA__DataSet;
        private DSS.___BASA__DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBoxPat;
        private System.Windows.Forms.Label labelPS;
        private System.Windows.Forms.RichTextBox richTextBoxTXT;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.RadioButton radioButtonPAT;
        private System.Windows.Forms.RichTextBox richTextBoxPS;
        private System.Windows.Forms.RadioButton radioButtonTXT;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.BindingSource kartyBindingSource;
        private DSS.___BASA__DataSetTableAdapters.KartyTableAdapter kartyTableAdapter;
        private System.Windows.Forms.Label labelMax1;
        private System.Windows.Forms.Label labelMax2;
    }
}