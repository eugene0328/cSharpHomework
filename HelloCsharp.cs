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
    public partial class HelloCsharp : Form
    {
        public HelloCsharp()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            Info(" Hello");
        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            Info(" Hi");
        }

        String name, enName, gender,  zodiac;

        private void Info(String greet)
        {
            name = textName.Text;
            enName = textEnName.Text;
            gender = textGen.Text;
            zodiac = textZod.Text;
            //if (!"".Equals(Check()))
            //{
            //    MessageBox.Show(Check());
            //}
            //else {
                MessageBox.Show(greet + ", 我是" + name + ",\r 英文名字是" + enName
                + ",\r 性別是" + gender + ",\r 星座是" + zodiac + ",\r 很高興認識你。");
            //}            
        }
        //public String Check()
        //{
        //    name = textName.Text;
        //    enName = textEnName.Text;
        //    gender = textGen.Text;
        //    zodiac = textZod.Text;
        //    StringBuilder chkMsg = new StringBuilder("");
        //    if ("".Equals(name) || name == null)
        //    {
        //        chkMsg.Append("".Equals(chkMsg.ToString()) ? "請填寫姓名" : "、姓名");
        //    }
        //    if ("".Equals(enName) || enName == null)
        //    {
        //        chkMsg.Append("".Equals(chkMsg.ToString()) ? "請填寫英文名" : "、英文名");
        //    }
        //    if ("".Equals(gender) || gender == null)
        //    {
        //        chkMsg.Append("".Equals(chkMsg.ToString()) ? "請填寫性別" : "、性別");
        //    }
        //    if ("".Equals(zodiac) || zodiac == null)
        //    {
        //        chkMsg.Append("".Equals(chkMsg.ToString()) ? "請填寫星座" : "、星座");
        //    }
        //    return chkMsg.ToString();
        //}
    }
}
