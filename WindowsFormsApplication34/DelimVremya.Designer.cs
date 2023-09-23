namespace DSS
{
    partial class DelimVremya
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
            this.textBoxT1S = new System.Windows.Forms.TextBox();
            this.trackBarMy = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownT2Per = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerT2S = new System.Windows.Forms.DateTimePicker();
            this.labelT1S = new System.Windows.Forms.Label();
            this.labelT2S = new System.Windows.Forms.Label();
            this.numericUpDownT1Per = new System.Windows.Forms.NumericUpDown();
            this.labelT1Per = new System.Windows.Forms.Label();
            this.labelT2Per = new System.Windows.Forms.Label();
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMy)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownT2Per)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownT1Per)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxT1S
            // 
            this.textBoxT1S.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxT1S.Location = new System.Drawing.Point(162, 54);
            this.textBoxT1S.Name = "textBoxT1S";
            this.textBoxT1S.ReadOnly = true;
            this.textBoxT1S.Size = new System.Drawing.Size(75, 20);
            this.textBoxT1S.TabIndex = 100;
            // 
            // trackBarMy
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.trackBarMy, 4);
            this.trackBarMy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarMy.Location = new System.Drawing.Point(3, 3);
            this.trackBarMy.Name = "trackBarMy";
            this.trackBarMy.Size = new System.Drawing.Size(475, 45);
            this.trackBarMy.TabIndex = 0;
            this.trackBarMy.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged_1);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 4;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.Controls.Add(this.numericUpDownT2Per, 3, 2);
            this.tableLayoutPanelMain.Controls.Add(this.dateTimePickerT2S, 3, 1);
            this.tableLayoutPanelMain.Controls.Add(this.trackBarMy, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelT1S, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxT1S, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelT2S, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.numericUpDownT1Per, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelT1Per, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelT2Per, 2, 2);
            this.tableLayoutPanelMain.Controls.Add(this.buttonY, 3, 6);
            this.tableLayoutPanelMain.Controls.Add(this.buttonN, 2, 6);
            this.tableLayoutPanelMain.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.radioButton1, 0, 4);
            this.tableLayoutPanelMain.Controls.Add(this.radioButton2, 2, 4);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 7;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.72603F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(481, 203);
            this.tableLayoutPanelMain.TabIndex = 7;
            // 
            // numericUpDownT2Per
            // 
            this.numericUpDownT2Per.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownT2Per.Location = new System.Drawing.Point(402, 80);
            this.numericUpDownT2Per.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownT2Per.Name = "numericUpDownT2Per";
            this.numericUpDownT2Per.Size = new System.Drawing.Size(76, 20);
            this.numericUpDownT2Per.TabIndex = 3;
            this.numericUpDownT2Per.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // dateTimePickerT2S
            // 
            this.dateTimePickerT2S.CustomFormat = "HH : mm";
            this.dateTimePickerT2S.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerT2S.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerT2S.Location = new System.Drawing.Point(402, 54);
            this.dateTimePickerT2S.Name = "dateTimePickerT2S";
            this.dateTimePickerT2S.ShowUpDown = true;
            this.dateTimePickerT2S.Size = new System.Drawing.Size(76, 20);
            this.dateTimePickerT2S.TabIndex = 2;
            this.dateTimePickerT2S.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // labelT1S
            // 
            this.labelT1S.AutoSize = true;
            this.labelT1S.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelT1S.Location = new System.Drawing.Point(3, 51);
            this.labelT1S.Name = "labelT1S";
            this.labelT1S.Size = new System.Drawing.Size(153, 26);
            this.labelT1S.TabIndex = 2;
            this.labelT1S.Text = "Время 1: Начало";
            this.labelT1S.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelT2S
            // 
            this.labelT2S.AutoSize = true;
            this.labelT2S.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelT2S.Location = new System.Drawing.Point(243, 51);
            this.labelT2S.Name = "labelT2S";
            this.labelT2S.Size = new System.Drawing.Size(153, 26);
            this.labelT2S.TabIndex = 101;
            this.labelT2S.Text = "Время 2: Начало";
            this.labelT2S.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownT1Per
            // 
            this.numericUpDownT1Per.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownT1Per.Location = new System.Drawing.Point(162, 80);
            this.numericUpDownT1Per.Name = "numericUpDownT1Per";
            this.numericUpDownT1Per.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownT1Per.TabIndex = 1;
            this.numericUpDownT1Per.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelT1Per
            // 
            this.labelT1Per.AutoSize = true;
            this.labelT1Per.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelT1Per.Location = new System.Drawing.Point(3, 77);
            this.labelT1Per.Name = "labelT1Per";
            this.labelT1Per.Size = new System.Drawing.Size(153, 26);
            this.labelT1Per.TabIndex = 103;
            this.labelT1Per.Text = "Время 1: Длительность";
            this.labelT1Per.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelT2Per
            // 
            this.labelT2Per.AutoSize = true;
            this.labelT2Per.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelT2Per.Location = new System.Drawing.Point(243, 77);
            this.labelT2Per.Name = "labelT2Per";
            this.labelT2Per.Size = new System.Drawing.Size(153, 26);
            this.labelT2Per.TabIndex = 104;
            this.labelT2Per.Text = "Время 2: Длительность";
            this.labelT2Per.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonY
            // 
            this.buttonY.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonY.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonY.Location = new System.Drawing.Point(418, 178);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(60, 22);
            this.buttonY.TabIndex = 4;
            this.buttonY.Text = "Да";
            this.buttonY.UseVisualStyleBackColor = true;
            this.buttonY.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonN
            // 
            this.buttonN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonN.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonN.Location = new System.Drawing.Point(336, 178);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(60, 22);
            this.buttonN.TabIndex = 5;
            this.buttonN.Text = "Нет";
            this.buttonN.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanelMain.SetColumnSpan(this.label1, 4);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 29);
            this.label1.TabIndex = 105;
            this.label1.Text = "Текущая запись (если имеется) останется в:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton1.Location = new System.Drawing.Point(3, 135);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(153, 17);
            this.radioButton1.TabIndex = 106;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Время 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton2.Location = new System.Drawing.Point(243, 135);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(153, 17);
            this.radioButton2.TabIndex = 107;
            this.radioButton2.Text = "Время 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // DelimVremya
            // 
            this.AcceptButton = this.buttonY;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonN;
            this.ClientSize = new System.Drawing.Size(481, 203);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DelimVremya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Разделить время";
            this.Load += new System.EventHandler(this.DelimVremya1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMy)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownT2Per)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownT1Per)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxT1S;
        private System.Windows.Forms.TrackBar trackBarMy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label labelT1S;
        private System.Windows.Forms.NumericUpDown numericUpDownT1Per;
        private System.Windows.Forms.Label labelT1Per;
        private System.Windows.Forms.Label labelT2S;
        private System.Windows.Forms.Label labelT2Per;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.NumericUpDown numericUpDownT2Per;
        private System.Windows.Forms.DateTimePicker dateTimePickerT2S;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}