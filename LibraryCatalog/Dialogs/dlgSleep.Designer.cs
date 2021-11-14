
namespace LibraryCatalog.Dialogs
{
    partial class dlgSleep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgSleep));
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.pictBox = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btn5Min = new System.Windows.Forms.Button();
            this.btn10min = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNote.ForeColor = System.Drawing.Color.Brown;
            this.txtNote.Location = new System.Drawing.Point(12, 279);
            this.txtNote.Name = "txtNote";
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(338, 168);
            this.txtNote.TabIndex = 1;
            this.txtNote.Text = "";
            // 
            // pictBox
            // 
            this.pictBox.Location = new System.Drawing.Point(12, 12);
            this.pictBox.Name = "pictBox";
            this.pictBox.Size = new System.Drawing.Size(338, 261);
            this.pictBox.TabIndex = 2;
            this.pictBox.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 455);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Хорошо, иду";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.OnOK);
            // 
            // btn5Min
            // 
            this.btn5Min.Location = new System.Drawing.Point(125, 455);
            this.btn5Min.Name = "btn5Min";
            this.btn5Min.Size = new System.Drawing.Size(112, 23);
            this.btn5Min.TabIndex = 3;
            this.btn5Min.Text = "Через 5 минут";
            this.btn5Min.UseVisualStyleBackColor = true;
            this.btn5Min.Click += new System.EventHandler(this.OnOK5Min);
            // 
            // btn10min
            // 
            this.btn10min.Location = new System.Drawing.Point(238, 454);
            this.btn10min.Name = "btn10min";
            this.btn10min.Size = new System.Drawing.Size(112, 23);
            this.btn10min.TabIndex = 3;
            this.btn10min.Text = "Через 10 минут";
            this.btn10min.UseVisualStyleBackColor = true;
            this.btn10min.Click += new System.EventHandler(this.OnOk10Min);
            // 
            // dlgSleep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 490);
            this.Controls.Add(this.btn10min);
            this.Controls.Add(this.btn5Min);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pictBox);
            this.Controls.Add(this.txtNote);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dlgSleep";
            this.Text = "Пора спать!";
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.PictureBox pictBox;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btn5Min;
        private System.Windows.Forms.Button btn10min;
    }
}