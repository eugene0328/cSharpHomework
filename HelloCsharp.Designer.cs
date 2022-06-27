
namespace MyHomework
{
    partial class HelloCsharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelloCsharp));
            this.textName = new System.Windows.Forms.TextBox();
            this.textEnName = new System.Windows.Forms.TextBox();
            this.textGen = new System.Windows.Forms.TextBox();
            this.textZod = new System.Windows.Forms.TextBox();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.btnSayHi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textName.Location = new System.Drawing.Point(176, 86);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(204, 43);
            this.textName.TabIndex = 0;
            // 
            // textEnName
            // 
            this.textEnName.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textEnName.Location = new System.Drawing.Point(176, 159);
            this.textEnName.Name = "textEnName";
            this.textEnName.Size = new System.Drawing.Size(204, 43);
            this.textEnName.TabIndex = 1;
            // 
            // textGen
            // 
            this.textGen.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textGen.Location = new System.Drawing.Point(176, 231);
            this.textGen.Name = "textGen";
            this.textGen.Size = new System.Drawing.Size(204, 43);
            this.textGen.TabIndex = 2;
            // 
            // textZod
            // 
            this.textZod.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textZod.Location = new System.Drawing.Point(176, 302);
            this.textZod.Name = "textZod";
            this.textZod.Size = new System.Drawing.Size(204, 43);
            this.textZod.TabIndex = 3;
            // 
            // btnSayHello
            // 
            this.btnSayHello.Location = new System.Drawing.Point(460, 379);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(144, 45);
            this.btnSayHello.TabIndex = 4;
            this.btnSayHello.Text = "Say Hello";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // btnSayHi
            // 
            this.btnSayHi.Location = new System.Drawing.Point(623, 379);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(144, 45);
            this.btnSayHi.TabIndex = 5;
            this.btnSayHi.Text = "Say Hi";
            this.btnSayHi.UseVisualStyleBackColor = true;
            this.btnSayHi.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("新細明體", 14F);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(101, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "姓名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("新細明體", 14F);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(52, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "ENG  name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("新細明體", 14F);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(101, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "性別:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("新細明體", 14F);
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(101, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "星座:";
            // 
            // HelloCsharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSayHi);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.textZod);
            this.Controls.Add(this.textGen);
            this.Controls.Add(this.textEnName);
            this.Controls.Add(this.textName);
            this.Name = "HelloCsharp";
            this.Text = "你好C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textEnName;
        private System.Windows.Forms.TextBox textGen;
        private System.Windows.Forms.TextBox textZod;
        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Button btnSayHi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

