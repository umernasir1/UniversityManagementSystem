using System;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            DateTime now = DateTime.Now;
            Success_DateTime_Label.Text = now.ToString();
        }

        private void Attendance_Button_Click(object sender, EventArgs e)
        {
            AttendenceForm attendenceForm = new AttendenceForm();
            attendenceForm.ShowDialog();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Log_Out_Click(object sender, EventArgs e)
        {
            Course_Info_Form course_Info_Form = new Course_Info_Form();
            course_Info_Form.Show();
        }

        private void Button_Student_Click(object sender, EventArgs e)
        {
            Student_Form student_Form = new Student_Form();
            student_Form.Show();
        }

        private void Button_About_Us_Click(object sender, EventArgs e)
        {
            About_Us_Form about_Us_Form = new About_Us_Form();
            about_Us_Form.Show();
        }

        private void Button_Contact_Us_Click(object sender, EventArgs e)
        {
            Contact_Us_Form contact_Us_Form = new Contact_Us_Form();
            contact_Us_Form.Show();
        }

        private void Button_Teacher_Click(object sender, EventArgs e)
        {
            Teacher_Form teacher_Form = new Teacher_Form();
            teacher_Form.Show();
        }

        private void Button_Payment_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
        }
    }
}