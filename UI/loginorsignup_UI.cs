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
    public partial class loginorsignup_UI : Form
    {
        Person p = new Person();

        public loginorsignup_UI()
        {
            InitializeComponent();
        }

   


        private void adminlb_Click(object sender, EventArgs e)
        {
            new Login_UI(p).Show();
            this.Hide();

        }

        private void loginorsignup_Load(object sender, EventArgs e)
        {
            p.PersonType = 3;


        }


        private void signupbtn_Click(object sender, EventArgs e)
        {

            if (rolecb.SelectedItem == null)
            {
                MessageBox.Show("Select the role");
            }

            else
            {
                string s = rolecb.SelectedItem.ToString();
                if (s == "Patient")
                {
                    p.PersonType = 1;
                }
                else if (s == "Doctor")
                {
                    p.PersonType = 2;
                }

                if (p.PersonType == 2)
                {
                    new DoctorSIgnup_UI().Show();
                    this.Hide();
                }
                else if (p.PersonType == 1)
                {
                    new PatientSignup_UI().Show();
                    this.Hide();
                }
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (rolecb.SelectedItem == null)
            {
                MessageBox.Show("Select the role");
            }

            else
            {
                string s = rolecb.SelectedItem.ToString();
                if (s == "Patient")
                {
                    p.PersonType = 1;
                }
                else if (s == "Doctor")
                {
                    p.PersonType = 2;
                }


                new Login_UI(p).Show();
                this.Hide();
            }
        }

        private void Exitpicbox_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
