using MedicalSystemBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalSystem
{
    public partial class DoctorForm2 : Form
    {
        public DoctorForm2()
        {
            InitializeComponent();
        }

        private void DoctorForm2_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            using (SqlDataReader dr = ReadInfoRmationManager.ReadPatientInfo(1))
            {
                if (dr.Read())
                {
                    label2.Text= "年龄："+dr["PatientAge"].ToString();
                    label3.Text= "姓名："+dr["PatientName"].ToString();
                    label4.Text= "性别："+dr["Gender"].ToString();
                    label5.Text = "医保卡号："+dr["PatientNumber"].ToString();
                    label7.Text = "联系电话："+dr["ContactNumber"].ToString();
                    //label8.Text = "科室：" + dr["DepartmentNo"].ToString();
                    //label9.Text = "挂号时间：" + dr["DateRegistration"].ToString();
                    //label10.Text = "挂号类别：" + dr["RegisteredType"].ToString();
                    //richTextBox1.Text= dr["Illness"].ToString();
                    pictureBox1.Image = Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory + dr["Photo"].ToString());
                    dr.Close();
                };
            }
         
            using (SqlDataReader dr = ReadInfoRmationManager.ReadPatientInfo(2))
            {
                if (dr.Read())
                {
                    label17.Text = "年龄：" + dr["PatientAge"].ToString();
                    label18.Text = "姓名：" + dr["PatientName"].ToString();
                    label19.Text = "性别：" + dr["Gender"].ToString();
                    label16.Text = "医保卡号：" + dr["PatientNumber"].ToString();
                    label14.Text = "联系电话：" + dr["ContactNumber"].ToString();
                    //label13.Text = "科室：" + dr["DepartmentNo"].ToString();
                    //label12.Text = "挂号时间：" + dr["DateRegistration"].ToString();
                    //label11.Text = "挂号类别：" + dr["RegisteredType"].ToString();
                    //richTextBox2.Text = dr["Illness"].ToString();
                    pictureBox3.Image = Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory + dr["Photo"].ToString());
                    dr.Close();
                };
            }

        }
    }
}
