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
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }

        String a ,b ,c, d;
        int ca, cb, cc, cd, i = 120, j = 180, k = 320, l = 350, total;

        private void btnClear_Click(object sender, EventArgs e)
        {
            a = "";
            b = "";
            c = "";
            d = "";
            ca = 0;
            cb = 0; 
            cc = 0;
            cd = 0;
            labList.Text = "尚未點餐";
            txtTotal.Text = "NT$ 0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ca += 1;
            a = "啤酒Beer x" + ca + ", 共NT$ " + ca * i + "元" + "\n";
            total = ca * i + cb * j + cc * k + cd * l;
            txtTotal.Text = "NT$ " + total;
            labList.Text = a + b + c + d;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb += 1; 
            b = "龍舌蘭Tequila x" + cb + ", 共NT$ " + cb * j + "元" + "\n";
            total = ca * i + cb * j + cc * k + cd * l;
            txtTotal.Text = "NT$ " + total;
            labList.Text = a + b + c + d;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cc += 1;
            c = "紅酒Wine x" + cc + ", 共NT$ " + cc * k + "元" + "\n";
            total = ca * i + cb * j + cc * k + cd * l;
            txtTotal.Text = "NT$ " + total;
            labList.Text = a + b + c + d;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cd += 1;
            d = "威士忌Whisky x" + cd + ", 共NT$ " + cd * l + "元" + "\n";
            total = ca * i + cb * j + cc * k + cd * l;
            txtTotal.Text = "NT$ " + total;
            labList.Text = a + b + c + d;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ("尚未點餐".Equals(labList.Text))
            {
                MessageBox.Show("尚未點餐");
            }
            else 
            {
                MessageBox.Show("總金額: NT$ " + total);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ("尚未點餐".Equals(labList.Text))
            {
                MessageBox.Show("尚未點餐");
            }
            else
            {
                MessageBox.Show("總金額: NT$ " + total + "\n折後金額: NT$ " + (total * 0.9));
            }
        }
    }
}
