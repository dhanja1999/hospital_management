using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hospital_management
{

    public partial class Form1 : Form
    {
        public SqlCommand cmd;
        public SqlConnection sqlcon;
        public Form1()
        {
            InitializeComponent();
            panel4.Hide();
            panel5.Hide();
            panel3.Hide();
        }

        private void Doctor_Click(object sender, EventArgs e)
        {
            panel3.Show();
            panel4.Hide();
            panel5.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                sqlcon = new SqlConnection("data source=192.168.1.103,1433 ;database=hospital ;user id='admin'; password='admin' ");
                cmd = new SqlCommand("select * from login where doctorname=@name AND doctorpassword=@password", sqlcon);
                sqlcon.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\n" + "Error occured :");
            }
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                MessageBox.Show("welcome ");
                panel3.Hide();
            }
            else
                MessageBox.Show(" check it");



        }

        private void Patient_Click(object sender, EventArgs e)
        {
            panel4.Show();
            panel5.Hide();
            panel3.Hide();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon = new SqlConnection("data source=192.168.1.103,1433 ;database=hospital ;user id='admin'; password='admin' ");
                cmd = new SqlCommand("select * from login where patientname=@name AND patientpassword=@password", sqlcon);
                sqlcon.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\n" + "Error occured :");
            }
            cmd.Parameters.AddWithValue("@name", textBox4.Text);
            cmd.Parameters.AddWithValue("@password", textBox3.Text);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                MessageBox.Show("welcome ");
                panel4.Hide();
            }
            else
                MessageBox.Show(" check it");
        }
        private void Hospital_Click(object sender, EventArgs e)
        {
            panel5.Show();
            panel3.Hide();
            panel4.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon = new SqlConnection("data source=192.168.1.103,1433 ;database=hospital ;user id='admin'; password='admin' ");
                cmd = new SqlCommand("select * from login where hospitalname=@name AND hospitalpassword=@password", sqlcon);
                sqlcon.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\n" + "Error occured :");
            }
            cmd.Parameters.AddWithValue("@name", textBox6.Text);
            cmd.Parameters.AddWithValue("@password", textBox5.Text);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                MessageBox.Show("welcome ");
                panel5.Hide();
            }
            else
                MessageBox.Show(" check it");
        }


    }
}
