using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalArt
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
            lblTitle.Text = "Information Form";
            lblLogOut.Text = "Logout";
            lblExhibition.Text = "Exhibition Details";
            lblTicket.Text = "Ticket Information";
            lblArtist.Text = "Artist Details";
            lblArt.Text = "Art Description";
            lblSecurity.Text = "Security Details";
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Information f2 = new Information();
            f2.Show();
        }

        private void lblSecurity_Click(object sender, EventArgs e)
        {

        }

        private void lblArt_Click(object sender, EventArgs e)
        {
            this.Hide();
            ArtDescription f2 = new ArtDescription();
            f2.Show();
        }

        private void lblArtist_Click(object sender, EventArgs e)
        {
            this.Hide();
            ArtistInformation ai = new ArtistInformation();
            ai.Show();
        }

        private void lblTicket_Click(object sender, EventArgs e)
        {

            this.Hide();
            TicketInfo ti = new TicketInfo();
            ti.Show();
        }

        private void lblExhibition_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //ExhibitionDetails ei = new ExhibitionDetails();
            //ei.Show();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm ti = new LoginForm();
            ti.Show();
        }

        private void Information_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaintExhibition ti = new PaintExhibition();
            ti.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Visitor vi = new Visitor();
            vi.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
