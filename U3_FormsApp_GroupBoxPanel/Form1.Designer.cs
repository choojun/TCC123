namespace U3_FormsApp_GroupBoxPanel
{
    partial class frmGroupBoxPanel
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
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.btnCSharp = new System.Windows.Forms.Button();
            this.btnVB = new System.Windows.Forms.Button();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpMain.SuspendLayout();
            this.PnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.btnCSharp);
            this.grpMain.Controls.Add(this.btnVB);
            this.grpMain.Location = new System.Drawing.Point(25, 24);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(200, 57);
            this.grpMain.TabIndex = 0;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "Programming Languages";
            // 
            // btnCSharp
            // 
            this.btnCSharp.Location = new System.Drawing.Point(119, 19);
            this.btnCSharp.Name = "btnCSharp";
            this.btnCSharp.Size = new System.Drawing.Size(75, 23);
            this.btnCSharp.TabIndex = 1;
            this.btnCSharp.Text = "C#";
            this.btnCSharp.UseVisualStyleBackColor = true;
            this.btnCSharp.Click += new System.EventHandler(this.btnCSharp_Click);
            // 
            // btnVB
            // 
            this.btnVB.Location = new System.Drawing.Point(6, 19);
            this.btnVB.Name = "btnVB";
            this.btnVB.Size = new System.Drawing.Size(75, 23);
            this.btnVB.TabIndex = 0;
            this.btnVB.Text = "Visual Basic";
            this.btnVB.UseVisualStyleBackColor = true;
            this.btnVB.Click += new System.EventHandler(this.btnVB_Click);
            // 
            // PnlMain
            // 
            this.PnlMain.AutoScroll = true;
            this.PnlMain.Controls.Add(this.btnRight);
            this.PnlMain.Controls.Add(this.btnLeft);
            this.PnlMain.Location = new System.Drawing.Point(25, 128);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(200, 65);
            this.PnlMain.TabIndex = 1;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(155, 12);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(-28, 12);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(25, 88);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 2;
            // 
            // frmGroupBoxPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 205);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.grpMain);
            this.Name = "frmGroupBoxPanel";
            this.Text = "GroupBox & Panel";
            this.grpMain.ResumeLayout(false);
            this.PnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.Button btnCSharp;
        private System.Windows.Forms.Button btnVB;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Label lblMessage;
    }
}

