using AlaMungo.Data;
using AlaMungo.Employee.Properties;
using System;
using System.Windows.Forms;

namespace AlaMungo.Employee.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Icon = Resources.YesAlaMungoLogo;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            string pw = txbPassword.Text;
            Data.Employee employee = DB.Employee.Check(id, pw);

            if (employee != null)
            {
                LoginSuccessForm employeeMain = new LoginSuccessForm(employee);
                employeeMain.FormClosed += new FormClosedEventHandler(EmployeeMainFormClosed);
                employeeMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ID 및 비밀번호가 맞지 않습니다.", "알림");
            }

        }

        private void EmployeeMainFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
