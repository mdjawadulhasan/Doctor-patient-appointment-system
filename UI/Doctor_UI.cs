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
    public partial class Doctor_UI : Form
    {
        Doctor Dr;
        public Doctor_UI(Doctor D)
        {
            Dr = D;
            InitializeComponent();
        }

        private void Doctor_UI_Load(object sender, EventArgs e)
        {
            Drname.Text = Dr.FirstName +" " + Dr.LastName;
            Drdpt.Text = Dr.Department;
            Drvdays.Text = Dr.visiting_days;
            Drvhrs.Text = Dr.Visitng_Hours;
            Drhcham.Text = Dr.Chammber;

        }

        private void Logoutpicbox_Click(object sender, EventArgs e)
        {
            new loginorsignup_UI().Show();
            this.Hide();
        }

        private void Givetreatmentpicbox_Click(object sender, EventArgs e)
        {
            new TreatmentUI(Dr).Show();
            this.Hide();
        }

        private void Aptlistpicbox_Click(object sender, EventArgs e)
        {
            new ViewAppointmentList_UI(Dr).Show();
            this.Hide();
        }
    }
}
