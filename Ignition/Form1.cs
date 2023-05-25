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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Usignin_btn_Click(object sender, EventArgs e)
        {

            if (Uname_txtbox.Text == "admin" && UPass_txtbox.Text == "admin123")
            {


                Admin_Dashboard admin = new Admin_Dashboard();
                admin.Show();
                this.Hide();
            }
            else
            {
                lbl_incorrect.Visible= true;
            }

        }

        private void Uname_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
