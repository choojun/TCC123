namespace U1_UPE_StateCapital_Q1
{
    partial class Form1
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
            this.btnPerak = new System.Windows.Forms.Button();
            this.btnPenang = new System.Windows.Forms.Button();
            this.btnJohor = new System.Windows.Forms.Button();
            this.btnSelangor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCap = new System.Windows.Forms.Label();
            this.lblCapital = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPerak
            // 
            this.btnPerak.Location = new System.Drawing.Point(22, 83);
            this.btnPerak.Name = "btnPerak";
            this.btnPerak.Size = new System.Drawing.Size(75, 23);
            this.btnPerak.TabIndex = 0;
            this.btnPerak.Text = "Perak";
            this.btnPerak.UseVisualStyleBackColor = true;
            this.btnPerak.Click += new System.EventHandler(this.btnPerak_Click);
            // 
            // btnPenang
            // 
            this.btnPenang.Location = new System.Drawing.Point(22, 112);
            this.btnPenang.Name = "btnPenang";
            this.btnPenang.Size = new System.Drawing.Size(75, 23);
            this.btnPenang.TabIndex = 1;
            this.btnPenang.Text = "Penang";
            this.btnPenang.UseVisualStyleBackColor = true;
            this.btnPenang.Click += new System.EventHandler(this.btnPenang_Click);
            // 
            // btnJohor
            // 
            this.btnJohor.Location = new System.Drawing.Point(22, 141);
            this.btnJohor.Name = "btnJohor";
            this.btnJohor.Size = new System.Drawing.Size(75, 23);
            this.btnJohor.TabIndex = 2;
            this.btnJohor.Text = "Johor";
            this.btnJohor.UseVisualStyleBackColor = true;
            this.btnJohor.Click += new System.EventHandler(this.btnJohor_Click);
            // 
            // btnSelangor
            // 
            this.btnSelangor.Location = new System.Drawing.Point(22, 170);
            this.btnSelangor.Name = "btnSelangor";
            this.btnSelangor.Size = new System.Drawing.Size(75, 23);
            this.btnSelangor.TabIndex = 3;
            this.btnSelangor.Text = "Selangor";
            this.btnSelangor.UseVisualStyleBackColor = true;
            this.btnSelangor.Click += new System.EventHandler(this.btnSelangor_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(200, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCap
            // 
            this.lblCap.AutoSize = true;
            this.lblCap.Location = new System.Drawing.Point(55, 42);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(42, 13);
            this.lblCap.TabIndex = 5;
            this.lblCap.Text = "Capital:";
            // 
            // lblCapital
            // 
            this.lblCapital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCapital.Location = new System.Drawing.Point(144, 42);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(100, 28);
            this.lblCapital.TabIndex = 6;
            this.lblCapital.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 205);
            this.Controls.Add(this.lblCapital);
            this.Controls.Add(this.lblCap);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSelangor);
            this.Controls.Add(this.btnJohor);
            this.Controls.Add(this.btnPenang);
            this.Controls.Add(this.btnPerak);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State Capitals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPerak;
        private System.Windows.Forms.Button btnPenang;
        private System.Windows.Forms.Button btnJohor;
        private System.Windows.Forms.Button btnSelangor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCap;
        private System.Windows.Forms.Label lblCapital;
    }
}

