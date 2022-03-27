using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UniversityManagementSystem
{
    public partial class AttendenceForm : Form
    {
        public AttendenceForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SID_TextBox.Clear();
            Name_TextBox.Clear();
            CID_ComboBox.SelectedIndex = -1;
            CID_ComboBox2.SelectedIndex = -1;
            Status_ComboBox.SelectedIndex = -1;
            dgvAttendenceTaken.Columns.Clear();
        }

        private void btnBacktoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void btnMarkAbsent_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=UniversityManagementSystem;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("INSERT INTO StudentAbsent VALUES(@SID,@S_NAME,@CID,@STATUS)", con);
                cmd.Parameters.AddWithValue("@SID", SID_TextBox.Text);
                cmd.Parameters.AddWithValue("@S_NAME", Name_TextBox.Text);
                cmd.Parameters.AddWithValue("@CID", CID_ComboBox2.Text);
                cmd.Parameters.AddWithValue("@STATUS", Status_ComboBox.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Attendence of the student is taken successfully.", "Denko | University Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | University Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void Display()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=UniversityManagementSystem;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT SID, S_NAME, CID, DEP_NAME, STATUS FROM StudentAbsent INNER JOIN Department ON CID = DEP_ID WHERE CID = " + CID_ComboBox.Text + "", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAttendenceTaken.DataSource = dt;
            con.Close();
        }

        private void dgvAttendenceTaken_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SID_TextBox.Text = dgvAttendenceTaken.Rows[e.RowIndex].Cells[0].Value.ToString();
            Name_TextBox.Text = dgvAttendenceTaken.Rows[e.RowIndex].Cells[1].Value.ToString();
            CID_ComboBox2.Text = dgvAttendenceTaken.Rows[e.RowIndex].Cells[2].Value.ToString();
            Status_ComboBox.Text = dgvAttendenceTaken.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}