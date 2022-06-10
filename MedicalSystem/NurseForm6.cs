using MedicalSystemBLL;
using MedicalSystemModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalSystem
{
    public partial class NurseForm6 : Form
    {
        public NurseForm6()
        {
            InitializeComponent();
        }
         
        private void NurseForm6_Load(object sender, EventArgs e)
        {
            comboBoxEx1.SelectedIndex = 0;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Random r = new Random();
            textBoxX7.Text = r.Next(7, 10).ToString();
            textBoxX6.Text = (r.Next(7, 10)-1).ToString();

            using (SqlDataReader dr = ReadInfoRmationManager.ReadNurseInfo(Config.User))
            {
                Console.WriteLine(Config.User);
                if (dr.Read())
                {
                    textBoxX1.Text = dr["NurseName"].ToString();
                    textBoxX2.Text = dr["Gender"].ToString();
                    textBoxX3.Text = dr["NurseAge"].ToString();
                    textBoxX4.Text = dr["Telephone"].ToString();
                    textBoxX5.Text = dr["Title"].ToString();
                    pictureBox1.Image = Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory + dr["Photo"].ToString());
                    dr.Close();
                }
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            new NurseForm4().Show();
        }

        private void buttonX13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("暂无");
        }

        public void Alter(String msg)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg);
        }

        private void buttonX10_Click(object sender, EventArgs e)
        {
            this.Alter("success!!!");
        }
    }
}
