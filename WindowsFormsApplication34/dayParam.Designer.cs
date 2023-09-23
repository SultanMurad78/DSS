namespace DSS
{
    partial class dayParam
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
            this.dateTimePickerBeg = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownPeriod = new System.Windows.Forms.NumericUpDown();
            this.buttonY = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.buttonN = new System.Windows.Forms.Button();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.labelBeg = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerBeg
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.dateTimePickerBeg, 3);
            this.dateTimePickerBeg.CustomFormat = "HH:mm";
            this.dateTimePickerBeg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerBeg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBeg.Location = new System.Drawing.Point(3, 36);
            this.dateTimePickerBeg.Name = "dateTimePickerBeg";
            this.dateTimePickerBeg.ShowUpDown = true;
            this.dateTimePickerBeg.Size = new System.Drawing.Size(122, 20);
            this.dateTimePickerBeg.TabIndex = 0;
            this.dateTimePickerBeg.Value = new System.DateTime(2009, 3, 29, 8, 0, 0, 0);
            // 
            // dateTimePickerEnd
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.dateTimePickerEnd, 3);
            this.dateTimePickerEnd.CustomFormat = "HH:mm";
            this.dateTimePickerEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(3, 75);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.ShowUpDown = true;
            this.dateTimePickerEnd.Size = new System.Drawing.Size(122, 20);
            this.dateTimePickerEnd.TabIndex = 1;
            this.dateTimePickerEnd.Value = new System.DateTime(2009, 3, 29, 16, 0, 0, 0);
            // 
            // numericUpDownPeriod
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.numericUpDownPeriod, 3);
            this.numericUpDownPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownPeriod.Location = new System.Drawing.Point(3, 157);
            this.numericUpDownPeriod.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDownPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPeriod.Name = "numericUpDownPeriod";
            this.numericUpDownPeriod.Size = new System.Drawing.Size(122, 20);
            this.numericUpDownPeriod.TabIndex = 2;
            this.numericUpDownPeriod.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // buttonY
            // 
            this.buttonY.AutoSize = true;
            this.buttonY.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonY.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonY.Location = new System.Drawing.Point(131, 211);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(67, 23);
            this.buttonY.TabIndex = 3;
            this.buttonY.Text = "Да";
            this.buttonY.UseVisualStyleBackColor = true;
            this.buttonY.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.AutoSize = true;
            this.tableLayoutPanelMain.ColumnCount = 5;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.75758F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.24242F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanelMain.Controls.Add(this.buttonN, 1, 8);
            this.tableLayoutPanelMain.Controls.Add(this.labelPeriod, 0, 5);
            this.tableLayoutPanelMain.Controls.Add(this.dateTimePickerBeg, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.dateTimePickerEnd, 0, 4);
            this.tableLayoutPanelMain.Controls.Add(this.numericUpDownPeriod, 0, 6);
            this.tableLayoutPanelMain.Controls.Add(this.labelBeg, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelEnd, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.buttonY, 3, 8);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 9;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(206, 237);
            this.tableLayoutPanelMain.TabIndex = 4;
            // 
            // buttonN
            // 
            this.buttonN.AutoSize = true;
            this.buttonN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonN.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonN.Location = new System.Drawing.Point(45, 211);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(67, 23);
            this.buttonN.TabIndex = 5;
            this.buttonN.Text = "Нет";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.tableLayoutPanelMain.SetColumnSpan(this.labelPeriod, 4);
            this.labelPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPeriod.Location = new System.Drawing.Point(3, 98);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(195, 56);
            this.labelPeriod.TabIndex = 4;
            this.labelPeriod.Text = "Продолжительность приема (мин)";
            this.labelPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBeg
            // 
            this.labelBeg.AutoSize = true;
            this.tableLayoutPanelMain.SetColumnSpan(this.labelBeg, 4);
            this.labelBeg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBeg.Location = new System.Drawing.Point(3, 20);
            this.labelBeg.Name = "labelBeg";
            this.labelBeg.Size = new System.Drawing.Size(195, 13);
            this.labelBeg.TabIndex = 2;
            this.labelBeg.Text = "Начало смены";
            this.labelBeg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.tableLayoutPanelMain.SetColumnSpan(this.labelEnd, 4);
            this.labelEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEnd.Location = new System.Drawing.Point(3, 59);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(195, 13);
            this.labelEnd.TabIndex = 3;
            this.labelEnd.Text = "Конец смены";
            this.labelEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayParam
            // 
            this.AcceptButton = this.buttonY;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonN;
            this.ClientSize = new System.Drawing.Size(206, 237);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dayParam";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Параметры дня";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dayParam_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dayParam_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerBeg;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.NumericUpDown numericUpDownPeriod;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label labelBeg;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Button buttonN;
    }
}