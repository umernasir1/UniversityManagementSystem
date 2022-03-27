using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class Student_Form : Form
    {
        public Student_Form()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            try
            {
                SID_TextBox.Clear();
                SName_TextBox.Clear();
                Age_TextBox.Clear();
                Gender_ComboBox.SelectedIndex = -1;
                Course_ComboBox.SelectedIndex = -1;
                Email_TextBox.Clear();
                Address_TextBox.Clear();
                Phone_TextBox.Clear();
                Search_Students_TextBox.Clear();
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
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Student_Info_DataGridView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | University Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Student_Info_DataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                SID_TextBox.Text = Student_Info_DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                SName_TextBox.Text = Student_Info_DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                Age_TextBox.Text = Student_Info_DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                Gender_ComboBox.Text = Student_Info_DataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                Course_ComboBox.Text = Student_Info_DataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                Email_TextBox.Text = Student_Info_DataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                Address_TextBox.Text = Student_Info_DataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                Phone_TextBox.Text = Student_Info_DataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | University Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search_Students_TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=UniversityManagementSystem;Integrated Security=True");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student WHERE S_NAME LIKE '" + Search_Students_TextBox.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Student_Info_DataGridView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | University Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_New_Student_Button_Click_1(object sender, EventArgs e)
        {
            try
            {
                Person student = new Student(int.Parse(SID_TextBox.Text), SName_TextBox.Text, int.Parse(Age_TextBox.Text), Gender_ComboBox.Text, Course_ComboBox.Text, Email_TextBox.Text, Address_TextBox.Text, int.Parse(Phone_TextBox.Text));
                student.GetFile();

                if (MessageBox.Show("Are you sure you want to add new student to the database?", "Denko | University Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=UniversityManagementSystem;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Student VALUES('" + student.ID + "', '" + student.Name + "', '" + student.Age + "', '" + student.Gender + "', '" + Course_ComboBox.Text + "', '" + Email_TextBox.Text + "', '" + Address_TextBox.Text + "', '" + int.Parse(Phone_TextBox.Text) + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Display();
                    Clear();

                    MessageBox.Show("A new student is added successfully to the database.", "Denko | University Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | University Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Display_Students_Button_Click_1(object sender, EventArgs e)
        {
            Display();
            Clear();
        }

        private void Update_Student_Button_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=UniversityManagementSystem;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Student SET S_NAME = @sname, AGE = @age, GENDER = @gender, COURSE = @course, EMAIL = @email, ADDRESS = @address, PHONE = @phone WHERE SID = @sid", con);
                cmd.Parameters.AddWithValue("@sid", SID_TextBox.Text);
                cmd.Parameters.AddWithValue("@sname", SName_TextBox.Text);
                cmd.Parameters.AddWithValue("@age", Age_TextBox.Text);
                cmd.Parameters.AddWithValue("@gender", Gender_ComboBox.SelectedItem);
                cmd.Parameters.AddWithValue("@course", Course_ComboBox.SelectedItem);
                cmd.Parameters.AddWithValue("@email", Email_TextBox.Text);
                cmd.Parameters.AddWithValue("@address", Address_TextBox.Text);
                cmd.Parameters.AddWithValue("@phone", Phone_TextBox.Text);
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

        private void Delete_Student_Button_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=UniversityManagementSystem;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Student WHERE SID = @sid", con);
                cmd.Parameters.AddWithValue("@sid", SID_TextBox.Text);
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

        private void PictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Images";
            ofd.Filter = "Image Files(*.PNG;*.BMP;*.JPG;*.GIF)|*.PNG;*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PictureBox.Image = new Bitmap(ofd.FileName);
            }
        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            PictureBox.Image.Save(ms, PictureBox.Image.RawFormat);
            return ms.GetBuffer();
        }

        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }
    }
}