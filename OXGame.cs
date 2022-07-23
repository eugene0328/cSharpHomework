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
    public partial class OXGame : Form
    {
        public OXGame()
        {
            InitializeComponent();
        }

        int i;

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            int x = i % 2;
            if (x == 0)
            {
                button1.Text = "O";
            }
            else
            {
                button1.Text = "X";
            }
            button1.Enabled = false;
            checkResult();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            int x = i % 2;
            if (x == 0)
            {
                button2.Text = "O";
            }
            else
            {
                button2.Text = "X";
            }
            button2.Enabled = false;
            checkResult();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i++;
            int x = i % 2;
            if (x == 0)
            {
                button3.Text = "O";
            }
            else
            {
                button3.Text = "X";
            }
            button3.Enabled = false;
            checkResult();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i++;
            int x = i % 2;
            if (x == 0)
            {
                button4.Text = "O";
            }
            else
            {
                button4.Text = "X";
            }
            button4.Enabled = false;
            checkResult();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            i++;
            int x = i % 2;
            if (x == 0)
            {
                button5.Text = "O";
            }
            else
            {
                button5.Text = "X";
            }
            button5.Enabled = false;
            checkResult();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            i++;
            int x = i % 2;
            if (x == 0)
            {
                button6.Text = "O";
            }
            else
            {
                button6.Text = "X";
            }
            button6.Enabled = false;
            checkResult();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            i++;
            int x = i % 2;
            if (x == 0)
            {
                button7.Text = "O";
            }
            else
            {
                button7.Text = "X";
            }
            button7.Enabled = false;
            checkResult();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            i++;
            int x = i % 2;
            if (x == 0)
            {
                button8.Text = "O";
            }
            else
            {
                button8.Text = "X";
            }
            button8.Enabled = false;
            checkResult();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            i++;
            int x = i % 2;
            if (x == 0)
            {
                button9.Text = "O";
            }
            else
            {
                button9.Text = "X";
            }
            button9.Enabled = false;
            checkResult();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button btn in buttons)
            {
                btn.Text = "";
                btn.Enabled = true;
            }
            i = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkResult()
        {
            if ((button7.Text == "X" && button4.Text == "X" && button1.Text == "X") ||
                (button1.Text == "X" && button2.Text == "X" && button3.Text == "X") ||
                (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") ||
                (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") ||
                (button3.Text == "X" && button5.Text == "X" && button7.Text == "X") ||
                (button3.Text == "X" && button6.Text == "X" && button9.Text == "X") ||
                (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") ||
                (button7.Text == "X" && button8.Text == "X" && button9.Text == "X"))
            {
                MessageBox.Show("The X win");
                btnEnable();
            }
            else if ((button7.Text == "O" && button4.Text == "O" && button1.Text == "O") ||
                (button1.Text == "O" && button2.Text == "O" && button3.Text == "O") ||
                (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") ||
                (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") ||
                (button3.Text == "O" && button5.Text == "O" && button7.Text == "O") ||
                (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") ||
                (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") ||
                (button7.Text == "O" && button8.Text == "O" && button9.Text == "O"))
            {
                MessageBox.Show("The O win");
                btnEnable();
            }
            if (button1.Text != "" && button4.Text != "" && button7.Text != "" &&
                 button2.Text != "" && button5.Text != "" && button8.Text != "" &&
                 button3.Text != "" && button6.Text != "" && button9.Text != "")
            {
                MessageBox.Show("Tie");
            }
        }

        private void btnEnable()
        {
            button1.Enabled = false; button4.Enabled = false; button7.Enabled = false;
            button2.Enabled = false; button5.Enabled = false; button8.Enabled = false;
            button3.Enabled = false; button6.Enabled = false; button9.Enabled = false;
        }
    }
}
