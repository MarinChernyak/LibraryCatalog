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
    public partial class dlgSomethingNew : Form
    {
        public dlgSomethingNew()
        {
            InitializeComponent();
        }
        public void SetLabels(string lbl)
        {
            label1.Text = label1.Text.Replace("%", lbl);
            this.Text = this.Text.Replace("%", lbl);
        }
        public string GetValue()
        {
            return txtValue.Text;
        }

        private void OnOK(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
