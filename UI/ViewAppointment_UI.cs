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

        private void label2_Click(object sender, EventArgs e)
        {
            new Patient_UI(Pt).Show();
            this.Hide();
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

        private void pictureBox8_Click(object sender, EventArgs e)//BookAppointmentUI
        {
            new BookAppointmentUI(Pt).Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new loginorsignup().Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)//Blood Bank
        {
            new BloodBankUI(Pt).Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void MedHistory_Click(object sender, EventArgs e)
        {
            new PatientMedicalHistory(Pt).Show();
            this.Hide();
        }
    }
}
