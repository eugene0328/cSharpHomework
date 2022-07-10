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
    public partial class GuessNumber : Form
    {
        public GuessNumber()
        {
            InitializeComponent();
        }
        int i;
        private void button1_Click(object sender, EventArgs e)
        {
            Generate();
            GuessNumInput guessNumInput = new GuessNumInput(i);
            guessNumInput.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Generate();
            MessageBox.Show($"Answer: {i}", "答案", MessageBoxButtons.OK);
        }

        public void Generate() {
            if (i == 0) { 
                i = new Random().Next(1, 100);
            }            
        }
    }
}
