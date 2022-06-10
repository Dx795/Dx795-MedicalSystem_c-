using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalSystemBLL;
using MedicalSystemModel;

namespace MedicalSystem
{
    public partial class 挂号 : Form
    {
        private bool isTrue;
        public 挂号()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PatientForm3_Load(object sender, EventArgs e)
        {
            if (Config.Ys=="1")
            {
                label3.Text = "科室位置";
            }
           else
            {
                label3.Text = "病床位置";
            }
            DataSet data = ReadInfoRmationManager.SelectDepartment();
            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                string a = data.Tables[0].Rows[i]["Department"].ToString();
                comboBox1.Items.Add(a);
            }

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //读卡
            //int icdev = DcHelper.dc_init(100, 115200);
            //if (icdev>0)
            //{
            //    long snr = 0;
            //    int dccard = DcHelper.dc_card(icdev, 0, ref snr);
            //    if (dccard == 0)
            //    {
            //        byte[] password = new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff };
            //        int dckey = DcHelper.dc_load_key(icdev, 0, 1, password);
            //        if (dckey == 0)
            //        {
            //            int dcauthentication = DcHelper.dc_authentication(icdev, 0, 1);
            //            if (dcauthentication == 0)
            //            {
            //                byte[] data = new byte[16];
            //                int dcread = DcHelper.dc_read(icdev, 4, data);
            //                if (dcread == 0)
            //                {
            //                    CarNo.Text = System.Text.Encoding.Default.GetString(data);

            //通过卡号获取其他信息

            DataSet data = ReadInfoRmationManager.SelectPatient(binrenCar.Text);
           
            if (data.Tables[0].Rows.Count > 0)
            {
                Name.Text = data.Tables[0].Rows[0]["PatientName"].ToString();
                Age.Text = data.Tables[0].Rows[0]["PatientAge"].ToString();
                Gender.Text = data.Tables[0].Rows[0]["Gender"].ToString();
                Phone.Text = data.Tables[0].Rows[0]["ContactNumber"].ToString();
                if (data.Tables[0].Rows[0]["yuer"].ToString() == "")
                {
                    yuer.Text = "0";
                }
                else
                {
                    yuer.Text = data.Tables[0].Rows[0]["yuer"].ToString();
                }
                pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + data.Tables[0].Rows[0]["Photo"].ToString());
                isTrue = true;
                time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            }
            else
            {
                MessageBox.Show("该卡无效");
            }
            //for (int i = 0; i < 3; i++)
            //{
            //    DcHelper.dc_beep(icdev, 10);
            //}


            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    //寻卡失败
            //    MessageBox.Show("请正确放置卡");
            //}
            //}
            //else
            //{
            //    MessageBox.Show("请检查设备");
            //}
            
        }

       

        //挂号类别 选择完之后
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Config.Ys == "0")
            {
                DataSet data2 = ReadInfoRmationManager.SelectInpatientWard(comboBox1.Text);
                if (data2.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("目前" + comboBox1.Text + "还剩下" + (data2.Tables[0].Rows.Count) + "个床位，已为你自动安排床位！");
                    weizhi.Text = data2.Tables[0].Rows[0]["BedNo"].ToString();
                }
                else
                {
                    MessageBox.Show("目前" + comboBox1.Text + "没有床位，请挂普通问诊！");
                    Config.Ys = "3";
                }

               
            }
            comboBoxyishen.Items.Clear();
            DataSet data = ReadInfoRmationManager.SelectDoctorName(comboBox1.Text);
            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                string a = data.Tables[0].Rows[i]["DoctorName"].ToString();
                comboBoxyishen.Items.Add(a);
            }

            
        }
        //医生类别 选择完之后
        private void comboBoxyishen_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet data = ReadInfoRmationManager.SelectImage(comboBoxyishen.Text);
            pictureBox2.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + data.Tables[0].Rows[0]["Photo"].ToString());
            if (Config.Ys == "1")
            { 
                weizhi.Text = data.Tables[0].Rows[0]["DutyArdess"].ToString();
            }
            

        }

        //确认挂号按钮
        private void button_Click(object sender, EventArgs e)
        {
            if (binli.Text!="")
            {
                //Config.Ys == "1" 普通
                if (Config.Ys == "1")
                {
                    int cg = InfoRmationMananger.InsertInfoRegister(binrenCar.Text, "普通问诊", comboBox1.Text, "1", time.Text, binli.Text);
                    if (cg > 0)
                    {
                        MessageBox.Show("挂号成功，请前往" + weizhi.Text + "进行排队等候");
                    }
                }
                else if (Config.Ys == "0")
                {
                    int cg = InfoRmationMananger.InsertInfoRegister(binrenCar.Text, "急诊", comboBox1.Text, "1", time.Text, binli.Text);
                    int a = InfoRmationMananger.UpdateTnpatientWard(binrenCar.Text, Config.User, comboBox1.Text, weizhi.Text);
                    if (a > 0 && cg > 0)
                    {
                        MessageBox.Show("挂号成功，请前往" + weizhi.Text + "先行入住，医生马上就到");
                    }
                    else
                    {
                        MessageBox.Show("挂号失败，系统重置请稍后再试！");
                    }
                }
                else
                {
                    MessageBox.Show("挂号失败,返回");
                }
                
                InfoRmationMananger.UpdatePatientjiner(int.Parse(jiner.Text)+ int.Parse(yuer.Text), binrenCar.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("病历没填哦~");
            }
        }
    }
}
