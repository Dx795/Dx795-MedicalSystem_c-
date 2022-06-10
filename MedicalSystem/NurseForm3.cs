using MedicalSystemModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MedicalSystem
{
    public partial class NurseForm3 : Form
    {
        public NurseForm3()
        {
            InitializeComponent();
        }

        int flag = 0;
        private void buttonX2_Click(object sender, EventArgs e)
        {
            flag++;
            if (flag %2!= 0)
            {
                this.panelmain.Controls.Clear();
                NurseForm3_2 DF = new NurseForm3_2();
                DF.TopLevel = false;
                DF.Dock = DockStyle.Fill;
                DF.FormBorderStyle = FormBorderStyle.None;
                panelmain.Controls.Add(DF);
                DF.Show();
                buttonX2.Text = "回到库存表";
            }
            else
            {
                this.panelmain.Controls.Clear();
                NurseForm3_1 DF = new NurseForm3_1();
                DF.TopLevel = false;
                DF.Dock = DockStyle.Fill;
                DF.FormBorderStyle = FormBorderStyle.None;
                panelmain.Controls.Add(DF);
                DF.Show();
                buttonX2.Text = "显示药品表";
            }
        }

        private void NurseForm3_Load(object sender, EventArgs e)
        {
            this.panelmain.Controls.Clear();
            NurseForm3_1 DF = new NurseForm3_1();
            DF.TopLevel = false;
            DF.Dock = DockStyle.Fill;
            DF.FormBorderStyle = FormBorderStyle.None;
            panelmain.Controls.Add(DF);
            DF.Show();
        }
    }
}
