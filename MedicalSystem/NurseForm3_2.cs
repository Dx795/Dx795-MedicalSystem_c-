using MedicalSystemBLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalSystem
{
    public partial class NurseForm3_2 : Form
    {
        public NurseForm3_2()
        {
            InitializeComponent();
            List<string> list = new List<string>();
            string[] a = new string[100];
            using (SqlDataReader dr = ReadInfoRmationManager.ReadDrugsInfo1())
            {

                while (dr.Read())
                {
                    list.Add(dr["DrugName"].ToString());
                    imageList1.Images.Add(Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory + dr["DrugImage"].ToString()));
                };
                dr.Close();
            }

            this.listView1.Items.Clear();  //先移除所有的项，避免重复添加

            this.listView1.View = View.LargeIcon;
            this.listView1.LargeImageList = this.imageList1;
            imageList1.ImageSize = new Size(64, 64);
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

       

        private void NurseForm3_2_Load(object sender, EventArgs e)
        {

        }
    }
}
