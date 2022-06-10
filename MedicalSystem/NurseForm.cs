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
    public partial class NurseForm : Form
    {
        public NurseForm()
        {
            InitializeComponent();
        }

        private void NurseForm_Load(object sender, EventArgs e)
        {
            this.panelmain.Controls.Clear();
            NurseForm6 DF = new NurseForm6();
            DF.TopLevel = false;
            DF.Dock = DockStyle.Fill;
            DF.FormBorderStyle = FormBorderStyle.None;
            panelmain.Controls.Add(DF);
            DF.Show();
            toolStripStatusLabel1.Text = Config.User + "，欢迎登录医务子系统(护士)，要记得打卡哟~";
            toolStripStatusLabel2.Text = "当前操作员：" + Config.User;
            toolStripStatusLabel3.Text = "当前时间：" + DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
        }

        private void 签到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SignInForm().Show();
        }

        private void 药品入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NurseForm1().Show();
        }

        private void 取药ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NurseForm2().Show();
        }

        private void 库存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NurseForm3().Show();
        }

        private void 收费ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NurseForm4().Show();
        }

        //首页
        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.panelmain.Controls.Clear();
            NurseForm6 DF = new NurseForm6();
            DF.TopLevel = false;
            DF.Dock = DockStyle.Fill;
            DF.FormBorderStyle = FormBorderStyle.None;
            panelmain.Controls.Add(DF);
            DF.Show();
        }

        //药品入库
        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.panelmain.Controls.Clear();
            NurseForm1 DF = new NurseForm1();
            DF.TopLevel = false;
            DF.Dock = DockStyle.Fill;
            DF.FormBorderStyle = FormBorderStyle.None;
            panelmain.Controls.Add(DF);
            DF.Show();
        }

        //取药
        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.panelmain.Controls.Clear();
            NurseForm2 DF = new NurseForm2();
            DF.TopLevel = false;
            DF.Dock = DockStyle.Fill;
            DF.FormBorderStyle = FormBorderStyle.None;
            panelmain.Controls.Add(DF);
            DF.Show();
        }

        //查看库存
        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.panelmain.Controls.Clear();
            NurseForm3 DF = new NurseForm3();
            DF.TopLevel = false;
            DF.Dock = DockStyle.Fill;
            DF.FormBorderStyle = FormBorderStyle.None;
            panelmain.Controls.Add(DF);
            DF.Show();
        }

        //缴医药费
        private void buttonX5_Click(object sender, EventArgs e)
        {
            this.panelmain.Controls.Clear();
            NurseForm4 DF = new NurseForm4();
            DF.TopLevel = false;
            DF.Dock = DockStyle.Fill;
            DF.FormBorderStyle = FormBorderStyle.None;
            panelmain.Controls.Add(DF);
            DF.Show();
        }

        //采购药品
        private void buttonX6_Click(object sender, EventArgs e)
        {
            this.panelmain.Controls.Clear();
            NurseForm5 DF = new NurseForm5();
            DF.TopLevel = false;
            DF.Dock = DockStyle.Fill;
            DF.FormBorderStyle = FormBorderStyle.None;
            panelmain.Controls.Add(DF);
            DF.Show();
        }
    }
}
