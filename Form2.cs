using AxWMPLib;
using jang;
using NAudio.Wave;
using System;
using System.Windows.Forms;
namespace jang
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.MaximumSize = new Size(625, 327);
            this.MinimumSize = new Size(625, 327);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string videoPath = @"D:\jang\WhatsApp Video 2025-03-22 at 16.43.26_03ac49df.mp4";
            axWindowsMediaPlayer1.URL = videoPath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form3 formm = new Form3();
            formm.Show();
            this.Hide();
            string videoPath = @"D:\jang\WhatsApp Video 2025-03-22 at 16.43.26_03ac49df.mp4";
            axWindowsMediaPlayer1.URL = videoPath;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 formm = new Form4();
            formm.Show();
            this.Hide();
            string videoPath = @"D:\jang\WhatsApp Video 2025-03-22 at 16.43.26_03ac49df.mp4";
            axWindowsMediaPlayer1.URL = videoPath;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 formm = new Form1();
            formm.Show();
            this.Hide();
            string videoPath = @"D:\jang\WhatsApp Video 2025-03-22 at 16.43.26_03ac49df.mp4";
            axWindowsMediaPlayer1.URL = videoPath;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
