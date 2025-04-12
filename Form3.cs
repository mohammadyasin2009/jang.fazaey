using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
namespace jang
{
    public partial class Form3 : Form
    {
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;
        public Form3()
        {
            InitializeComponent();
            this.MaximumSize = new Size(882, 489);
            this.MinimumSize = new Size(882, 489);
            PlayAudio(@"D:\jang\setting.wav");
        }
        private void PlayAudio(string filePath)
        {
            waveOutDevice = new WaveOutEvent();
            audioFileReader = new AudioFileReader(filePath);
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("شما برای انتخاب عکس ها  یا گزینه ها برای بازی فقط" +
                " باید کلیک کنید تا اون عکس یا اون کار به عنوان پبشفرض در تمام بازی انتخاب شود." +
                "نکته:با انتخاب 2 عکس با هم یا 2 کار عکس اخری با گزینه اخری که انتخاب شده به عنوان پیشفرض انتخاب شود");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string soundplay = @"D:\jang\mose.wav";
            using (SoundPlayer player = new SoundPlayer(soundplay))
            {
                player.Play();
            }
            global.change = true;
            global1.change1 = false;
            global2.change2 = false;
            MessageBox.Show("عملیات با موفقیت انجام شد");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string soundplay = @"D:\jang\mose.wav";
            using (SoundPlayer player = new SoundPlayer(soundplay))
            {
                player.Play();
            }
            global1.change1 = true;
            global.change = false;
            global2.change2 = false;
            MessageBox.Show("عملیات با موفقیت انجام شد");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string soundplay = @"D:\jang\mose.wav";
            using (SoundPlayer player = new SoundPlayer(soundplay))
            {
                player.Play();
            }
            global2.change2 = true;
            global1.change1 = false;
            global.change = false;
            MessageBox.Show("عملیات با موفقیت انجام شد");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string soundplay = @"D:\jang\mose.wav";
            using (SoundPlayer player = new SoundPlayer(soundplay))
            {
                player.Play();
            }
            moshack.moshack1 = true;
            moshack1.moshack2 = false;
            moshack2.moshack3 = false;
            MessageBox.Show("عملیات با موفقیت انجام شد");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string soundplay = @"D:\jang\mose.wav";
            using (SoundPlayer player = new SoundPlayer(soundplay))
            {
                player.Play();
            }
            moshack.moshack1 = false;
            moshack1.moshack2 = true;
            moshack2.moshack3 = false;
            MessageBox.Show("عملیات با موفقیت انجام شد");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string soundplay = @"D:\jang\mose.wav";
            using (SoundPlayer player = new SoundPlayer(soundplay))
            {
                player.Play();
            }
            moshack.moshack1 = false;
            moshack1.moshack2 = false;
            moshack2.moshack3 = true;
            MessageBox.Show("عملیات با موفقیت انجام شد");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string soundplay = @"D:\jang\mose.wav";
            using (SoundPlayer player = new SoundPlayer(soundplay))
            {
                player.Play();
            }
            tir.tir1 = true;
            tir1.tir2 = false;
            tir2.tir3 = false;
            MessageBox.Show("عملیات با موفقیت انجام شد");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string soundplay = @"D:\jang\mose.wav";
            using (SoundPlayer player = new SoundPlayer(soundplay))
            {
                player.Play();
            }
            tir.tir1 = false;
            tir1.tir2 = true;
            tir2.tir3 = false;
            MessageBox.Show("عملیات با موفقیت انجام شد");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string soundplay = @"D:\jang\mose.wav";
            using (SoundPlayer player = new SoundPlayer(soundplay))
            {
                player.Play();
            }
            eazy.eazy1 = true;
            medium.medium1 = false;
            hard.hard1 = false;
            MessageBox.Show("عملیات با موفقیت انجام شد");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string soundplay = @"D:\jang\mose.wav";
            using (SoundPlayer player = new SoundPlayer(soundplay))
            {
                player.Play();
            }
            eazy.eazy1 = false;
            medium.medium1 = true;
            hard.hard1 = false;
            MessageBox.Show("عملیات با موفقیت انجام شد");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string soundplay = @"D:\jang\mose.wav";
            using (SoundPlayer player = new SoundPlayer(soundplay))
            {
                player.Play();
            }
            eazy.eazy1 = false;
            medium.medium1 = false;
            hard.hard1 = true;
            MessageBox.Show("عملیات با موفقیت انجام شد");
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            waveOutDevice.Pause();
            Form3 fom4 = new Form3();
            fom4.Close();
            Form2 fom3 = new Form2();
            fom3.Show();
            waveOutDevice.Pause();
            waveOutDevice.Stop();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("عملیات با موفقیت انجام شد");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
            waveOutDevice.Pause();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string soundplay = @"D:\jang\mose.wav";
            using (SoundPlayer player = new SoundPlayer(soundplay))
            {
                player.Play();
            }
            tir.tir1 = false;
            tir1.tir2 = false;
            tir2.tir3 = true;
            MessageBox.Show("عملیات با موفقیت انجام شد");
        }
    }
    public static class global
    {
        public static bool change = false;
    }
    public static class global1
    {
        public static bool change1 = false;
    }
    public static class global2
    {
        public static bool change2 = false;
    }
    public static class moshack
    {
        public static bool moshack1 = false;
    }
    public static class moshack1
    {
        public static bool moshack2 = false;
    }
    public static class moshack2
    {
        public static bool moshack3 = false;
    }
    public static class tir
    {
        public static bool tir1 = false;
    }
    public static class tir1
    {
        public static bool tir2 = false;
    }
    public static class tir2
    {
        public static bool tir3 = false;
    }
    public static class eazy
    {
        public static bool eazy1 = false;
    }
    public static class medium
    {
        public static bool medium1 = false;
    }
    public static class hard
    {
        public static bool hard1 = false;
    }
}
