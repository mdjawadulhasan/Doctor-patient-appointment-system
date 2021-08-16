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
    public partial class BookAppointmentUI : Form
    {
        Patient Pt;
        Doctor D = new Doctor();

        public BookAppointmentUI(Patient P)
        {
            Pt = P;
            InitializeComponent();
        }



        void populateData()
        {
            DoctorOperations OP = new DoctorOperations();
            DataSet ds = OP.ShowDoctors();
            DoctorApDGV.DataSource = ds.Tables[0];
        }
        private void AppointmentUI_Load(object sender, EventArgs e)
        {
            populateData();
            DoctorApDGV.AllowUserToAddRows = false;
            this.DoctorApDGV.Columns["Did"].Visible = false;
            DoctorApDGV.Columns["Did"].HeaderText = "ID";
            DoctorApDGV.Columns["Dtfname"].HeaderText = "First Name";
            DoctorApDGV.Columns["Dtlname"].HeaderText = "Last Name";
            DoctorApDGV.Columns["Dtdegree"].HeaderText = "Degree";
            DoctorApDGV.Columns["Dtdept"].HeaderText = "Department";
            DoctorApDGV.Columns["Dtchamber"].HeaderText = "Chamber";
            DoctorApDGV.Columns["Dtvhours"].HeaderText = "Visiting Hours";
            DoctorApDGV.Columns["Dtvdays"].HeaderText = "Visiting Days";
            DoctorApDGV.Columns["Dtaptcall"].HeaderText = "For Appointmnent";
        }

        private void SeacrhBtn_Click(object sender, EventArgs e)
        {
            String src = searchtxt.Text;
            DoctorOperations OP = new DoctorOperations();
            DataSet ds = OP.ShowSpecificDoctor(src);
            DoctorApDGV.DataSource = ds.Tables[0];

        }

        private void DoctorApDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DoctorApDGV.Rows[e.RowIndex];
                dtnamelb.Text = row.Cells["Dtfname"].Value.ToString() + " "+ row.Cells["Dtlname"].Value.ToString();  
                dtdeptlb.Text = row.Cells["Dtdept"].Value.ToString();          
                dtvisitinglv.Text = row.Cells["Dtvdays"].Value.ToString();
                Chamberlb.Text= row.Cells["Dtchamber"].Value.ToString();
               
                D.FirstName = row.Cells["Dtfname"].Value.ToString();
                D.LastName= row.Cells["Dtlname"].Value.ToString();
                D.Department= row.Cells["Dtdept"].Value.ToString();
                D.visiting_days= row.Cells["Dtvdays"].Value.ToString();
                D.Chammber= row.Cells["Dtchamber"].Value.ToString();
                D.id = Convert.ToInt32(row.Cells["Did"].Value.ToString());
            }
        }


        private void SetAppBtn_Click(object sender, EventArgs e)
        {
            Pt.Date = AptDatePicker.Value.Date;
            AppointmentOperations op = new AppointmentOperations();
            if (String.IsNullOrEmpty(dtnamelb.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(dtdeptlb.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(dtvisitinglv.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(Chamberlb.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (AptDatePicker.Value < DateTime.Today)
            {
                MessageBox.Show("Invalid Date!");
            }
            else if (op.ChecApt(Pt.id, D.id)>=1)
            {
                MessageBox.Show("Appointment Set Already!");
            }
            else
            {
                try
                {
                    op.SetAppointment(Pt, D);
                    MessageBox.Show("Appointment has been set succesfully.!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                   
                }
            }
        }

        

        private void Medhistorypicbox_Click(object sender, EventArgs e)
        {
            new PatientMedicalHistory_UI(Pt).Show();
            this.Hide();
        }

        private void Diseaseprdpicbox_Click(object sender, EventArgs e)
        {
            new CovidPredict_UI(Pt).Show();
            this.Hide();
        }

        private void Bloodbankpicbox_Click(object sender, EventArgs e)
        {
            new BloodBankUI(Pt).Show();
            this.Hide();
        }

        private void Logoutpicbox_Click(object sender, EventArgs e)
        {
            new loginorsignup_UI().Show();
            this.Hide();
        }

        private void Patientlb_Click(object sender, EventArgs e)
        {
            new Patient_UI(Pt).Show();
            this.Hide();
        }

        private void SeeAptpicbox_Click(object sender, EventArgs e)
        {
            new ViewAppointment_UI(Pt).Show();
            this.Hide();
        }
    }
}
