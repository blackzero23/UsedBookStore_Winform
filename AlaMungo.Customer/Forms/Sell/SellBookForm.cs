using AlaMungo.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlaMungo.Customer.Forms
{
    public partial class SellBookForm : Form
    {
        private MetaDataBook _metaDataBook;
        private Data.Customer _customer;

        public SellBookForm(MetaDataBook metaDataBook)
        {
            InitializeComponent();
            _metaDataBook = metaDataBook;

            cbbQuality.Items.Add("A");
            cbbQuality.Items.Add("B");
            cbbQuality.Items.Add("C");
            cbbQuality.Items.Add("F");
        }
        public SellBookForm(Data.Customer customer, MetaDataBook metaDataBook)
        {
            InitializeComponent();
            _customer = customer;
            _metaDataBook = metaDataBook;

            cbbQuality.Items.Add("A");
            cbbQuality.Items.Add("B");
            cbbQuality.Items.Add("C");
            cbbQuality.Items.Add("F");
        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SellBookForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = _metaDataBook.Title;
            lblWriter.Text = _metaDataBook.Writer;
            lblPublisher.Text = _metaDataBook.Publisher;
            lblPrice.Text = _metaDataBook.Price.ToString("C");

            pcbBookImage.Image = Image.FromFile(_metaDataBook.Image);
            pcbBookImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void CbbQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            string quality = cbbQuality.Text;
            lblPrice.Text = Discount.SalePrices(quality, _metaDataBook.Price).ToString("C");
        }

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            Sell sell = new Sell();


            sell.SellID = DB.Sell.GetCount() + 1;
            sell.SellerID = _customer.CustomerID;
            sell.RegistrationDate = DateTime.Now;
            sell.Checked = false;

            UsedBook usedBook = new UsedBook();

            usedBook.UsedBookID = DB.UsedBook.GetCount() + 1;
            usedBook.MetaDataID = _metaDataBook.MetaDataBookID;
            usedBook.Quality = (string)cbbQuality.SelectedItem;
            usedBook.IsSell = false;

            DB.UsedBook.Insert(usedBook);
            DB.Sell.Insert(sell);

            SellUsedBook sellUsedBook = new SellUsedBook();

            sellUsedBook.UsedBookID = usedBook.UsedBookID;
            sellUsedBook.SellID = sell.SellID;

            DB.SellUsedBook.Insert(sellUsedBook);

            Close();
        }
    }
}
