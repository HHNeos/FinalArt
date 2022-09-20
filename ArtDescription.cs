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
    public partial class ArtDescription : Form
    {
        string connectionString = @"Data Source=DESKTOP-B6E8NPK;Initial Catalog=test;Integrated Security=True";
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B6E8NPK;Initial Catalog=test;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        
        public ArtDescription()
        {
            InitializeComponent();

        }
        //dataGridView1 table = new data();
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            //saving or insertion
            con.Open();
            String query = "INSERT INTO artDescription(paintNumber,paintName,img,artistId,directorId,exhibitionNumber,managingDirectorId) VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("INSERTED SUCCESSFULLY!!!");


        }

        private void Frm1_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
        
        
            void PopulateDataGridView()
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM artDescription", sqlCon);
                    DataTable artDescription = new DataTable();
                    sqlDa.Fill(artDescription);
                    dataGridView1.DataSource = artDescription;
                }

            }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Show ALL
            con.Open();
            String query = "select * from artDescription";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable artDescription = new DataTable();
            SDA.Fill(artDescription);
            dataGridView1.DataSource = artDescription;
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DELETE
            
                cmd = new SqlCommand("delete artDescription where paintNumber=@paintNumber", con);
                con.Open();
                cmd.Parameters.AddWithValue("@paintNumber", textBox9.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //event occured
            /*selecteedRow = e.RowIndex;
            DataGridView row = dataGridView1.Rows[selectedRow];
            textBox2.Text = row.Cells[0].Value.ToString();
            textBox3.Text = row.Cells[1].Value.ToString();
            textBox4.Text = row.Cells[2].Value.ToString();
            textBox5.Text = row.Cells[3].Value.ToString();
            textBox6.Text = row.Cells[4].Value.ToString();
            textBox7.Text = row.Cells[5].Value.ToString();
            textBox8.Text = row.Cells[6].Value.ToString();*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
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

        private void button4_Click(object sender, EventArgs e)
        {
            //Search by name
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B6E8NPK;Initial Catalog=test;Integrated Security=True");
            string query = "select * from artDescription where paintName like @paintName + '%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@paintName", textBox1.Text.Trim());
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //txt change event
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B6E8NPK;Initial Catalog=test;Integrated Security=True");
            string query = "select * from artDescription where paintName like @paintName + '%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@paintName", textBox1.Text.Trim());
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
            //Double click
            if (dataGridView1.CurrentRow.Index != -1)
            {

                textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                button2.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Update
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                cmd = new SqlCommand("update artDescription set paintNumber=@paintNumber,paintName=@paintName,img=@img,artistId=@artistId,directorId=@directorId,exhibitionNumber=@exhibitionNumber,managingDirectorId=@managingDirectorId", con);
                con.Open();
                cmd.Parameters.AddWithValue("@paintNumber", textBox2.Text);
                cmd.Parameters.AddWithValue("@paintName", textBox3.Text);
                cmd.Parameters.AddWithValue("@img", textBox4.Text);
                cmd.Parameters.AddWithValue("@artistId", textBox5.Text);
                cmd.Parameters.AddWithValue("@directorId", textBox6.Text);
                cmd.Parameters.AddWithValue("@exhibitionNumber", textBox7.Text);
                cmd.Parameters.AddWithValue("@managingDirectorId", textBox8.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void lblInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Information info = new Information();
            info.Show();
        }
    }
}
