using System;
using System.Windows.Forms;

namespace AlaMungo.Employee.Controls
{
    public partial class SellSearchControl : UserControl
    {
        public SellSearchControl()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string sellerId = txbSellerID.Enabled? txbSellerID.Text : null;
            bool? bookChecked = cbbChecked.Enabled ? (bool)cbbChecked.SelectedItem : (bool?)null;

            OnSearchButtonClicked(sellerId, bookChecked);            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            object[] data = { false, true };

            cbbChecked.Items.AddRange(data);
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(string sellerId, bool? bookChecked)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(sellerId, bookChecked);
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
            public string SellerId { get; set; }
            public bool? BookChecked { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(string sellerId, bool? bookChecked)
            {
                SellerId = sellerId;
                BookChecked = bookChecked;
            }
        }
        #endregion

        private void ChbSellerID_CheckedChanged(object sender, EventArgs e)
        {
            txbSellerID.Enabled = chbSellerID.Checked;
        }

        private void ChbChecked_CheckedChanged(object sender, EventArgs e)
        {
            cbbChecked.Enabled = chbChecked.Checked;
        }
    }
}
   
