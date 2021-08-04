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
    public partial class Login : Form
    {
        int persontype;
        public Login(Person p)
        {
            persontype = p.PersonType;
            InitializeComponent();
            textpassword.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(persontype==3)
            {
                if(textpassword.Text=="admin" && textusrname.Text=="admin")
                {
                    new Admin().Show();
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Credentials Incorrect");
                }
            }
        }
    }
}
