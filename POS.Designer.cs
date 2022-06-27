
namespace MyHomework
{
    partial class POS
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.labList = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(17, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 79);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(98, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 79);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(98, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 79);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(17, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 79);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 14F);
            this.groupBox1.ForeColor = System.Drawing.Color.DeepPink;
            this.groupBox1.Location = new System.Drawing.Point(32, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 201);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "菜單";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 14F);
            this.groupBox2.ForeColor = System.Drawing.Color.DeepPink;
            this.groupBox2.Location = new System.Drawing.Point(260, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 97);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "總金額";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.MediumVioletRed;
            this.txtTotal.ForeColor = System.Drawing.Color.Ivory;
            this.txtTotal.Location = new System.Drawing.Point(35, 37);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(159, 30);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.Text = "NT$ 0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 14F);
            this.groupBox3.ForeColor = System.Drawing.Color.DeepPink;
            this.groupBox3.Location = new System.Drawing.Point(260, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 97);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "付款方式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("新細明體", 10F);
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(125, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "信用卡享9折";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SlateBlue;
            this.button6.ForeColor = System.Drawing.Color.Lavender;
            this.button6.Location = new System.Drawing.Point(124, 27);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 39);
            this.button6.TabIndex = 1;
            this.button6.Text = "信用卡";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SlateBlue;
            this.button5.ForeColor = System.Drawing.Color.Lavender;
            this.button5.Location = new System.Drawing.Point(20, 27);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 39);
            this.button5.TabIndex = 0;
            this.button5.Text = "現金";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.labList);
            this.groupBox4.Font = new System.Drawing.Font("新細明體", 14F);
            this.groupBox4.ForeColor = System.Drawing.Color.DeepPink;
            this.groupBox4.Location = new System.Drawing.Point(528, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 201);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "購物清單 List";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SlateBlue;
            this.btnClear.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.ForeColor = System.Drawing.Color.Lavender;
            this.btnClear.Location = new System.Drawing.Point(149, 157);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 39);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清除清單";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labList
            // 
            this.labList.BackColor = System.Drawing.Color.AliceBlue;
            this.labList.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labList.ForeColor = System.Drawing.Color.SlateBlue;
            this.labList.Location = new System.Drawing.Point(8, 23);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(225, 130);
            this.labList.TabIndex = 0;
            this.labList.Text = "尚未點餐";
            this.labList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "POS";
            this.Text = "POS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labList;
        private System.Windows.Forms.Button btnClear;
    }
}

