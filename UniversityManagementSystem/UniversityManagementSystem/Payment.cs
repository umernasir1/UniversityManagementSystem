using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void S_Fetch_ID_Button_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void Display()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=UniversityManagementSystem;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT S_NAME, COURSE, COURSE_FEE FROM Student INNER JOIN Course ON SID = '" + SID_TextBox.Text + "'", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    Course_TextBox.Text = sdr.GetValue(0).ToString();
                    S_PID_TextBox.Text = sdr.GetValue(1).ToString();
                    S_Pay_TextBox.Text = sdr.GetValue(2).ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | University Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void S_Pay_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pay Success", "Denko | University Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void T_Fetch_ID_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=UniversityManagementSystem;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Teacher WHERE TID = '" + TID_TextBox.Text + "'", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    Name_TextBox.Text = sdr.GetValue(1).ToString();
                    Course_Teacher_TextBox.Text = sdr.GetValue(4).ToString();
                    Salary_TextBox.Text = sdr.GetValue(5).ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | University Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void T_Pay_Button_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Pay Success", "Denko | University Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}