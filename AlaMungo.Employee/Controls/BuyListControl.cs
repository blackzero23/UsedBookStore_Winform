using AlaMungo.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlaMungo.Employee.Controls
{
    public partial class BuyListControl : UserControl
    {
        public BuyListControl()
        {
            InitializeComponent();
        }

        public void SetDataSource(List<Buy> buys)
        {
            bdsBuy.DataSource = buys;

            lblCount.Text = $"총 {buys.Count} 건 있습니다";
        }

        private void DgvList_DoubleClick(object sender, System.EventArgs e)
        {
            var buy = dgvList.CurrentRow.DataBoundItem as Buy;
        
            if (buy == null)
                return;

            OnRowDoubleClicked(buy);
        }
        private void DgvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                e.Value = ((int)e.Value).ToString("C");
            }
        }

        #region RowDoubleClicked event things for C# 3.0
        public event EventHandler<RowDoubleClickedEventArgs> RowDoubleClicked;

        protected virtual void OnRowDoubleClicked(RowDoubleClickedEventArgs e)
        {
            if (RowDoubleClicked != null)
                RowDoubleClicked(this, e);
        }

        private RowDoubleClickedEventArgs OnRowDoubleClicked(Buy buy)
        {
            RowDoubleClickedEventArgs args = new RowDoubleClickedEventArgs(buy);
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
            public Buy Buy { get; set; }

            public RowDoubleClickedEventArgs()
            {
            }

            public RowDoubleClickedEventArgs(Buy buy)
            {
                Buy = buy;
            }
        }
     
      


        #endregion

        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);

        //    if (DesignMode)
        //        return;

        //    bdsBuy.DataSource = DB.Buy.GetAll();
        //}
    }
}
