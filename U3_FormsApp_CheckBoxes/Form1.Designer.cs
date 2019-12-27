namespace U3_FormsApp_CheckBoxes
{
    partial class frmCheckBoxes
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
            this.chkOrange = new System.Windows.Forms.CheckBox();
            this.chkApple = new System.Windows.Forms.CheckBox();
            this.chkGrape = new System.Windows.Forms.CheckBox();
            this.chkPearl = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkOrange
            // 
            this.chkOrange.AutoSize = true;
            this.chkOrange.Location = new System.Drawing.Point(13, 23);
            this.chkOrange.Name = "chkOrange";
            this.chkOrange.Size = new System.Drawing.Size(93, 17);
            this.chkOrange.TabIndex = 0;
            this.chkOrange.Text = "&Orange (RM1)";
            this.chkOrange.UseVisualStyleBackColor = true;
            this.chkOrange.CheckedChanged += new System.EventHandler(this.chkOrange_CheckedChanged);
            // 
            // chkApple
            // 
            this.chkApple.AutoSize = true;
            this.chkApple.Location = new System.Drawing.Point(13, 47);
            this.chkApple.Name = "chkApple";
            this.chkApple.Size = new System.Drawing.Size(99, 17);
            this.chkApple.TabIndex = 1;
            this.chkApple.Text = "&Apple (Rm0.60)";
            this.chkApple.UseVisualStyleBackColor = true;
            this.chkApple.CheckedChanged += new System.EventHandler(this.chkApple_CheckedChanged);
            // 
            // chkGrape
            // 
            this.chkGrape.AutoSize = true;
            this.chkGrape.Location = new System.Drawing.Point(13, 71);
            this.chkGrape.Name = "chkGrape";
            this.chkGrape.Size = new System.Drawing.Size(87, 17);
            this.chkGrape.TabIndex = 2;
            this.chkGrape.Text = "&Grape (RM8)";
            this.chkGrape.UseVisualStyleBackColor = true;
            this.chkGrape.CheckedChanged += new System.EventHandler(this.chkGrape_CheckedChanged);
            // 
            // chkPearl
            // 
            this.chkPearl.AutoSize = true;
            this.chkPearl.Location = new System.Drawing.Point(13, 95);
            this.chkPearl.Name = "chkPearl";
            this.chkPearl.Size = new System.Drawing.Size(82, 17);
            this.chkPearl.TabIndex = 3;
            this.chkPearl.Text = "&Pearl (RM2)";
            this.chkPearl.UseVisualStyleBackColor = true;
            this.chkPearl.CheckedChanged += new System.EventHandler(this.chkPearl_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(13, 143);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(117, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total Amount Payment:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(136, 140);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // frmCheckBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 205);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.chkPearl);
            this.Controls.Add(this.chkGrape);
            this.Controls.Add(this.chkApple);
            this.Controls.Add(this.chkOrange);
            this.Name = "frmCheckBoxes";
            this.Text = "CheckBoxes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkOrange;
        private System.Windows.Forms.CheckBox chkApple;
        private System.Windows.Forms.CheckBox chkGrape;
        private System.Windows.Forms.CheckBox chkPearl;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

