using AlaMungo.Customer.Properties;
using AlaMungo.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlaMungo.Customer.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Icon = Resources.YesAlaMungoLogo;
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            string pw = txbPassword.Text;
            Data.Customer customer = DB.Customer.Check(id, pw);

            

          
            
            if (customer != null)
            {
                //CustomerMainForm customerMain = new CustomerMainForm();
                //customerMain.FormClosed += new FormClosedEventHandler(CustomerMainFormClosed);
                //customerMain.Show();
                //this.Hide();
                LoginSuccessForm loginSuccess = new LoginSuccessForm(customer);
                loginSuccess.FormClosed += new FormClosedEventHandler(LoginSuccessFormClosed);
                loginSuccess.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("ID 및 비밀번호가 맞지 않습니다. \n 다시 입력해주십시오.", "알 림");
            }
        }

        private void LoginSuccessFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.ShowDialog();
        }
    }
}
