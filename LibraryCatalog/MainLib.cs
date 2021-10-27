using LibraryCatalog.Dialogs;
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
        protected List<string> Formats { get; set; }
        protected BookModel _book;

        public MainLib()
        {
            InitializeComponent();
            InitCombos();
            InitBooks();
            ControlsReadonly(true);
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
            Formats = fact.Data;
            cmbFormat.DataSource = Formats;

            GenresFactory fg = new GenresFactory();
            cmbGenre.DataSource = fg.Data;
        }
        protected void InitBooks()
        {
            BooksFactory fact = new BooksFactory();
            InitMainList( fact.Data);
            InitFields((BookModel)lstBooks.SelectedItem);

        }
        protected void InitFields(BookModel book)
        {
            txtAuthor.Text = book.Author;
            txtDuration.Text = book.Duration;
            txtName.Text = book.Name;
            txtDuration.Text = book.Duration;
            txtDescription.Text = book.Description;
            txtSeries.Text = book.Series;
            txtRating.Text = book.Rating;
            cmbFormat.SelectedItem = book.Format;
            cmbGenre.SelectedItem = book.Genre;
            cmbLang.SelectedItem = book.Language;
            string filename = Directory.GetCurrentDirectory().Replace("bin\\Debug\\net5.0-windows", "Data\\Images\\");
            if (!String.IsNullOrEmpty(book.Image))
            {
                Image img = Image.FromFile($"{filename}{book.Image}");
                Bitmap b = new Bitmap($"{filename}{book.Image}");
                fillPictureBox(b);
            }
            else
            {
                pictBox.Image = null;
                pictBox.Invalidate();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstBooks.SelectedIndex = -1;
            ControlsReadonly(false);
            _book = new BookModel()
            {
                ID = Guid.NewGuid()
            };
            txtAuthor.Text = string.Empty;
            txtDuration.Text = string.Empty;
            txtName.Text = string.Empty;
            txtDuration.Text = string.Empty;
            txtSeries.Text = string.Empty;
            txtDescription.Text = string.Empty;

        }
        protected void ControlsReadonly(bool IsReadOnly)
        {
            txtAuthor.ReadOnly = IsReadOnly;
            txtDuration.ReadOnly = IsReadOnly;
            txtName.ReadOnly = IsReadOnly;
            txtDescription.ReadOnly = IsReadOnly;
            txtRating.ReadOnly = IsReadOnly;
            txtSeries.ReadOnly = IsReadOnly;

            cmbFormat.Enabled = !IsReadOnly;
            cmbGenre.Enabled = !IsReadOnly;
            cmbLang.Enabled = !IsReadOnly;
            btnAddFormat.Enabled = !IsReadOnly;
            btnAddGenre.Enabled = !IsReadOnly;
            btnAddFormat.Enabled = !IsReadOnly;
            btnRemoveFormat.Enabled = !IsReadOnly;
            btnRemoveGenre.Enabled = !IsReadOnly;

            btnSelectPict.Visible = !IsReadOnly;
            btnEdit.Visible = IsReadOnly;
            btnFinishEdit.Visible = !IsReadOnly;

            Color cr = IsReadOnly ? SystemColors.ControlLightLight : SystemColors.Control;
            txtAuthor.BackColor = cr;
            txtDuration.BackColor = cr;
            txtName.BackColor = cr;
            txtDescription.BackColor = cr;
            txtRating.BackColor = cr;
            txtSeries.BackColor = cr;
            cmbFormat.BackColor = cr;
            cmbGenre.BackColor = cr;
            cmbLang.BackColor = cr;

        }
        private void OnListSelectionChanged(object sender, EventArgs e)
        {
            _book = (BookModel)lstBooks.SelectedItem;
            if (_book != null)
            {
                InitFields((BookModel)lstBooks.SelectedItem);
            }
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ControlsReadonly(false);
        }

        private void OnFinishEdit(object sender, EventArgs e)
        {
            ControlsReadonly(true);
            SaveBook();

        }
        protected void SaveBook()
        {
            _book.Language = cmbLang.SelectedItem.ToString();
            _book.Name = txtName.Text;
            _book.Rating = txtRating.Text;
            _book.Series = txtSeries.Text;
            _book.Author = txtAuthor.Text;
            _book.Description = txtDescription.Text;
            _book.Duration = txtDuration.Text;
            _book.Format = cmbFormat.SelectedItem.ToString();
            _book.Genre = cmbGenre.SelectedItem.ToString();            

            BooksFactory fact = new BooksFactory();
            List<BookModel> lst = fact.Data;
            lst.RemoveAll(x => x.ID == _book.ID);
            lst.Add(_book);
            fact = new BooksFactory(lst);
            InitBooks();
        }
        protected string GetPictureFilter()
        {
            string sfilter=string.Empty;
            foreach(string s in Formats)
            {
                sfilter = $"{sfilter}|{s} files(*.{s})| *.{s} |";
            }
            sfilter = sfilter.Substring(1);
            return sfilter;
        }
        private void OnSelectPicture(object sender, EventArgs e)
        {
            DeletePicture();
            string fname = _book.ID.ToString();
            OpenFileDialog f = new OpenFileDialog();
            f.Title = "Select picture for title";
            f.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|gif files (*.gif)|*.gif|tif files (*.tif)|*.tif ";
            string PasteTo =Directory.GetCurrentDirectory().Replace("bin\\Debug\\net5.0-windows", "Data\\Images\\");
            PasteTo = $"{PasteTo}{fname}";
            if (f.ShowDialog() == DialogResult.OK)
            {
                string FileTitle = f.FileName;
                int ipos = f.FileName.LastIndexOf('.');
                string ext = f.FileName.Substring(ipos + 1);
                PasteTo = $"{PasteTo}.{ext}";

                File.Copy(FileTitle, PasteTo); // change to move
                _book.Image = $"{fname}.{ext}";
                MessageBox.Show($"The selected file has been copied notmally and renamed to {fname}.{ext} ", "File Copied",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        protected void DeletePicture()
        {
            BookModel book = (BookModel)lstBooks.SelectedItem;
            if (book != null)
            {
                pictBox.Image.Dispose();
                string dir = Directory.GetCurrentDirectory().Replace("bin\\Debug\\net5.0-windows", "Data\\Images\\");
                string fname = $"{book.ID}.jpg";
                List<string> files = Directory.GetFiles(dir).ToList();

                string filename = files.Where(x => x.Contains(fname)).FirstOrDefault();
                if (!string.IsNullOrEmpty(filename))

                {
                    
                    try
                    {
                        if (MessageBox.Show($"The current picture will be deleted permanently! Are you sure? ", "Delete File ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            System.GC.Collect();
                            System.GC.WaitForPendingFinalizers();
                            File.Delete(filename);
                        }
                    }
                    catch(Exception e)
                    {

                    }
                }
            }

        }

        private void OnDeleteBook(object sender, EventArgs e)
        {
            if(_book !=null)
            {
                if (MessageBox.Show($"The selected book will be deleted permanently! Are you sure? ", "Delete Book ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    DeletePicture();
                    BooksFactory fact = new BooksFactory();
                    List<BookModel> lst = fact.Data;
                    lst.RemoveAll(x => x.ID == _book.ID);
                    fact = new BooksFactory(lst);

                    InitMainList(lst);
                }
            }
        }
        /*
         *            cmbSource["By Name"] = "1";
            cmbSource["By Author"] = "2";
            cmbSource["By Genre"] = "3";
         */
        private void btnSort_Click(object sender, EventArgs e)
        {
            int scriterion = Convert.ToInt32(cmbSortCriterion.SelectedValue);
            BooksFactory fact = new BooksFactory();
            List<BookModel> lst = null;
            switch(scriterion)
            {
                case 1:
                    lst = fact.Data.OrderBy(x => x.Name).ToList();
                    break;
                case 2:
                    lst = fact.Data.OrderBy(x => x.Author).ToList();
                    break;
                case 3:
                    lst = fact.Data.OrderBy(x => x.Genre).ToList();
                    break;
            };
            InitMainList(lst);
        }
        protected void InitMainList(List<BookModel> lst)
        {
            lstBooks.DataSource = null;
            lstBooks.DataSource = lst;
            lstBooks.DisplayMember = "TextField";
            lstBooks.ValueMember = "ID";
            lstBooks.SelectedIndex = 0;
        }

        private void OnAddGenre(object sender, EventArgs e)
        {
            dlgSomethingNew dlg = new dlgSomethingNew();
            dlg.SetLabels("Genre");

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string value = dlg.GetValue();
                GenresFactory fact = new GenresFactory();
                fact.Data.Add(value);
                fact.SetData(fact.Data);
                cmbGenre.DataSource = fact.Data;
                cmbGenre.SelectedItem = value;

            }
        }

        private void OnRemoveGenre(object sender, EventArgs e)
        {
            if (MessageBox.Show($"The selected genre will be deleted! Are you sure? ", "Delete genre ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string value = cmbGenre.SelectedItem.ToString();
                GenresFactory fact = new GenresFactory();
                fact.Data.Remove(value);
                fact.SetData(fact.Data);
                cmbGenre.DataSource = fact.Data;
            }
        }

        private void OnAddFormat(object sender, EventArgs e)
        {
            dlgSomethingNew dlg = new dlgSomethingNew();
            dlg.SetLabels("Format");

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string value = dlg.GetValue();
                FormatsFactory fact = new FormatsFactory();
                fact.Data.Add(value);
                fact.SetData(fact.Data);
                cmbFormat.DataSource = fact.Data;
                cmbFormat.SelectedItem = value;

            }
        }

        private void OnRemoveFormat(object sender, EventArgs e)
        {
            if (MessageBox.Show($"The selected format will be deleted! Are you sure? ", "Delete format ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string value = cmbFormat.SelectedItem.ToString();
                FormatsFactory fact = new FormatsFactory();
                fact.Data.Remove(value);
                fact.SetData(fact.Data);
                cmbFormat.DataSource = fact.Data;

            }
        }
    }
}
