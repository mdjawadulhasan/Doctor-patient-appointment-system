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
    public partial class AppointmentUI : Form
    {
        Person Pt;
        Doctor D = new Doctor();

        public AppointmentUI(Person P)
        {
            Pt = P;
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new loginorsignup().Show();
            this.Hide();
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
                dtnamelb.Text = row.Cells["Dtlname"].Value.ToString() + " "+ row.Cells["Dtlname"].Value.ToString();  
                dtdeptlb.Text = row.Cells["Dtdept"].Value.ToString();          
                dtvisitinglv.Text = row.Cells["Dtvdays"].Value.ToString();
                D.FirstName = row.Cells["Dtlname"].Value.ToString();
                D.LastName= row.Cells["Dtlname"].Value.ToString();
                D.Department= row.Cells["Dtdept"].Value.ToString();
                D.visiting_days= row.Cells["Dtvdays"].Value.ToString();
            }
        }
    }
}
