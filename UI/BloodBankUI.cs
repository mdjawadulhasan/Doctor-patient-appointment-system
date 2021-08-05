using DataLayer_HMA.Entity;
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
    public partial class BloodBankUI : Form
    {
        Patient pt;
        public BloodBankUI(Patient P)
        {
            pt = P;
            InitializeComponent();
        }
        void populateData()
        {
            DonorOperations op = new DonorOperations();
            DataSet ds = op.ShowDonors();
            DonorLitsDGV.DataSource = ds.Tables[0];
        }
        private void BloodBankUI_Load(object sender, EventArgs e)
        {

            populateData();
            this.DonorLitsDGV.Columns["DoId"].Visible = false;
            DonorLitsDGV.Columns["Dfname"].HeaderText = "FirstName";
            DonorLitsDGV.Columns["Dlname"].HeaderText = "Last Name";
            DonorLitsDGV.Columns["Dphone"].HeaderText = "Phone NO.";
            DonorLitsDGV.Columns["DBGrp"].HeaderText = "Blood GROUP";
            DonorLitsDGV.Columns["Dcity"].HeaderText = "City";
            DonorLitsDGV.Columns["Darea"].HeaderText = "Area";
        }

        private void SeacrhBtn_Click(object sender, EventArgs e)
        {
            String src = searchtxt.Text;
            DonorOperations OP = new DonorOperations();
            DataSet ds = OP.ShowSpecificDonor(src);
            DonorLitsDGV.DataSource = ds.Tables[0];
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new loginorsignup().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Patient_UI(pt).Show();
            this.Hide();
        }
    }
}
