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
    public partial class Login_UI : Form
    {
        int persontype;
        public Login_UI(Person p)
        {
            persontype = p.PersonType;
            InitializeComponent();
            textpassword.PasswordChar = '*';
        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string pass = textpassword.Text;
            string user = textusrname.Text;
            if (textpassword.Text == "" || textusrname.Text == "")
            {
                MessageBox.Show("Provide User name and Password");
            }
            else
            {
                if (persontype == 3)
                {
                    if (pass == "admin" && user == "admin")
                    {
                        new Admin_UI().Show();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Credentials Incorrect");
                    }
                }
                else if (persontype == 2)
                {
                    RegisteredDoctorOperations op = new RegisteredDoctorOperations();
                    Doctor D = op.GetDoctor(user, pass);


                    if (D == null)
                    {
                        MessageBox.Show("Credentials Incorrect");

                    }
                    else
                    {
                        MessageBox.Show("Login Succesful ! ," + D.FirstName);
                        new Doctor_UI(D).Show();
                        this.Close();
                    }

                }
                else if (persontype == 1)
                {
                    PatientOperations op = new PatientOperations();
                    Patient P = op.GetPatient(user, pass);
                    if (P == null)
                    {
                        MessageBox.Show("Credentials Incorrect");

                    }
                    else
                    {
                        MessageBox.Show("Login Succesful ! ," + P.FirstName);
                        new Patient_UI(P).Show();
                        this.Close();
                    }

                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            new loginorsignup_UI().Show();
            this.Close();
        }
    }
}
