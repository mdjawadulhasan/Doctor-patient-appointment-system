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
            DataSet ds = OP.ShowSpecificDoctor(src);
            RegDoctorDGV.DataSource = ds.Tables[0];
        }

        private void DoctorSIgnup_UI_Load(object sender, EventArgs e)
        {
            
            populateData();
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
            new loginorsignup();
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            d.FirstName = RDtfnametxt.Text;
            d.LastName = RDtlnametxt.Text;
            d.Degree = RDtdegree.Text;
            d.Department = RDtdept.Text;
            d.Chammber = RDtcham.Text;
            d.Visitng_Hours = RDtvhours.Text;
            d.visiting_days = RDtvisitingdys.Text;
            d.Appoinment_CallNo = RDtApt.Text;
            d.UserName = usernametxt.Text;
            d.Password = passwordtxt.Text;

            if (OP.CheckSignup(d.id) >= 1)
            {
                MessageBox.Show("This Doctor Already Exists in the system");
            }

            if (String.IsNullOrEmpty(RDtfnametxt.Text))
            {
                MessageBox.Show(" First Name Field Can Not Be Empty!");
            }
            else if (String.IsNullOrEmpty(RDtlnametxt.Text))
            {
                MessageBox.Show(" Last Name Field Can Not Be Empty!");
            }
            else if (String.IsNullOrEmpty(RDtdegree.Text))
            {
                MessageBox.Show("Degree Field Can Not Be Empty!");
            }
            else if (String.IsNullOrEmpty(RDtdept.Text))
            {
                MessageBox.Show("Department Field Can Not Be Empty!");
            }
            else if (String.IsNullOrEmpty(RDtcham.Text))
            {
                MessageBox.Show(" Chamber Field Can Not Be Empty!");
            }
            else if (String.IsNullOrEmpty(RDtvhours.Text))
            {
                MessageBox.Show("Visiting Hours  Field Can Not Be Empty!");
            }
            else if (String.IsNullOrEmpty(RDtvisitingdys.Text))
            {
                MessageBox.Show("Visiting  Days  Field Can Not Be Empty!");
            }
            else if (String.IsNullOrEmpty(RDtApt.Text))
            {
                MessageBox.Show("Appoinment Call No. Field Can Not Be Empty!");
            }

            else if (String.IsNullOrEmpty(passwordtxt.Text))
            {
                MessageBox.Show("Password Field Can Not Be Empty!");
            }
            else if (String.IsNullOrEmpty(usernametxt.Text))
            {
                MessageBox.Show("Username Field Can Not Be Empty!");
            }

            else if (passwordtxt.Text.Length < 5)
            {
                MessageBox.Show("Password Must have more then 5 character");
            }

            else
            {

                try
                {

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
}
