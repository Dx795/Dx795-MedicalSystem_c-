using MedicalSystemBLL;
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
    public partial class Tishi : Form
    {
        public Tishi()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Config.Ys = "1";
            cahxun("1");
        }

        

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Config.Ys = "0";
            cahxun("0");
        }
        private void cahxun(string a)
        {
            DataSet da = ReadInfoRmationManager.SelectGender(Config.User);
            string PatientNumber = da.Tables[0].Rows[0]["PatientNumber"].ToString();
            DataSet da2 = ReadInfoRmationManager.SelectRegist(PatientNumber);
            if (da2.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show(" 正在排队，不要紧紧张张！");
                this.Close();
            }
            else
            {
                if (a == "1")
                {
                    MessageBox.Show("即将为你跳转普通问诊窗口！");
                }
                else
                {
                    MessageBox.Show("即将为你跳转急诊窗口！");
                }
                new 挂号().Show();
                this.Close();
            }
        }
    }
}
