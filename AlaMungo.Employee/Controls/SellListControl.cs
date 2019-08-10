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

namespace AlaMungo.Employee.Controls
{
    public partial class SellListControl : UserControl
    {
        public SellListControl()
        {
            InitializeComponent();
        }

        internal void SetDataSource(List<Sell> sells)
        {
            dgvList.DataSource = sells;
            lblCount.Text = $"총 {sells.Where(x=>x.Checked == false).Count()} 건의 미수락이 있습니다";
        }
       
        private void DgvList_DoubleClick(object sender, EventArgs e)
        {
            Sell sell = dgvList.CurrentRow.DataBoundItem as Sell;

            if (sell == null)
                return;
            OnRowDoubleClicked(sell);
        }
            
            #region RowDoubleClicked event things for C# 3.0
public event EventHandler<RowDoubleClickedEventArgs> RowDoubleClicked;

        protected virtual void OnRowDoubleClicked(RowDoubleClickedEventArgs e)
        {
            if (RowDoubleClicked != null)
                RowDoubleClicked(this, e);
        }

        private RowDoubleClickedEventArgs OnRowDoubleClicked(Sell sell)
        {
            RowDoubleClickedEventArgs args = new RowDoubleClickedEventArgs(sell);
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
            public Sell Sell { get; set; }

            public RowDoubleClickedEventArgs()
            {
            }

            public RowDoubleClickedEventArgs(Sell sell)
            {
                Sell = sell;
            }
        }
        #endregion

        string quality;
        int price;

        private void DgvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
                quality = e.Value.ToString();

            if (e.ColumnIndex == 4)
            {
                price = (int)e.Value;
                e.Value = Discount.SalePrices(quality, price).ToString("C");
            }
        }
    }
}

