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
    public partial class add_staff : Form
    {
        public add_staff()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void add_staff_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form1 login = new Form1();
            login.Show();
            this.Hide();
            


        }

        private void txtb_Name_TextChanged(object sender, EventArgs e)
        {
            lbl_Name.Visible= false;    
        }

        private void txtb_Email_TextChanged(object sender, EventArgs e)
        {
            lbl_Email.Visible = false;
        }

        private void txtb_Pass_TextChanged(object sender, EventArgs e)
        {
            lbl_Pass.Visible = false;
        }

        private void txtb_Address_TextChanged(object sender, EventArgs e)
        {
            lbl_Address.Visible = false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            lbl_Name.Visible = true;
            lbl_Email.Visible = true;
            lbl_Pass.Visible = true;
            lbl_Address.Visible = true;


        }

        private void btn_home_Click(object sender, EventArgs e)
        {

            Admin_Dashboard admin_ = new Admin_Dashboard();
            admin_.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtb_Name_Click(object sender, EventArgs e)
        {
            lbl_Name.Visible = false;
        }

        private void txtb_Email_Click(object sender, EventArgs e)
        {
            lbl_Email.Visible = false;
        }

        private void txtb_Pass_Click(object sender, EventArgs e)
        {
            lbl_Pass.Visible = false;
        }

        private void txtb_Address_Click(object sender, EventArgs e)
        {
            lbl_Address.Visible = false;
        }
    }
}
