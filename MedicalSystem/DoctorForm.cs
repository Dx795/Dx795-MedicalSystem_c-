using MedicalSystemModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalSystem
{
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panelmain.Controls.Clear();
            DoctorForm1 DF = new DoctorForm1();
            DF.TopLevel = false;
            DF.Dock = DockStyle.Fill;
            DF.FormBorderStyle = FormBorderStyle.None;
            panelmain.Controls.Add(DF);
            DF.Show();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            this.panelmain.Controls.Clear();
            DoctorForm1 DF = new DoctorForm1();
            DF.TopLevel = false;
            DF.Dock = DockStyle.Fill;
            DF.FormBorderStyle = FormBorderStyle.None;
            panelmain.Controls.Add(DF);
            DF.Show();
            toolStripStatusLabel1.Text = Config.User + "，欢迎登录医务子系统(医生)，要记得打卡哟~";
            toolStripStatusLabel2.Text = "当前操作员："+Config.User;
            toolStripStatusLabel3.Text = "当前时间：" + DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panelmain.Controls.Clear();
            DoctorForm2 DF = new DoctorForm2();
            DF.TopLevel = false;
            DF.Dock = DockStyle.Fill;
            DF.FormBorderStyle = FormBorderStyle.None;
            panelmain.Controls.Add(DF);
            DF.Show();
        }

        private void 签到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SignInForm().Show();
        }
    }
}
