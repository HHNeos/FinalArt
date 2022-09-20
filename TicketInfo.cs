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
    public partial class TicketInfo : Form
    {

        string connectionString = @"Data Source=DESKTOP-B6E8NPK;Initial Catalog=test;Integrated Security=True";
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B6E8NPK;Initial Catalog=test;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public TicketInfo()
        {
            InitializeComponent();
        }

       

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.PeachPuff;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Silver;
        }

        private void TicketInfo_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //showall
            con.Open();
            String query = "select * from ticketPrice";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable ticketPrice = new DataTable();
            SDA.Fill(ticketPrice);
            dataGridView1.DataSource = ticketPrice;
            con.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //save
            con.Open();
            String query = "INSERT INTO ticketPrice(t_id,t_date,price,type,r_id) VALUES('" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("INSERTED SUCCESSFULLY!!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //delete

        }
    }
}
