using AlaMungo.Data;
using AlaMungo.Employee.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlaMungo.Employee.Forms
{
    public partial class InvoiceListForm : Form
    {
        private Data.Employee _employee;
        public InvoiceListForm()
        {
            InitializeComponent();
        }

        public InvoiceListForm(Data.Employee employee)
        {
            InitializeComponent();
            _employee = employee;
            Icon = Resources.Delivery_Truck11;
        }


        private void UscSearch_SearchButtonClicked(object sender, Controls.InvoiceSearchControl.SearchButtonClickedEventArgs e)
        {
            List<Buy> buys = DB.Buy.Search2(e.Title, e.CusID, e.FromDate, e.ToDate);
            uscList.SetDataSource(buys);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
