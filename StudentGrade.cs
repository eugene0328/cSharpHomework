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
        string name, chn, en, math, max, min, result, resultTotal;
        int total, avg, count;
        private void button1_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            chn = txtChn.Text;
            en = txtEn.Text;
            math = txtMath.Text;
            total = int.Parse(chn) + int.Parse(en) + int.Parse(math);
            avg = (int.Parse(chn) + int.Parse(en) + int.Parse(math)) / 3;
            MaxMinScore();
            student.Add(new Student(name, chn, en, math, total.ToString(), avg.ToString(), max, min));
            ShowList(student);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            label7.Text = "";
        }

        public void MaxMinScore()
        {
            List<int> score = new List<int> { int.Parse(chn), int.Parse(en), int.Parse(math) };
            List<string> subject = new List<string> { "國文", "英文", "數學" };
            int maxScore = score.IndexOf(score.Max());
            int minScore = score.IndexOf(score.Min());
            max = $"{subject[maxScore]}{score[maxScore]}";
            min = $"{subject[minScore]}{score[minScore]}";
        }

        public void ShowList(List<Student> students)
        {            
            foreach (Student student in students)
            {
                result = $"{student.name.PadRight(10)}{student.chn.PadLeft(7)}{student.en.PadLeft(13)}{student.math.PadLeft(13)}{student.total.PadLeft(13)}{student.avg.PadLeft(13)}{student.min.PadLeft(13)}{student.max.PadLeft(8)}\n";
            }
            label7.Text += result;
        }

        public struct Student {
            public string name, chn, en, math, total, avg, max, min;
            public Student(string n, string c, string e, string m, string t, string a, string h, string l) {
                name = n;
                chn = c;
                en = e;
                math = m;
                total = t;
                avg = a;
                max = h;
                min = l;
            }
        }
    }
}
