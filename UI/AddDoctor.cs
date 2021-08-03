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
    public partial class AddDoctor : Form
    {
        public AddDoctor()
        {
            InitializeComponent();
        }



        private void Addbtn_Click(object sender, EventArgs e)
        {
            Doctor dr = new Doctor();
            DoctorOperations OP = new DoctorOperations();

            dr.FirstName = Dtfnametxt.Text;
            dr.LastName = Dtlnametxt.Text;
            dr.visiting_days = Dtvisitingdys.Text;
            dr.Visitng_Hours = Dtvisithrs.Text;
            dr.Chammber = Dtcham.Text;
            dr.Degree = Dtdegree.Text;
            dr.Department = Dtdept.Text;
            dr.Appoinment_CallNo = DtApt.Text;


            OP.InsertDoctor(dr);
            populateData();
        }
        void populateData()
        {
            DoctorOperations OP = new DoctorOperations();
            DataSet ds = OP.ShowDoctors();
            DoctorDGV.DataSource = ds.Tables[0];
        }
        private void AddDoctor_Load(object sender, EventArgs e)
        {

            populateData();
            DoctorDGV.Columns["Dtfname"].HeaderText = "ID";
            DoctorDGV.Columns["Dtlname"].HeaderText = "First Name";
            DoctorDGV.Columns["Dtdegree"].HeaderText = "Last Name";
            DoctorDGV.Columns["Dtdept"].HeaderText = "Department";
            DoctorDGV.Columns["Dtchamber"].HeaderText = "Chamber";
            DoctorDGV.Columns["Dtvhours"].HeaderText = "Visiting Hours";
            DoctorDGV.Columns["Dtvdays"].HeaderText = "Visiting Days";
            DoctorDGV.Columns["Dtaptcall"].HeaderText = "For Appointmnent";
            
        }



        private void Editvbtn_Click(object sender, EventArgs e)
        {
            Doctor dr = new Doctor();
            DoctorOperations op = new DoctorOperations();
            if (key == 0)
            {
                MessageBox.Show("Select the DOCTOR");
            }
            else
            {

                dr.FirstName = Dtfnametxt.Text;
                dr.LastName = Dtlnametxt.Text;
                dr.visiting_days = Dtvisitingdys.Text;
                dr.Visitng_Hours = Dtvisithrs.Text;
                dr.Chammber = Dtcham.Text;
                dr.Degree = Dtdegree.Text;
                dr.Department = Dtdept.Text;
                dr.Appoinment_CallNo = DtApt.Text;

                try
                {
                    op.UpdateDoctors(key, dr);
                    MessageBox.Show("Doctor info Succesfully Updated");
                    populateData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        int key = 0;
        private void DoctorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DoctorDGV.Rows[e.RowIndex];

                Dtfnametxt.Text = row.Cells["Dtfname"].Value.ToString();
                Dtlnametxt.Text = row.Cells["Dtlname"].Value.ToString();
                Dtdegree.Text = row.Cells["Dtdegree"].Value.ToString();
                Dtdept.Text = row.Cells["Dtdept"].Value.ToString();
                Dtcham.Text = row.Cells["Dtchamber"].Value.ToString();
                Dtvisithrs.Text = row.Cells["Dtvhours"].Value.ToString();
                Dtvisitingdys.Text = row.Cells["Dtvdays"].Value.ToString();
                DtApt.Text = row.Cells["Dtaptcall"].Value.ToString();
            }

            if (Dtfnametxt.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DoctorDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            DoctorOperations op = new DoctorOperations();
            if (key == 0)
            {
                MessageBox.Show("Select the Doctor");
            }
            else
            {
                try
                {

                    op.DeleteDoctors(key);
                    MessageBox.Show("Doctor Succesfully Deleted");
                    populateData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            new AddDonor().Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new Admin().Show();
            this.Close();
        }
    }
}
