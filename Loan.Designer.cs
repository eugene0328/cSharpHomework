
namespace MyHomework
{
    partial class Loan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loan));
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.txtDeadLine = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLoan
            // 
            this.txtLoan.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtLoan.Font = new System.Drawing.Font("新細明體", 14F);
            this.txtLoan.ForeColor = System.Drawing.Color.IndianRed;
            this.txtLoan.Location = new System.Drawing.Point(141, 66);
            this.txtLoan.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(138, 30);
            this.txtLoan.TabIndex = 0;
            this.txtLoan.Text = "100000";
            // 
            // txtDeadLine
            // 
            this.txtDeadLine.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtDeadLine.Font = new System.Drawing.Font("新細明體", 14F);
            this.txtDeadLine.ForeColor = System.Drawing.Color.IndianRed;
            this.txtDeadLine.Location = new System.Drawing.Point(141, 110);
            this.txtDeadLine.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeadLine.Name = "txtDeadLine";
            this.txtDeadLine.Size = new System.Drawing.Size(138, 30);
            this.txtDeadLine.TabIndex = 1;
            this.txtDeadLine.Text = "2";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtInterestRate.Font = new System.Drawing.Font("新細明體", 14F);
            this.txtInterestRate.ForeColor = System.Drawing.Color.IndianRed;
            this.txtInterestRate.Location = new System.Drawing.Point(141, 155);
            this.txtInterestRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(138, 30);
            this.txtInterestRate.TabIndex = 2;
            this.txtInterestRate.Text = "10";
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtDownPayment.Font = new System.Drawing.Font("新細明體", 14F);
            this.txtDownPayment.ForeColor = System.Drawing.Color.IndianRed;
            this.txtDownPayment.Location = new System.Drawing.Point(141, 201);
            this.txtDownPayment.Margin = new System.Windows.Forms.Padding(2);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(138, 30);
            this.txtDownPayment.TabIndex = 3;
            this.txtDownPayment.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("新細明體", 11F);
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(61, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "貸款金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("新細明體", 11F);
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(61, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "期限(年)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("新細明體", 11F);
            this.label3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label3.Location = new System.Drawing.Point(61, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "利率(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Font = new System.Drawing.Font("新細明體", 11F);
            this.label4.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label4.Location = new System.Drawing.Point(61, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "頭期款";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 281);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "PMT(月付)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 281);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "總付款";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(360, 281);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 34);
            this.button3.TabIndex = 10;
            this.button3.Text = "Report";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtDeadLine);
            this.Controls.Add(this.txtLoan);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Loan";
            this.Text = "Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.TextBox txtDeadLine;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}