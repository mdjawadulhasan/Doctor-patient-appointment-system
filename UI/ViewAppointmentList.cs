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
    public partial class ViewAppointmentList : Form
    {
        Doctor Dr;
        public ViewAppointmentList(Doctor D)
        {
            Dr = D;
            InitializeComponent();
        }

        void populateData()
        {
            AppointmentOperations OP = new AppointmentOperations();
            DataSet ds = OP.ShowDtAptList(Dr.id);
            DrAptList.DataSource = ds.Tables[0];

        }

        private void ViewAppointmentList_Load(object sender, EventArgs e)
        {
           populateData();
            this.DrAptList.Columns["Apid"].Visible = false;
            this.DrAptList.Columns["Pid"].Visible = false;
            this.DrAptList.Columns["Did"].Visible = false;

            DrAptList.Columns["Patname"].HeaderText = "Name";
            DrAptList.Columns["Patusername"].HeaderText = "Usre Name";
            DrAptList.Columns["Doctorname"].HeaderText = "Doctor Name";
            DrAptList.Columns["AppDAte"].HeaderText = "Appointment Date";
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            AppointmentOperations OP = new AppointmentOperations();
            if (key == 0)
            {
                MessageBox.Show("Select the Appointmnet");
            }
            else
            {
                try
                {

                    OP.DeleteApt(key);
                    MessageBox.Show("Appointmnet Succesfully Deleted");
                    dltlb.Text = null;
                    populateData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        int key = 0;
        private void DrAptList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DrAptList.Rows[e.RowIndex];
                dltlb.Text = row.Cells["Doctorname"].Value.ToString();
            }

            if (dltlb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DrAptList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Doctor_UI(Dr).Show();
            this.Hide();
        }

        private void Trtload_Click(object sender, EventArgs e)
        {
            new TreatmentUI(Dr).Show();
            this.Hide();
        }

        private void Logoutpage_Click(object sender, EventArgs e)
        {
            new loginorsignup().Show();
            this.Hide();
        }
    }
}
