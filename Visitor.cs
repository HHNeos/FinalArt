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
    public partial class Visitor : Form
    {
        string connectionString = @"Data Source=DESKTOP-B6E8NPK;Initial Catalog=test;Integrated Security=True";
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B6E8NPK;Initial Catalog=test;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public Visitor()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && textBox3.Text != "" )
            {
                cmd = new SqlCommand("update artDescription set paintNumber=@paintNumber,paintName=@paintName,img=@img,artistId=@artistId,directorId=@directorId,exhibitionNumber=@exhibitionNumber,managingDirectorId=@managingDirectorId", con);
                con.Open();
                cmd.Parameters.AddWithValue("@v_id", textBox1.Text);
                cmd.Parameters.AddWithValue("@v_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@v_date", textBox4.Text);
                cmd.Parameters.AddWithValue("@v_time", textBox3.Text);
                
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
            cmd = new SqlCommand("delete artDescription where v_id=@v_id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@v_id", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //insert
            con.Open();
            String query = "INSERT INTO visitor(v_id,v_name,v_date,v_time) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox3.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("INSERTED SUCCESSFULLY!!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //show
            con.Open();
            String query = "select * from visitor";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable visitor = new DataTable();
            SDA.Fill(visitor);
            dataGridView1.DataSource = visitor;
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
            string query = "select * from visitor where paintName like @v_name + '%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@v_name", textBox1.Text.Trim());
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {

                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                
                button2.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Information f2 = new Information();
            f2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B6E8NPK;Initial Catalog=test;Integrated Security=True");
            string query = "select * from visitor where paintName like @v_name + '%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@v_name", textBox1.Text.Trim());
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
