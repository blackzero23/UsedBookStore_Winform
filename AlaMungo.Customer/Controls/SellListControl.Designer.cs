namespace AlaMungo.Customer.Controls
{
    partial class SellListControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvUsedBook = new System.Windows.Forms.DataGridView();
            this.metaDataBookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metaDataBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usedBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsedBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metaDataBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedBookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsedBook
            // 
            this.dgvUsedBook.AllowUserToAddRows = false;
            this.dgvUsedBook.AllowUserToDeleteRows = false;
            this.dgvUsedBook.AllowUserToResizeColumns = false;
            this.dgvUsedBook.AllowUserToResizeRows = false;
            this.dgvUsedBook.AutoGenerateColumns = false;
            this.dgvUsedBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsedBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvUsedBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsedBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.metaDataBookIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.writerDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgvUsedBook.DataSource = this.metaDataBookBindingSource;
            this.dgvUsedBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsedBook.Location = new System.Drawing.Point(0, 0);
            this.dgvUsedBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvUsedBook.MultiSelect = false;
            this.dgvUsedBook.Name = "dgvUsedBook";
            this.dgvUsedBook.ReadOnly = true;
            this.dgvUsedBook.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvUsedBook.RowTemplate.Height = 23;
            this.dgvUsedBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsedBook.Size = new System.Drawing.Size(1039, 699);
            this.dgvUsedBook.TabIndex = 0;
            this.dgvUsedBook.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvUsedBook_CellFormatting);
            this.dgvUsedBook.DoubleClick += new System.EventHandler(this.DgvUsedBook_DoubleClick);
            // 
            // metaDataBookIDDataGridViewTextBoxColumn
            // 
            this.metaDataBookIDDataGridViewTextBoxColumn.DataPropertyName = "MetaDataBookID";
            this.metaDataBookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            this.metaDataBookIDDataGridViewTextBoxColumn.Name = "metaDataBookIDDataGridViewTextBoxColumn";
            this.metaDataBookIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "책 제목";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // writerDataGridViewTextBoxColumn
            // 
            this.writerDataGridViewTextBoxColumn.DataPropertyName = "Writer";
            this.writerDataGridViewTextBoxColumn.HeaderText = "저 자";
            this.writerDataGridViewTextBoxColumn.Name = "writerDataGridViewTextBoxColumn";
            this.writerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "출판사";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "가 격";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // metaDataBookBindingSource
            // 
            this.metaDataBookBindingSource.DataSource = typeof(AlaMungo.Data.MetaDataBook);
            // 
            // usedBookBindingSource
            // 
            this.usedBookBindingSource.DataSource = typeof(AlaMungo.Data.UsedBook);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCount.Location = new System.Drawing.Point(0, 684);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(37, 15);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "대기";
            // 
            // SellListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dgvUsedBook);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SellListControl";
            this.Size = new System.Drawing.Size(1039, 699);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsedBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metaDataBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedBookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsedBook;
        private System.Windows.Forms.BindingSource metaDataBookBindingSource;
        private System.Windows.Forms.BindingSource usedBookBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn metaDataBookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn writerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblCount;
    }
}
