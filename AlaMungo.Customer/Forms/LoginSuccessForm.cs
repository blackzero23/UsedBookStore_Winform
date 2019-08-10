using AlaMungo.Customer.Properties;
using AlaMungo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlaMungo.Customer.Forms
{
    public partial class LoginSuccessForm : Form
    {
        
        private Data.Customer _customer;


        public LoginSuccessForm()
        {
            InitializeComponent();
        }

        public LoginSuccessForm(Data.Customer customer)
        {
            InitializeComponent();
            _customer = customer;

            pictureBox1.Image = Resources.AlaMungoMain;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            lblComment.Text = $"{customer.LoginID}님 어서 오세요.";
            Icon = Resources.YesAlaMungoLogo;
        }



        private void TsbBuy_Click(object sender, EventArgs e)
        {
            Form form = new BuyListForm(_customer);
            form.ShowDialog();
        }

        private void TsbExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TsbSell_Click(object sender, EventArgs e)
        {
            Form form = new SellListForm(_customer);
            form.ShowDialog();
        }

        private void Tsbinvoice_Click(object sender, EventArgs e)
        {
            Form form = new InvoiceForm(_customer);
            form.ShowDialog();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
