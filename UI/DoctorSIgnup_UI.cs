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
        public DoctorSIgnup_UI()
        {
            InitializeComponent();
        }

        void populateData()
        {
            RegisteredDoctorOperations OP = new RegisteredDoctorOperations();
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
    }
}
