using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHomework
{
    public partial class StudentStructForm : Form
    {
        public StudentStructForm()
        {
            InitializeComponent();
        }

        string name, chn, en, math, result1, result2, highest, lowest;
        int[] score = new int [3] {1,2,3};

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            chn = textBox2.Text;
            en = textBox3.Text;
            math = textBox4.Text;
            result1 = "姓名: "+ name +"\n國文: " + chn + "\n英文: " + en + "\n數學: " + math;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ("".Equals(Check()))
            {
                Lab5Show();
            }
            else
            {
                MessageBox.Show(Check());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(Check()))
                {
                    Lab6Show();
                }
                else
                {
                    MessageBox.Show(Check());
                }
            }
            catch (Exception ex) {
                MessageBox.Show("輸入格式錯誤或沒輸入成績");
                Trace.WriteLine(ex);
            }                    
        }

        private string Check()
        {
            string chkmsg = "";
            if ("".Equals(result1) || result1 == null) {
                chkmsg = "請先儲存";
            }
            return chkmsg;
        }

        private void Lab5Show()
        {
            label5.Text = result1;
        }

        private void Lab6Show()
        {
            score[0] = int.Parse(chn);
            score[1] = int.Parse(en);
            score[2] = int.Parse(math);
            int max = score.Max();
            int min = score.Min();
            if (max == score[0])
            {
                highest = "國文" + chn + "分";
            }
            else if (max == score[1]) {
                highest = "英文" + en + "分";
            }
            else if (max == score[2])
            {
                highest = "數學" + math + "分";
            }
            if (min == score[0])
            {
                lowest = "國文" + chn + "分";
            }
            else if (min == score[1])
            {
                lowest = "英文" + en + "分";
            }
            else if (min == score[2])
            {
                lowest = "數學" + math + "分";
            }
            result2 = "最高科目成績為: " + highest + "\n最低科目成績為: " + lowest;
            label6.Text = result2;
        }
    }
}
