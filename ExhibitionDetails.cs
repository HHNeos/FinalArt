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
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=DESKTOP-B6E8NPK;Initial Catalog=test;Integrated Security=True";
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B6E8NPK;Initial Catalog=test;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Information info = new Information();
            info.Show();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            //update
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && textBox3.Text != "" && textBox5.Text != "" )
            {
                cmd = new SqlCommand("update exhibition set ex_number=@ex_number,ex_name=@ex_name,ex_date=@ex_date,ex_type=@ex_type,ex_floor=@ex_floor", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ex_number", textBox1.Text);
                cmd.Parameters.AddWithValue("@ex_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@ex_date", textBox4.Text);
                cmd.Parameters.AddWithValue("@ex_type", textBox3.Text);
                cmd.Parameters.AddWithValue("@e_floor", textBox5.Text);
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
            cmd = new SqlCommand("delete artDescription where ex_number=@ex_number", con);
            con.Open();
            cmd.Parameters.AddWithValue("@ex_number", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //insert
            con.Open();
            String query = "INSERT INTO exhibition(ex_number,ex_name,ex_date,ex_type,ex_floor) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox5.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("INSERTED SUCCESSFULLY!!!");
        }

        void PopulateDataGridView()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM exhibition", sqlCon);
                DataTable exhibition = new DataTable();
                sqlDa.Fill(exhibition);
                dataGridView1.DataSource = exhibition;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //showall
            con.Open();
            String query = "select * from exhibition";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable exhibition = new DataTable();
            SDA.Fill(exhibition);
            dataGridView1.DataSource = exhibition;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //clear
            ClearAllText(this);
        }
        void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //search by name
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B6E8NPK;Initial Catalog=test;Integrated Security=True");
            string query = "select * from exhibition where ex_name like @ex_name + '%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@ex_name", textBox1.Text.Trim());
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            if (data.Rows.Count > 0)
            {
                dataGridView1.DataSource = data;
            }
            else
            {
                MessageBox.Show("No Rows Found");
                dataGridView1.DataSource = null;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
       /* void PopulateDataGridView()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM exhibition", sqlCon);
                DataTable exhibition = new DataTable();
                sqlDa.Fill(exhibition);
                dataGridView1.DataSource = exhibition;
            }

        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //txt change event
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B6E8NPK;Initial Catalog=test;Integrated Security=True");
            string query = "select * from exhibition where ex_name like @ex_name + '%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@ex_name", textBox1.Text.Trim());
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            if (data.Rows.Count > 0)
            {
                dataGridView1.DataSource = data;
            }
            else
            {
                MessageBox.Show("No Rows Found");
                dataGridView1.DataSource = null;
            }
        }
    }
}
