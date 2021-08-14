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
    public partial class Admin_UI : Form
    {
        public Admin_UI()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            AdminOperation op = new AdminOperation();
            dtcount.Text = Convert.ToString(op.Doctorcount());
            dnrcount.Text = Convert.ToString(op.DonorCount());
            patcountlb.Text = Convert.ToString(op.PatientCount());
        }

        private void AddDonorpicbox_Click(object sender, EventArgs e)
        {
            new AddDonor_UI().Show();
            this.Close();
        }

        private void AddDoctorPIcbox_Click(object sender, EventArgs e)
        {

            new AddDoctor_UI().Show();
            this.Close();

        }

        private void Logoutpicbox_Click(object sender, EventArgs e)
        {
            new loginorsignup_UI().Show();
            this.Close();
        }
    }
}
