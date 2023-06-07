using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Ignition
{
    public partial class New_Member : Form
    {
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());


        public New_Member()
        {

            InitializeComponent();
            DispMember();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void New_Member_Load(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
            lbl_Name.Visible = true;
            lbl_Email.Visible = true;
            lbl_Phone.Visible = true;
            lbl_Address.Visible = true;



        }
        private void reset()
        {
            txtb_Name.Text = "";
            txtb_Phone.Text = "";
            txtb_Email.Text = "";
            txtb_Address.Text = "";
        }

        private void txtb_Name_TextChanged(object sender, EventArgs e)
        {
            lbl_Name.Visible = false;
        }

        private void txtb_Phone_TextChanged(object sender, EventArgs e)
        {
            lbl_Phone.Visible = false;
        }

        private void txtb_Email_TextChanged(object sender, EventArgs e)
        {
            lbl_Email.Visible = false;
        }

        private void txtb_Address_TextChanged(object sender, EventArgs e)
        {
            lbl_Address.Visible = false;
        }

        private void txtb_Name_Click(object sender, EventArgs e)
        {
            lbl_Name.Visible = false;
        }

        private void txtb_Email_Click(object sender, EventArgs e)
        {
            lbl_Email.Visible = false;
        }

        private void txtb_Phone_Click(object sender, EventArgs e)
        {
            lbl_Phone.Visible = false;
        }

        private void txtb_Address_Click(object sender, EventArgs e)
        {
            lbl_Address.Visible = false;
        }

        private void DispMember()
        {

            //select all from table and fill the datagridview with the data in the table
            Conn.Open();
            string query = "SELECT * FROM MemberTbl";
            SqlDataAdapter adp = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adp);
            var dataset = new DataSet();
            adp.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];

            Conn.Close();
        }
        private void label9_Click(object sender, EventArgs e)
        {
            if (txtb_Name.Text == "" || txtb_Phone.Text == "" || txtb_Email.Text == "" || txtb_Address.Text == "")
            {
                MessageBox.Show("Please Add The Missing Information", "Ignition", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                    Conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO MemberTbl (Name, Phone, Email, Address) VALUES (@Sn,@Sp,@Se,@Sadd)", Conn);
                    //add parameter with name and value pairs and passed through to the sql query
                    cmd.Parameters.AddWithValue("@Sn", txtb_Name.Text);
                    cmd.Parameters.AddWithValue("@Sp", txtb_Phone.Text);
                    cmd.Parameters.AddWithValue("@Se", txtb_Email.Text);
                    cmd.Parameters.AddWithValue("@Sadd", txtb_Address.Text);

                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Member Saved!", "Ignition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ignition", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally //code in the final block gets executed no matter what
                {
                    Conn.Close();
                }

                reset();
                lbl_Name.Visible = true;
                lbl_Email.Visible = true;
                lbl_Phone.Visible = true;
                lbl_Address.Visible = true;
                DispMember();//shows the updated table after saving
            }
        }
        int selectedRow = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtb_Name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtb_Phone.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
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
            if (txtb_Name.Text == "" || txtb_Phone.Text == "" || txtb_Email.Text == "" || txtb_Address.Text == "")
            {
                MessageBox.Show("Please Add The Missing Information", "Ignition", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    Conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE MemberTbl SET Name=@Sn, Phone=@Sp, Email=@Se, Address=@Sadd WHERE MemberID=@Sr", Conn);
                    //add parameter with name and value
                    cmd.Parameters.AddWithValue("@Sn", txtb_Name.Text);
                    cmd.Parameters.AddWithValue("@Sp", txtb_Phone.Text);
                    cmd.Parameters.AddWithValue("@Se", txtb_Email.Text);
                    cmd.Parameters.AddWithValue("@Sadd", txtb_Address.Text);

                    cmd.Parameters.AddWithValue("@Sr", selectedRow);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Member Updated!", "Ignition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ignition", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { Conn.Close(); }

                reset();
                lbl_Name.Visible = true;
                lbl_Email.Visible = true;
                lbl_Phone.Visible = true;
                lbl_Address.Visible = true;
                DispMember();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Are you sure you want to delete this record?", "Ignition", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    Conn.Open();
                    string sql = "DELETE FROM MemberTbl WHERE MemberID=@Sr";
                    SqlCommand cmd = new SqlCommand(sql, Conn);
                    cmd.Parameters.AddWithValue("@Sr", selectedRow);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Successfully Deleted", "Ignition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
            lbl_Phone.Visible = true;
            lbl_Address.Visible = true;
            DispMember();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            add_staff sf = new add_staff();
            sf.Show();
            this.Hide();
        }
    } 
}
