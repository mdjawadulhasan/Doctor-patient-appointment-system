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
    public partial class loginorsignup : Form
    {
        Person p = new Person();
       
        public loginorsignup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string s = rolecb.SelectedItem.ToString();
            //if (s == "Patient")
            //{
            //    p.PersonType = 1;
            //}
            //else if (s == "Doctor")
            //{
            //    p.PersonType = 2;
            //}
           
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //new Registration().Show();
            //this.Close();
        }

        private void adminlb_Click(object sender, EventArgs e)
        {
            new Login(p).Show();
            this.Hide();
            
        }

        private void loginorsignup_Load(object sender, EventArgs e)
        {
            p.PersonType = 3;
            
            
        }
    }
}
