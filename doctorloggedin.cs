using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hospital_management
{
    public partial class doctorloggedin : UserControl
    {
        Form2 form = new Form2();
        // SqlConnection sqlcon;
        public SqlCommand cmd;
        SqlDataReader sdr;

        public doctorloggedin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (form.sqlcon.State == ConnectionState.Closed)
            {
                try
                {
                    form.sqlcon = new SqlConnection("data source=192.168.1.103,1433 ;database=hospital ;user id='admin'; password='admin' ");
                    form.sqlcon.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "Connection not established in doctorlogged in form");
                }
            }
            cmd = new SqlCommand("select * from patient where patient_id='" + textBox1.Text + "';", form.sqlcon);
            //cmd.ExecuteNonQuery();
            sdr = cmd.ExecuteReader();
            sdr.Read();
            textBox2.Text = sdr["patient_name"].ToString();
            textBox3.Text = sdr["patient_age"].ToString();
            textBox4.Text = sdr["patient_weight"].ToString();
            textBox5.Text = sdr["disease"].ToString();
            textBox6.Text = sdr["doctor_priscription"].ToString();
            form.sqlcon.Close();
        }
    }
}
