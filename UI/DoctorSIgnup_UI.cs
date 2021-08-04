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
    }
}
