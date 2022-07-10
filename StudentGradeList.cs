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
    public partial class StudentGradeList : Form
    {
        public StudentGradeList()
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
            if (check() == true)
            {
                total = int.Parse(chn) + int.Parse(en) + int.Parse(math);
                avg = (int.Parse(chn) + int.Parse(en) + int.Parse(math)) / 3;
                MaxMinScore();
                student.Add(new Student(name, chn, en, math, total.ToString(), avg.ToString(), max, min));
                count = student.Count;
                ShowList();
                button5.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            name = RandomList();
            Random random = new Random();
            int chinese = random.Next(101);
            int english = random.Next(101);
            int math = random.Next(101);
            GenerateList(name, chinese, english, math);
            button5.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            student.RemoveAt(count);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            label9.Text = "";
            result = "";
            button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<int> ChnScoreTotal = new List<int>();
            List<int> EnScoreTotal = new List<int>();
            List<int> MathScoreTotal = new List<int>();
            foreach (Student students in student)
            {
                ChnScoreTotal.Add(int.Parse(students.chn));
                EnScoreTotal.Add(int.Parse(students.en));
                MathScoreTotal.Add(int.Parse(students.math));
            }
            string sumChinese = ChnScoreTotal.Sum().ToString();
            string averageChinese = Math.Round(ChnScoreTotal.Average(), 1, MidpointRounding.AwayFromZero).ToString();
            string highChinese = ChnScoreTotal.Max().ToString();
            string lowChinese = ChnScoreTotal.Min().ToString();
            string sumEnglish = EnScoreTotal.Sum().ToString();
            string averageEnglish = Math.Round(EnScoreTotal.Average(), 1, MidpointRounding.AwayFromZero).ToString();
            string highEnglish = EnScoreTotal.Max().ToString();
            string lowEnglish = EnScoreTotal.Min().ToString();
            string sumMath = MathScoreTotal.Sum().ToString();
            string averageMath = Math.Round(MathScoreTotal.Average(), 1, MidpointRounding.AwayFromZero).ToString();
            string highMath = MathScoreTotal.Max().ToString();
            string lowMath = MathScoreTotal.Min().ToString();
            string total = "總分";
            string average = "平均";
            string highScore = "最高分";
            string lowScore = "最低分";
            resultTotal = $"{total.PadRight(10)}{sumChinese.PadLeft(5)}{sumEnglish.PadLeft(12)}{sumMath.PadLeft(12)}\n{average.PadRight(9)}{averageChinese.PadLeft(6)}{averageEnglish.PadLeft(12)}{averageMath.PadLeft(12)}\n{highScore.PadRight(7)}{highChinese.PadLeft(5)}{highEnglish.PadLeft(12)}{highMath.PadLeft(12)}\n{lowScore.PadRight(7)}{lowChinese.PadLeft(5)}{lowEnglish.PadLeft(12)}{lowMath.PadLeft(12)}";
            label9.Text = resultTotal;
        }

        private bool check()
        {
            StringBuilder chkMsg = new StringBuilder("");
            if ("".Equals(name))
            {
                chkMsg.Append("".Equals(chkMsg.ToString()) ? "請輸入姓名" : "、姓名");
            }
            if ("".Equals(chn) || "".Equals(en) || "".Equals(math))
            {
                chkMsg.Append("".Equals(chkMsg.ToString()) ? "請輸入成績" : "、成績");
            }
            if ("".Equals(chkMsg.ToString()))
            {
                return true;
            }
            else
            {
                MessageBox.Show(chkMsg.ToString());
            }
            return false;
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

        public string RandomList()
        {
            string s = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string tempStr = "";
            Random r = new Random();
            for (int i = 0; i < 6; i++)
            {
                tempStr += s[r.Next(52)];
            }
            return tempStr;
        }

        private void GenerateList(string name, int chinese, int english, int math)
        {
            List<int> score = new List<int> { chinese, english, math };
            List<string> subject = new List<string> { "國文", "英文", "數學" };
            int maxScoreI = score.IndexOf(score.Max());
            int minScoreI = score.IndexOf(score.Min());
            string totalScore = score.Sum().ToString();
            string averageScore = (Math.Round(score.Average(), 1, MidpointRounding.AwayFromZero)).ToString();
            string maxScore = $"{subject[maxScoreI]}{score[maxScoreI]}";
            string minScore = $"{subject[minScoreI]}{score[minScoreI]}";
            student.Add(new Student(name, chinese.ToString(), english.ToString(), math.ToString(), totalScore, averageScore, minScore, maxScore));
            ShowList();
        }

        public void ShowList()
        {
            foreach (Student student in student)
            {
                result = $"{student.name.PadRight(10)}{student.chn.PadLeft(7)}{student.en.PadLeft(13)}{student.math.PadLeft(13)}{student.total.PadLeft(13)}{student.avg.PadLeft(13)}{student.min.PadLeft(13)}{student.max.PadLeft(8)}\n";
            }
            label6.Text += result;
        }

        public struct Student
        {
            public string name, chn, en, math, total, avg, max, min;
            public Student(string n, string c, string e, string m, string t, string a, string h, string l)
            {
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
