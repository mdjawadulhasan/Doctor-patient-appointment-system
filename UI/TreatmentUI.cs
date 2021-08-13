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
    public partial class TreatmentUI : Form
    {
        Doctor Dr;
        Patient Pt;
        public TreatmentUI(Doctor D)
        {
            Dr = D;
            InitializeComponent();
        }

        void populateData()
        {
            AppointmentOperations OP = new AppointmentOperations();
            DataSet ds = OP.ShowDtAptList(Dr.id);
            TreatDGV.DataSource = ds.Tables[0];

        }


        void populatePatientData(string username)
        {
            PatientOperations OP = new PatientOperations();
            Pt = OP.GetPatient2(username);
            patnamelb.Text = Pt.FirstName + " " + Pt.LastName;
            patgenderlb.Text = Pt.Gender;
            patheightlb.Text = Convert.ToString(Pt.HeightInCm);
            patweightlb.Text = Convert.ToString(Pt.WeightInKg);
            patagelb.Text = Convert.ToString(Pt.Age);
            Diseaselb.Text = Pt.Diseases;
            patgenderlb.Text = Pt.Gender;


        }
        private void TreatmentUI_Load(object sender, EventArgs e)
        {
            populateData();

            this.TreatDGV.Columns["Apid"].Visible = false;
            this.TreatDGV.Columns["Pid"].Visible = false;
            this.TreatDGV.Columns["Did"].Visible = false;

            TreatDGV.Columns["Patname"].HeaderText = "Name";
            TreatDGV.Columns["Patusername"].HeaderText = "User Name";
            TreatDGV.Columns["Doctorname"].HeaderText = "Doctor Name";
            TreatDGV.Columns["AppDAte"].HeaderText = "Appointment Date";
        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            Pt.Prescription = GiveTrttxt.Text;
            try
            {
                PrescriptionOperations op = new PrescriptionOperations();
                op.InsertPrescription(Dr, Pt);
                MessageBox.Show("Prescription Given !");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
        private void TreatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.TreatDGV.Rows[e.RowIndex];
                string UserName= Convert.ToString(row.Cells["Patusername"].Value.ToString());
                populatePatientData(UserName);     

            }          
        }

        private void prevrecordload_Click(object sender, EventArgs e)
        {
            new PreviousRecordUI(Pt).Show();

        }
    }
}
