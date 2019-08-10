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
    public partial class UsedBookForm : Form
    {
        private Data.Customer _customer;
        public UsedBookForm(UsedBook usedBook)
        {
            InitializeComponent();

            _usedBook = usedBook;
            Icon = Resources.Purchase1;
        }

        public UsedBookForm(Data.Customer customer,UsedBook usedBook)
        {
            InitializeComponent();

            _customer = customer;

            _usedBook = usedBook;
            Icon = Resources.Purchase1;
        }

        private UsedBook _usedBook;

        private void UsedBookForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = _usedBook.Title;
            lblWriter.Text = _usedBook.Writer;
            lblPublisher.Text = _usedBook.Publisher;
            lblQuality.Text = _usedBook.Quality;
            lblPrice.Text = _usedBook.Price.ToString("C");


            //pcbBookImage.Image = Image.FromFile(_usedBook.ImagePath);
            pcbBookImage.Image = Image.FromFile(_usedBook.ImagePath);
            //pcbBookImage.BackgroundImageLayout = ImageLayout.Stretch; 
            pcbBookImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            UsedBook usedBook = _usedBook;

            OrderSheet form = new OrderSheet(_customer,usedBook);

            form.ShowDialog();
            Close();
        }
    }
}
