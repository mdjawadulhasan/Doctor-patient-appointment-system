using DataLayer_HMA.Entity;
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
    public partial class Patient_UI : Form
    {
        Patient Pt;
        public Patient_UI(Patient P)
        {
            Pt = P;
            InitializeComponent();
        }  

        private void Patient_UI_Load(object sender, EventArgs e)
        {
            Ptname.Text= Pt.FirstName + " " + Pt.LastName;
            Ptphone.Text = Pt.Phone;
            Ptage.Text = Convert.ToString(Pt.Age);
            Ptbgrp.Text = Pt.BloodGroup;
            Ptcrndis.Text = Pt.Diseases;
        }

        private void BookAptPicbox_Click(object sender, EventArgs e)
        {
            new BookAppointmentUI(Pt).Show();
            this.Hide();
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

        private void logoutpicbox_Click(object sender, EventArgs e)
        {
            new loginorsignup_UI().Show();
            this.Hide();
        }

        private void SeeAptpicbox_Click(object sender, EventArgs e)
        {
            new ViewAppointment_UI(Pt).Show();
            this.Hide();
        }
    }
}
