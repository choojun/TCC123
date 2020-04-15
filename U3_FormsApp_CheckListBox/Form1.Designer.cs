namespace U3_FormsApp_CheckListBox
{
    partial class fromCheckListBox
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
            this.chkLstProgramming = new System.Windows.Forms.CheckedListBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lstProgramming = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // chkLstProgramming
            // 
            this.chkLstProgramming.FormattingEnabled = true;
            this.chkLstProgramming.Items.AddRange(new object[] {
            "C#",
            "Visual Basic",
            "Java",
            "C",
            "Python",
            "Perl",
            "Ruby"});
            this.chkLstProgramming.Location = new System.Drawing.Point(12, 12);
            this.chkLstProgramming.Name = "chkLstProgramming";
            this.chkLstProgramming.Size = new System.Drawing.Size(107, 94);
            this.chkLstProgramming.TabIndex = 0;
            this.chkLstProgramming.SelectedIndexChanged += new System.EventHandler(this.chkLstProgramming_SelectedIndexChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 120);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 2;
            // 
            // lstProgramming
            // 
            this.lstProgramming.FormattingEnabled = true;
            this.lstProgramming.Location = new System.Drawing.Point(144, 11);
            this.lstProgramming.Name = "lstProgramming";
            this.lstProgramming.Size = new System.Drawing.Size(100, 95);
            this.lstProgramming.TabIndex = 3;
            // 
            // fromCheckListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 205);
            this.Controls.Add(this.lstProgramming);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.chkLstProgramming);
            this.Name = "fromCheckListBox";
            this.Text = "CheckListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkLstProgramming;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ListBox lstProgramming;
    }
}

