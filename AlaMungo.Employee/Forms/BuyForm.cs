using AlaMungo.Data;
using AlaMungo.Employee.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlaMungo.Employee.Forms
{
    public partial class BuyForm : Form
    {
        public BuyForm(Buy buy)
        {
            InitializeComponent();
            Icon = Resources.Purchase11;

            _buy = buy;
        }

        private Buy _buy;

        private void BtnInvoice_Click(object sender, EventArgs e)
        {

            _buy.InvoiceState = 1;

            //if (_buy.BuyerID == 0)
            //   DB.Buy.Insert(_buy);
            //else
                DB.Buy.Update(_buy);

            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BuyForm_Load(object sender, EventArgs e)
        {
            lblBuyerID.Text = _buy.BuyerLoginID;
            lblTitle.Text = _buy.Title;
            lblWriter.Text = _buy.Writer;

            lblPrice.Text = _buy.Price.ToString("C");

            lblOrderDate.Text = _buy.OrderDate.ToString();

            pcbBookImage.Image = Image.FromFile(_buy.ImagePath);
            pcbBookImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
