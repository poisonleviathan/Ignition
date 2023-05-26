using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ignition
{
    public partial class add_staff : Form
    {
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        public add_staff()
        {
            InitializeComponent();
            DispStaff();
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
            lbl_Name.Visible = false;
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

        private void label9_Click(object sender, EventArgs e)
        {
            if (txtb_Name.Text == "" || txtb_Pass.Text == "" || txtb_Email.Text == "" || txtb_Address.Text == "")
            {
                MessageBox.Show("Please Add The Missing Information", "Ignition", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                    Conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO StaffTbl (Name, Password, Email, Address) VALUES (@Sn,@Sp,@Se,@Sadd)", Conn);
                    //add parameter with name and value pairs and passed through to the sql query
                    cmd.Parameters.AddWithValue("@Sn", txtb_Name.Text);
                    cmd.Parameters.AddWithValue("@Sp", txtb_Pass.Text);
                    cmd.Parameters.AddWithValue("@Se", txtb_Email.Text);
                    cmd.Parameters.AddWithValue("@Sadd", txtb_Address.Text);

                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Staff Member Saved!", "Ignition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ignition", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Conn.Close();
                }
               
                reset();
                lbl_Name.Visible = true;
                lbl_Email.Visible = true;
                lbl_Pass.Visible = true;
                lbl_Address.Visible = true;
                DispStaff(); //shows the updated table after saving
            }

        }
        private void DispStaff()
        {
            //select all from table and fill the datagridview with the data in the table
            Conn.Open();
            string query = "SELECT * FROM StaffTbl";
            SqlDataAdapter adp = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adp);
            var dataset = new DataSet();
            adp.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];

            Conn.Close();
        }
        int selectedRow = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtb_Name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtb_Pass.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtb_Email.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtb_Address.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            if (txtb_Name.Text == "")
            {
                selectedRow = 0;
            }
            else
            {
                selectedRow = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (txtb_Name.Text == "" || txtb_Pass.Text == "" || txtb_Email.Text == "" || txtb_Address.Text == "")
            {
                MessageBox.Show("Please Add The Missing Information", "Ignition", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    Conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE StaffTbl SET Name=@Sn, Password=@Sp, Email=@Se, Address=@Sadd WHERE StaffID=@Sr", Conn);
                    //add parameter with name and value
                    cmd.Parameters.AddWithValue("@Sn", txtb_Name.Text);
                    cmd.Parameters.AddWithValue("@Sp", txtb_Pass.Text);
                    cmd.Parameters.AddWithValue("@Se", txtb_Email.Text);
                    cmd.Parameters.AddWithValue("@Sadd", txtb_Address.Text);

                    cmd.Parameters.AddWithValue("@Sr", selectedRow);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Staff Member Updated!", "Ignition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ignition", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { Conn.Close(); }
                
                reset();
                lbl_Name.Visible = true;
                lbl_Email.Visible = true;
                lbl_Pass.Visible = true;
                lbl_Address.Visible = true;
                DispStaff();
         
            }
        
           
           
        }
        private void reset()
        {
            txtb_Name.Text = "";
            txtb_Pass.Text = "";
            txtb_Email.Text = "";
            txtb_Address.Text = "";
        }
    }
}
