namespace U3_FormsApp_DateTimePicker
{
    partial class frmDateTimePicker
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
            this.dteDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblChoose = new System.Windows.Forms.Label();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dteDateTimePicker
            // 
            this.dteDateTimePicker.Location = new System.Drawing.Point(27, 51);
            this.dteDateTimePicker.Name = "dteDateTimePicker";
            this.dteDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dteDateTimePicker.TabIndex = 0;
            this.dteDateTimePicker.ValueChanged += new System.EventHandler(this.dteDateTimePicker_ValueChanged);
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Location = new System.Drawing.Point(24, 26);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(112, 13);
            this.lblChoose.TabIndex = 1;
            this.lblChoose.Text = "Choose Your Delivery:";
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Location = new System.Drawing.Point(24, 87);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(74, 13);
            this.lblDelivery.TabIndex = 2;
            this.lblDelivery.Text = "Delivery Date:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(24, 116);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 3;
            // 
            // frmDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 205);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblDelivery);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.dteDateTimePicker);
            this.Name = "frmDateTimePicker";
            this.Text = "DateTimePicker";
            this.Load += new System.EventHandler(this.frmDateTimePicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dteDateTimePicker;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Label lblMessage;
    }
}

