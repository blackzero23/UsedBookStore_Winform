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
    public partial class BuySearchControl : UserControl
    {
        public BuySearchControl()
        {
            InitializeComponent();
        }

        private void TxbBuyerID_Enter(object sender, EventArgs e)
        {
            txbBuyerID.BackColor = Color.Beige;
        }

        private void TxbBuyerID_Leave(object sender, EventArgs e)
        {
            txbBuyerID.BackColor = Color.White;
        }

        private void TxbTitle_Enter(object sender, EventArgs e)
        {
            txbTitle.BackColor = Color.Beige;
        }

        private void TxbTitle_Leave(object sender, EventArgs e)
        {
            txbTitle.BackColor = Color.White;
        }

        private void BtnSearch_Enter(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.Beige;
        }

        private void BtnSearch_Leave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.White;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string buyerId = txbBuyerID.Text;
            string title = txbTitle.Text;

            OnSearchButtonClicked(buyerId, title);
            //bdsTrack.DataSource = DB.Track.Search(name, albumId, genreId);
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(string buyerId, string title)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(buyerId, title);
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
            public string BuyerId { get; set; }
            public string Title { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs( string buyerId, string title)
            {
                BuyerId = buyerId;
                Title = title;
            }
        }

        #endregion

        private void ChbBuyerID_CheckedChanged(object sender, EventArgs e)
        {
            txbBuyerID.Enabled = chbBuyerID.Checked;
        }

        private void ChbTitle_CheckedChanged(object sender, EventArgs e)
        {
            txbTitle.Enabled = chbTitle.Checked;
        }
    }
}
