using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalArt
{
    public partial class Register : Form
    {
        string connectionString = @"Data Source=DESKTOP-B6E8NPK;Initial Catalog=test;Integrated Security=True";
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B6E8NPK;Initial Catalog=test;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public Register()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            //update
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && textBox3.Text != "" && textBox8.Text != "" && textBox7.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                cmd = new SqlCommand("update register set r_id=@r_id,r_name=@r_name,p_number=@p_number,email=@email,address=@address,city=@city,password=@password,re_password=@re_password", con);
                con.Open();
                cmd.Parameters.AddWithValue("@r_id", textBox1.Text);
                cmd.Parameters.AddWithValue("@r_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@p_number", textBox4.Text);
                cmd.Parameters.AddWithValue("@email", textBox3.Text);
                cmd.Parameters.AddWithValue("@address", textBox8.Text);
                cmd.Parameters.AddWithValue("@city", textBox7.Text);
                cmd.Parameters.AddWithValue("@password", textBox5.Text);
                cmd.Parameters.AddWithValue("@re_password", textBox6.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();

            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //delete
            cmd = new SqlCommand("delete register where r_id=@r_id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@paintNumber", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //insert
            con.Open();
            String query = "INSERT INTO register(r_is,r_name,p_number,email,address,city,password,re_password) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox8.Text + "','" + textBox7.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("INSERTED SUCCESSFULLY!!!");
            if (textBox5.Text != textBox6.Text)
            {
                MessageBox.Show("password did't match");

            }
            else 
            {
                MessageBox.Show("Registration Successfull");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //show all
            con.Open();
            String query = "select * from register";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable register = new DataTable();
            SDA.Fill(register);
            //dataGridView1.DataSource = register;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //searchby name
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B6E8NPK;Initial Catalog=test;Integrated Security=True");
            string query = "select * from registration where paintName like @paintName + '%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@r_name", textBox1.Text.Trim());
            DataTable data = new DataTable();
            sda.Fill(data);
            //dataGridView1.DataSource = data;
            /*if (data.Rows.Count > 0)
            {
                dataGridView1.DataSource = data;
            }
            else
            {
                MessageBox.Show("No Rows Found");
                dataGridView1.DataSource = null;
            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Information info = new Information();
            info.Show();
        }
    }
}
