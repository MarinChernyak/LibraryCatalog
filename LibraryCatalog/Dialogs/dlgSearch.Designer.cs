
namespace LibraryCatalog.Dialogs
{
    partial class dlgSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgSearch));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            textAuthor = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            textFormat = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            textSeries = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            txtKeyword = new System.Windows.Forms.TextBox();
            lblKeyword = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(13, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Serarch by...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 42);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(94, 15);
            label2.TabIndex = 1;
            label2.Text = "Name of  book *";
            // 
            // textName
            // 
            textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textName.Location = new System.Drawing.Point(12, 60);
            textName.Name = "textName";
            textName.Size = new System.Drawing.Size(270, 23);
            textName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(16, 95);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(102, 15);
            label3.TabIndex = 1;
            label3.Text = "Name of  author *";
            // 
            // textAuthor
            // 
            textAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textAuthor.Location = new System.Drawing.Point(12, 113);
            textAuthor.Name = "textAuthor";
            textAuthor.Size = new System.Drawing.Size(270, 23);
            textAuthor.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 148);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(53, 15);
            label4.TabIndex = 1;
            label4.Text = "Format *";
            // 
            // textFormat
            // 
            textFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textFormat.Location = new System.Drawing.Point(12, 166);
            textFormat.Name = "textFormat";
            textFormat.Size = new System.Drawing.Size(270, 23);
            textFormat.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 201);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(45, 15);
            label5.TabIndex = 1;
            label5.Text = "Series *";
            // 
            // textSeries
            // 
            textSeries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textSeries.Location = new System.Drawing.Point(12, 219);
            textSeries.Name = "textSeries";
            textSeries.Size = new System.Drawing.Size(270, 23);
            textSeries.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(12, 323);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(75, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += OnSearch;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(93, 323);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.DarkRed;
            label6.Location = new System.Drawing.Point(12, 295);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(272, 21);
            label6.TabIndex = 5;
            label6.Text = "* - Enter  full or a part of the  value";
            // 
            // txtKeyword
            // 
            txtKeyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtKeyword.Location = new System.Drawing.Point(13, 269);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new System.Drawing.Size(270, 23);
            txtKeyword.TabIndex = 2;
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Location = new System.Drawing.Point(13, 251);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new System.Drawing.Size(53, 15);
            lblKeyword.TabIndex = 1;
            lblKeyword.Text = "Keyword";
            // 
            // dlgSearch
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(299, 357);
            Controls.Add(label6);
            Controls.Add(btnCancel);
            Controls.Add(btnSearch);
            Controls.Add(txtKeyword);
            Controls.Add(textSeries);
            Controls.Add(lblKeyword);
            Controls.Add(label5);
            Controls.Add(textFormat);
            Controls.Add(label4);
            Controls.Add(textAuthor);
            Controls.Add(label3);
            Controls.Add(textName);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "dlgSearch";
            Text = "Search book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textFormat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSeries;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label lblKeyword;
    }
}