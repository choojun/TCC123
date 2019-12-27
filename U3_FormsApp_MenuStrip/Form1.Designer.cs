namespace U3_FormsApp_MenuStrip
{
    partial class frmMenuStrip
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
            this.picWou = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPictureVisible = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPictureSizeSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPictureSizeLarge = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picWou)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picWou
            // 
            this.picWou.Image = global::U3_FormsApp_MenuStrip.Properties.Resources.WOU;
            this.picWou.Location = new System.Drawing.Point(12, 36);
            this.picWou.Name = "picWou";
            this.picWou.Size = new System.Drawing.Size(232, 157);
            this.picWou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWou.TabIndex = 0;
            this.picWou.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.pictureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(256, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureToolStripMenuItem
            // 
            this.pictureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPictureVisible,
            this.sizeToolStripMenuItem});
            this.pictureToolStripMenuItem.Name = "pictureToolStripMenuItem";
            this.pictureToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.pictureToolStripMenuItem.Text = "Picture";
            // 
            // mnuPictureVisible
            // 
            this.mnuPictureVisible.Checked = true;
            this.mnuPictureVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuPictureVisible.Name = "mnuPictureVisible";
            this.mnuPictureVisible.Size = new System.Drawing.Size(108, 22);
            this.mnuPictureVisible.Text = "Visible";
            this.mnuPictureVisible.Click += new System.EventHandler(this.visibleToolStripMenuItem_Click);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPictureSizeSmall,
            this.mnuPictureSizeLarge});
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // mnuPictureSizeSmall
            // 
            this.mnuPictureSizeSmall.Name = "mnuPictureSizeSmall";
            this.mnuPictureSizeSmall.Size = new System.Drawing.Size(103, 22);
            this.mnuPictureSizeSmall.Text = "Small";
            this.mnuPictureSizeSmall.Click += new System.EventHandler(this.mnuPictureSizeSmall_Click);
            // 
            // mnuPictureSizeLarge
            // 
            this.mnuPictureSizeLarge.Checked = true;
            this.mnuPictureSizeLarge.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuPictureSizeLarge.Name = "mnuPictureSizeLarge";
            this.mnuPictureSizeLarge.Size = new System.Drawing.Size(103, 22);
            this.mnuPictureSizeLarge.Text = "Large";
            this.mnuPictureSizeLarge.Click += new System.EventHandler(this.largeToolStripMenuItem_Click);
            // 
            // frmMenuStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 205);
            this.Controls.Add(this.picWou);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuStrip";
            this.Text = "MenuStrip";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWou)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picWou;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPictureVisible;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPictureSizeSmall;
        private System.Windows.Forms.ToolStripMenuItem mnuPictureSizeLarge;
    }
}

