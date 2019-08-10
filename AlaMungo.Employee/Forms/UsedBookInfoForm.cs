using AlaMungo.Data;
using AlaMungo.Employee.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlaMungo.Employee.Forms
{
    public partial class UsedBookInfoForm : Form
    {
        private UsedBook _usedBook;
        public UsedBookInfoForm()
        {
            InitializeComponent();
        }
        public UsedBookInfoForm(UsedBook usedBook)
        {
            InitializeComponent();
            _usedBook = usedBook;
            Icon = Resources.Book11;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            lblTitle.Text = _usedBook.Title;
            lblWriter.Text = _usedBook.Writer;
            lbPublisher.Text = _usedBook.Publisher;
            lblPrice.Text = _usedBook.Price.ToString("C");
            lbQuality.Text = _usedBook.Quality;

            //사진 추가.
            pcbBookImage.Image = Image.FromFile(_usedBook.ImagePath);
            pcbBookImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
