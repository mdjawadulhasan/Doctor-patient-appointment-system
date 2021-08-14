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
    public partial class CovidPredict_UI : Form, IDiseasePrediction
    {
        Patient Pt;
        int count = 0;
        public string result;
        public CovidPredict_UI(Patient P)
        {
            Pt = P;
            InitializeComponent();
        }

        public void CalculateRisk()
        {
            if(count>4)
            {
                Resultlb.Text = "High Chances";
                Redpicbox.Visible = true;

                Yellowpicbox.Visible = false;
                GreenPicbox.Visible = false;
            }
            else if(count>3)
            {
                Resultlb.Text = "Mild Chances";
                Yellowpicbox.Visible = true;

                Redpicbox.Visible = false;
                GreenPicbox.Visible = false;
            }
            else
            {
                Resultlb.Text = "Less Chances";
                GreenPicbox.Visible = true;

                Redpicbox.Visible = false;
                Yellowpicbox.Visible = false;
            }
        }
 

        private void Patientlb_Click(object sender, EventArgs e)
        {
            new Patient_UI(Pt).Show();
            this.Hide();
        }

        private void BookAptPicbox_Click(object sender, EventArgs e)
        {
            new Patient_UI(Pt).Show();
            this.Hide();
        }

        

        private void Medhistorypicbox_Click(object sender, EventArgs e)
        {
            new PatientMedicalHistory_UI(Pt).Show();
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

        private void painchk_CheckedChanged(object sender, EventArgs e)
        {
            if(painchk.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        private void breathingchk_CheckedChanged(object sender, EventArgs e)
        {
            if (breathingchk.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        private void nosechk_CheckedChanged(object sender, EventArgs e)
        {
            if (nosechk.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        private void oxychk_CheckedChanged(object sender, EventArgs e)
        {
            if (oxychk.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        private void sorethrtchk_CheckedChanged(object sender, EventArgs e)
        {
            if (sorethrtchk.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        private void Loosechk_CheckedChanged(object sender, EventArgs e)
        {
            if (Loosechk.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        private void smellchk_CheckedChanged(object sender, EventArgs e)
        {
            if (smellchk.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        private void chestchk_CheckedChanged(object sender, EventArgs e)
        {
            if(chestchk.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateRisk();

        }
    }
}
