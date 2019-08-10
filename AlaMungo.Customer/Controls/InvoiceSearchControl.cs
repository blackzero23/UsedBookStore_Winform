using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlaMungo.Data;

namespace AlaMungo.Customer.Controls
{
    public partial class InvoiceSearchControl : UserControl
    {
        public InvoiceSearchControl()
        {
            InitializeComponent();
        }

        public InvoiceSearchControl(int customerID)
        {
            InitializeComponent();
            int _customerId = customerID;
        }

        private void ChbTitle_CheckedChanged(object sender, EventArgs e)
        {
            txbTitle.Enabled = chbTitle.Checked;
        }



        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string title = txbTitle.Text;
            DateTime? date = null;

            
            DateTime? fromDateTime = dtpFromDate.Enabled ? (DateTime)dtpFromDate.Value : date;

            DateTime? toDateTime = dtpToDate.Enabled ? (DateTime)dtpToDate.Value : date;

            OnSearchButtonClicked(title, fromDateTime, toDateTime);
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(string title, DateTime? fromDate, DateTime? toDate)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(title, fromDate, toDate);
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
            public DateTime? FromDate { get; set; }
            public DateTime? ToDate { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(string title, DateTime? fromDate, DateTime? toDate)
            {
                Title = title;
                FromDate = fromDate;
                ToDate = toDate;
            }
        }

        #endregion

        private void ChbFromDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpFromDate.Enabled = chbFromDate.Checked;
        }

        private void ChbToDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpToDate.Enabled = chbToDate.Checked;
        }
    }

}
