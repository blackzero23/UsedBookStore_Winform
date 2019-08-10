using AlaMungo.Customer.Properties;
using AlaMungo.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlaMungo.Customer.Forms
{
    public partial class SignUpForm : Form
    {
        private bool _signUpAble = false;
        public SignUpForm()
        {
            InitializeComponent();
            Icon = Resources.YesAlaMungoLogo;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            ValidateId(txbId.Text);
        }

        private void ValidateId(string text)
        {
            if (string.IsNullOrEmpty(txbId.Text))
            {
                MessageBox.Show("아이디를 입력해주세요.", "알 림");
            }
            else if (txbId.Text.Length <= 4)
            {
                MessageBox.Show("적어도 다섯 글자 이상 이어야 합니다.", "알 림");
            }
            else if (DB.Customer.CheckId(txbId.Text))
            {
                MessageBox.Show("중복된 아이디 입니다.", "알 림");
            }
            else
            {
                MessageBox.Show("사용 가능한 아이디 입니다.", "알 림");
                _signUpAble = true;
            };
        }

        private bool ValidatePassword()
        {
            bool validateState = false;

            if (string.IsNullOrEmpty(txbPw.Text))
            {
                MessageBox.Show("비밀번호를 입력해주세요.", "알 림");
            }
            else if (txbPw.Text.Equals(txbPwCheck.Text) == false)
            {
                MessageBox.Show("비밀번호가 일치 하지 않습니다.", "알 림");
            }
            else if (txbPw.Text.Length <= 4)
            {
                MessageBox.Show("적어도 다섯 글자 이상 이어야 합니다.", "알 림");
            }
            else
                validateState = true;

            return validateState;
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {


            if (_signUpAble)
            {
                Data.Customer customer = new Data.Customer();
                customer.CustomerID = DB.Customer.GetCount() + 1;
                customer.LoginID = txbId.Text;
                if (ValidatePassword() == false)
                    return;
                customer.PassWord = txbPw.Text;
                customer.Address = txbAddress.Text;
                customer.Email = txbEMail.Text;
                customer.PhoneNumber = txbPhone.Text;
                DB.Customer.Insert(customer);
                MessageBox.Show("가입완료!", "알 림");
                this.Close();
            }
            else
            {
                MessageBox.Show("중복체크를 해주세요", "알 림");
            }
        }
    }
}