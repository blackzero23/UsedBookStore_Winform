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
    public partial class UsedBookSearchControl : UserControl
    {
        public UsedBookSearchControl()
        {
            InitializeComponent();
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
            string title = txbTitle.Enabled ? txbTitle.Text : null;
            string writer = txbWriter.Enabled ? txbWriter.Text : null;
            string quality = cbbQuality.Enabled ? cbbQuality.ValueMember : null;
                        
            OnSearchButtonCliked(title, writer, quality);
        }

        #region SearchButtonCliked event things for C# 3.0
        public event EventHandler<SearchButtonClikedEventArgs> SearchButtonCliked;

        protected virtual void OnSearchButtonCliked(SearchButtonClikedEventArgs e)
        {
            if (SearchButtonCliked != null)
                SearchButtonCliked(this, e);
        }

        private SearchButtonClikedEventArgs OnSearchButtonCliked(string title, string writer, string quality)
        {
            SearchButtonClikedEventArgs args = new SearchButtonClikedEventArgs(title, writer, quality);
            OnSearchButtonCliked(args);

            return args;
        }

        private SearchButtonClikedEventArgs OnSearchButtonClikedForOut()
        {
            SearchButtonClikedEventArgs args = new SearchButtonClikedEventArgs();
            OnSearchButtonCliked(args);

            return args;
        }

        public class SearchButtonClikedEventArgs : EventArgs
        {
            public string Title { get; set; }
            public string Writer { get; set; }
            public string Quality { get; set; }

            public SearchButtonClikedEventArgs()
            {
            }

            public SearchButtonClikedEventArgs(string title, string writer, string quality)
            {
                Title = title;
                Writer = writer;
                Quality = quality;
            }
        }
        #endregion
    }
}
