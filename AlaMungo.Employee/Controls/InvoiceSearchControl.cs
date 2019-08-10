using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlaMungo.Employee.Controls
{
    public partial class InvoiceSearchControl : UserControl
    {
        public InvoiceSearchControl()
        {
            InitializeComponent();
        }

        private void ChbTitle_CheckedChanged(object sender, EventArgs e)
        {
            txbTitle.Enabled = chbTitle.Checked;
        }

        private void ChbBuyerID_CheckedChanged(object sender, EventArgs e)
        {
            txbBuyerID.Enabled = chbBuyerID.Checked;
        }

        private void ChbDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpFromDate.Enabled = chbDate.Checked;
            dtpToDate.Enabled = chbDate.Checked;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //책 제목, 구매자 ID, 날짜 체크박스에 체크가 안 되있는건
            //조건없이 다 하는 것.
            //체크 박스가 되어 있는 부분은 검색어를 넣고 그 분야는
            //그것에 한하여 검색하겠다는 식으로

            string title = txbTitle.Text;
            string cusID = txbBuyerID.Text;
            DateTime? date = null;

            DateTime? fromDate = dtpFromDate.Enabled ? dtpFromDate.Value : date;
            DateTime? toDate = dtpToDate.Enabled ? dtpToDate.Value : date;


            //var empInvoice = Data.BuyData.

            OnSearchButtonClicked(title, cusID, fromDate, toDate);
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(string title, string cusID, DateTime? fromDate, DateTime? toDate)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(title, cusID, fromDate, toDate);
            OnSearchButtonClicked(args);

            return args;
        }

        private SearchButtonClickedEventArgs OnSearchButtonClickedForOut()
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs();
            OnSearchButtonClicked(args);

            return args;
        }

        public class SearchButtonClickedEventArgs : EventArgs
        {
            public string Title { get; set; }
            public string CusID { get; set; }
            public DateTime? FromDate { get; set; }
            public DateTime? ToDate { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(string title, string cusID, DateTime? fromDate, DateTime? toDate)
            {
                Title = title;
                CusID = cusID;
                FromDate = fromDate;
                ToDate = toDate;
            }
        }
        #endregion
    }
}
