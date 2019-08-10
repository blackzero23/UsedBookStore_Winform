using AlaMungo.Data;
using AlaMungo.Employee.Properties;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AlaMungo.Employee.Forms
{
    public partial class LoginSuccessForm : Form
    {

        private Data.Employee _employee;

        public LoginSuccessForm()
        {
            InitializeComponent();
        }

        public LoginSuccessForm(Data.Employee employee)
        {
            InitializeComponent();
            _employee = employee;
            Icon = Resources.YesAlaMungoLogo;
        }


        private void EmployeeMainForm_Load(object sender, EventArgs e)
        {
            var buy = DB.Buy.GetAll().Where(x => x.InvoiceState == 0);
            var usedBook = DB.UsedBook.GetAll().Where(x => x.IsSell == false);
            var sell = DB.Sell.GetAll().Where(x => x.Checked == false);
            var customer = DB.Customer.GetAll();

            lblCustomerCount.Text = $"{customer.Count} 명";
            lblUsedBookCount.Text = $"{usedBook.Count()} 권";
            lblSellCount.Text = $"{sell.Count()} 건";
            lblBuyCount.Text = $"{buy.Count()} 건";
        }

        private void TsbExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnReLoad_Click(object sender, EventArgs e)
        {
            EmployeeMainForm_Load(sender, e);
        }

        private void TsbUsedBook_Click(object sender, EventArgs e)
        {
            Form form = new UsedBookListForm(_employee);
            form.ShowDialog();
        }

        private void TsbInvoice_Click(object sender, EventArgs e)
        {
            Form form = new InvoiceListForm(_employee);
            form.ShowDialog();
        }

        private void TsbBuy_Click(object sender, EventArgs e)
        {
            Form form = new BuyListForm(_employee);
            form.ShowDialog();
        }

        private void TsbSell_Click(object sender, EventArgs e)
        {
            Form form = new SellListForm();
            form.ShowDialog();
        }
    }
}
