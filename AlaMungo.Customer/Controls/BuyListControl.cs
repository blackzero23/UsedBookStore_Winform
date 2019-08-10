using AlaMungo.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlaMungo.Customer.Controls
{
    public partial class BuyListControl : UserControl
    {
        public BuyListControl()
        {
            InitializeComponent();
        }

        public void SetDataSource(List<UsedBook> usedBooks)
        {
            bdsUsedBook.DataSource = usedBooks;
            lblCount.Text = $"총 {usedBooks.Count} 건 입니다.";
        }

        private void DgvList_DoubleClick(object sender, System.EventArgs e)
        {
            UsedBook usedBook = dgvList.CurrentRow.DataBoundItem as UsedBook;

            if (usedBook == null)
                return;

            // TrackForm 띄우기
            OnRowDoubleClicked(usedBook);

            //if (usedBook.IsSell == true)
            //    dgvList.Rows[usedBook.UsedBookID].Visible = false;

        }

        #region RowDoubleClicked event things for C# 3.0
        public event EventHandler<RowDoubleClickedEventArgs> RowDoubleClicked;

        protected virtual void OnRowDoubleClicked(RowDoubleClickedEventArgs e)
        {
            if (RowDoubleClicked != null)
                RowDoubleClicked(this, e);
        }

        private RowDoubleClickedEventArgs OnRowDoubleClicked(UsedBook usedBook)
        {
            RowDoubleClickedEventArgs args = new RowDoubleClickedEventArgs(usedBook);
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
            public UsedBook UsedBook { get; set; }

            public RowDoubleClickedEventArgs()
            {
            }

            public RowDoubleClickedEventArgs(UsedBook usedBook)
            {
                UsedBook = usedBook;
            }
        }

        #endregion

        private void DgvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
                e.Value = ((int)e.Value).ToString("C");
        }
    }
}
