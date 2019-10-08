using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hospital_management
{
    public partial class afterdoctorlogin : UserControl
    {
        String query1;
        public SqlCommand cmd;
        public Form2 form;
        int val;
        public afterdoctorlogin()
        {
            InitializeComponent();
        }
        public void setvalue(Form2 x, int t)
        {
            form = x;
            this.val = t;

            if (t == 1)
            {
                query1 = "select * from login where doctorname=@name AND doctorpassword=@password";
            }
            else if (t == 2)
            {
                query1 = "select * from login where patientname=@name AND patientpassword=@password";
            }
            else if (t == 3)
            {
                query1 = "select * from login where hospitalname=@name AND hospitalpassword=@password";
            }
        }
        public void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand(query1, form.sqlcon);
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" login Error: " + ex.ToString());
            }
            int count = 0;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ++count;

            }
            form.sqlcon.Close();

            if (count > 0)
            {
                MessageBox.Show(" welcome ");
                form.doctorloggedin1.BringToFront();
            }
            else
            {
                MessageBox.Show(" check it");
            }

        }

    }
}
