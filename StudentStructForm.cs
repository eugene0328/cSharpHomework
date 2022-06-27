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
    public partial class StudentStructForm : Form
    {
        public StudentStructForm()
        {
            InitializeComponent();
        }

        string name, chn, en, math, result;

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            chn = textBox2.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
