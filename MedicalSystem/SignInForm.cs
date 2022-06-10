using MedicalSystemBLL;
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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            this.panel1.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "医生")
            {
                this.panel1.Show();
                comboBox2.SelectedIndex = 0;
            }
            else
            {
                this.panel1.Hide();
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            int result = SelectReadInfoRmationMananger.SelectSignInInfoRmation(textBox1.Text, comboBox1.SelectedItem.ToString());
            
            if (result == 1)
            {
                if (comboBox1.SelectedItem.ToString() == "医生")
                {
                    InfoRmationMananger.UpdateDoctorInfo(comboBox2.SelectedItem.ToString(),textBox1.Text);
                    MessageBox.Show("签到成功");
                }
                else
                {
                    MessageBox.Show("签到成功");
                }
                
            }
            else
            {
                MessageBox.Show("签到失败");
            }
        }
    }
}
