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
    public partial class AddDonor : Form
    {
        public AddDonor()
        {
            InitializeComponent();
        }

        void populateData()
        {
            DonorOperations op = new DonorOperations();
            DataSet ds = op.ShowDonors();
            DonorDGV.DataSource = ds.Tables[0];
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            Address D = new Address();
            Donor d = new Donor(D);
            DonorOperations op = new DonorOperations();

            d.FirstName = Dfnametxt.Text;
            d.LastName = Dlnametxt.Text;
            d.Phone = Dphontxt.Text;
            d.BloodGroup = Dgendercb.SelectedItem.ToString();
            d.address.Area = Dareatxt.Text;
            d.address.City = Dcitytxt.Text;
            op.InsertDonor(d);
            populateData();
        }

        private void AddDonor_Load(object sender, EventArgs e)
        {
            populateData();
        }
    }
}
