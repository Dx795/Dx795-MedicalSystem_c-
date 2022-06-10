using MedicalSystemBLL;
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
    public partial class NurseForm1 : Form
    {
        public NurseForm1()
        {
            InitializeComponent();
        }


        private void buttonX2_Click(object sender, EventArgs e)
        {
            int result = InfoRmationMananger.InsertDrugsInfo(textBox1.Text, textBox2.Text, textBox8.Text, textBox3.Text, dateTimePicker1.Value, textBox6.Text, ".\\Images\\" + textBox2.Text + ".jpg");
            if (result == 1)
            {
                MessageBox.Show("入库成功");
            }
            else
            {
                MessageBox.Show("入库失败");
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            using (SqlDataReader dr = ReadInfoRmationManager.ReadDrugsInfo(textBox1.Text))
            {
                if (dr.Read())
                {
                    //自动生成卡号卡密
                    textBox8.Text = DateTime.Now.ToString("yyyymmddhhmmssff");
                    //药品信息
                    textBox2.Text = dr["DrugName"].ToString();
                    textBox3.Text = dr["QuantityDrugs"].ToString();
                    textBox4.Text = dr["DrugSpecIfications"].ToString();
                    textBox5.Text = dr["DrugBrand"].ToString();
                    textBox6.Text = dr["DrugSellingUnitPrice"].ToString();
                    textBox7.Text = dr["DrugPurchasePrice"].ToString();
                    comboBox1.Text = dr["DrugClassIfication"].ToString();
                    pictureBox1.Image = Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory + dr["DrugImage"].ToString());
                    dr.Close();
                };
            }
        }

        private void NurseForm1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
