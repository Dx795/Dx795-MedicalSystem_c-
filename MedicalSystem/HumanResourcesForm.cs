using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalSystemBLL;
using MedicalSystemModel;

namespace MedicalSystem
{
    public partial class HumanResourcesForm : Form
    {
        public HumanResourcesForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult result = open.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                if (!Directory.Exists(System.AppDomain.CurrentDomain.BaseDirectory + "\\Images\\"))
                {
                    Directory.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory + "\\Images\\");
                }
            }

            using (SqlDataReader dr = ReadInfoRmationManager.Readinfo(".\\Images\\" + open.SafeFileName))
            {
                Config.Img = ".\\Images\\" + open.SafeFileName;
                if (dr.Read())
                {
                    //自动生成卡号卡密
                    textBox2.Text = DateTime.Now.ToString("yyyymmddhhmmssff");
                    textBox6.Text = DateTime.Now.ToString("hhmmssff");
                    //根据用户头像 读取用户基本信息 类似人脸识别
                    textBox1.Text = dr["Name"].ToString();
                    textBox3.Text = dr["Age"].ToString();
                    textBox4.Text = dr["Sex"].ToString();
                    textBox5.Text = dr["Title"].ToString();
                    textBox7.Text = dr["DateBirth"].ToString();
                    textBox8.Text= dr["Phone"].ToString();
                    comboBox1.SelectedItem = dr["CardIssuer"].ToString();
                    dr.Close();
                };
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //发卡医生 并把此人数据 下发至相应的表
            if (comboBox1.SelectedIndex == 0)
            {
                int result = InfoRmationMananger.InsertInfoRmation(textBox2.Text, textBox1.Text, textBox3.Text, textBox4.Text, textBox7.Text, textBox5.Text, dateTimePicker1.Value, textBox6.Text,textBox8.Text,Config.Img);
                int delect = InfoRmationMananger.DeleteInfoRmation(textBox1.Text, textBox3.Text);
                if (result == 1 && delect == 1)
                {
                    MessageBox.Show("入职成功");
                }
                else
                {
                    MessageBox.Show("入职失败");
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                int result = InfoRmationMananger.InsertInfoRmation1(textBox2.Text, textBox1.Text, textBox3.Text, textBox4.Text, textBox7.Text, textBox5.Text, dateTimePicker1.Value, textBox6.Text,textBox8.Text, Config.Img);
                int delect = InfoRmationMananger.DeleteInfoRmation(textBox1.Text, textBox3.Text);
                if (result == 1 && delect == 1)
                {
                    MessageBox.Show("入职成功");
                }
                else
                {
                    MessageBox.Show("入职失败");
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                int result = InfoRmationMananger.InsertInfoRmation2(textBox2.Text, textBox1.Text, textBox3.Text, textBox4.Text, textBox7.Text,textBox6.Text,textBox8.Text, Config.Img);
                int delect = InfoRmationMananger.DeleteInfoRmation(textBox1.Text, textBox3.Text);
                if (result == 1 && delect == 1)
                {
                    MessageBox.Show("领取医保卡成功");
                }
                else
                {
                    MessageBox.Show("领取医保卡失败");
                }
            }


        }

        private void HumanResourcesForm_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
