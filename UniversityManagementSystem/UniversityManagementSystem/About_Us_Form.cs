using System;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class About_Us_Form : Form
    {
        public About_Us_Form()
        {
            InitializeComponent();
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void Button_Back_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}