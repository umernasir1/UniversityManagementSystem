using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UniversityManagementSystem
{
    public partial class Student_LoginForm : Form
    {
        public Student_LoginForm()
        {
            InitializeComponent();
            password_TextBox.UseSystemPasswordChar = true;
        }
        private void ShowPassword_CheckBox_CheckedChanged_1(object sender, EventArgs e)
        {

            if (ShowPassword_CheckBox.Checked)
            {
                password_TextBox.UseSystemPasswordChar = false;
            }
            else
            {
                password_TextBox.UseSystemPasswordChar = true;
            }
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.;Initial Catalog=UniversityManagementSystem;Integrated Security=True";
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT username, pass FROM AdminLogin WHERE username = '" + username_TextBox.Text + "' AND pass = '" + password_TextBox.Text + "';", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();

                    username_TextBox.Clear();
                    password_TextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Unsuccessful login.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | University Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}