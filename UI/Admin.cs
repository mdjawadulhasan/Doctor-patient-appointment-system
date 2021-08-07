using DataLayer_HMA.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMA
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            new AddDonor().Show();
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            new AddDoctor().Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new loginorsignup().Show();
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            AdminOperation op = new AdminOperation();
            dtcount.Text = Convert.ToString(op.Doctorcount());
            dnrcount.Text = Convert.ToString(op.DonorCount());
            patcountlb.Text= Convert.ToString(op.PatientCount());
        }
    }
}
