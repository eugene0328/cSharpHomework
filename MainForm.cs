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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HelloCsharp hello = new HelloCsharp();
            hello.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(hello);
            hello.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loan loan = new Loan();
            loan.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(loan);
            loan.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            POS pos = new POS();
            pos.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(pos);
            pos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentStructForm ssForm = new StudentStructForm();
            ssForm.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(ssForm);
            ssForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StudentGrade sg = new StudentGrade();
            sg.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(sg);
            sg.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StudentGradeList sgl = new StudentGradeList();
            sgl.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(sgl);
            sgl.Show();
        }
    }
}
