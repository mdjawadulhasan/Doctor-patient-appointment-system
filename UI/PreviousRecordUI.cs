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
    public partial class PreviousRecordUI : Form
    {
        Patient Pt;

        public PreviousRecordUI(Patient P)
        {
            Pt = P;
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        void populateData()
        {
            PrescriptionOperations OP = new PrescriptionOperations(); 
            if(Pt==null)
            {
                MessageBox.Show("Select the Patient");
            }
            else
            {
                DataSet ds = OP.ShowPrescription(Pt.id);
                PrevRecordDGV.DataSource = ds.Tables[0];
            }
            

        }

        private void PreviousRecordUI_Load(object sender, EventArgs e)
        {
            populateData();
            PrevRecordDGV.AllowUserToAddRows = false;
            this.PrevRecordDGV.Columns["Prescid"].Visible = false;
            this.PrevRecordDGV.Columns["Patid"].Visible = false;
            this.PrevRecordDGV.Columns["Did"].Visible = false;

            PrevRecordDGV.Columns["Patname"].HeaderText = "Patient Name";
            PrevRecordDGV.Columns["Dtname"].HeaderText = "Doctor Name";
            PrevRecordDGV.Columns["Treatment"].HeaderText = "Treatment";
            PrevRecordDGV.Columns["PrescDate"].HeaderText = "Date";
        }
    }
}
