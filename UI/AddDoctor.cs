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
    public partial class AddDoctor : Form
    {
        public AddDoctor()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            Doctor dr = new Doctor();
            DoctorOperations OP = new DoctorOperations();
            
            dr.FirstName = Dtfnametxt.Text;
            dr.LastName = Dtlnametxt.Text;
            dr.visiting_days = Dtvisitingdys.Text;
            dr.Visitng_Hours = Dtvisithrs.Text;
            dr.Chammber = Dtcham.Text;
            dr.Degree = Dtdegree.Text;
            dr.Department = Dtdept.Text;
            dr.Appoinment_CallNo = DtApt.Text;

            OP.InsertDoctor(dr);

        }
    }
}
