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
    public partial class PaintExhibition : Form
    {
        string connectionString = @"Data Source=DESKTOP-B6E8NPK;Initial Catalog=test;Integrated Security=True";
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B6E8NPK;Initial Catalog=test;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public PaintExhibition()
        {
            InitializeComponent();
            lblTitle.Text = "Exhibition Details";
            //lblHome.Text = "Home";
            btnShowExVisit.Text = "Show Details";
            btnShowPaintEx.Text = "Show Details";
            lblInfo.Text = "Home";
        }

        private void ExhibitionDetails_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShowExVisit_Click(object sender, EventArgs e)
        {
            //Show ALL
            con.Open();
            String query = "select * from visitExhibition";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable visitExhibition = new DataTable();
            SDA.Fill(visitExhibition);
            dataGridView1.DataSource = visitExhibition;
            con.Close();
        }

        private void btnShowPaintEx_Click(object sender, EventArgs e)
        {
            //Show ALL
            con.Open();
            String query = "select * from exhibition";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable exhibition = new DataTable();
            SDA.Fill(exhibition);
            dataGridView3.DataSource = exhibition;
            con.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaintExhibition exd = new PaintExhibition();
            exd.Show();
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            //Home Info
            this.Hide();
            Information info = new Information();
            info.Show();
        }
    }
}
