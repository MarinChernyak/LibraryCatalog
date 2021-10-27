
namespace LibraryCatalog
{
    partial class MainLib
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLib));
            this.lblSort = new System.Windows.Forms.Label();
            this.cmbSortCriterion = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDElete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeries = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.btnAddFormat = new System.Windows.Forms.Button();
            this.cmbLang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pictBox = new System.Windows.Forms.PictureBox();
            this.btnSelectPict = new System.Windows.Forms.Button();
            this.btnFinishEdit = new System.Windows.Forms.Button();
            this.btnRemoveGenre = new System.Windows.Forms.Button();
            this.btnRemoveFormat = new System.Windows.Forms.Button();
            this.txtListFormats = new System.Windows.Forms.TextBox();
            this.btnAddFormatToList = new System.Windows.Forms.Button();
            this.ttAddFormatToList = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(13, 10);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(44, 15);
            this.lblSort.TabIndex = 0;
            this.lblSort.Text = "Sort by";
            // 
            // cmbSortCriterion
            // 
            this.cmbSortCriterion.FormattingEnabled = true;
            this.cmbSortCriterion.Location = new System.Drawing.Point(63, 5);
            this.cmbSortCriterion.Name = "cmbSortCriterion";
            this.cmbSortCriterion.Size = new System.Drawing.Size(242, 23);
            this.cmbSortCriterion.TabIndex = 1;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(311, 5);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(48, 23);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 15;
            this.lstBooks.Location = new System.Drawing.Point(13, 39);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(346, 334);
            this.lstBooks.TabIndex = 3;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.OnListSelectionChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 633);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add New Book";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDElete
            // 
            this.btnDElete.Location = new System.Drawing.Point(130, 633);
            this.btnDElete.Name = "btnDElete";
            this.btnDElete.Size = new System.Drawing.Size(112, 23);
            this.btnDElete.TabIndex = 5;
            this.btnDElete.Text = "Delete selected";
            this.btnDElete.UseVisualStyleBackColor = true;
            this.btnDElete.Click += new System.EventHandler(this.OnDeleteBook);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(247, 633);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMain.Location = new System.Drawing.Point(440, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(262, 28);
            this.lblMain.TabIndex = 6;
            this.lblMain.Text = "Information about a book:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(393, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 15);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtName.Location = new System.Drawing.Point(393, 71);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(371, 23);
            this.txtName.TabIndex = 8;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAuthor.Location = new System.Drawing.Point(393, 103);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(49, 15);
            this.lblAuthor.TabIndex = 7;
            this.lblAuthor.Text = "Author:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAuthor.Location = new System.Drawing.Point(393, 121);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(371, 23);
            this.txtAuthor.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(393, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Series:";
            // 
            // txtSeries
            // 
            this.txtSeries.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSeries.Location = new System.Drawing.Point(393, 171);
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.ReadOnly = true;
            this.txtSeries.Size = new System.Drawing.Size(371, 23);
            this.txtSeries.TabIndex = 8;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenre.Location = new System.Drawing.Point(393, 203);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(45, 15);
            this.lblGenre.TabIndex = 7;
            this.lblGenre.Text = "Genre:";
            // 
            // cmbGenre
            // 
            this.cmbGenre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbGenre.Enabled = false;
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(393, 221);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(301, 23);
            this.cmbGenre.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(393, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(393, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Formats List:";
            // 
            // cmbFormat
            // 
            this.cmbFormat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbFormat.Enabled = false;
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Location = new System.Drawing.Point(633, 271);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(61, 23);
            this.cmbFormat.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(393, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Duration:";
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDuration.Location = new System.Drawing.Point(393, 321);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ReadOnly = true;
            this.txtDuration.Size = new System.Drawing.Size(113, 23);
            this.txtDuration.TabIndex = 8;
            // 
            // txtRating
            // 
            this.txtRating.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtRating.Location = new System.Drawing.Point(512, 321);
            this.txtRating.Name = "txtRating";
            this.txtRating.ReadOnly = true;
            this.txtRating.Size = new System.Drawing.Size(113, 23);
            this.txtRating.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(512, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rating:";
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddGenre.Image = ((System.Drawing.Image)(resources.GetObject("btnAddGenre.Image")));
            this.btnAddGenre.Location = new System.Drawing.Point(700, 221);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(29, 23);
            this.btnAddGenre.TabIndex = 10;
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.OnAddGenre);
            // 
            // btnAddFormat
            // 
            this.btnAddFormat.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFormat.Image")));
            this.btnAddFormat.Location = new System.Drawing.Point(700, 271);
            this.btnAddFormat.Name = "btnAddFormat";
            this.btnAddFormat.Size = new System.Drawing.Size(29, 23);
            this.btnAddFormat.TabIndex = 10;
            this.btnAddFormat.UseVisualStyleBackColor = true;
            this.btnAddFormat.Click += new System.EventHandler(this.OnAddFormat);
            // 
            // cmbLang
            // 
            this.cmbLang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbLang.Enabled = false;
            this.cmbLang.FormattingEnabled = true;
            this.cmbLang.Location = new System.Drawing.Point(631, 321);
            this.cmbLang.Name = "cmbLang";
            this.cmbLang.Size = new System.Drawing.Size(133, 23);
            this.cmbLang.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(631, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Language:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDescription.Location = new System.Drawing.Point(393, 371);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(371, 256);
            this.txtDescription.TabIndex = 12;
            this.txtDescription.Text = "";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(393, 633);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pictBox
            // 
            this.pictBox.Location = new System.Drawing.Point(13, 380);
            this.pictBox.Name = "pictBox";
            this.pictBox.Size = new System.Drawing.Size(346, 247);
            this.pictBox.TabIndex = 14;
            this.pictBox.TabStop = false;
            // 
            // btnSelectPict
            // 
            this.btnSelectPict.Location = new System.Drawing.Point(522, 633);
            this.btnSelectPict.Name = "btnSelectPict";
            this.btnSelectPict.Size = new System.Drawing.Size(112, 23);
            this.btnSelectPict.TabIndex = 15;
            this.btnSelectPict.Text = "Select Picture";
            this.btnSelectPict.UseVisualStyleBackColor = true;
            this.btnSelectPict.Visible = false;
            this.btnSelectPict.Click += new System.EventHandler(this.OnSelectPicture);
            // 
            // btnFinishEdit
            // 
            this.btnFinishEdit.Location = new System.Drawing.Point(651, 633);
            this.btnFinishEdit.Name = "btnFinishEdit";
            this.btnFinishEdit.Size = new System.Drawing.Size(112, 23);
            this.btnFinishEdit.TabIndex = 16;
            this.btnFinishEdit.Text = "Finish Edit";
            this.btnFinishEdit.UseVisualStyleBackColor = true;
            this.btnFinishEdit.Visible = false;
            this.btnFinishEdit.Click += new System.EventHandler(this.OnFinishEdit);
            // 
            // btnRemoveGenre
            // 
            this.btnRemoveGenre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveGenre.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveGenre.Image")));
            this.btnRemoveGenre.Location = new System.Drawing.Point(735, 221);
            this.btnRemoveGenre.Name = "btnRemoveGenre";
            this.btnRemoveGenre.Size = new System.Drawing.Size(29, 23);
            this.btnRemoveGenre.TabIndex = 10;
            this.btnRemoveGenre.UseVisualStyleBackColor = true;
            this.btnRemoveGenre.Click += new System.EventHandler(this.OnRemoveGenre);
            // 
            // btnRemoveFormat
            // 
            this.btnRemoveFormat.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveFormat.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveFormat.Image")));
            this.btnRemoveFormat.Location = new System.Drawing.Point(735, 271);
            this.btnRemoveFormat.Name = "btnRemoveFormat";
            this.btnRemoveFormat.Size = new System.Drawing.Size(29, 23);
            this.btnRemoveFormat.TabIndex = 10;
            this.btnRemoveFormat.UseVisualStyleBackColor = true;
            this.btnRemoveFormat.Click += new System.EventHandler(this.OnRemoveFormat);
            // 
            // txtListFormats
            // 
            this.txtListFormats.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtListFormats.Location = new System.Drawing.Point(393, 271);
            this.txtListFormats.Name = "txtListFormats";
            this.txtListFormats.ReadOnly = true;
            this.txtListFormats.Size = new System.Drawing.Size(195, 23);
            this.txtListFormats.TabIndex = 17;
            // 
            // btnAddFormatToList
            // 
            this.btnAddFormatToList.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFormatToList.Image")));
            this.btnAddFormatToList.Location = new System.Drawing.Point(595, 271);
            this.btnAddFormatToList.Name = "btnAddFormatToList";
            this.btnAddFormatToList.Size = new System.Drawing.Size(31, 23);
            this.btnAddFormatToList.TabIndex = 18;
            this.ttAddFormatToList.SetToolTip(this.btnAddFormatToList, "Add a format from the right combo to the list at left");
            this.btnAddFormatToList.UseVisualStyleBackColor = true;
            this.btnAddFormatToList.Click += new System.EventHandler(this.AddFormatToList);
            // 
            // MainLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 668);
            this.Controls.Add(this.btnAddFormatToList);
            this.Controls.Add(this.txtListFormats);
            this.Controls.Add(this.btnFinishEdit);
            this.Controls.Add(this.btnSelectPict);
            this.Controls.Add(this.pictBox);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbLang);
            this.Controls.Add(this.btnAddFormat);
            this.Controls.Add(this.btnRemoveFormat);
            this.Controls.Add(this.btnRemoveGenre);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtSeries);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.btnDElete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.cmbSortCriterion);
            this.Controls.Add(this.lblSort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainLib";
            this.Text = "Библиотека Танюшечки Ивановой";
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox cmbSortCriterion;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDElete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeries;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Button btnAddFormat;
        private System.Windows.Forms.ComboBox cmbLang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox pictBox;
        private System.Windows.Forms.Button btnSelectPict;
        private System.Windows.Forms.Button btnFinishEdit;
        private System.Windows.Forms.Button btnRemoveGenre;
        private System.Windows.Forms.Button btnRemoveFormat;
        private System.Windows.Forms.TextBox txtListFormats;
        private System.Windows.Forms.Button btnAddFormatToList;
        private System.Windows.Forms.ToolTip ttAddFormatToList;
    }
}

