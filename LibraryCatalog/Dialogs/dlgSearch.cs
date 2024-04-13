using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryCatalog.Dialogs
{
    public partial class dlgSearch : Form
    {

        public string Author { get { return textAuthor.Text; } }
        public string Format { get { return textFormat.Text; } }
        public string Series { get { return textSeries.Text; } }
        public string BookName { get { return textName.Text; } }
        public string Keyword { get { return txtKeyword.Text; } }

        public dlgSearch()
        {
            InitializeComponent();
        }


        private void OnSearch(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
