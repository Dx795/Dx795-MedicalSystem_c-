using MedicalSystemBLL;
using MedicalSystemModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalSystem
{
    public partial class NurseForm5 : Form
    {
        public NurseForm5()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            
            int result = InfoRmationMananger.InsertDrugsAddInfo(textBox1.Text, textBox2.Text, comboBox1.SelectedItem.ToString(), textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, ".\\Images\\" + Config.Img);
            if (result == 1)
            {
                MessageBox.Show("添加药品成功");
            }
            else
            {
                MessageBox.Show("添加药品失败");
            }
        }

        private void NurseForm5_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonX2_Click(object sender, EventArgs e)
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
            Config.Img = open.SafeFileName;
        }
    }
}
