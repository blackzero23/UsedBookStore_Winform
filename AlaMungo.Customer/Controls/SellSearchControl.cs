using System;
using System.Windows.Forms;

namespace AlaMungo.Customer.Controls
{
    public partial class SellSearchControl : UserControl
    {
        public SellSearchControl()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string title = txbTitle.Text;
            string writer = txbWriter.Text;
            string publisher = txbPublisher.Text;

            OnSearchButtonClicked(title, writer, publisher);
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(string title, string writer, string publisher)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(title, writer, publisher);
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
            public string Writer { get; set; }
            public string Publisher { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(string title, string writer, string publisher)
            {
                Title = title;
                Writer = writer;
                Publisher = publisher;
            }
        }
        #endregion

        private void ChbTitle_CheckedChanged(object sender, EventArgs e)
        {
            txbTitle.Enabled = chbTitle.Checked;
        }

        private void ChbWriter_CheckedChanged(object sender, EventArgs e)
        {
            txbWriter.Enabled = chbWriter.Checked;
        }

        private void ChbPublisher_CheckedChanged(object sender, EventArgs e)
        {
            txbPublisher.Enabled = chbPublisher.Checked;
        }
    }
}
