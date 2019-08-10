namespace AlaMungo.Customer.Controls
{
    partial class BuySearchControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbbQuality = new System.Windows.Forms.ComboBox();
            this.chbQuality = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbWriter = new System.Windows.Forms.TextBox();
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.chbWriter = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chbTitle = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "책 제목 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cbbQuality);
            this.groupBox1.Controls.Add(this.chbQuality);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbWriter);
            this.groupBox1.Controls.Add(this.txbTitle);
            this.groupBox1.Controls.Add(this.chbWriter);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chbTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 48);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(585, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // cbbQuality
            // 
            this.cbbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbQuality.Enabled = false;
            this.cbbQuality.FormattingEnabled = true;
            this.cbbQuality.Location = new System.Drawing.Point(433, 17);
            this.cbbQuality.Name = "cbbQuality";
            this.cbbQuality.Size = new System.Drawing.Size(102, 20);
            this.cbbQuality.TabIndex = 10;
            // 
            // chbQuality
            // 
            this.chbQuality.AutoSize = true;
            this.chbQuality.Location = new System.Drawing.Point(369, 20);
            this.chbQuality.Name = "chbQuality";
            this.chbQuality.Size = new System.Drawing.Size(15, 14);
            this.chbQuality.TabIndex = 9;
            this.chbQuality.UseVisualStyleBackColor = true;
            this.chbQuality.CheckedChanged += new System.EventHandler(this.ChbQuality_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "품질 :";
            // 
            // txbWriter
            // 
            this.txbWriter.Enabled = false;
            this.txbWriter.Location = new System.Drawing.Point(259, 17);
            this.txbWriter.Name = "txbWriter";
            this.txbWriter.Size = new System.Drawing.Size(100, 21);
            this.txbWriter.TabIndex = 7;
            // 
            // txbTitle
            // 
            this.txbTitle.Enabled = false;
            this.txbTitle.Location = new System.Drawing.Point(86, 17);
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(100, 21);
            this.txbTitle.TabIndex = 6;
            // 
            // chbWriter
            // 
            this.chbWriter.AutoSize = true;
            this.chbWriter.Location = new System.Drawing.Point(195, 20);
            this.chbWriter.Name = "chbWriter";
            this.chbWriter.Size = new System.Drawing.Size(15, 14);
            this.chbWriter.TabIndex = 5;
            this.chbWriter.UseVisualStyleBackColor = true;
            this.chbWriter.CheckedChanged += new System.EventHandler(this.ChbWriter_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "저자 :";
            // 
            // chbTitle
            // 
            this.chbTitle.AutoSize = true;
            this.chbTitle.Location = new System.Drawing.Point(6, 20);
            this.chbTitle.Name = "chbTitle";
            this.chbTitle.Size = new System.Drawing.Size(15, 14);
            this.chbTitle.TabIndex = 3;
            this.chbTitle.UseVisualStyleBackColor = true;
            this.chbTitle.CheckedChanged += new System.EventHandler(this.ChbTitle_CheckedChanged);
            // 
            // BuySearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "BuySearchControl";
            this.Size = new System.Drawing.Size(666, 55);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbWriter;
        private System.Windows.Forms.TextBox txbTitle;
        private System.Windows.Forms.CheckBox chbWriter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbbQuality;
        private System.Windows.Forms.CheckBox chbQuality;
        private System.Windows.Forms.Label label2;
    }
}
