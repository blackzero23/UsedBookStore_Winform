using AlaMungo.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlaMungo.Customer.Controls
{
    public partial class SellListControl : UserControl
    {
        public SellListControl()
        {
            InitializeComponent();
        }


        public void SetDataSource(List<MetaDataBook> books)
        {
            dgvUsedBook.DataSource = books;
            lblCount.Text = $@"총 {books.Count}건이 검색 되었습니다.";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            dgvUsedBook.DataSource = DB.MetaDataBook.GetAll();
        }

        private void DgvUsedBook_DoubleClick(object sender, EventArgs e)
        {
            MetaDataBook metaData = dgvUsedBook.CurrentRow.DataBoundItem as MetaDataBook;

            if (metaData == null)
                return;

            OnRowDoubleClicked(metaData);
        }

        #region RowDoubleClicked event things for C# 3.0
        public event EventHandler<RowDoubleClickedEventArgs> RowDoubleClicked;

        protected virtual void OnRowDoubleClicked(RowDoubleClickedEventArgs e)
        {
            if (RowDoubleClicked != null)
                RowDoubleClicked(this, e);
        }

        private RowDoubleClickedEventArgs OnRowDoubleClicked(MetaDataBook metaDataBook)
        {
            RowDoubleClickedEventArgs args = new RowDoubleClickedEventArgs(metaDataBook);
            OnRowDoubleClicked(args);

            return args;
        }

        private RowDoubleClickedEventArgs OnRowDoubleClickedForOut()
        {
            RowDoubleClickedEventArgs args = new RowDoubleClickedEventArgs();
            OnRowDoubleClicked(args);

            return args;
        }

        public class RowDoubleClickedEventArgs : EventArgs
        {
            public MetaDataBook MetaDataBook { get; set; }

            public RowDoubleClickedEventArgs()
            {
            }

            public RowDoubleClickedEventArgs(MetaDataBook metaDataBook)
            {
                MetaDataBook = metaDataBook;
            }
        }
        #endregion

        private void DgvUsedBook_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
                e.Value = ((int)e.Value).ToString("C");
        }
    }
}
