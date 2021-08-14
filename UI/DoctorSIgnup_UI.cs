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
    public partial class DoctorSIgnup_UI : Form
    {
        Doctor d = new Doctor();

        RegisteredDoctorOperations OP = new RegisteredDoctorOperations();
        public DoctorSIgnup_UI()
        {
            InitializeComponent();
        }

        void populateData()
        {

            DataSet ds = OP.ShowAllDoctor();
            RegDoctorDGV.DataSource = ds.Tables[0];
        }
        private void SeacrhBtn_Click(object sender, EventArgs e)
        {
            String src = searchtxt.Text;
            RegisteredDoctorOperations OP = new RegisteredDoctorOperations();
            try
            {
                DataSet ds = OP.ShowSpecificDoctor(src);
                RegDoctorDGV.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void DoctorSIgnup_UI_Load(object sender, EventArgs e)
        {

            populateData();
            RegDoctorDGV.AllowUserToAddRows = false;
            this.RegDoctorDGV.Columns["Did"].Visible = false;
            this.RegDoctorDGV.Columns["Dtdegree"].Visible = false;
            this.RegDoctorDGV.Columns["Dtdept"].Visible = false;
            this.RegDoctorDGV.Columns["Dtvhours"].Visible = false;
            this.RegDoctorDGV.Columns["Dtchamber"].Visible = false;
            this.RegDoctorDGV.Columns["Dtaptcall"].Visible = false;
            this.RegDoctorDGV.Columns["Dtvdays"].Visible = false;

            RegDoctorDGV.Columns["Dtfname"].HeaderText = "First Name";
            RegDoctorDGV.Columns["Dtlname"].HeaderText = "Last Name";
        }

        private void RegDoctorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.RegDoctorDGV.Rows[e.RowIndex];
                RDtfnametxt.Text = row.Cells["Dtfname"].Value.ToString();
                RDtlnametxt.Text = row.Cells["Dtlname"].Value.ToString();
                RDtdegree.Text = row.Cells["Dtdegree"].Value.ToString();
                RDtdept.Text = row.Cells["Dtdept"].Value.ToString();
                RDtcham.Text = row.Cells["Dtchamber"].Value.ToString();
                RDtvhours.Text = row.Cells["Dtvhours"].Value.ToString();
                RDtvisitingdys.Text = row.Cells["Dtvdays"].Value.ToString();
                RDtApt.Text = row.Cells["Dtaptcall"].Value.ToString();

                d.id = Convert.ToInt32(row.Cells["Did"].Value);
            }
        }

        private void RDtvhours_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            new loginorsignup_UI().Show();
            this.Hide();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(RDtfnametxt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(RDtlnametxt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(RDtdegree.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(RDtdept.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(RDtcham.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(RDtvhours.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(RDtvisitingdys.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(RDtApt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }

            else if (String.IsNullOrEmpty(passwordtxt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(usernametxt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }

            else if (passwordtxt.Text.Length < 5)
            {
                MessageBox.Show("Password is too weak !");
            }


            else
            {
                d.UserName = usernametxt.Text;
                if (OP.CheckSignup(d.id, d.UserName) >= 1)
                {
                    MessageBox.Show("This Doctor Already Exists in the system");
                }

                else
                {
                    try
                    {
                        d.FirstName = RDtfnametxt.Text;
                        d.LastName = RDtlnametxt.Text;
                        d.Degree = RDtdegree.Text;
                        d.Department = RDtdept.Text;
                        d.Chammber = RDtcham.Text;
                        d.Visitng_Hours = RDtvhours.Text;
                        d.visiting_days = RDtvisitingdys.Text;
                        d.Appoinment_CallNo = RDtApt.Text;

                        d.Password = passwordtxt.Text;
                        OP.RegisterDoctor(d);
                        MessageBox.Show("Sign up Succes !");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populateData();
        }
    }
}
