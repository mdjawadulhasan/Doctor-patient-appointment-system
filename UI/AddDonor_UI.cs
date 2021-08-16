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
    public partial class AddDonor_UI : Form
    {
        public AddDonor_UI()
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
            string s = Dfnametxt.Text;

            if (String.IsNullOrEmpty(Dfnametxt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (char.IsDigit(s[0]))
            {
                MessageBox.Show("First Letter can not be a number!");
            }
            else if (String.IsNullOrEmpty(Dlnametxt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(Dphontxt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(DBloodGrpcb.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(Dareatxt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(Dcitytxt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }

            else
            {


                try
                {
                    d.FirstName = Dfnametxt.Text;
                    d.LastName = Dlnametxt.Text;
                    d.Phone = Dphontxt.Text;
                    d.BloodGroup = DBloodGrpcb.SelectedItem.ToString();
                    d.address.Area = Dareatxt.Text;
                    d.address.City = Dcitytxt.Text;
                    op.InsertDonor(d);
                    MessageBox.Show("Donor Added!");
                    populateData();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

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
            string s = Dfnametxt.Text;
            if (key == 0)
            {
                MessageBox.Show("Select the Donor");
            }
            else if (String.IsNullOrEmpty(Dfnametxt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (char.IsDigit(s[0]))
            {
                MessageBox.Show("First Letter can not be a number!");
            }
            else if (String.IsNullOrEmpty(Dlnametxt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(Dphontxt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(DBloodGrpcb.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(Dareatxt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(Dcitytxt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }

            else
            {

                try
                {
                    d.FirstName = Dfnametxt.Text;
                    d.LastName = Dlnametxt.Text;
                    d.Phone = Dphontxt.Text;
                    d.BloodGroup = DBloodGrpcb.SelectedItem.ToString();
                    d.address.Area = Dareatxt.Text;
                    d.address.City = Dcitytxt.Text;
                    op.UpdateDonors(key, d);
                    MessageBox.Show("Donor info Succesfully Updated");
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DonorDGV.Rows[e.RowIndex];
                Dfnametxt.Text = row.Cells["Dfname"].Value.ToString();
                Dlnametxt.Text = row.Cells["Dlname"].Value.ToString();
                Dphontxt.Text = row.Cells["Dphone"].Value.ToString();
                DBloodGrpcb.Text = row.Cells["DBGrp"].Value.ToString();
                Dcitytxt.Text = row.Cells["Dcity"].Value.ToString();
                Dareatxt.Text = row.Cells["Darea"].Value.ToString();
            }


            if (Dfnametxt.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DonorDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {

            DonorOperations op = new DonorOperations();
            if (key == 0)
            {
                MessageBox.Show("Select the Donor");
            }
            else if (Dfnametxt.Text == "" || Dlnametxt.Text == "" || Dphontxt.Text == "" || DBloodGrpcb.SelectedItem == null || Dareatxt.Text == "" || Dcitytxt.Text == "")
            {
                MessageBox.Show("Select the Donor");
            }
            else
                    {
                        try
                        {

                            op.DeleteDonors(key);
                            MessageBox.Show("Donor Succesfully Deleted");
                            Dfnametxt.Text = "";
                            Dlnametxt.Text = "";
                            Dphontxt.Text = "";
                            DBloodGrpcb.SelectedItem = null;
                            Dareatxt.Text = "";
                            Dcitytxt.Text = "";
                            populateData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
        }

       

        private void Adminlb_Click(object sender, EventArgs e)
        {
            new Admin_UI().Show();
            this.Hide();
        }

        private void AddDoctorpicbox_Click(object sender, EventArgs e)
        {
            new AddDoctor_UI().Show();
            this.Close();
        }

        private void Backpicbox_Click(object sender, EventArgs e)
        {
            new Admin_UI().Show();
            this.Hide();
        }
    }
}
