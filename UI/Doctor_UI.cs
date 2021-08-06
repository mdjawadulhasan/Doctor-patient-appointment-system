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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new loginorsignup().Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void ViewAptlist_Click(object sender, EventArgs e)
        {
            new ViewAppointmentList(Dr).Show();
            this.Hide();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            new loginorsignup().Show();
            this.Show();
        }
    }
}
