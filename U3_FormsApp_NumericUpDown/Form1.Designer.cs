namespace U3_FormsApp_NumericUpDown
{
    partial class frmNumericUpDown
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
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.lblYearlyPayment = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Location = new System.Drawing.Point(21, 18);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(111, 13);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "House Loan Principal:";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(21, 39);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(88, 13);
            this.lblRate.TabIndex = 1;
            this.lblRate.Text = "Interest Rate (%):";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(21, 62);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(37, 13);
            this.lblYears.TabIndex = 2;
            this.lblYears.Text = "Years:";
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Location = new System.Drawing.Point(139, 18);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(100, 20);
            this.txtPrincipal.TabIndex = 3;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(139, 39);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 20);
            this.txtRate.TabIndex = 4;
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(139, 60);
            this.nudYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.ReadOnly = true;
            this.nudYear.Size = new System.Drawing.Size(100, 20);
            this.nudYear.TabIndex = 5;
            this.nudYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblYearlyPayment
            // 
            this.lblYearlyPayment.AutoSize = true;
            this.lblYearlyPayment.Location = new System.Drawing.Point(24, 88);
            this.lblYearlyPayment.Name = "lblYearlyPayment";
            this.lblYearlyPayment.Size = new System.Drawing.Size(83, 13);
            this.lblYearlyPayment.TabIndex = 6;
            this.lblYearlyPayment.Text = "Yearly Payment:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(163, 88);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(27, 117);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplay.Size = new System.Drawing.Size(211, 76);
            this.txtDisplay.TabIndex = 8;
            // 
            // frmNumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 205);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblYearlyPayment);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblPrincipal);
            this.Name = "frmNumericUpDown";
            this.Text = "NumericUpDown";
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Label lblYearlyPayment;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtDisplay;
    }
}

