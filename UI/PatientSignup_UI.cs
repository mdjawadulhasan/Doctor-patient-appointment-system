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

        private void button1_Click(object sender, EventArgs e)//submit
        {
            Patient P = new Patient();
            PatientOperations op = new PatientOperations();

            bool chk = false;
            string Disease = "";
            if (checkpressureb.Checked == true)
            {
                chk = true;
                Disease = "Blood presure";
            }
            if (checksugerb.Checked == true)
            {
                chk = true;
                Disease = Disease + "  , " + "Diabetes";
            }
            if (checkheartdb.Checked == true)
            {
                chk = true;
                Disease = Disease + "  , " + "Heart Diseases";
            }
            if (checkgastrickb.Checked == true)
            {
                chk = true;
                Disease = Disease + "  , " + "Gastrick";
            }
            if (checkanemiab.Checked == true)
            {
                chk = true;
                Disease = Disease + "  , " + "Anemia";
            }
            if (checkallergyb.Checked)
            {
                chk = true;
                Disease = Disease + "  , " + "Allergy";
            }
            if (checknoneb.Checked == true)
            {
                chk = true;
                Disease = null;
                checkpressureb.Checked = false;
                checksugerb.Checked = false;
                checkheartdb.Checked = false;
                checkgastrickb.Checked = false;
                checkanemiab.Checked = false;
                checkallergyb.Checked = false;

            }
            if(chk==false)
            {
                MessageBox.Show("Disease Fild can not be Empty !");
            }


            P.FirstName = Pfnametxt.Text;
            P.LastName = Plnametxt.Text;
            P.Phone = Pcontacttxt.Text;
            P.Gender = Pgendercb.SelectedItem.ToString();
            P.Age = Convert.ToInt32(Pagetxt.Text);
            P.HeightInCm = Convert.ToInt32(pheighttxt.Text);
            P.WeightInKg = Convert.ToInt32(Pweighttxt.Text);
            P.BloodGroup = Pbgrptxt.SelectedItem.ToString();
            P.UserName = Pusertxt.Text;
            P.Password = Ppasstxt.Text;

            


            

        }
    }
}
