using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ignition
{
    public partial class memberships : Form
    {
        public memberships()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {






        }

        private void button1_Click(object sender, EventArgs e)
        {
            New_Member new_member = new New_Member();
            new_member.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unfortunately the Equipment page is under Construction", "Under Construction");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            memberships dashboard = new memberships();
            dashboard.Show();
            this.Hide();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {

            Admin_Dashboard dashboard = new Admin_Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();  
            login.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            add_staff addStaff = new add_staff();
            addStaff.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            payments.Show();
            this.Hide();
        }
    }
}
