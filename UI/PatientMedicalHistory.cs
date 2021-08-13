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
    public partial class PatientMedicalHistory : Form
    {
        Patient Pt;
        public PatientMedicalHistory(Patient P)
        {
            Pt = P;
            InitializeComponent();
        }

        private void PatientLoad_Click(object sender, EventArgs e)
        {
            new Patient_UI(Pt).Show();
            this.Hide();
        }

        void populateData()
        {
            PrescriptionOperations OP = new PrescriptionOperations();
            DataSet ds = OP.ShowPrescription(Pt.id);
            HistoryDGV.DataSource = ds.Tables[0];


        }

        private void PatientMedicalHistory_Load(object sender, EventArgs e)
        {
            populateData();

            this.HistoryDGV.Columns["Prescid"].Visible = false;
            this.HistoryDGV.Columns["Patid"].Visible = false;
            this.HistoryDGV.Columns["Did"].Visible = false;

            HistoryDGV.Columns["Patname"].HeaderText = "Patient Name";
            HistoryDGV.Columns["Dtname"].HeaderText = "Doctor Name";
            HistoryDGV.Columns["Treatment"].HeaderText = "Treatment";
            HistoryDGV.Columns["PrescDate"].HeaderText = "Date";
        }

        private void BookAptLoad_Click(object sender, EventArgs e)
        {
            new BookAppointmentUI(Pt).Show();
            this.Hide();
        }

        private void SetAppointment_Click(object sender, EventArgs e)
        {
            new ViewAppointment_UI(Pt).Show();
            this.Hide();
        }

        private void BloodBankLoad_Click(object sender, EventArgs e)
        {
            new BloodBankUI(Pt).Show();
            this.Hide();
        }

        private void LogoutLoad_Click(object sender, EventArgs e)
        {
            new loginorsignup().Show();
            this.Hide();
        }
    }
}
