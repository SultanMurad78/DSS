namespace DSS
{
    partial class TakeMoney
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelDolg = new System.Windows.Forms.Label();
            this.labelPay = new System.Windows.Forms.Label();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.labelPFIO0 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonCansel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPred = new System.Windows.Forms.Label();
            this.plataTableAdapter1 = new DSS.___BASA__DataSetTableAdapters.PlataTableAdapter();
            this.___BASA__DataSet = new DSS.___BASA__DataSet();
            this.dolgTableAdapter = new DSS.___BASA__DataSetTableAdapters.DolgTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.___BASA__DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Документ №";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 102);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 17, 3, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelDolg
            // 
            this.labelDolg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDolg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDolg.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDolg.Location = new System.Drawing.Point(3, 30);
            this.labelDolg.Name = "labelDolg";
            this.labelDolg.Size = new System.Drawing.Size(145, 30);
            this.labelDolg.TabIndex = 2;
            this.labelDolg.Text = "Долг  :  ";
            this.labelDolg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPay
            // 
            this.labelPay.AutoSize = true;
            this.labelPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPay.Location = new System.Drawing.Point(3, 60);
            this.labelPay.Name = "labelPay";
            this.labelPay.Size = new System.Drawing.Size(145, 25);
            this.labelPay.TabIndex = 4;
            this.labelPay.Text = "Оплата  :";
            this.labelPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonYes
            // 
            this.buttonYes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonYes.Location = new System.Drawing.Point(332, 137);
            this.buttonYes.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(92, 23);
            this.buttonYes.TabIndex = 6;
            this.buttonYes.Text = "Да";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPrint.Enabled = false;
            this.buttonPrint.Location = new System.Drawing.Point(30, 137);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(91, 23);
            this.buttonPrint.TabIndex = 7;
            this.buttonPrint.Text = "Печать";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelPFIO0
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.labelPFIO0, 3);
            this.labelPFIO0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPFIO0.Location = new System.Drawing.Point(3, 0);
            this.labelPFIO0.Name = "labelPFIO0";
            this.labelPFIO0.Size = new System.Drawing.Size(448, 30);
            this.labelPFIO0.TabIndex = 8;
            this.labelPFIO0.Text = "Должник  : ";
            this.labelPFIO0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Location = new System.Drawing.Point(154, 63);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(145, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // buttonCansel
            // 
            this.buttonCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCansel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCansel.Location = new System.Drawing.Point(181, 137);
            this.buttonCansel.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(91, 23);
            this.buttonCansel.TabIndex = 10;
            this.buttonCansel.Text = "Отмена";
            this.buttonCansel.UseVisualStyleBackColor = true;
            this.buttonCansel.Click += new System.EventHandler(this.buttonCansel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.labelPred, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonYes, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonCansel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelPay, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonPrint, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelPFIO0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDolg, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 163);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // labelPred
            // 
            this.labelPred.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPred.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPred.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPred.Location = new System.Drawing.Point(305, 30);
            this.labelPred.Name = "labelPred";
            this.labelPred.Size = new System.Drawing.Size(146, 30);
            this.labelPred.TabIndex = 11;
            this.labelPred.Text = "Предоплата  :  ";
            this.labelPred.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPred.Visible = false;
            // 
            // plataTableAdapter1
            // 
            this.plataTableAdapter1.ClearBeforeFill = true;
            // 
            // ___BASA__DataSet
            // 
            this.___BASA__DataSet.DataSetName = "___BASA__DataSet";
            this.___BASA__DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dolgTableAdapter
            // 
            this.dolgTableAdapter.ClearBeforeFill = true;
            // 
            // TakeMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 163);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 195);
            this.Name = "TakeMoney";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TakeMoney";
            this.Load += new System.EventHandler(this.TakeMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.___BASA__DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelDolg;
        private System.Windows.Forms.Label labelPay;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Label labelPFIO0;
        private DSS.___BASA__DataSetTableAdapters.PlataTableAdapter plataTableAdapter1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private ___BASA__DataSet ___BASA__DataSet;
        private DSS.___BASA__DataSetTableAdapters.DolgTableAdapter dolgTableAdapter;
        private System.Windows.Forms.Button buttonCansel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelPred;
    }
}