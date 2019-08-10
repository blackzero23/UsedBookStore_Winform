namespace AlaMungo.Employee.Controls
{
    partial class SellSearchControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbChecked = new System.Windows.Forms.ComboBox();
            this.chbChecked = new System.Windows.Forms.CheckBox();
            this.txbSellerID = new System.Windows.Forms.TextBox();
            this.chbSellerID = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbChecked);
            this.groupBox1.Controls.Add(this.chbChecked);
            this.groupBox1.Controls.Add(this.txbSellerID);
            this.groupBox1.Controls.Add(this.chbSellerID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 48);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(549, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "검수 상태 :";
            // 
            // cbbChecked
            // 
            this.cbbChecked.Enabled = false;
            this.cbbChecked.FormattingEnabled = true;
            this.cbbChecked.Location = new System.Drawing.Point(309, 18);
            this.cbbChecked.Name = "cbbChecked";
            this.cbbChecked.Size = new System.Drawing.Size(102, 20);
            this.cbbChecked.TabIndex = 10;
            // 
            // chbChecked
            // 
            this.chbChecked.AutoSize = true;
            this.chbChecked.Location = new System.Drawing.Point(217, 20);
            this.chbChecked.Name = "chbChecked";
            this.chbChecked.Size = new System.Drawing.Size(15, 14);
            this.chbChecked.TabIndex = 9;
            this.chbChecked.UseVisualStyleBackColor = true;
            this.chbChecked.CheckedChanged += new System.EventHandler(this.ChbChecked_CheckedChanged);
            // 
            // txbSellerID
            // 
            this.txbSellerID.Enabled = false;
            this.txbSellerID.Location = new System.Drawing.Point(101, 17);
            this.txbSellerID.Name = "txbSellerID";
            this.txbSellerID.Size = new System.Drawing.Size(100, 21);
            this.txbSellerID.TabIndex = 6;
            // 
            // chbSellerID
            // 
            this.chbSellerID.AutoSize = true;
            this.chbSellerID.Location = new System.Drawing.Point(6, 20);
            this.chbSellerID.Name = "chbSellerID";
            this.chbSellerID.Size = new System.Drawing.Size(15, 14);
            this.chbSellerID.TabIndex = 3;
            this.chbSellerID.UseVisualStyleBackColor = true;
            this.chbSellerID.CheckedChanged += new System.EventHandler(this.ChbSellerID_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "판매자 ID : ";
            // 
            // SellSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "SellSearchControl";
            this.Size = new System.Drawing.Size(630, 53);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbbChecked;
        private System.Windows.Forms.CheckBox chbChecked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSellerID;
        private System.Windows.Forms.CheckBox chbSellerID;
        private System.Windows.Forms.Label label1;
    }
}
