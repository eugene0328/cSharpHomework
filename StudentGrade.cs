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
    public partial class StudentGrade : Form
    {
        public StudentGrade()
        {
            InitializeComponent();
        }
        List<Student> student = new List<Student>();
        string name ,chn ,en ,math, result, resultAdd, resultTotal;
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            chn = txtChn.Text;
            en = txtEn.Text;
            math = txtMath.Text;
            student.Add(new Student(name,int.Parse(chn),int.Parse(en), int.Parse(math)));
            ShowList(student);
        }

        private void ShowList(List<Student> student)
        {
            

        }

        public struct Student {
            public string name;
            public int chn, en, math;
            public Student(string n, int c, int e, int m) {
                name = n;
                chn = c;
                en = e;
                math = m;
            }
        }
    }
}
