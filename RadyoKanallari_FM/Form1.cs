using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadyoKanallari_FM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBestFm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.7.125/listen.pls";
        }

        private void btnJoyTurk_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://provisioning.streamtheworld.com/pls/JOY_TURKAAC.pls";
        }

        private void btnMetroFm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://provisioning.streamtheworld.com/pls/METRO_FMAAC.pls";
        }

        private void btnPowerFm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://powerfm.listenpowerapp.com/powerfm/mpeg/icecast.audio";
        }

        private void btnIstanbul_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://45.32.154.169:9300/;";
        }

        private void btnTRT_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://trtcanlifm-lh.akamaihd.net/i/TRTFM_1@181846/master.m3u8";
        }

        private void btnSlowTurk_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://r3.rocketcdn.com/slowturk/abr/playlist.m3u8";
        }

        private void btnFenomen_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://fenomen.listenfenomen.com/fenomen/128/icecast.audio";
        }

        private void brnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
