using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHomework
{
    public partial class MyCalc : Form
    {
        public MyCalc()
        {
            InitializeComponent();
        }

        string num1, num2, chkmsg;
        int i;
        double d;

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            num2 = textBox2.Text;
            if ("".Equals(check()))
            {
                i = int.Parse(num1) + int.Parse(num2);
                textBox3.Text = i.ToString();
            }
            else
            {
                MessageBox.Show(chkmsg);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            num2 = textBox2.Text;
            if ("".Equals(check()))
            {
                i = int.Parse(num1) - int.Parse(num2);
                textBox3.Text = i.ToString();   
            }
            else { 
                MessageBox.Show(chkmsg);
            }       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            num2 = textBox2.Text;
            if ("".Equals(check()))
            {
                i = int.Parse(num1) * int.Parse(num2);
                textBox3.Text = i.ToString();
            }
            else { 
                MessageBox.Show(chkmsg);
            }                  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            num2 = textBox2.Text;
            if ("".Equals(check()))
            {
                d = double.Parse(num1) / double.Parse(num2);
                textBox3.Text = d.ToString();
            }
            else {             
                MessageBox.Show(chkmsg);
            }
        }

        public string check() {
            chkmsg = "";
            if ("".Equals(num1) || "".Equals(num2)) {
                chkmsg = "請輸入數值";
            }
            return chkmsg;
        }
    }
}
