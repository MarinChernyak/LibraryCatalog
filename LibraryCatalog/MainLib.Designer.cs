
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLib));
            lblSort = new System.Windows.Forms.Label();
            cmbSortCriterion = new System.Windows.Forms.ComboBox();
            btnSort = new System.Windows.Forms.Button();
            lstBooks = new System.Windows.Forms.ListBox();
            btnAdd = new System.Windows.Forms.Button();
            btnDElete = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            lblMain = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            lblAuthor = new System.Windows.Forms.Label();
            txtAuthor = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtSeries = new System.Windows.Forms.TextBox();
            lblGenre = new System.Windows.Forms.Label();
            cmbGenre = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            cmbFormat = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            txtDuration = new System.Windows.Forms.TextBox();
            txtRating = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            btnAddGenre = new System.Windows.Forms.Button();
            btnAddFormat = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            txtDescription = new System.Windows.Forms.RichTextBox();
            btnEdit = new System.Windows.Forms.Button();
            pictBox = new System.Windows.Forms.PictureBox();
            btnSelectPict = new System.Windows.Forms.Button();
            btnFinishEdit = new System.Windows.Forms.Button();
            btnRemoveGenre = new System.Windows.Forms.Button();
            btnRemoveFormat = new System.Windows.Forms.Button();
            txtListFormats = new System.Windows.Forms.TextBox();
            btnAddFormatToList = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            cmbShowKind = new System.Windows.Forms.ComboBox();
            label9 = new System.Windows.Forms.Label();
            cmbLang = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            cmbKeywords = new System.Windows.Forms.ComboBox();
            btnRemoveKW = new System.Windows.Forms.Button();
            btnAddKW = new System.Windows.Forms.Button();
            txtKeywords = new System.Windows.Forms.TextBox();
            btnAddKWtoList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictBox).BeginInit();
            SuspendLayout();
            // 
            // lblSort
            // 
            lblSort.AutoSize = true;
            lblSort.Location = new System.Drawing.Point(12, 50);
            lblSort.Name = "lblSort";
            lblSort.Size = new System.Drawing.Size(44, 15);
            lblSort.TabIndex = 0;
            lblSort.Text = "Sort by";
            // 
            // cmbSortCriterion
            // 
            cmbSortCriterion.FormattingEnabled = true;
            cmbSortCriterion.Location = new System.Drawing.Point(77, 45);
            cmbSortCriterion.Name = "cmbSortCriterion";
            cmbSortCriterion.Size = new System.Drawing.Size(227, 23);
            cmbSortCriterion.TabIndex = 1;
            // 
            // btnSort
            // 
            btnSort.Location = new System.Drawing.Point(310, 45);
            btnSort.Name = "btnSort";
            btnSort.Size = new System.Drawing.Size(48, 23);
            btnSort.TabIndex = 2;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // lstBooks
            // 
            lstBooks.FormattingEnabled = true;
            lstBooks.ItemHeight = 15;
            lstBooks.Location = new System.Drawing.Point(12, 76);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new System.Drawing.Size(371, 319);
            lstBooks.TabIndex = 3;
            lstBooks.SelectedIndexChanged += OnListSelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            btnAdd.Location = new System.Drawing.Point(410, 730);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(112, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add New Book";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDElete
            // 
            btnDElete.BackColor = System.Drawing.Color.IndianRed;
            btnDElete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            btnDElete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnDElete.Location = new System.Drawing.Point(141, 730);
            btnDElete.Name = "btnDElete";
            btnDElete.Size = new System.Drawing.Size(112, 23);
            btnDElete.TabIndex = 5;
            btnDElete.Text = "Delete selected";
            btnDElete.UseVisualStyleBackColor = false;
            btnDElete.Click += OnDeleteBook;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(11, 730);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(112, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += OnSearch;
            // 
            // lblMain
            // 
            lblMain.AutoSize = true;
            lblMain.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMain.Location = new System.Drawing.Point(457, 0);
            lblMain.Name = "lblMain";
            lblMain.Size = new System.Drawing.Size(262, 28);
            lblMain.TabIndex = 6;
            lblMain.Text = "Information about a book:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblName.Location = new System.Drawing.Point(410, 31);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(43, 15);
            lblName.TabIndex = 7;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.BackColor = System.Drawing.SystemColors.ControlLight;
            txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtName.Location = new System.Drawing.Point(410, 49);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new System.Drawing.Size(380, 23);
            txtName.TabIndex = 8;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblAuthor.Location = new System.Drawing.Point(410, 81);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new System.Drawing.Size(49, 15);
            lblAuthor.TabIndex = 7;
            lblAuthor.Text = "Author:";
            // 
            // txtAuthor
            // 
            txtAuthor.BackColor = System.Drawing.SystemColors.ControlLight;
            txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtAuthor.Location = new System.Drawing.Point(410, 100);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.ReadOnly = true;
            txtAuthor.Size = new System.Drawing.Size(380, 23);
            txtAuthor.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(410, 132);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 15);
            label1.TabIndex = 7;
            label1.Text = "Series:";
            // 
            // txtSeries
            // 
            txtSeries.BackColor = System.Drawing.SystemColors.ControlLight;
            txtSeries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSeries.Location = new System.Drawing.Point(410, 151);
            txtSeries.Name = "txtSeries";
            txtSeries.ReadOnly = true;
            txtSeries.Size = new System.Drawing.Size(380, 23);
            txtSeries.TabIndex = 8;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblGenre.Location = new System.Drawing.Point(410, 183);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new System.Drawing.Size(45, 15);
            lblGenre.TabIndex = 7;
            lblGenre.Text = "Genre:";
            // 
            // cmbGenre
            // 
            cmbGenre.BackColor = System.Drawing.SystemColors.ControlLight;
            cmbGenre.Enabled = false;
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new System.Drawing.Point(410, 202);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new System.Drawing.Size(380, 23);
            cmbGenre.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(410, 398);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 15);
            label2.TabIndex = 7;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(410, 234);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 15);
            label3.TabIndex = 7;
            label3.Text = "Formats List:";
            // 
            // cmbFormat
            // 
            cmbFormat.BackColor = System.Drawing.SystemColors.ControlLight;
            cmbFormat.Enabled = false;
            cmbFormat.FormattingEnabled = true;
            cmbFormat.Location = new System.Drawing.Point(648, 253);
            cmbFormat.Name = "cmbFormat";
            cmbFormat.Size = new System.Drawing.Size(142, 23);
            cmbFormat.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(410, 346);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(101, 15);
            label4.TabIndex = 7;
            label4.Text = "Duration (hours):";
            // 
            // txtDuration
            // 
            txtDuration.BackColor = System.Drawing.SystemColors.ControlLight;
            txtDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtDuration.Location = new System.Drawing.Point(410, 368);
            txtDuration.Name = "txtDuration";
            txtDuration.ReadOnly = true;
            txtDuration.Size = new System.Drawing.Size(133, 23);
            txtDuration.TabIndex = 8;
            // 
            // txtRating
            // 
            txtRating.BackColor = System.Drawing.SystemColors.ControlLight;
            txtRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtRating.Location = new System.Drawing.Point(569, 368);
            txtRating.Name = "txtRating";
            txtRating.ReadOnly = true;
            txtRating.Size = new System.Drawing.Size(133, 23);
            txtRating.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(569, 346);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(46, 15);
            label5.TabIndex = 7;
            label5.Text = "Rating:";
            // 
            // btnAddGenre
            // 
            btnAddGenre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAddGenre.Image = (System.Drawing.Image)resources.GetObject("btnAddGenre.Image");
            btnAddGenre.Location = new System.Drawing.Point(798, 202);
            btnAddGenre.Name = "btnAddGenre";
            btnAddGenre.Size = new System.Drawing.Size(29, 23);
            btnAddGenre.TabIndex = 10;
            btnAddGenre.UseVisualStyleBackColor = true;
            btnAddGenre.Click += OnAddGenre;
            // 
            // btnAddFormat
            // 
            btnAddFormat.Image = (System.Drawing.Image)resources.GetObject("btnAddFormat.Image");
            btnAddFormat.Location = new System.Drawing.Point(796, 253);
            btnAddFormat.Name = "btnAddFormat";
            btnAddFormat.Size = new System.Drawing.Size(29, 23);
            btnAddFormat.TabIndex = 10;
            btnAddFormat.UseVisualStyleBackColor = true;
            btnAddFormat.Click += OnAddFormat;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(728, 346);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(63, 15);
            label6.TabIndex = 7;
            label6.Text = "Language:";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            txtDescription.Location = new System.Drawing.Point(410, 423);
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new System.Drawing.Size(452, 301);
            txtDescription.TabIndex = 12;
            txtDescription.Text = "";
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(579, 730);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(112, 23);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // pictBox
            // 
            pictBox.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictBox.BackgroundImage");
            pictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pictBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictBox.InitialImage = (System.Drawing.Image)resources.GetObject("pictBox.InitialImage");
            pictBox.Location = new System.Drawing.Point(12, 423);
            pictBox.Name = "pictBox";
            pictBox.Size = new System.Drawing.Size(371, 301);
            pictBox.TabIndex = 14;
            pictBox.TabStop = false;
            // 
            // btnSelectPict
            // 
            btnSelectPict.BackColor = System.Drawing.SystemColors.ControlDark;
            btnSelectPict.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnSelectPict.Location = new System.Drawing.Point(271, 730);
            btnSelectPict.Name = "btnSelectPict";
            btnSelectPict.Size = new System.Drawing.Size(112, 23);
            btnSelectPict.TabIndex = 15;
            btnSelectPict.Text = "Select Picture";
            btnSelectPict.UseVisualStyleBackColor = false;
            btnSelectPict.Visible = false;
            btnSelectPict.Click += OnSelectPicture;
            // 
            // btnFinishEdit
            // 
            btnFinishEdit.Location = new System.Drawing.Point(748, 730);
            btnFinishEdit.Name = "btnFinishEdit";
            btnFinishEdit.Size = new System.Drawing.Size(112, 23);
            btnFinishEdit.TabIndex = 16;
            btnFinishEdit.Text = "Finish Edit";
            btnFinishEdit.UseVisualStyleBackColor = true;
            btnFinishEdit.Visible = false;
            btnFinishEdit.Click += OnFinishEdit;
            // 
            // btnRemoveGenre
            // 
            btnRemoveGenre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRemoveGenre.Image = (System.Drawing.Image)resources.GetObject("btnRemoveGenre.Image");
            btnRemoveGenre.Location = new System.Drawing.Point(833, 202);
            btnRemoveGenre.Name = "btnRemoveGenre";
            btnRemoveGenre.Size = new System.Drawing.Size(29, 23);
            btnRemoveGenre.TabIndex = 10;
            btnRemoveGenre.UseVisualStyleBackColor = true;
            btnRemoveGenre.Click += OnRemoveGenre;
            // 
            // btnRemoveFormat
            // 
            btnRemoveFormat.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRemoveFormat.Image = (System.Drawing.Image)resources.GetObject("btnRemoveFormat.Image");
            btnRemoveFormat.Location = new System.Drawing.Point(831, 253);
            btnRemoveFormat.Name = "btnRemoveFormat";
            btnRemoveFormat.Size = new System.Drawing.Size(29, 23);
            btnRemoveFormat.TabIndex = 10;
            btnRemoveFormat.UseVisualStyleBackColor = true;
            btnRemoveFormat.Click += OnRemoveFormat;
            // 
            // txtListFormats
            // 
            txtListFormats.BackColor = System.Drawing.SystemColors.ControlLight;
            txtListFormats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtListFormats.Location = new System.Drawing.Point(410, 253);
            txtListFormats.Name = "txtListFormats";
            txtListFormats.ReadOnly = true;
            txtListFormats.Size = new System.Drawing.Size(195, 23);
            txtListFormats.TabIndex = 17;
            // 
            // btnAddFormatToList
            // 
            btnAddFormatToList.Image = (System.Drawing.Image)resources.GetObject("btnAddFormatToList.Image");
            btnAddFormatToList.Location = new System.Drawing.Point(611, 253);
            btnAddFormatToList.Name = "btnAddFormatToList";
            btnAddFormatToList.Size = new System.Drawing.Size(31, 23);
            btnAddFormatToList.TabIndex = 18;
            btnAddFormatToList.UseVisualStyleBackColor = true;
            btnAddFormatToList.Click += AddFormatToList;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(11, 398);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(75, 15);
            label8.TabIndex = 7;
            label8.Text = "Book Cover:";
            // 
            // cmbShowKind
            // 
            cmbShowKind.FormattingEnabled = true;
            cmbShowKind.Location = new System.Drawing.Point(77, 14);
            cmbShowKind.Name = "cmbShowKind";
            cmbShowKind.Size = new System.Drawing.Size(227, 23);
            cmbShowKind.TabIndex = 22;
            cmbShowKind.SelectedIndexChanged += OnShowKindChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(12, 17);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(58, 15);
            label9.TabIndex = 21;
            label9.Text = "Show just";
            // 
            // cmbLang
            // 
            cmbLang.BackColor = System.Drawing.SystemColors.ControlLight;
            cmbLang.Enabled = false;
            cmbLang.FormattingEnabled = true;
            cmbLang.Location = new System.Drawing.Point(728, 368);
            cmbLang.Name = "cmbLang";
            cmbLang.Size = new System.Drawing.Size(133, 23);
            cmbLang.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(410, 285);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(65, 15);
            label7.TabIndex = 7;
            label7.Text = "Keywords:";
            // 
            // cmbKeywords
            // 
            cmbKeywords.BackColor = System.Drawing.SystemColors.ControlLight;
            cmbKeywords.Enabled = false;
            cmbKeywords.FormattingEnabled = true;
            cmbKeywords.Location = new System.Drawing.Point(648, 304);
            cmbKeywords.Name = "cmbKeywords";
            cmbKeywords.Size = new System.Drawing.Size(142, 23);
            cmbKeywords.TabIndex = 9;
            // 
            // btnRemoveKW
            // 
            btnRemoveKW.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRemoveKW.Image = (System.Drawing.Image)resources.GetObject("btnRemoveKW.Image");
            btnRemoveKW.Location = new System.Drawing.Point(831, 304);
            btnRemoveKW.Name = "btnRemoveKW";
            btnRemoveKW.Size = new System.Drawing.Size(29, 23);
            btnRemoveKW.TabIndex = 10;
            btnRemoveKW.UseVisualStyleBackColor = true;
            btnRemoveKW.Click += btnRemoveKW_Click;
            // 
            // btnAddKW
            // 
            btnAddKW.Image = (System.Drawing.Image)resources.GetObject("btnAddKW.Image");
            btnAddKW.Location = new System.Drawing.Point(796, 304);
            btnAddKW.Name = "btnAddKW";
            btnAddKW.Size = new System.Drawing.Size(29, 23);
            btnAddKW.TabIndex = 10;
            btnAddKW.UseVisualStyleBackColor = true;
            btnAddKW.Click += btnAddKW_Click;
            // 
            // txtKeywords
            // 
            txtKeywords.BackColor = System.Drawing.SystemColors.ControlLight;
            txtKeywords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtKeywords.Location = new System.Drawing.Point(410, 304);
            txtKeywords.Name = "txtKeywords";
            txtKeywords.ReadOnly = true;
            txtKeywords.Size = new System.Drawing.Size(195, 23);
            txtKeywords.TabIndex = 17;
            // 
            // btnAddKWtoList
            // 
            btnAddKWtoList.Image = (System.Drawing.Image)resources.GetObject("btnAddKWtoList.Image");
            btnAddKWtoList.Location = new System.Drawing.Point(611, 304);
            btnAddKWtoList.Name = "btnAddKWtoList";
            btnAddKWtoList.Size = new System.Drawing.Size(31, 23);
            btnAddKWtoList.TabIndex = 18;
            btnAddKWtoList.UseVisualStyleBackColor = true;
            btnAddKWtoList.Click += btnAddKWtoList_Click;
            // 
            // MainLib
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(874, 761);
            Controls.Add(cmbShowKind);
            Controls.Add(label9);
            Controls.Add(btnAddKWtoList);
            Controls.Add(btnAddFormatToList);
            Controls.Add(txtKeywords);
            Controls.Add(txtListFormats);
            Controls.Add(btnFinishEdit);
            Controls.Add(btnSelectPict);
            Controls.Add(pictBox);
            Controls.Add(btnEdit);
            Controls.Add(txtDescription);
            Controls.Add(btnAddKW);
            Controls.Add(cmbLang);
            Controls.Add(btnRemoveKW);
            Controls.Add(btnAddFormat);
            Controls.Add(btnRemoveFormat);
            Controls.Add(btnRemoveGenre);
            Controls.Add(cmbKeywords);
            Controls.Add(btnAddGenre);
            Controls.Add(cmbFormat);
            Controls.Add(cmbGenre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtRating);
            Controls.Add(txtDuration);
            Controls.Add(label7);
            Controls.Add(txtSeries);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(lblGenre);
            Controls.Add(label1);
            Controls.Add(txtAuthor);
            Controls.Add(lblAuthor);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblMain);
            Controls.Add(btnDElete);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(lstBooks);
            Controls.Add(btnSort);
            Controls.Add(cmbSortCriterion);
            Controls.Add(lblSort);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainLib";
            Text = "Библиотека Танюшечки Ивановой (v. 2.1)";
            ((System.ComponentModel.ISupportInitialize)pictBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbShowKind;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbLang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbKeywords;
        private System.Windows.Forms.Button btnRemoveKW;
        private System.Windows.Forms.Button btnAddKW;
        private System.Windows.Forms.TextBox txtKeywords;
        private System.Windows.Forms.Button btnAddKWtoList;
    }
}

