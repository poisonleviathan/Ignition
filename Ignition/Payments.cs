using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ignition
{
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if(open.ShowDialog() == DialogResult.OK) 
            { 
               textBox1.Text = open.FileName;
               guna2PictureBox1.Image = new Bitmap(open.FileName);
            }

            guna2Button2.Hide();
            uploadreceiptlabel.Hide();
            textBox1.Hide();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            File.Copy(textBox1.Text, Path.Combine(@"C:\Users\user\Desktop\PROJECT\new\Ignition\Ignition\Receipts\",Path.GetFileName(textBox1.Text)),true);
            label5.Text = "Receipt Saved Successfully..!";

        }

        private void Payments_Load(object sender, EventArgs e)
        {

        }

        private void closeButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
