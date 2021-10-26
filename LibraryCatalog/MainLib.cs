using LibraryCatalog.Models;
using LibraryCatalog.Models.Factories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryCatalog
{
    public partial class MainLib : Form
    {
        public MainLib()
        {
            InitializeComponent();
            InitCombos();
            InitBooks();
        }
        protected void InitCombos()
        {
            Dictionary<string, string> cmbSource = new Dictionary<string, string>();
            cmbSource["By Name"] = "1";
            cmbSource["By Author"] = "2";
            cmbSource["By Genre"] = "3";

            cmbSortCriterion.DataSource = new BindingSource( cmbSource, null);
            cmbSortCriterion.DisplayMember = "Key";
            cmbSortCriterion.ValueMember = "Value";

            cmbSource = new Dictionary<string, string>();
            cmbSource["English"] = "1";
            cmbSource["Русский"] = "2";
            cmbLang.DataSource = new BindingSource(cmbSource, null);
            cmbLang.DisplayMember = "Key";
            cmbLang.ValueMember = "Value";

            FormatsFactory fact = new FormatsFactory();
            cmbFormat.DataSource = fact.Data;

            GenresFactory fg = new GenresFactory();
            cmbGenre.DataSource = fg.Data;
        }
        protected void InitBooks()
        {
            BooksFactory fact = new BooksFactory();
            lstBooks.DataSource = fact.Data;
            lstBooks.DisplayMember = "TextField";
            lstBooks.ValueMember = "ID";
            lstBooks.SelectedIndex = 0;
            InitFields((BookModel)lstBooks.SelectedItem);

        }
        protected void InitFields(BookModel book)
        {
            txtAuthor.Text = book.Author;
            txtDuration.Text = book.Duration;
            txtName.Text = book.Name;
            txtDuration.Text = book.Duration;
            txtDescription.Text = book.Description;
            cmbFormat.SelectedItem = book.Format;
            cmbGenre.SelectedItem = book.Genre;
            cmbLang.SelectedItem = book.Language;
            string filename = Directory.GetCurrentDirectory().Replace("bin\\Debug\\net5.0-windows", "Data\\Images\\");
            //pictBox.SizeMode = PictureBoxSizeMode.CenterImage;
            //pictBox.ImageLocation = $"{filename}{book.Image}";
            Image img = Image.FromFile($"{filename}{book.Image}");
            Bitmap b = new Bitmap($"{filename}{book.Image}");
            fillPictureBox(b);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ControlsReadonly(false);



        }
        protected void ControlsReadonly(bool IsReadOnly)
        {
            txtAuthor.ReadOnly = IsReadOnly;
            txtDuration.ReadOnly = IsReadOnly;
            txtName.ReadOnly = IsReadOnly;
            txtDescription.ReadOnly = IsReadOnly;
            txtRating.ReadOnly = IsReadOnly;
            cmbFormat.Enabled = !IsReadOnly;
            cmbGenre.Enabled = !IsReadOnly;
            cmbLang.Enabled = !IsReadOnly;
            btnSelectPict.Visible = !IsReadOnly;
        }
        private void OnListSelectionChanged(object sender, EventArgs e)
        {
            InitFields((BookModel)lstBooks.SelectedItem);
        }
        public void fillPictureBox(Bitmap bmp)
        {
            pictBox.SizeMode = PictureBoxSizeMode.Normal;
            bool source_is_wider = (float)bmp.Width / bmp.Height > (float)pictBox.Width / pictBox.Height;

            var resized = new Bitmap(pictBox.Width, pictBox.Height);
            var g = Graphics.FromImage(resized);
            var dest_rect = new Rectangle(0, 0, pictBox.Width, pictBox.Height);
            Rectangle src_rect;

            if (source_is_wider)
            {
                float size_ratio = (float)pictBox.Height / bmp.Height;
                int sample_width = (int)(pictBox.Width / size_ratio);
                src_rect = new Rectangle((bmp.Width - sample_width) / 2, 0, sample_width, bmp.Height);
            }
            else
            {
                float size_ratio = (float)pictBox.Width / bmp.Width;
                int sample_height = (int)(pictBox.Height / size_ratio);
                src_rect = new Rectangle(0, (bmp.Height - sample_height) / 2, bmp.Width, sample_height);
            }

            g.DrawImage(bmp, dest_rect, src_rect, GraphicsUnit.Pixel);
            g.Dispose();

            pictBox.Image = resized;
            //pictBox.SizeMode = PictureBoxSizeMode.CenterImage;
        }
    }
}
