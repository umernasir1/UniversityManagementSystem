using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class Teacher_Form : Form
    {
        public Teacher_Form()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            try
            {
                TID_TextBox.Clear();
                TName_TextBox.Clear();
                Age_TextBox.Clear();
                Gender_ComboBox.SelectedIndex = -1;
                Course_Teacher_ComboBox.SelectedIndex = -1;
                Salary_TextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | University Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Display()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=UniversityManagementSystem;Integrated Security=True");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Teacher", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Teacher_Info_DataGridView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | University Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_Teacher_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Person teacher = new Teacher(int.Parse(TID_TextBox.Text), TName_TextBox.Text, int.Parse(Age_TextBox.Text), Gender_ComboBox.Text, Course_Teacher_ComboBox.Text, int.Parse(Salary_TextBox.Text));
                teacher.GetFile();

                if (MessageBox.Show("Are you sure you want to add new teacher to the database?", "Denko | University Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=UniversityManagementSystem;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Teacher VALUES('" + TID_TextBox.Text + "', '" + TName_TextBox.Text + "', '" + int.Parse(Age_TextBox.Text) + "', '" + Gender_ComboBox.Text + "', '" + Course_Teacher_ComboBox.Text + "', '" + int.Parse(Salary_TextBox.Text) + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("A new teacher is added successfully to the database.", "Denko | University Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Display();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | University Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Teacher_Info_DataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                TID_TextBox.Text = Teacher_Info_DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                TName_TextBox.Text = Teacher_Info_DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                Age_TextBox.Text = Teacher_Info_DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                Gender_ComboBox.Text = Teacher_Info_DataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                Course_Teacher_ComboBox.Text = Teacher_Info_DataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                Salary_TextBox.Text = Teacher_Info_DataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | University Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Display_Button_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void Update_Teacher_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=UniversityManagementSystem;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Teacher SET T_NAME = @tname, AGE = @age, GENDER = @gender, COURSE_TEACHER = @courseTeacher, SALARY = @salary WHERE TID = @tid", con);
                cmd.Parameters.AddWithValue("@tid", TID_TextBox.Text);
                cmd.Parameters.AddWithValue("@tname", TName_TextBox.Text);
                cmd.Parameters.AddWithValue("@age", Age_TextBox.Text);
                cmd.Parameters.AddWithValue("@gender", Gender_ComboBox.SelectedItem);
                cmd.Parameters.AddWithValue("@courseTeacher", Course_Teacher_ComboBox.SelectedItem);
                cmd.Parameters.AddWithValue("@salary", Salary_TextBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Display();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | University Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Teacher_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=UniversityManagementSystem;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Teacher WHERE TID = @tid", con);
                cmd.Parameters.AddWithValue("@tid", TID_TextBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Display();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | University Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}