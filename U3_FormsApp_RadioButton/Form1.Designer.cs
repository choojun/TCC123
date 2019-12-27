namespace U3_FormsApp_RadioButton
{
    partial class frmRadioButton
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radVB = new System.Windows.Forms.RadioButton();
            this.radCSharp = new System.Windows.Forms.RadioButton();
            this.txtLang = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radCSharp);
            this.groupBox1.Controls.Add(this.radVB);
            this.groupBox1.Location = new System.Drawing.Point(30, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programming Languages";
            // 
            // radVB
            // 
            this.radVB.AutoSize = true;
            this.radVB.Location = new System.Drawing.Point(7, 20);
            this.radVB.Name = "radVB";
            this.radVB.Size = new System.Drawing.Size(82, 17);
            this.radVB.TabIndex = 0;
            this.radVB.TabStop = true;
            this.radVB.Text = "&Visual Basic";
            this.radVB.UseVisualStyleBackColor = true;
            this.radVB.CheckedChanged += new System.EventHandler(this.radVB_CheckedChanged);
            // 
            // radCSharp
            // 
            this.radCSharp.AutoSize = true;
            this.radCSharp.Location = new System.Drawing.Point(7, 44);
            this.radCSharp.Name = "radCSharp";
            this.radCSharp.Size = new System.Drawing.Size(39, 17);
            this.radCSharp.TabIndex = 1;
            this.radCSharp.TabStop = true;
            this.radCSharp.Text = "&C#";
            this.radCSharp.UseVisualStyleBackColor = true;
            this.radCSharp.CheckedChanged += new System.EventHandler(this.radCSharp_CheckedChanged);
            // 
            // txtLang
            // 
            this.txtLang.Location = new System.Drawing.Point(30, 131);
            this.txtLang.Name = "txtLang";
            this.txtLang.Size = new System.Drawing.Size(200, 20);
            this.txtLang.TabIndex = 1;
            // 
            // frmRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 205);
            this.Controls.Add(this.txtLang);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRadioButton";
            this.Text = "RadioButton";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radCSharp;
        private System.Windows.Forms.RadioButton radVB;
        private System.Windows.Forms.TextBox txtLang;
    }
}

