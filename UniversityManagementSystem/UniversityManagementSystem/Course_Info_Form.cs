using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class Course_Info_Form : Form
    {
        public Course_Info_Form()
        {
            InitializeComponent();
        }

        private void Check_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=UniversityManagementSystem;Integrated Security=True");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT SID, S_NAME, T_NAME, DEP_ID, COURSE_TEACHER, DEP_HEAD FROM Department INNER JOIN Teacher ON COURSE_TEACHER = DEP_NAME INNER JOIN Student ON COURSE = DEP_NAME WHERE COURSE_TEACHER = '" + Course_ComboBox.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Course_Info_DataGridView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | University Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}