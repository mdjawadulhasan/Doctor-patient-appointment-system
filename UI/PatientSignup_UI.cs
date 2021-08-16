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
    public partial class PatientSignup_UI : Form
    {
        public PatientSignup_UI()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
        string Disease = "";
        bool chk = false;
        
        private void button1_Click(object sender, EventArgs e)//submit
        {
            Patient P = new Patient();
            PatientOperations op = new PatientOperations();

            string s = Pfnametxt.Text;
            
            int value;
         
            if (String.IsNullOrEmpty(Pusertxt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(Pfnametxt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (char.IsDigit(s[0]))
            {
                MessageBox.Show("First Letter can not be a number!");
            }
            else if (String.IsNullOrEmpty(Plnametxt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }

            else if (String.IsNullOrEmpty(Pcontacttxt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(Pgendercb.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(Pagetxt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(pheighttxt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(Pweighttxt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(Pbgrptxt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (String.IsNullOrEmpty(Ppasstxt.Text))
            {
                MessageBox.Show("All the information must be filled up!");
            }
            else if (!int.TryParse(Pagetxt.Text.ToString(), out value))
            {
                MessageBox.Show("Age  must be a integer!");
            }
            else if (!int.TryParse(pheighttxt.Text.ToString(), out value))
            {
                MessageBox.Show("Height must be a integer!");
            }
            else if (!int.TryParse(Pweighttxt.Text.ToString(), out value))
            {
                MessageBox.Show("Weight must be a integer!");
            }
            else if (chk == false)
            {
                MessageBox.Show("Disease Fild can not be Empty !");
            }
            else if (Ppasstxt.Text.Length < 5)
            {
                MessageBox.Show("Password is too weak !");
            }
            else
            {
                P.UserName = Pusertxt.Text;
                if (op.CheckSignup(P.UserName) >= 1)
                {
                    MessageBox.Show("Username Already Exists, Select Another !");
                }
                else
                {
                    try
                    {
                        P.FirstName = Pfnametxt.Text;
                        P.LastName = Plnametxt.Text;
                        P.Phone = Pcontacttxt.Text;
                        P.Gender = Pgendercb.SelectedItem.ToString();
                        P.Age = Convert.ToInt32(Pagetxt.Text);
                        P.HeightInCm = Convert.ToInt32(pheighttxt.Text);
                        P.WeightInKg = Convert.ToInt32(Pweighttxt.Text);
                        P.BloodGroup = Pbgrptxt.SelectedItem.ToString();
                        P.Password = Ppasstxt.Text;
                        P.Diseases = Disease;
                        op.InsertPatient(P);
                        MessageBox.Show("Signup Succes !");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Provide the Information correctly");
                    }
                }
            }



        }

        private void checknoneb_CheckedChanged(object sender, EventArgs e)
        {
            if (checknoneb.Checked == true)
            {
                chk = true;
                checkpressureb.Checked = false;
                checksugerb.Checked = false;
                checkheartdb.Checked = false;
                checkgastrickb.Checked = false;
                checkanemiab.Checked = false;
                checkallergyb.Checked = false;
                Disease = "";

            }
            else
            {
                chk =false;
            }
        }

        private void checkpressureb_CheckedChanged(object sender, EventArgs e)
        {
            if (checkpressureb.Checked == true)
            {
                checknoneb.Checked = false;
                chk = true;
                Disease = Disease+" "+"Blood Pressure";
            }
            else
            {
                Disease= (Disease.Replace("Blood Pressure", ""));
                chk = false;
            }
        }

        

        private void checksugerb_CheckedChanged(object sender, EventArgs e)
        {
            if (checksugerb.Checked == true)
            {
                checknoneb.Checked = false;
                chk = true;
                Disease = Disease + "  " + "Diabetes";
            }
            else
            {
                Disease = (Disease.Replace("Diabetes",""));
                chk = false;
            }
        }

        private void checkheartdb_CheckedChanged(object sender, EventArgs e)
        {
            if (checkheartdb.Checked == true)
            {
                checknoneb.Checked = false;
                chk = true;
                Disease = Disease + "  " + "Heart Diseases";
            }
            else
            {
                Disease = (Disease.Replace("Heart Diseases", ""));
                chk = false;
            }
        }

        private void checkgastrickb_CheckedChanged(object sender, EventArgs e)
        {
            if (checkgastrickb.Checked == true)
            {
                checknoneb.Checked = false;
                chk = true;
                Disease = Disease + "  " + "Gastrick";
            }
            else
            {
                Disease = (Disease.Replace("Gastrick", ""));
                chk = false;
            }
        }

        private void checkanemiab_CheckedChanged(object sender, EventArgs e)
        {
            if (checkanemiab.Checked == true)
            {
                checknoneb.Checked = false;
                chk = true;
                Disease = Disease + "  " + "Anemia";
            }
            else
            {
                Disease = (Disease.Replace("Anemia", ""));
                chk = false;
            }
        }

        private void checkallergyb_CheckedChanged(object sender, EventArgs e)
        {
            if (checkallergyb.Checked)
            {
                checknoneb.Checked = false;
                chk = true;
                Disease = Disease + "  " + "Allergy";
            }
            else
            {
                Disease = (Disease.Replace("Allergy", ""));
                chk = false;
            }
        }


        private void btnexit_Click(object sender, EventArgs e)
        {
            new loginorsignup_UI().Show();
            this.Hide();
        }

        private void pheighttxt_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Give an Integer Value";
        }

        private void pheighttxt_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void Pweighttxt_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Give an Integer Value";
        }

        private void Pweighttxt_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
    }
}
