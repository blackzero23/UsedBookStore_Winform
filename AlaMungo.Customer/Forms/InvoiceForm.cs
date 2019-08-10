using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlaMungo.Customer.Controls;
using AlaMungo.Data;

namespace AlaMungo.Customer.Forms
{
    
    public partial class InvoiceForm : Form
    {
        
        private Data.Customer _customer;

        public InvoiceForm()
        {
            InitializeComponent();
        }

        public InvoiceForm(Data.Customer customer)
        {
            InitializeComponent();
            _customer = customer;
        }


        private void UscSearch_SearchButtonClicked(object sender, Controls.InvoiceSearchControl.SearchButtonClickedEventArgs e)
        {
           List<Buy> buys = DB.Buy.Search(_customer.LoginID,e.Title, e.FromDate, e.ToDate);
           uscList.SetDateSource(buys);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
