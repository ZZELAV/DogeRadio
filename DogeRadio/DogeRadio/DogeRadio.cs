using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            { "Antenne Bayern Musik - DE", "https://s10-webradio.antenne.de/nur-die-musik" },
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
                cbSender.Items.Add(URLs[i, 0]);
            }
            wmp.settings.volume = 50;
        }

        private void tbSender_Enter(object sender, EventArgs e)
        {
            if (tbSender.Text == "Eigener Sender")
            {
                tbSender.Text = "";
                tbSender.ForeColor = Color.Black;
            }
        }

        private void tbSender_Leave(object sender, EventArgs e)
        {
            if (tbSender.Text == "")
            {
                tbSender.Text = "Eigener Sender";
                tbSender.ForeColor = Color.Gray;
            }
        }

        private void btnAbspielen_Click(object sender, EventArgs e)
        {
            if (tbSender.Text.Contains("http"))
            {
                wmp.URL = tbSender.Text;
                pbDogeGif.Enabled = true;
            }
        }

        private void cbSender_SelectedIndexChanged(object sender, EventArgs e)
        {
            wmp.URL = URLs[cbSender.SelectedIndex, 1];
            pbDogeGif.Enabled = true;
        }

        private void btnAbspielen_MouseHover(object sender, EventArgs e)
        {
            btnAbspielen.BackColor = Color.FromArgb(255, 82, 0, 0);
        }

        private void cbSender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbSender.Text.Contains("http"))
                {
                    wmp.URL = tbSender.Text;
                    pbDogeGif.Enabled = true;
                }
            }
        }
    }
}
