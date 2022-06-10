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
    public partial class NurseForm3_1 : Form
    {
        public NurseForm3_1()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            dataGridViewX1.Columns[0].HeaderText = "ID";
            dataGridViewX1.Columns[1].HeaderText = "药品编号";
            dataGridViewX1.Columns[2].HeaderText = "药品名称";
            dataGridViewX1.Columns[3].HeaderText = "入库编号";
            dataGridViewX1.Columns[4].HeaderText = "药品数量";
            dataGridViewX1.Columns[5].HeaderText = "入库时间";
            dataGridViewX1.Columns[6].HeaderText = "取药时间";
            dataGridViewX1.Columns[7].HeaderText = "药品售价";
        }

        private void NurseForm3_1_Load(object sender, EventArgs e)
        {
            #region 绑定dataGridView
            DataSet ds = new DataSet();
            string ConnectionStr = "Data Source=" + Config.Ip + ";Initial Catalog=Medical system;Persist Security Info=True;User ID=sa;Password=Jinx13850526746";
            SqlConnection conn = new SqlConnection(ConnectionStr);
            conn.Open();
            string sql = "select * from T_DrugInventory";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            sqlData.Fill(ds);
            dataGridViewX1.DataSource = ds.Tables[0];

            conn.Close();
            conn.Dispose();
            #endregion
        }
    }
}
