using System;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            Student_LoginForm student_LoginForm = new Student_LoginForm();
            student_LoginForm.Show();
            this.Hide();
        }
    }
}