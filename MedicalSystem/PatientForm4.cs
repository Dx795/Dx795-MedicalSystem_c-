using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalSystemBLL;
using MedicalSystemModel;

namespace MedicalSystem
{
    public partial class PatientForm4 : Form
    {
        public PatientForm4()
        {
            InitializeComponent();
            p1.SizeMode = PictureBoxSizeMode.Zoom;
            p2.SizeMode = PictureBoxSizeMode.Zoom;
            p3.SizeMode = PictureBoxSizeMode.Zoom;
            p4.SizeMode = PictureBoxSizeMode.Zoom;
            p5.SizeMode = PictureBoxSizeMode.Zoom;
            p6.SizeMode = PictureBoxSizeMode.Zoom;

        }

        int b = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            b++;
            if (b % 2 == 0)
            {
                panel.Visible = true;
                DataSet da = ReadInfoRmationManager.ReadCaiPing();
                l1.Text = (da.Tables[0].Rows[0]["caiName"].ToString());
                l2.Text = (da.Tables[0].Rows[1]["caiName"].ToString());
                l3.Text = (da.Tables[0].Rows[2]["caiName"].ToString());
                l4.Text = (da.Tables[0].Rows[3]["caiName"].ToString());
                l5.Text = (da.Tables[0].Rows[4]["caiName"].ToString());
                l6.Text = (da.Tables[0].Rows[5]["caiName"].ToString());
                
                y1.Text = (da.Tables[0].Rows[0]["caiMoney"].ToString() + "元");
                y2.Text = (da.Tables[0].Rows[0]["caiMoney"].ToString() + "元");
                y3.Text = (da.Tables[0].Rows[0]["caiMoney"].ToString() + "元");
                y4.Text = (da.Tables[0].Rows[0]["caiMoney"].ToString() + "元");
                y5.Text = (da.Tables[0].Rows[0]["caiMoney"].ToString() + "元");
                y6.Text = (da.Tables[0].Rows[0]["caiMoney"].ToString() + "元");

                p1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + da.Tables[0].Rows[0]["caiImage"].ToString());
                p2.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + da.Tables[0].Rows[1]["caiImage"].ToString());
                p3.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + da.Tables[0].Rows[2]["caiImage"].ToString());
                p4.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + da.Tables[0].Rows[3]["caiImage"].ToString());
                p5.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + da.Tables[0].Rows[4]["caiImage"].ToString());
                p6.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + da.Tables[0].Rows[5]["caiImage"].ToString());


            }
            else
            {
                panel.Visible = false;
            }
        }

        //购物车按钮
        int a = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            a++;
            if (a % 2 == 0)
            {
                panel2.Visible = true;

                List<string> list = new List<string>();
                List<string> listname = new List<string>();
                List<string> count = new List<string>();
                string[] a = new string[100];
                DataSet da = ReadInfoRmationManager.ReadSpingCart(Config.User);
                for (int i = 0; i < da.Tables[0].Rows.Count; i++)
                {
                    listname.Add(da.Tables[0].Rows[i]["caiName"].ToString());
                    count.Add(da.Tables[0].Rows[i]["count"].ToString());
                }
                int zhonghjia=0;
                for (int i = 0; i < listname.Count; i++)
                {
                    DataSet da2 = ReadInfoRmationManager.ReadCaiPingJQ(listname[i]);
                    list.Add(da2.Tables[0].Rows[0]["caiName"].ToString() + " " + da2.Tables[0].Rows[0]["caiMoney"].ToString() +"元  *"+count[i]+"份");
                    imageList1.Images.Add(Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory + da2.Tables[0].Rows[0]["caiImage"].ToString()));
                    zhonghjia += int.Parse(da2.Tables[0].Rows[0]["caiMoney"].ToString()) * int.Parse(count[i]);
                }
                zj.Text = zhonghjia.ToString();

                this.listView1.Items.Clear();  //先移除所有的项，避免重复添加
                this.listView1.View = View.LargeIcon;
                this.listView1.LargeImageList = this.imageList1;
                imageList1.ImageSize = new Size(120, 50);
                this.listView1.BeginUpdate();

                int t = 0;
                foreach (var item in list)
                {
                    a[t] = item.ToString();
                    t++;
                }

                for (int i = 0; i <= list.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageIndex = i;
                    lvi.Text = a[i];
                    this.listView1.Items.Add(lvi);
                }
                this.listView1.EndUpdate();

            }
            else
            {
                panel2.Visible = false;
            }
        }

        private void PatientForm4_Load(object sender, EventArgs e)
        {
            panel.Visible = false;
            panel2.Visible = false;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Tianjia(l1.Text);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Tianjia(l2.Text);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Tianjia(l3.Text);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Tianjia(l4.Text);
        }
        private void b5_Click(object sender, EventArgs e)
        {
            Tianjia(l5.Text);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            Tianjia(l6.Text);
        }

        private void Tianjia(string text)
        {
            DataSet da = ReadInfoRmationManager.ReadSpingCart(Config.User, text);
            if (da.Tables[0].Rows.Count == 0)
            {
                int a = InfoRmationMananger.InsertSpingCart(text, Config.User, 1);
                if (a > 0)
                {
                    MessageBox.Show("已加到购物车");
                }
            }
            else
            {
                int b = InfoRmationMananger.UpdateSpingCart(text, int.Parse(da.Tables[0].Rows[0]["count"].ToString()) + 1);
                if (b > 0)
                {
                    MessageBox.Show("已加到购物车");
                }
            }
        }


        //付款
        private void button3_Click(object sender, EventArgs e)
        {
            DataSet da= ReadInfoRmationManager.SelectGender(Config.User);
            int money= int.Parse(da.Tables[0].Rows[0]["yuer"].ToString());
            if ((money - int.Parse(zj.Text))> 0)
            {
                DataSet da2 = ReadInfoRmationManager.SelectGender(Config.User);
                string carno = da2.Tables[0].Rows[0]["PatientNumber"].ToString();
                int a = InfoRmationMananger.UpdatePatientjiner(money - int.Parse(zj.Text), carno);
                int b = InfoRmationMananger.DeleterPatientjiner(Config.User);
                if (a > 0 && b > 0)
                {
                    MessageBox.Show("付款成功");
                }
                else
                {
                    MessageBox.Show("付款失败");
                }
            }
            else
            {
                MessageBox.Show("金额不足");
            }

        }
    }
}
