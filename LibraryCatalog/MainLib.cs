﻿using LibraryCatalog.Dialogs;
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
        protected BookModel _book = new BookModel();
        protected bool IsSearch;
        public MainLib()
        {
            InitializeComponent();
            InitCombos();
            InitBooks();
            ControlsReadonly(true);
            IsSearch = true;
        }
        protected void InitCombos()
        {
            Dictionary<string, string> cmbSource = new Dictionary<string, string>();
            cmbSource["By Name"] = "1";
            cmbSource["By Author"] = "2";
            cmbSource["By Genre"] = "3";
            cmbSource["By Series"] = "4";
            cmbSortCriterion.DataSource = new BindingSource(cmbSource, null);
            cmbSortCriterion.DisplayMember = "Key";
            cmbSortCriterion.ValueMember = "Value";
            cmbSortCriterion.SelectedIndex = 0;
            //----------------------------------
            Dictionary<string, string> cmbSourceShow = new Dictionary<string, string>();
            cmbSourceShow["Show all"] = "0";
            cmbSourceShow["Text books"] = "1";
            cmbSourceShow["Audio books"] = "2";
            cmbShowKind.DataSource = new BindingSource(cmbSourceShow, null);
            cmbShowKind.DisplayMember = "Key";
            cmbShowKind.ValueMember = "Value";

            //------------------------------------------------------------------
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

            KeywordsFactory kwf = new KeywordsFactory();
            cmbKeywords.DataSource = kwf.Data;

        }
        protected void InitBooks()
        {
            List<BookModel> lst = ShowKindFactoryCall();
            InitMainList(lst);
            InitFields((BookModel)lstBooks.SelectedItem);

        }
        protected void InitFields(BookModel book)
        {
            if (book != null && book.Name != Constants.NoBooks)
            {
                txtAuthor.Text = book.Author;
                txtDuration.Text = book.Duration;
                txtName.Text = book.Name;
                txtDuration.Text = book.Duration;
                txtDescription.Text = book.Description;
                txtSeries.Text = book.Series;
                txtRating.Text = book.Rating;
                txtListFormats.Text = book.Format;
                cmbGenre.SelectedItem = book.Genre;
                cmbLang.SelectedItem = book.Language;
                string filename = string.Empty;
                txtKeywords.Text = book.Keywords;
                //#if DEBUG
                //filename = Constants.GetDebugImgPath();
                //#else
                filename = Constants.GetImgPath();
                //#endif
                string imgpath = $"{filename}unknown_pic.png";
                if (!String.IsNullOrEmpty(book.Image))
                {
                    imgpath = $"{filename}{book.Image}";

                }
                if (File.Exists(imgpath))
                {
                    Image img = Image.FromFile(imgpath);
                    int w = img.Width;
                    Bitmap b = new Bitmap(imgpath);
                    Utilities.FillPictureBox(pictBox, b);

                    //InitKeyWords(book.Keywords);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstBooks.SelectedIndex = -1;
            ControlsReadonly(false);
            _book = new BookModel()
            {
                ID = Guid.NewGuid().ToString()
            };
            ClearBookInfo();
        }
        protected void ClearBookInfo()
        {
            txtAuthor.Text = string.Empty;
            txtDuration.Text = string.Empty;
            txtName.Text = string.Empty;
            txtSeries.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtRating.Text = string.Empty;
            if (pictBox.Image != null)
            {
                pictBox.Image.Dispose();
                pictBox.Image = null;
            }
        }
        protected void ControlsReadonly(bool IsReadOnly)
        {
            txtAuthor.ReadOnly = IsReadOnly;
            txtDuration.ReadOnly = IsReadOnly;
            txtName.ReadOnly = IsReadOnly;
            txtDescription.ReadOnly = IsReadOnly;
            txtRating.ReadOnly = IsReadOnly;
            txtSeries.ReadOnly = IsReadOnly;
            txtListFormats.ReadOnly = IsReadOnly;
            txtKeywords.ReadOnly = IsReadOnly;

            cmbFormat.Enabled = !IsReadOnly;
            cmbGenre.Enabled = !IsReadOnly;
            cmbLang.Enabled = !IsReadOnly;
            cmbKeywords.Enabled = !IsReadOnly;
            btnAddFormat.Enabled = !IsReadOnly;
            btnAddGenre.Enabled = !IsReadOnly;
            btnAddFormat.Enabled = !IsReadOnly;
            btnRemoveFormat.Enabled = !IsReadOnly;
            btnRemoveGenre.Enabled = !IsReadOnly;
            btnAddFormatToList.Enabled = !IsReadOnly;
            btnSelectPict.Visible = !IsReadOnly;
            btnEdit.Visible = IsReadOnly;
            btnFinishEdit.Visible = !IsReadOnly;
            btnAddKW.Enabled = !IsReadOnly;
            btnRemoveKW.Enabled = !IsReadOnly;
            btnAddKWtoList.Enabled = !IsReadOnly;

            Color cr = IsReadOnly ? SystemColors.ControlLight : SystemColors.Control;
            txtAuthor.BackColor = cr;
            txtDuration.BackColor = cr;
            txtName.BackColor = cr;
            txtDescription.BackColor = cr;
            txtRating.BackColor = cr;
            txtSeries.BackColor = cr;
            txtListFormats.BackColor = cr;
            txtKeywords.BackColor = cr;
            cmbFormat.BackColor = cr;
            cmbGenre.BackColor = cr;
            cmbLang.BackColor = cr;
            cmbKeywords.BackColor = cr;


        }
        private void OnListSelectionChanged(object sender, EventArgs e)
        {
            _book = (BookModel)lstBooks.SelectedItem;
            if (_book != null)
            {
                InitFields((BookModel)lstBooks.SelectedItem);
            }
        }
        //public void FillPictureBox(Bitmap bmp)
        //{

        //    pictBox.SizeMode = PictureBoxSizeMode.Normal;
        //    double W = pictBox.Width;
        //    double H = pictBox.Height;
        //    double w = bmp.Width;
        //    double h = bmp.Height;
        //    double rh = h / H;
        //    double rw = w / W;
        //    double rate = Math.Max(rh, rw);
        //    if (rate > 0)
        //    {
        //        h = h / rate;
        //        w = w / rate;
        //    }


        //    Bitmap resized = new Bitmap(bmp, new Size((int)w, (int)h));
        //    pictBox.Image = resized;
        //    pictBox.SizeMode = PictureBoxSizeMode.CenterImage;
        //}

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
            _book.Format = txtListFormats.Text;
            _book.Genre = cmbGenre.SelectedItem.ToString();
            _book.Keywords = txtKeywords.Text;
            BooksFactory fact = new BooksFactory();
            List<BookModel> lst = fact.Data;
            if (lst != null && lst.Count == 1 && lst[0].Name == Constants.NoBooks)
                lst.Remove(lst[0]);

            lst.RemoveAll(x => x.ID == _book.ID);
            lst.Add(_book);
            fact = new BooksFactory(lst);
            InitBooks();
        }
        private void OnSelectPicture(object sender, EventArgs e)
        {
            DeletePicture();
            string fname = _book.ID.ToString();
            OpenFileDialog f = new OpenFileDialog();
            f.Title = "Select picture for title";
            f.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|gif files (*.gif)|*.gif|tif files (*.tif)|*.tif ";

            string PasteTo = string.Empty;
            //#if DEBUG
            //            PasteTo = Constants.GetDebugImgPath();
            //#else
            PasteTo = Constants.GetImgPath();
            //#endif
            if (!Directory.Exists(PasteTo))
            {
                Directory.CreateDirectory(PasteTo);
            }
            PasteTo = $"{PasteTo}{fname}";
            if (f.ShowDialog() == DialogResult.OK)
            {
                string FileTitle = f.FileName;
                int ipos = f.FileName.LastIndexOf('.');
                string ext = f.FileName.Substring(ipos + 1);
                PasteTo = $"{PasteTo}.{ext}";

                File.Copy(FileTitle, PasteTo); // change to move
                _book.Image = $"{fname}.{ext}";
                MessageBox.Show($"The selected file has been copied notmally and renamed to {fname}.{ext} ", "File Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected void DeletePicture()
        {
            BookModel book = (BookModel)lstBooks.SelectedItem;
            if (book != null)
            {
                if (pictBox.Image != null)
                    pictBox.Image.Dispose();

                string dir = string.Empty;
                //#if DEBUG
                //                dir = Constants.GetDebugImgPath();
                //#else
                dir = Constants.GetImgPath();
                //#endif

                string fname = $"{book.ID}.jpg";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
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
                    catch (Exception e)
                    {

                    }
                }
            }

        }

        private void OnDeleteBook(object sender, EventArgs e)
        {
            if (_book != null && _book.Name != Constants.NoBooks)
            {
                if (MessageBox.Show($"The selected book will be deleted permanently! Are you sure? ", "Delete Book ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    DeletePicture();
                    BooksFactory fact = new BooksFactory();
                    List<BookModel> lst = fact.Data;
                    lst.RemoveAll(x => x.ID == _book.ID);
                    fact.SetData(lst);
                    fact = new BooksFactory();
                    ClearBookInfo();
                    InitMainList(fact.Data, 1);
                    ControlsReadonly(true);
                }
            }
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            int criterion = Convert.ToInt32(cmbSortCriterion.SelectedValue);
            List<BookModel> lst = ShowKindFactoryCall();
            switch (criterion)
            {
                case 1:
                    lst = lst.OrderBy(x => x.Name).ToList();
                    break;
                case 2:
                    lst = lst.OrderBy(x => x.Author).ToList();
                    break;
                case 3:
                    lst = lst.OrderBy(x => x.Genre).ToList();
                    break;
                case 4:
                    lst = lst.OrderBy(x => x.Series).ToList();
                    break;
                default:
                    lst = lst.OrderBy(x => x.Name).ToList();
                    break;
            };
            InitMainList(lst, criterion);
        }
        protected void InitMainList(List<BookModel> lst, int criterion = 1)
        {
            lstBooks.DataSource = null;
            lstBooks.DataSource = lst;
            if (criterion == 1)
                lstBooks.DisplayMember = "TextField";//by Name
            else if (criterion == 2)
                lstBooks.DisplayMember = "TextFieldByAuthor";
            else if (criterion == 3)
                lstBooks.DisplayMember = "TextFieldByGenre";
            else if (criterion == 4)
                lstBooks.DisplayMember = "TextFieldBySeries";
            lstBooks.ValueMember = "ID";


            if (lstBooks.Items.Count > 0)
                lstBooks.SelectedIndex = 0;

            IfSleep();
        }
        protected string GetStringByNameGenre(BookModel bm)
        {
            string sout = string.Empty;
            sout = $"{bm.Name}, {bm.Author}";
            return sout;
        }
        protected string GetStringByAuthor(BookModel bm)
        {
            string sout = string.Empty;
            sout = $"\t{bm.Author}, {bm.Name} ";
            return sout;
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

        private void AddFormatToList(object sender, EventArgs e)
        {
            string format = cmbFormat.SelectedItem.ToString();
            string coma = txtListFormats.Text.Length > 0 ? ", " : string.Empty;
            txtListFormats.Text = $"{txtListFormats.Text}{coma}{format}";
        }

        private void OnSearch(object sender, EventArgs e)
        {
            BooksFactory fact = new BooksFactory();
            if (IsSearch)
            {
                dlgSearch dlg = new dlgSearch();

                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    List<BookModel> lstBooks = fact.Data;
                    if (!string.IsNullOrEmpty(dlg.Author))
                    {
                        lstBooks = lstBooks.Where(x => x.Author.Contains(dlg.Author)).ToList();
                    }
                    if (!string.IsNullOrEmpty(dlg.Format) && lstBooks.Count > 0)
                    {
                        lstBooks = lstBooks.Where(x => x.Format.Contains(dlg.Format)).ToList();
                    }
                    if (!string.IsNullOrEmpty(dlg.Series) && lstBooks.Count > 0)
                    {
                        lstBooks = lstBooks.Where(x => x.Series.Contains(dlg.Series)).ToList();
                    }
                    if (!string.IsNullOrEmpty(dlg.BookName) && lstBooks.Count > 0)
                    {
                        lstBooks = lstBooks.Where(x => x.Name.Contains(dlg.BookName)).ToList();
                    }

                    if (!string.IsNullOrEmpty(dlg.Keyword ) && lstBooks.Count > 0)
                    {
                        lstBooks = lstBooks.Where(x => x.Keywords.Contains(dlg.Keyword)).ToList();
                    }
                    InitMainList(lstBooks);
                    IsSearch = false;
                    btnSearch.Text = "Return to Library";
                }
            }
            else
            {
                IsSearch = true;
                btnSearch.Text = "Search";
                InitMainList(fact.Data);
            }
        }

        private void OnShowKindChanged(object sender, EventArgs e)
        {
            bool IsInit = cmbShowKind.SelectedValue.GetType().Name == "KeyValuePair`2";
            if (!IsInit)
            {
                List<BookModel> lst = ShowKindFactoryCall();
                InitMainList(lst);
            }
        }
        protected List<BookModel> ShowKindFactoryCall()
        {
            int val = Convert.ToInt32(cmbShowKind.SelectedValue);
            ShowKindFactory fact = new ShowKindFactory(val);
            return fact.Data;

        }
        protected void IfSleep()
        {
            DateTime now = DateTime.Now;
            DateTime dt1 = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
            DateTime dt2 = new DateTime(now.Year, now.Month, now.Day, 5, 0, 0);

            if (now > dt1 && now < dt2)
            {
                dlgSleep dlg = new dlgSleep();
                dlg.ShowDialog();
            }
        }


        private void btnNewKW_Click(object sender, EventArgs e)
        {

        }

        private void btnAddKW_Click(object sender, EventArgs e)
        {
            dlgSomethingNew dlg = new dlgSomethingNew();
            dlg.SetLabels("Keyword");

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string value = dlg.GetValue();
                KeywordsFactory fact = new KeywordsFactory();
                if (!fact.IsKWordExisting(value))
                {
                    fact.Data.Add(value);
                    fact.SetData(fact.Data);
                    cmbKeywords.DataSource = fact.Data;
                    cmbKeywords.SelectedItem = value;
                }
            }
        }

        private void btnAddKWtoList_Click(object sender, EventArgs e)
        {
            string kw = cmbKeywords.SelectedItem.ToString();
            if (!txtKeywords.Text.Contains(kw))
            {
                string coma = txtKeywords.Text.Length > 0 ? ", " : string.Empty;
                txtKeywords.Text = $"{txtKeywords.Text}{coma}{kw}";
            }
        }

        private void btnRemoveKW_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"The selected keyword will be deleted! Are you sure? ", "Delete keyword ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string value = cmbKeywords.SelectedItem.ToString();
                KeywordsFactory fact = new KeywordsFactory();
                fact.Data.Remove(value);
                fact.SetData(fact.Data);
                cmbKeywords.DataSource = fact.Data;
                RemoveValueFromTxtxBox(txtKeywords, value);
            }
        }
        protected void RemoveValueFromTxtxBox(TextBox textBox, string value)
        {
            string txt = textBox.Text.Trim();
            txt = txt.Replace(value,"").Trim();
            txt = txt.Replace(",,", ",").Trim();
            txt = txt.Replace(", ,", ",").Trim();
            if (txt[txt.Length - 1] == ',')
            {
                txt = txt.Remove(txt.Length - 1);
            }
            if (txt[0] == ',')
            {
                txt = txt.Remove(0,2).Trim();
            }
            textBox.Text = txt;
        }
    }
}
