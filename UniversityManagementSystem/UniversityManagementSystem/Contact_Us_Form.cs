using System;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class Contact_Us_Form : Form
    {
        public Contact_Us_Form()
        {
            InitializeComponent();
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}