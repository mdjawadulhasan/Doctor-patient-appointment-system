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
    public partial class ViewAppointment_UI : Form
    {
        Patient Pt;
        public ViewAppointment_UI(Patient P)
        {
            Pt = P;
            InitializeComponent();
        }

        

        void populateData()
        {
            AppointmentOperations OP = new AppointmentOperations();
            DataSet ds1 = OP.ShowUpComingApt(Pt.id);
            DataSet ds2 = OP.ShowPrevApt(Pt.id);
            UpAptDgv.DataSource = ds1.Tables[0];
            PrevAptDgv.DataSource = ds2.Tables[0];
        }

        private void ViewAppointment_UI_Load(object sender, EventArgs e)
        {
            populateData();

            UpAptDgv.AllowUserToAddRows = false;
            PrevAptDgv.AllowUserToAddRows = false;
            this.UpAptDgv.Columns["Apid"].Visible = false;
            this.UpAptDgv.Columns["Pid"].Visible = false;
            this.UpAptDgv.Columns["Did"].Visible = false;
            this.PrevAptDgv.Columns["Apid"].Visible = false;
            this.PrevAptDgv.Columns["Pid"].Visible = false;
            this.PrevAptDgv.Columns["Did"].Visible = false;

            UpAptDgv.Columns["Patname"].HeaderText = "Name";
            UpAptDgv.Columns["Patusername"].HeaderText = "User Name";
            UpAptDgv.Columns["Doctorname"].HeaderText = "Doctor Name";
            UpAptDgv.Columns["AppDAte"].HeaderText = "Appointment Date";

            PrevAptDgv.Columns["Patname"].HeaderText = "Name";
            PrevAptDgv.Columns["Patusername"].HeaderText = "User Name";
            PrevAptDgv.Columns["Doctorname"].HeaderText = "Doctor Name";
            PrevAptDgv.Columns["AppDAte"].HeaderText = "Appointment Date";

        }

        int key = 0;
        private void UpAptDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.UpAptDgv.Rows[e.RowIndex];
                dltlb.Text = row.Cells["Doctorname"].Value.ToString();
            }

            if (dltlb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(UpAptDgv.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            AppointmentOperations OP = new AppointmentOperations();
            if (key == 0)
            {
                MessageBox.Show("Select the Appointmnet");
            }
            else
            {
                try
                {

                    OP.DeleteApt(key);
                    MessageBox.Show("Appointmnet Succesfully Deleted");
                    dltlb.Text=null;
                    populateData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Patientlb_Click(object sender, EventArgs e)
        {
            new Patient_UI(Pt).Show();
            this.Hide();
        }

        private void BookAPtpicbox_Click(object sender, EventArgs e)
        {

            new BookAppointmentUI(Pt).Show();
            this.Hide();
        }

        private void MedHistorypicbox_Click(object sender, EventArgs e)
        {
            new PatientMedicalHistory_UI(Pt).Show();
            this.Hide();
        }

        private void DiseasePredpicbox_Click(object sender, EventArgs e)
        {
            new CovidPredict_UI(Pt).Show();
            this.Hide();
        }

        private void BloodBankpicbox_Click(object sender, EventArgs e)
        {
            new BloodBankUI(Pt).Show();
            this.Hide();
        }

        private void Logoutpicbox_Click(object sender, EventArgs e)
        {
            new loginorsignup_UI().Show();
            this.Hide();
        }
    }
}
