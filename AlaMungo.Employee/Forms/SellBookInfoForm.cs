using AlaMungo.Data;
using AlaMungo.Employee.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlaMungo.Employee.Forms
{
    public partial class SellBookInfoForm : Form
    {
        private Sell _sell;
        
        public SellBookInfoForm()
        {
            InitializeComponent();
        }

        public SellBookInfoForm(Sell sell)
        {
            InitializeComponent();
            Icon = Resources.sale31;
            _sell = sell;

            object[] data = { "A", "B", "C", "F" };

            // 각 콤보박스에 데이타를 초기화
            cbbQuality.Items.AddRange(data);
        }
       
        private UsedBook usedBook;

        private void SellBookInfoForm_Load(object sender, EventArgs e)
        {
            usedBook = DB.Sell.SearchBook(_sell);
            lblTitle.Text = usedBook.Title;
            lblWriter.Text = usedBook.Writer;
            lbPublisher.Text = usedBook.Publisher;
            lbSeller.Text = _sell.SellerID.ToString();
            lblPrice.Text = Discount.SalePrices(usedBook.Quality, usedBook.Price).ToString("C");

            pcbBookImage.Image = Image.FromFile(usedBook.ImagePath);
            pcbBookImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //DB.UsedBook.Insert(_usedBook);
            //_sell.Checked = true;
            if(cbbQuality.SelectedItem != null)
                usedBook.Quality = (string)cbbQuality.SelectedItem;
            usedBook.IsSell = false;
            DB.UsedBook.Update(usedBook);

            _sell.Checked = true;
            DB.Sell.Update(_sell);

            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CbbQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            string quality = cbbQuality.Text;

            lblPrice.Text = Discount.SalePrices(quality, usedBook.Price).ToString("C");
        }

       
    }
}

        
 
