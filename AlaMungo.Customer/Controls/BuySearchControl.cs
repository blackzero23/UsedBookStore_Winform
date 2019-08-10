using System;
using System.Windows.Forms;

namespace AlaMungo.Customer.Controls
{
    public partial class BuySearchControl : UserControl
    {
        public BuySearchControl()
        {
            InitializeComponent();
            cbbQuality.Items.Add("A");
            cbbQuality.Items.Add("B");
            cbbQuality.Items.Add("C");
            cbbQuality.Items.Add("F");
            
        }

        private void ChbTitle_CheckedChanged(object sender, EventArgs e)
        {
            txbTitle.Enabled = chbTitle.Checked;
        }

        private void ChbWriter_CheckedChanged(object sender, EventArgs e)
        {
            txbWriter.Enabled = chbWriter.Checked;
        }

        private void ChbQuality_CheckedChanged(object sender, EventArgs e)
        {
            cbbQuality.Enabled = chbQuality.Checked;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string title = txbTitle.Text;
            string writer = txbWriter.Text;
            string quality = cbbQuality.Text;

            if(cbbQuality.Enabled == false)
                quality = "";


            OnSearchButtonClicked(title, writer, quality);
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(string title, string writer, string quality)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(title, writer, quality);
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
            public string Quality { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(string title, string writer, string quality)
            {
                Title = title;
                Writer = writer;
                Quality = quality;
            }
        }
        #endregion
    }
}
