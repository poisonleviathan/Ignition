﻿using System;
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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            add_staff add_staff_mem = new add_staff();
            add_staff_mem.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_newMem_Click(object sender, EventArgs e)
        {
            New_Member new_member = new New_Member();
            new_member.Show();
            this.Hide();
        }

        private void btn_Equi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unfortunately the Equipment page is under Construction", "Under Construction");
        }

        private void btn_MemPay_Click(object sender, EventArgs e)
        {
            memberships membership = new memberships();
            membership.Show();
            this.Hide();
        }
    }
}
