using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHomework
{
    public partial class GuessNumInput : Form
    {
        public GuessNumInput(int i)
        {
            InitializeComponent();
            ans = i;
        }
        int ans;
        int max = 100;
        int min = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (check() == "")
            {
                int j = int.Parse(textBox1.Text);
                if (j == ans) {
                    MessageBox.Show("恭喜猜中，數字為" + ans);
                }
                else {
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.GetType() == typeof(GuessNumber)) {                        
                            if (j > ans) {
                                max = j;
                                ((GuessNumber)form).GetLabelConditionText = $"Too Large!!!\nBetween {min} and {max}";
                            } else if (j < ans) { 
                                min = j;
                                ((GuessNumber)form).GetLabelConditionText = $"Too Small!!!\nBetween {min} and {max}";
                            }
                        }
                    }                        
                }
            }
            else {
                MessageBox.Show(check());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string check()
        {
            string a = textBox1.Text;
            string b = "";
            if ("".Equals(a) || a == null) {
                b = "請輸入數字";
            }
            else if (Regex.IsMatch(a, "^[a-zA-Z]"))
            {
                b = "輸入的格式不為數字";
            }
            else if (int.Parse(a) < 1 || int.Parse(a) > 100)
            {
                b = "輸入的數值應在1-100之間";
            }
            return b;
        }

    }
}
