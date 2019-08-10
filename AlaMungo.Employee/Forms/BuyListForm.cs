using AlaMungo.Data;
using AlaMungo.Employee.Controls;
using AlaMungo.Employee.Properties;
using System;
using System.Windows.Forms;

namespace AlaMungo.Employee.Forms
{
    public partial class BuyListForm : Form
    {
        private Data.Employee _employee;
        public BuyListForm()
        {
            InitializeComponent();
        }

        public BuyListForm(Data.Employee employee)
        {
            InitializeComponent();
            Icon = Resources.Purchase11;
            _employee = employee;
        }

        private void UscSearch_SearchButtonClicked(object sender, BuySearchControl.SearchButtonClickedEventArgs e)
        {
            var buys = DB.Buy.Search3(e.BuyerId, e.Title);
            uscList.SetDataSource(buys);
        }

        private void UscList_RowDoubleClicked(object sender, BuyListControl.RowDoubleClickedEventArgs e)
        {
            BuyForm form = new BuyForm(e.Buy);
            form.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
