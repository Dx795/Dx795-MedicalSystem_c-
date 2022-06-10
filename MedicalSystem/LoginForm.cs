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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new HumanResourcesForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result = SelectReadInfoRmationMananger.SelectReadInfoRmation(textBox2.Text, textBox3.Text, (string)comboBox1.SelectedItem);
            Config.User = textBox2.Text;
            if (comboBox1.SelectedIndex <= 2)
            {
                if (result == 1&&comboBox1.SelectedIndex==1)
                {
                    MessageBox.Show("祝您上班愉快");
                    new DoctorForm().Show();
                }
                else if (result == 1 && comboBox1.SelectedIndex == 2)
                {
                    MessageBox.Show("祝您上班愉快");
                    new NurseForm().Show();
                }
                else
                {
                    MessageBox.Show("输入密码或用户名有误哦!");
                }
            }
            else
            {
                if (result == 1)
                {
                   
                    new PatientForm().Show();
                }
                else
                {
                    MessageBox.Show("输入密码或用户名有误哦!");
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Config.Ip = textBox1.Text;//接受服务器地址
            ////医生
            //textBox2.Text = "李明";
            //textBox3.Text = "12232425";
            //comboBox1.SelectedIndex = 1;
            //护士
            //textBox2.Text = "淑丽";
            //textBox3.Text = "12593752";
            //comboBox1.SelectedIndex = 2;
            //病人
            //textBox2.Text = "周延";
            //textBox3.Text = "01002917";
            //comboBox1.SelectedIndex = 3;
             //病人
            textBox2.Text = "朱军";
            textBox3.Text = "04360490";
            comboBox1.SelectedIndex = 3;
        }
    }
}
