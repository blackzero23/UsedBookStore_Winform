using AlaMungo.Data;
using AlaMungo.Employee.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlaMungo.Employee.Forms
{
    public partial class SellListForm : Form
    {
        public SellListForm()
        {
            InitializeComponent();
            Icon = Resources.sale31;
        }

        private void UscSearch_SearchButtonClicked(object sender, Controls.SellSearchControl.SearchButtonClickedEventArgs e)
        {
            List<Sell> sells=DB.Sell.Search(e.SellerId, e.BookChecked);


            uscList.SetDataSource(sells);
        }

        private void UscList_RowDoubleClicked(object sender, Controls.SellListControl.RowDoubleClickedEventArgs e)
        {
            SellBookInfoForm sellBook = new SellBookInfoForm(e.Sell);
            sellBook.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
