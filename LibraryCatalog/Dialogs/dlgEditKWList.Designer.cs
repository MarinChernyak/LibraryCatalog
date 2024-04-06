namespace LibraryCatalog.Dialogs
{
    partial class dlgEditKWList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgEditKWList));
            btnGetKW = new System.Windows.Forms.Button();
            btnRemoveKW = new System.Windows.Forms.Button();
            btnDrillDown = new System.Windows.Forms.Button();
            btnDrillUp = new System.Windows.Forms.Button();
            lstKWExist = new System.Windows.Forms.ListBox();
            lstKWSelected = new System.Windows.Forms.ListBox();
            btnNewKW = new System.Windows.Forms.Button();
            btnDelKW = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnGetKW
            // 
            btnGetKW.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnGetKW.Image = (System.Drawing.Image)resources.GetObject("btnGetKW.Image");
            btnGetKW.Location = new System.Drawing.Point(206, 51);
            btnGetKW.Name = "btnGetKW";
            btnGetKW.Size = new System.Drawing.Size(29, 23);
            btnGetKW.TabIndex = 10;
            btnGetKW.UseVisualStyleBackColor = true;
            // 
            // btnRemoveKW
            // 
            btnRemoveKW.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRemoveKW.Image = (System.Drawing.Image)resources.GetObject("btnRemoveKW.Image");
            btnRemoveKW.Location = new System.Drawing.Point(206, 80);
            btnRemoveKW.Name = "btnRemoveKW";
            btnRemoveKW.Size = new System.Drawing.Size(29, 23);
            btnRemoveKW.TabIndex = 10;
            btnRemoveKW.UseVisualStyleBackColor = true;
            // 
            // btnDrillDown
            // 
            btnDrillDown.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDrillDown.Image = (System.Drawing.Image)resources.GetObject("btnDrillDown.Image");
            btnDrillDown.Location = new System.Drawing.Point(206, 109);
            btnDrillDown.Name = "btnDrillDown";
            btnDrillDown.Size = new System.Drawing.Size(29, 23);
            btnDrillDown.TabIndex = 10;
            btnDrillDown.UseVisualStyleBackColor = true;
            // 
            // btnDrillUp
            // 
            btnDrillUp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDrillUp.Image = (System.Drawing.Image)resources.GetObject("btnDrillUp.Image");
            btnDrillUp.Location = new System.Drawing.Point(206, 138);
            btnDrillUp.Name = "btnDrillUp";
            btnDrillUp.Size = new System.Drawing.Size(29, 23);
            btnDrillUp.TabIndex = 10;
            btnDrillUp.UseVisualStyleBackColor = true;
            // 
            // lstKWExist
            // 
            lstKWExist.FormattingEnabled = true;
            lstKWExist.ItemHeight = 15;
            lstKWExist.Location = new System.Drawing.Point(21, 32);
            lstKWExist.Name = "lstKWExist";
            lstKWExist.Size = new System.Drawing.Size(179, 259);
            lstKWExist.TabIndex = 23;
            // 
            // lstKWSelected
            // 
            lstKWSelected.FormattingEnabled = true;
            lstKWSelected.ItemHeight = 15;
            lstKWSelected.Location = new System.Drawing.Point(250, 32);
            lstKWSelected.Name = "lstKWSelected";
            lstKWSelected.Size = new System.Drawing.Size(179, 259);
            lstKWSelected.TabIndex = 23;
            // 
            // btnNewKW
            // 
            btnNewKW.BackColor = System.Drawing.Color.Gray;
            btnNewKW.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnNewKW.Location = new System.Drawing.Point(21, 297);
            btnNewKW.Name = "btnNewKW";
            btnNewKW.Size = new System.Drawing.Size(75, 23);
            btnNewKW.TabIndex = 24;
            btnNewKW.Text = "New KW";
            btnNewKW.UseVisualStyleBackColor = false;
            // 
            // btnDelKW
            // 
            btnDelKW.BackColor = System.Drawing.Color.Salmon;
            btnDelKW.Location = new System.Drawing.Point(102, 297);
            btnDelKW.Name = "btnDelKW";
            btnDelKW.Size = new System.Drawing.Size(75, 23);
            btnDelKW.TabIndex = 24;
            btnDelKW.Text = "Delete KW";
            btnDelKW.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Gray;
            button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            button2.Location = new System.Drawing.Point(28, 336);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 32;
            button2.Text = "New KW";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Salmon;
            button1.Location = new System.Drawing.Point(109, 336);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 31;
            button1.Text = "Delete KW";
            button1.UseVisualStyleBackColor = false;
            // 
            // dlgEditKWList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(448, 369);
            Controls.Add(button1);
            Controls.Add(button2);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "dlgEditKWList";
            Text = "Edit keywords ";
            Load += dlgEditKWList_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnGetKW;
        private System.Windows.Forms.Button btnRemoveKW;
        private System.Windows.Forms.Button btnDrillDown;
        private System.Windows.Forms.Button btnDrillUp;
        private System.Windows.Forms.ListBox lstKWExist;
        private System.Windows.Forms.ListBox lstKWSelected;
        private System.Windows.Forms.Button btnNewKW;
        private System.Windows.Forms.Button btnDelKW;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}