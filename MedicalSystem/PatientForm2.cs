using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalSystem
{
    public partial class PatientForm2 : Form
    {
        public PatientForm2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Tishi().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PatientForm4().Show();
        }
    }
}
