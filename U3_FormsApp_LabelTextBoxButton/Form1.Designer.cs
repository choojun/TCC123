namespace U3_FormsApp_LabelTextBoxButton
{
    partial class frmLabelTextBoxButton
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
            this.lblInputPass = new System.Windows.Forms.Label();
            this.txtInputPassword = new System.Windows.Forms.TextBox();
            this.btnDisplayPassword = new System.Windows.Forms.Button();
            this.txtDisplayPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInputPass
            // 
            this.lblInputPass.AutoSize = true;
            this.lblInputPass.Location = new System.Drawing.Point(13, 25);
            this.lblInputPass.Name = "lblInputPass";
            this.lblInputPass.Size = new System.Drawing.Size(56, 13);
            this.lblInputPass.TabIndex = 0;
            this.lblInputPass.Text = "Password:";
            // 
            // txtInputPassword
            // 
            this.txtInputPassword.Location = new System.Drawing.Point(76, 25);
            this.txtInputPassword.Name = "txtInputPassword";
            this.txtInputPassword.PasswordChar = '*';
            this.txtInputPassword.Size = new System.Drawing.Size(100, 20);
            this.txtInputPassword.TabIndex = 1;
            // 
            // btnDisplayPassword
            // 
            this.btnDisplayPassword.Location = new System.Drawing.Point(79, 103);
            this.btnDisplayPassword.Name = "btnDisplayPassword";
            this.btnDisplayPassword.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayPassword.TabIndex = 3;
            this.btnDisplayPassword.Text = "Show Password";
            this.btnDisplayPassword.UseVisualStyleBackColor = true;
            this.btnDisplayPassword.Click += new System.EventHandler(this.btnDisplayPassword_Click);
            // 
            // txtDisplayPassword
            // 
            this.txtDisplayPassword.Location = new System.Drawing.Point(76, 52);
            this.txtDisplayPassword.Name = "txtDisplayPassword";
            this.txtDisplayPassword.ReadOnly = true;
            this.txtDisplayPassword.Size = new System.Drawing.Size(100, 20);
            this.txtDisplayPassword.TabIndex = 4;
            // 
            // frmLabelTextBoxButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 205);
            this.Controls.Add(this.txtDisplayPassword);
            this.Controls.Add(this.btnDisplayPassword);
            this.Controls.Add(this.txtInputPassword);
            this.Controls.Add(this.lblInputPass);
            this.Name = "frmLabelTextBoxButton";
            this.Text = "Label, TextBox & Button";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputPass;
        private System.Windows.Forms.TextBox txtInputPassword;
        private System.Windows.Forms.Button btnDisplayPassword;
        private System.Windows.Forms.TextBox txtDisplayPassword;
    }
}

