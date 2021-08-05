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
    public partial class Patient_UI : Form
    {
        Patient Pt;
        public Patient_UI(Patient P)
        {
            Pt = P;
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            new loginorsignup().Show();
            this.Hide();
        }

        private void Patient_UI_Load(object sender, EventArgs e)
        {
            Ptname.Text= Pt.FirstName + " " + Pt.LastName;
            Ptphone.Text = Pt.Phone;
            Ptage.Text = Convert.ToString(Pt.Age);
            Ptbgrp.Text = Pt.BloodGroup;
            Ptcrndis.Text = Pt.Diseases;
        }
    }
}
