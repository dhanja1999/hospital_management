using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hospital_management
{
    public partial class Form2 : Form
    {
        public SqlConnection sqlcon = null;
        public Form2()
        {
            InitializeComponent();
            afterdoctorlogin1.Hide();

            try
            {
                sqlcon = new SqlConnection("data source=192.168.1.103,1433 ;database=hospital ;user id='admin'; password='admin' ");
                sqlcon.Open();
                MessageBox.Show(" connection open ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\n" + "Error occured :");
            }
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon = new SqlConnection("data source=192.168.1.103,1433 ;database=hospital ;user id='admin'; password='admin' ");
                sqlcon.Open();
            }
            this.afterdoctorlogin1.setvalue(this, 1);
            this.afterdoctorlogin1.Show();
            this.afterdoctorlogin1.BringToFront();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon = new SqlConnection("data source=192.168.1.103,1433 ;database=hospital ;user id='admin'; password='admin' ");
                sqlcon.Open();
            }
            this.afterdoctorlogin1.setvalue(this, 2);
            afterdoctorlogin1.Show();
            afterdoctorlogin1.BringToFront();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon = new SqlConnection("data source=192.168.1.103,1433 ;database=hospital ;user id='admin'; password='admin' ");
                sqlcon.Open();
            }
            this.afterdoctorlogin1.setvalue(this, 3);
            afterdoctorlogin1.Show();
            afterdoctorlogin1.BringToFront();
        }


    }
}
