using System;
using System.Drawing;
using System.Windows.Forms;

namespace DogeRadio
{
    public partial class DogeRadio : Form
    {
        public DogeRadio()
        {
            InitializeComponent();
        }

        String[,] URLs =
        {
            // A
            { "Antenne Bayern - DE", "https://stream.antenne.de/antenne/stream/mp3" },
            { "Antenne Vorarlberg - AT", "http://webradio.antennevorarlberg.at/live" },
            // B
            // C
            // D
            // E
            // F
            // G
            // H
            { "Hit Radio - GB", "http://live-bauer-al.sharp-stream.com/key.aac" },
            // I
            // J
            { "JAM FM - DE", "https://stream.jam.fm/jamfm-live/mp3-192/tunein" },
            // K
            // L
            // M
            // N
            // O
            { "Ö3 - AT", "http://ors-sn06.ors-shoutcast.at/oe3-q2a" },
            // P
            // Q
            // R
            { "Radio 1 - CH", "https://stream.radio1.ch/128k" },
            { "Radio Top - CH", "http://icecast.radiotop.ch/radiotop_128" },
            // S
            { "SRF 3 - CH", "http://streaming.swisstxt.ch/m/drs3/mp3_128" },
            { "SRF Musikwelle - CH", "https://stream.srg-ssr.ch/m/drsmw/mp3_128" },
            { "SWR 1 - DE", "https://wdr-edge-30c2-dus-ts-cdn.cast.addradio.de/wdr/1live/live/mp3/128/stream.mp3?_art=dj0yJmlwPTg1LjMuMTAxLjE1NyZpZD1pY3NjeGwtZWs2Nzd2ZG5iJnQ9MTYyNDQ3MTE4NiZzPTc4NjZmMjljIzlkNjJkMjQ5NDNiYTc1N2JlZTNlNDdjYWJjMWJmZmYz" }
            // T
            // U
            // U
            // V
            // W
            // X
            // Y 
        };

        private void DogeRadio_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < URLs.Length / 2; i++)
            {
                drpdwnSender.Items.Add(URLs[i, 0]);
            }
            wmp.settings.volume = 50;
        }

        private void txtBxSender_Enter(object sender, EventArgs e)
        {
            if (txtBxSender.Text == "Eigener Sender")
            {
                txtBxSender.Text = "";
                txtBxSender.ForeColor = Color.Black;
            }
        }

        private void txtBxSender_Leave(object sender, EventArgs e)
        {
            if (txtBxSender.Text == "")
            {
                txtBxSender.Text = "Eigener Sender";
                txtBxSender.ForeColor = Color.Gray;
            }
        }

        private void btnAbspielen_Click(object sender, EventArgs e)
        {
            if (txtBxSender.Text != "")
            {
                wmp.URL = txtBxSender.Text;
            }
        }

        private void drpdwnSender_SelectedIndexChanged(object sender, EventArgs e)
        {
            wmp.URL = URLs[drpdwnSender.SelectedIndex, 1];
        }

        private void btnAbspielen_MouseHover(object sender, EventArgs e)
        {
            btnAbspielen.BackColor = Color.FromArgb(255, 82, 0, 0);
        }

        private void txtBxSender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBxSender.Text.Contains("http"))
                {
                    wmp.URL = txtBxSender.Text;
                }
            }
        }
    }
}