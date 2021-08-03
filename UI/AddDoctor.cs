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
            Dtfnametxt.Text = DoctorDGV.SelectedRows[0].Cells[1].Value.ToString();
            Dtlnametxt.Text = DoctorDGV.SelectedRows[0].Cells[2].Value.ToString();
            Dtdegree.Text = DoctorDGV.SelectedRows[0].Cells[3].Value.ToString();
            Dtdept.Text = DoctorDGV.SelectedRows[0].Cells[4].Value.ToString();
            Dtcham.Text = DoctorDGV.SelectedRows[0].Cells[5].Value.ToString();
            Dtvisithrs.Text = DoctorDGV.SelectedRows[0].Cells[6].Value.ToString();
            Dtvisitingdys.Text = DoctorDGV.SelectedRows[0].Cells[7].Value.ToString();
            DtApt.Text = DoctorDGV.SelectedRows[0].Cells[8].Value.ToString();

            if (Dtfnametxt.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DoctorDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
