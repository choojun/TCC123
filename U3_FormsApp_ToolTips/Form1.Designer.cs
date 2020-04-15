namespace U3_FormsApp_ToolTips
{
    partial class frmToolTip
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
            this.components = new System.ComponentModel.Container();
            this.lblVB = new System.Windows.Forms.Label();
            this.lblCSharp = new System.Windows.Forms.Label();
            this.lblToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblVB
            // 
            this.lblVB.AutoSize = true;
            this.lblVB.Location = new System.Drawing.Point(61, 34);
            this.lblVB.Name = "lblVB";
            this.lblVB.Size = new System.Drawing.Size(64, 13);
            this.lblVB.TabIndex = 0;
            this.lblVB.Text = "Visual Basic";
            this.lblToolTip.SetToolTip(this.lblVB, "Visual Basic");
            this.lblVB.Click += new System.EventHandler(this.lblVB_Click);
            // 
            // lblCSharp
            // 
            this.lblCSharp.AutoSize = true;
            this.lblCSharp.Location = new System.Drawing.Point(64, 61);
            this.lblCSharp.Name = "lblCSharp";
            this.lblCSharp.Size = new System.Drawing.Size(21, 13);
            this.lblCSharp.TabIndex = 1;
            this.lblCSharp.Text = "C#";
            this.lblToolTip.SetToolTip(this.lblCSharp, "C#");
            // 
            // frmToolTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 205);
            this.Controls.Add(this.lblCSharp);
            this.Controls.Add(this.lblVB);
            this.Name = "frmToolTip";
            this.Text = "ToolTip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVB;
        private System.Windows.Forms.Label lblCSharp;
        private System.Windows.Forms.ToolTip lblToolTip;
    }
}

