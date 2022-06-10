using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalSystemModel;
using MedicalSystemBLL;

namespace MedicalSystem
{
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }
        private void PatientForm_Load(object sender, EventArgs e)
        {
            la3.Text = "现在时间:  " + DateTime.Now.ToString("yyyy年MM月dd日   HH:mm:ss");
            la3.Alignment = ToolStripItemAlignment.Right;

            //查询性别
            string Genger;
            DataSet data = ReadInfoRmationManager.SelectGender(Config.User);
            string xinbie = data.Tables[0].Rows[0]["Gender"].ToString();
            if (xinbie == "男")
            {
                Genger ="先生";
            }
            else 
            {
                Genger = "女士";
            }

            //医生上班时间 和 病人进去系统时间的比较
            int classtime =int.Parse(Config.ClassTime.ToString("HH"));
            int time = int.Parse(DateTime.Now.ToString("HH"));
            if (time >= 24 && time <= 11 && time >= classtime &&classtime!=0)
            {
                Label2.Text = "早上好，" + Config.User + "  " + Genger;
            }
            else if (time > 11 && time <= 17 && time >= classtime && classtime != 0)
            {
                Label2.Text = "下午好，" + Config.User + "  " + Genger;
            }
            else if (time > 17 && time <= 24 && time >= classtime && classtime != 0)
            {
                Label2.Text = "晚上好，" + Config.User + "  " + Genger;
            }
            else
            {
                Label2.Text = "医生还未上班  " + Config.User + "" + Genger+" 晚点再来哦亲~";
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("医院简历：福建省漳州市诏安县深桥镇深桥村上兴巷390号，医院电话：(0596)3323260");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("即将为你跳转医院缴费挂号窗口！");
            new PatientForm2().Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
