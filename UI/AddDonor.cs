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
            Address AD = new Address();
            Donor d = new Donor(AD);
            DonorOperations op = new DonorOperations();

            d.FirstName = Dfnametxt.Text;
            d.LastName = Dlnametxt.Text;
            d.Phone = Dphontxt.Text;
            d.BloodGroup = DBloodGrpcb.SelectedItem.ToString();
            d.address.Area = Dareatxt.Text;
            d.address.City = Dcitytxt.Text;
            op.InsertDonor(d);
            populateData();
        }

        private void AddDonor_Load(object sender, EventArgs e)
        {
            populateData();
            DonorDGV.Columns["DoID"].HeaderText = "ID";
            DonorDGV.Columns["Dfname"].HeaderText = "FirstName";
            DonorDGV.Columns["Dlname"].HeaderText = "Last Name";
            DonorDGV.Columns["Dphone"].HeaderText = "Phone NO.";
            DonorDGV.Columns["DBGrp"].HeaderText = "Blood GROUP";
            DonorDGV.Columns["Dcity"].HeaderText = "City";
            DonorDGV.Columns["Darea"].HeaderText = "Area";

        }

        private void Editvbtn_Click(object sender, EventArgs e)
        {
            Address AD = new Address();
            Donor d = new Donor(AD);
            DonorOperations op = new DonorOperations();
            if (key == 0)
            {
                MessageBox.Show("select the student");
            }
            else
            {
                d.FirstName = Dfnametxt.Text;
                d.LastName = Dlnametxt.Text;
                d.Phone = Dphontxt.Text;
                d.BloodGroup = DBloodGrpcb.SelectedItem.ToString();
                d.address.Area = Dareatxt.Text;
                d.address.City = Dcitytxt.Text;
                try
                {
                    op.UpdateDonors(key, d);
                    MessageBox.Show("Student info Succesfully Updated");
                    populateData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        int key = 0;
        private void DonorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Dfnametxt.Text = DonorDGV.SelectedRows[0].Cells[1].Value.ToString();
            Dlnametxt.Text = DonorDGV.SelectedRows[0].Cells[2].Value.ToString();
            Dphontxt.Text = DonorDGV.SelectedRows[0].Cells[3].Value.ToString();
            DBloodGrpcb.Text = DonorDGV.SelectedRows[0].Cells[4].Value.ToString();
            Dcitytxt.Text = DonorDGV.SelectedRows[0].Cells[5].Value.ToString();
            Dareatxt.Text = DonorDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (Dfnametxt.Text == "")
            {
                key = 0;
            }
            else
            {
                key =Convert.ToInt32(DonorDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
          
            DonorOperations op = new DonorOperations();
            if (key == 0)
            {
                MessageBox.Show("select the student");
            }
            else
            {
                try
                {
                    
                    op.DeleteDonors(key);
                    MessageBox.Show("Student Succesfully Deleted");
                    populateData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
