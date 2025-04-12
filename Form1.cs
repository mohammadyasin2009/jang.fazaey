using System;
using System.Windows.Forms;
using NAudio.Wave;
using System.Media;
using System.Linq.Expressions;
namespace jang
{
    public partial class Form1 : Form
    {
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer9.Interval = 10;
            timer9.Tick += timer9_Tick!;
            timer8.Interval = 10;
            timer8.Tick += timer8_Tick!;
            timer7.Interval = 10;
            timer7.Tick += timer7_Tick!;
            timer6.Interval = 10;
            timer6.Tick += timer6_Tick!;
            timer3.Interval = 10;
            timer3.Tick += timer3_Tick!;
            timer14.Interval = 10;
            timer14.Tick += timer9_Tick!;
            this.MinimumSize = new Size(505, 572);
            this.MaximumSize = new Size(505, 572);
            Position();
            emtiazat();
            PlayAudio(@"D:\jang\music game.wav");
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            waveOutDevice.Pause();
            Form1 fom4 = new Form1();
            fom4.Close();
            Form2 fom3 = new Form2();
            fom3.Show();
        }
        private void PlayAudio(string filePath)
        {
            waveOutDevice = new WaveOutEvent();
            audioFileReader = new AudioFileReader(filePath);
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
        }
        bool pic1 = false;
        bool pic2 = false;
        bool pic3 = false;
        bool pic4 = false;
        bool pic5 = false;
        bool pic6 = false;
        bool pic7 = false;
        bool pic8 = false;
        bool dosh1 = false;
        bool dosh2 = false;
        bool dosh3 = false;
        bool dosh4 = false;
        bool dosh5 = false;
        bool dosh6 = false;
        bool ghab = false;
        bool setaree = false;
        bool setare1 = false;
        bool shahab = false;
        bool Y = false;
        bool T = false;
        private int roh = 0;
        private int roh1 = 0;
        bool dom = false;
        int co = 0;
        private Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            control();
            sora();
            check();
            if (pictureBox8.Location.Y == 535)
            {
                Pic8();
                emtiaz += 1;
                timer3.Start();
                emtiazat();
                label4.Text = emtiaz.ToString();
            }
            else if (pictureBox9.Location.Y == 535)
            {
                Pic9();
                emtiaz += 1;
                timer6.Start();
                emtiazat();
                label4.Text = emtiaz.ToString();
            }
            else if (pictureBox7.Location.Y == 535)
            {
                Pic7();
                emtiaz += 1;
                timer7.Start();
                emtiazat();
                label4.Text = emtiaz.ToString();
            }
            else if (pictureBox14.Location.Y >= 535)
            {
                Pic14();
                emtiaz += 1;
                timer8.Start();
                emtiazat();
                label4.Text = emtiaz.ToString();
            }
            else if (pictureBox15.Location.Y >= 535)
            {
                Pic15();
                emtiaz += 1;
                timer9.Start();
                emtiazat();
                label4.Text = emtiaz.ToString();
            }
            else if (label6.Location.Y >= 535 && pictureBox14.Location.Y >= 125)
            {
                postgal();
            }
            else if (pictureBox1.Location.Y >= 535)
            {
                setare();
                shahabb();
            }
            if (pictureBox9.Location.Y > 125)
            {
                dosh4 = true;
                dosh5 = true;
            }
            if (pictureBox9.Location.Y > 225)
            {
                dosh6 = true;
            }
            if (pictureBox14.Location.Y > 125)
            {
                ghab = true;
                dosh3 = false;
            }
            if (pictureBox8.Location.Y > 125)
            {
                dosh1 = false;
                dosh2 = false;
                setaree = true;
                setare1 = true;
                dom = true;
                shahab = true;
            }
            if (pic1)
            {
                int tir = pictureBox2.Location.X;
                int tir1 = pictureBox2.Location.Y - 5;
                pictureBox2.Location = new Point(tir, tir1);
            }
            if (pic2)
            {
                int bomb = pictureBox3.Location.X;
                int bomb1 = pictureBox3.Location.Y - 5;
                pictureBox3.Location = new Point(bomb, bomb1);
            }
            if (pic3)
            {
                int bomb = pictureBox4.Location.X;
                int bomb1 = pictureBox4.Location.Y - 5;
                pictureBox4.Location = new Point(bomb, bomb1);
            }
            if (pic4)
            {
                int bo = pictureBox5.Location.X;
                int bo1 = pictureBox5.Location.Y - 5;
                pictureBox5.Location = new Point(bo, bo1);

            }
            if (pic5)
            {
                int tir = pictureBox10.Location.X;
                int tir1 = pictureBox10.Location.Y - 5;
                pictureBox10.Location = new Point(tir, tir1);
            }
            if (pic6)
            {
                int bomb = pictureBox11.Location.X;
                int bomb1 = pictureBox11.Location.Y - 5;
                pictureBox11.Location = new Point(bomb, bomb1);
            }
            if (pic7)
            {
                int tir = pictureBox13.Location.X;
                int tir1 = pictureBox13.Location.Y - 5;
                pictureBox13.Location = new Point(tir, tir1);
            }
            if (pic8)
            {
                int bomb = pictureBox12.Location.X;
                int bomb1 = pictureBox12.Location.Y - 5;
                pictureBox12.Location = new Point(bomb, bomb1);
            }
            if (!dosh1)
            {
                int tir = pictureBox8.Location.X;
                int tir1 = pictureBox8.Location.Y + 5;
                pictureBox8.Location = new Point(tir, tir1);
            }
            if (!dosh2)
            {
                int bomb = pictureBox7.Location.X;
                int bomb1 = pictureBox7.Location.Y + 5;
                pictureBox7.Location = new Point(bomb, bomb1);
            }
            if (!dosh3)
            {
                int bomb = pictureBox9.Location.X;
                int bomb1 = pictureBox9.Location.Y + 5;
                pictureBox9.Location = new Point(bomb, bomb1);
            }
            if (dosh4)
            {
                int bomb = pictureBox15.Location.X;
                int bomb1 = pictureBox15.Location.Y + 5;
                pictureBox15.Location = new Point(bomb, bomb1);
            }
            if (dosh5)
            {
                int bomb = pictureBox14.Location.X;
                int bomb1 = pictureBox14.Location.Y + 5;
                pictureBox14.Location = new Point(bomb, bomb1);
            }
            if (dosh6)
            {
                int bomb = pictureBox19.Location.X;
                int bomb1 = pictureBox19.Location.Y + 5;
                pictureBox19.Location = new Point(bomb, bomb1);
            }
            if (ghab)
            {
                int bomb = label6.Location.X;
                int bomb1 = label6.Location.Y + 5;
                label6.Location = new Point(bomb, bomb1);
            }
            if (setaree)
            {
                int bomb = pictureBox1.Location.X;
                int bomb1 = pictureBox1.Location.Y + 5;
                pictureBox1.Location = new Point(bomb, bomb1);
            }
            if (setare1)
            {
                int bomb = pictureBox16.Location.X;
                int bomb1 = pictureBox16.Location.Y + 5;
                pictureBox16.Location = new Point(bomb, bomb1);
            }
            if (shahab)
            {
                int bomb = pictureBox17.Location.X - 5;
                int bomb1 = pictureBox17.Location.Y;
                pictureBox17.Location = new Point(bomb, bomb1);
            }
            if (dom)
            {
                int bomb = pictureBox18.Location.X + 5;
                int bomb1 = pictureBox18.Location.Y;
                pictureBox18.Location = new Point(bomb, bomb1);
            }
            check();
        }
        bool tarkib = false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                int bord = pictureBox6.Location.X + 5;
                int bord1 = pictureBox6.Location.Y;
                pictureBox6.Location = new Point(bord, bord1);
                if (!pic1)
                {
                    int tir = pictureBox2.Location.X + 5;
                    int tir1 = pictureBox2.Location.Y;
                    pictureBox2.Location = new Point(tir, tir1);
                }
                if (!pic2)
                {
                    int bomb = pictureBox3.Location.X + 5;
                    int bomb1 = pictureBox3.Location.Y;
                    pictureBox3.Location = new Point(bomb, bomb1);
                }
                if (!pic3)
                {
                    int bom = pictureBox4.Location.X + 5;
                    int bom1 = pictureBox4.Location.Y;
                    pictureBox4.Location = new Point(bom, bom1);
                }
                if (!pic4)
                {
                    int bo = pictureBox5.Location.X + 5;
                    int bo1 = pictureBox5.Location.Y;
                    pictureBox5.Location = new Point(bo, bo1);
                }
                if (!pic5)
                {
                    int tir = pictureBox10.Location.X + 5;
                    int tir1 = pictureBox10.Location.Y;
                    pictureBox10.Location = new Point(tir, tir1);

                }
                if (!pic6)
                {
                    int bomb = pictureBox11.Location.X + 5;
                    int bomb1 = pictureBox11.Location.Y;
                    pictureBox11.Location = new Point(bomb, bomb1);
                }
                if (!pic7)
                {
                    int bom = pictureBox12.Location.X + 5;
                    int bom1 = pictureBox12.Location.Y;
                    pictureBox12.Location = new Point(bom, bom1);
                }
                if (!pic8)
                {
                    int bo = pictureBox13.Location.X + 5;
                    int bo1 = pictureBox13.Location.Y;
                    pictureBox13.Location = new Point(bo, bo1);
                }
                if (pic1)
                {
                    int tir = pictureBox2.Location.X;
                    int tir1 = pictureBox2.Location.Y - 5;
                    pictureBox2.Location = new Point(tir, tir1);
                }
                if (pic2)
                {
                    int bomb = pictureBox3.Location.X;
                    int bomb1 = pictureBox3.Location.Y - 5;
                    pictureBox3.Location = new Point(bomb, bomb1);
                }
                if (pic3)
                {
                    int bomb = pictureBox4.Location.X;
                    int bomb1 = pictureBox4.Location.Y - 5;
                    pictureBox4.Location = new Point(bomb, bomb1);
                }
                if (pic4)
                {
                    int bo = pictureBox5.Location.X;
                    int bo1 = pictureBox5.Location.Y - 5;
                    pictureBox5.Location = new Point(bo, bo1);

                }
                if (pic5)
                {
                    int tir = pictureBox10.Location.X;
                    int tir1 = pictureBox10.Location.Y - 5;
                    pictureBox10.Location = new Point(tir, tir1);
                }
                if (pic6)
                {
                    int bomb = pictureBox11.Location.X;
                    int bomb1 = pictureBox11.Location.Y - 5;
                    pictureBox11.Location = new Point(bomb, bomb1);
                }
                if (pic7)
                {
                    int tir = pictureBox13.Location.X;
                    int tir1 = pictureBox13.Location.Y - 5;
                    pictureBox13.Location = new Point(tir, tir1);
                }
                if (pic8)
                {
                    int bomb = pictureBox12.Location.X;
                    int bomb1 = pictureBox12.Location.Y - 5;
                    pictureBox12.Location = new Point(bomb, bomb1);
                }
                check();
            }
            else if (e.KeyCode == Keys.Left)
            {
                int bord = pictureBox6.Location.X - 5;
                int bord1 = pictureBox6.Location.Y;
                pictureBox6.Location = new Point(bord, bord1);
                if (!pic1)
                {
                    int tir = pictureBox2.Location.X - 5;
                    int tir1 = pictureBox2.Location.Y;
                    pictureBox2.Location = new Point(tir, tir1);
                }
                if (!pic2)
                {
                    int bomb = pictureBox3.Location.X - 5;
                    int bomb1 = pictureBox3.Location.Y;
                    pictureBox3.Location = new Point(bomb, bomb1);
                }
                if (!pic3)
                {
                    int bom = pictureBox4.Location.X - 5;
                    int bom1 = pictureBox4.Location.Y;
                    pictureBox4.Location = new Point(bom, bom1);
                }
                if (!pic4)
                {
                    int bo = pictureBox5.Location.X - 5;
                    int bo1 = pictureBox5.Location.Y;
                    pictureBox5.Location = new Point(bo, bo1);
                }
                if (!pic5)
                {
                    int tir = pictureBox10.Location.X - 5;
                    int tir1 = pictureBox10.Location.Y;
                    pictureBox10.Location = new Point(tir, tir1);
                }
                if (!pic6)
                {
                    int bomb = pictureBox11.Location.X - 5;
                    int bomb1 = pictureBox11.Location.Y;
                    pictureBox11.Location = new Point(bomb, bomb1);
                }
                if (!pic7)
                {
                    int bom = pictureBox12.Location.X - 5;
                    int bom1 = pictureBox12.Location.Y;
                    pictureBox12.Location = new Point(bom, bom1);
                }
                if (!pic8)
                {
                    int bo = pictureBox13.Location.X - 5;
                    int bo1 = pictureBox13.Location.Y;
                    pictureBox13.Location = new Point(bo, bo1);
                }
                if (pic1)
                {
                    int tir = pictureBox2.Location.X;
                    int tir1 = pictureBox2.Location.Y - 5;
                    pictureBox2.Location = new Point(tir, tir1);
                }
                if (pic2)
                {
                    int bomb = pictureBox3.Location.X;
                    int bomb1 = pictureBox3.Location.Y - 5;
                    pictureBox3.Location = new Point(bomb, bomb1);
                }
                if (pic3)
                {
                    int bomb = pictureBox4.Location.X;
                    int bomb1 = pictureBox4.Location.Y - 5;
                    pictureBox4.Location = new Point(bomb, bomb1);
                }
                if (pic4)
                {
                    int bo = pictureBox5.Location.X;
                    int bo1 = pictureBox5.Location.Y - 5;
                    pictureBox5.Location = new Point(bo, bo1);

                }
                if (pic5)
                {
                    int tir = pictureBox10.Location.X;
                    int tir1 = pictureBox10.Location.Y - 5;
                    pictureBox10.Location = new Point(tir, tir1);
                }
                if (pic6)
                {
                    int bomb = pictureBox11.Location.X;
                    int bomb1 = pictureBox11.Location.Y - 5;
                    pictureBox11.Location = new Point(bomb, bomb1);
                }
                if (pic7)
                {
                    int tir = pictureBox13.Location.X;
                    int tir1 = pictureBox13.Location.Y - 5;
                    pictureBox13.Location = new Point(tir, tir1);
                }
                if (pic8)
                {
                    int bomb = pictureBox12.Location.X;
                    int bomb1 = pictureBox12.Location.Y - 5;
                    pictureBox12.Location = new Point(bomb, bomb1);
                }
                check();
            }
            else if (e.KeyCode == Keys.Add | e.KeyCode == Keys.Return)
            {
                co++;
                if (co == 1)
                {
                    pic1 = true;
                    pic2 = true;
                    string soundplay = @"D:\jang\tir.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                }
                else if (co == 2)
                {
                    pic3 = true;
                    pic4 = true;
                    string soundplay = @"D:\jang\tir.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                }
                else if (co == 3)
                {
                    pic5 = true;
                    pic6 = true;
                    string soundplay = @"D:\jang\tir.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                }
                else if (co == 4)
                {
                    pic7 = true;
                    pic8 = true;
                    string soundplay = @"D:\jang\tir.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    co = 0;
                }
            }
            if (e.KeyCode == Keys.Add | e.KeyCode == Keys.Y)
            {
                Y = true;
                roh++;

            }
            if (e.KeyCode == Keys.Add | e.KeyCode == Keys.T)
            {
                tarkib = true;
                T = true;
                roh1++;
            }
            if (e.KeyCode == Keys.Add | e.KeyCode == Keys.J)
            {
                string soundplay = @"D:\jang\enfejar.wav";
                using (SoundPlayer player = new SoundPlayer(soundplay))
                {
                    player.Play();
                }
                pictureBox8.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                pictureBox8.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox8.BackColor = Color.Transparent;
                timer6.Start();

                pictureBox9.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                pictureBox9.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox9.BackColor = Color.Transparent;
                timer3.Start();

                pictureBox7.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                pictureBox7.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox7.BackColor = Color.Transparent;
                timer7.Start();

                pictureBox14.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                pictureBox14.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox14.BackColor = Color.Transparent;
                timer8.Start();

                pictureBox15.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                pictureBox15.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox15.BackColor = Color.Transparent;
                timer9.Start();

                pictureBox19.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                pictureBox19.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox19.BackColor = Color.Transparent;
                timer14.Start();
            }
        }
        private void pictureBox2_Move(object sender, EventArgs e)
        {
            if (pic1)
            {
                pictureBox2.Visible = true;
            }
            if (pictureBox2.Location.Y <= -16)
            {
                pictureBox2.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                pic1 = false;
                pictureBox2.Visible = false;
            }
        }
        private void Pic8()
        {
            int x = random.Next(0, 439);
            int y = (-54);
            pictureBox8.Location = new Point(x, y);
            checkvin();
            pictureBox8.Image = Image.FromFile(@"D:\jang\doshjadid.png");
            pictureBox8.BackgroundImageLayout = ImageLayout.Tile;
            pictureBox8.BackColor = Color.Transparent;
        }
        private void Pic7()
        {
            int x1 = random.Next(0, 439);
            int y1 = (-54);
            pictureBox7.Location = new Point(x1, y1);
            pictureBox7.Image = Image.FromFile(@"D:\jang\doshjadid.png");
            pictureBox7.BackgroundImageLayout = ImageLayout.Tile;
            pictureBox7.BackColor = Color.Transparent;
            checkvin();
        }
        private void Pic9()
        {
            int x2 = random.Next(0, 439);
            int y2 = (-54);
            pictureBox9.Location = new Point(x2, y2);
            pictureBox9.Image = Image.FromFile(@"D:\jang\doshjadid.png");
            pictureBox9.BackgroundImageLayout = ImageLayout.Tile;
            pictureBox9.BackColor = Color.Transparent;
            checkvin();
        }
        private void Pic14()
        {
            int x3 = random.Next(0, 439);
            int y3 = (-54);
            pictureBox14.Location = new Point(x3, y3);
            checkvin();
            pictureBox14.Image = Image.FromFile(@"D:\jang\doshjadid.png");
            pictureBox14.BackgroundImageLayout = ImageLayout.Tile;
            pictureBox14.BackColor = Color.Transparent;
        }
        private void Pic15()
        {
            int x4 = random.Next(0, 439);
            int y4 = (-54);
            pictureBox15.Location = new Point(x4, y4);
            checkvin();
            pictureBox15.Image = Image.FromFile(@"D:\jang\doshjadid.png");
            pictureBox15.BackgroundImageLayout = ImageLayout.Tile;
            pictureBox15.BackColor = Color.Transparent;
        }
        private void Pic16()
        {
            int x4 = random.Next(0, 439);
            int y4 = (-54);
            pictureBox19.Location = new Point(x4, y4);
            checkvin();
            pictureBox19.Image = Image.FromFile(@"D:\jang\doshjadid.png");
            pictureBox19.BackgroundImageLayout = ImageLayout.Tile;
            pictureBox19.BackColor = Color.Transparent;
        }
        private void Position()
        {
            int x = random.Next(0, 439);
            int y = (-20);
            pictureBox8.Location = new Point(x, y);
            int x1 = random.Next(0, 439);
            int y1 = (-20);
            pictureBox7.Location = new Point(x1, y1);
            int x2 = random.Next(0, 439);
            int y2 = (-20);
            pictureBox9.Location = new Point(x2, y2);
            checkvin();
        }
        private void emtiazat()
        {
            File.AppendAllText("emtiazat.txt", + emtiaz + Environment.NewLine);
            int maxscore = File.ReadAllLines("emtiazat.txt").Select(int.Parse).Max();
            label7.Text = maxscore.ToString();
        }
        private void postgal()
        {
            int x3 = random.Next(0, 439);
            int y3 = (-54);
            label6.Location = new Point(x3, y3);
            checkvin();
        }
        private void setare()
        {
            int x3 = random.Next(0, 439);
            int y3 = (-54);
            pictureBox1.Location = new Point(x3, y3);
            int x4 = random.Next(0, 439);
            int y4 = (-54);
            pictureBox16.Location = new Point(x4, y4);
        }
        private void shahabb()
        {
            int x3 = random.Next(0, 450);
            int y3 = (490);
            pictureBox17.Location = new Point(y3, x3);
            int x4 = random.Next(-4, 450);
            int y4 = (-81);
            pictureBox18.Location = new Point(y4, x4);
        }
        private void sora()
        {
            if (eazy.eazy1 == false && medium.medium1 == false && hard.hard1 == false)
            {
                if (emtiaz > 5 && emtiaz < 10)
                {
                    timer1.Interval = 45;
                }
                if (emtiaz > 10 && emtiaz < 15)
                {
                    timer1.Interval = 40;
                }
                if (emtiaz > 15 && emtiaz < 20)
                {
                    timer1.Interval = 35;
                }
                if (emtiaz > 20 && emtiaz < 25)
                {
                    timer1.Interval = 30;
                }
                if (emtiaz > 25 && emtiaz < 30)
                {
                    timer1.Interval = 25;
                }
                if (emtiaz > 30 && emtiaz < 35)
                {
                    timer1.Interval = 20;
                }
                if (emtiaz > 35 && emtiaz < 40)
                {
                    timer1.Interval = 15;
                }
                if (emtiaz > 40 && emtiaz < 45)
                {
                    timer1.Interval = 10;
                }
                if (emtiaz > 45 && emtiaz < 50)
                {
                    timer1.Interval = 5;
                }
                if (emtiaz > 50 && emtiaz < 100)
                {
                    timer1.Interval = 1;
                }
            }
        }
        bool kar = false;
        private void control()
        {
            if (emtiaz >= 20)
            {
                kar = true;
            }
        }
        private void pictureBox3_Move(object sender, EventArgs e)
        {
            if (pic2)
            {
                pictureBox3.Visible = true;

            }
            if (pictureBox3.Location.Y <= -16)
            {
                pictureBox3.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                pic2 = false;
                pictureBox3.Visible = false;
            }
        }
        private void pictureBox4_Move(object sender, EventArgs e)
        {
            if (pic3)
            {
                pictureBox4.Visible = true;

            }
            if (pictureBox4.Location.Y <= -16)
            {
                pictureBox4.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                pic3 = false;
                pictureBox4.Visible = false;
            }
        }
        private void pictureBox5_Move(object sender, EventArgs e)
        {
            if (pic4)
            {
                pictureBox5.Visible = true;

            }
            if (pictureBox5.Location.Y <= -16)
            {
                pictureBox5.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                pic4 = false;
                pictureBox5.Visible = false;
            }
        }
        bool shomaresh = false;
        private void checkvin()
        {
            if (shomaresh == true && global.change == false && global1.change1 == false && global2.change2 == false)
            {
                this.BackColor = Color.LightSkyBlue;
                if (emtiaz >= 40 && emtiaz < 60)
                {
                    shomaresh = false;
                }
                if (emtiaz >= 80 && emtiaz < 100)
                {
                    shomaresh = false;
                }
                if (emtiaz >= 120 && emtiaz < 140)
                {
                    shomaresh = false;
                }
            }
            if (shomaresh == false && global.change == false && global1.change1 == false && global2.change2 == false)
            {
                this.BackColor = Color.Gray;
                if (emtiaz >= 20 && emtiaz < 40)
                {
                    shomaresh = true;
                }
                if (emtiaz >= 60 & emtiaz < 80)
                {
                    shomaresh = true;
                }
                if (emtiaz >= 100 && emtiaz < 120)
                {
                    shomaresh = true;
                }
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            emtiazat();
            checkvin();
            Pic9();
        }
        private void timer6_Tick(object sender, EventArgs e)
        {
            timer6.Stop();
            emtiazat();
            checkvin();
            Pic8();
        }
        private void timer7_Tick(object sender, EventArgs e)
        {
            timer7.Stop();
            checkvin();
            emtiazat();
            Pic7();
        }
        private void timer8_Tick(object sender, EventArgs e)
        {
            timer8.Stop();
            checkvin();
            emtiazat();
            Pic14();
        }
        private void timer9_Tick(object sender, EventArgs e)
        {
            timer9.Stop();
            emtiazat();
            checkvin();
            Pic15();
        }
        private void timer13_Tick(object sender, EventArgs e)
        {
            timer13.Stop();
            checkvin();
        }
        private void timer14_Tick(object sender, EventArgs e)
        {
            timer14.Stop();
            emtiazat();
            checkvin();
            Pic16();
        }
        private bool isGameOver = false;
        private void check()
        {
            if (pic5)
            {
                pictureBox10.Visible = true;
            }
            if (pictureBox10.Location.Y <= -16)
            {
                pictureBox10.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                pic5 = false;
                pictureBox10.Visible = false;
            }
            if (pictureBox6.Bounds.IntersectsWith(pictureBox8.Bounds))
            {
                dorost += 1;
                string soundplay1 = @"D:\jang\enfejarmoshack.wav";
                using (SoundPlayer player = new SoundPlayer(soundplay1))
                {
                    player.Play();
                }
                if (label3.Text == "♥" && dorost == 1)
                {
                    Pic8();
                    label3.Text = label3.Text.Replace("♥", "");
                }
                else if (label2.Text == "♥" && dorost == 2)
                {
                    Pic8();
                    label2.Text = label2.Text.Replace("♥", "");
                }
                if (label1.Text == "♥" && dorost == 3 && !isGameOver)
                {
                    isGameOver = true;
                    label4.Text = emtiaz.ToString();
                    this.BackgroundImage = Image.FromFile(@"D:\jang\game-over-01.jpeg");
                    this.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox1.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox18.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label6.Visible = false;
                    label11.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label5.Visible = false;
                    label7.Visible = false;
                    dorost = 0;
                    waveOutDevice.Pause();
                    string soundplay = @"D:\jang\gameovernew.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                        MessageBox.Show("..bazy dobare shoroe shod..");
                        player.Stop();
                    }
                    Form1 rorm1;
                    rorm1 = new Form1();
                    rorm1.Show();
                    this.Hide();
                }
            }
            else if (pictureBox6.Bounds.IntersectsWith(pictureBox7.Bounds))
            {
                dorost += 1;
                string soundplay1 = @"D:\jang\enfejarmoshack.wav";
                using (SoundPlayer player = new SoundPlayer(soundplay1))
                {
                    player.Play();
                }
                if (label3.Text == "♥" && dorost == 1)
                {
                    Pic7();
                    label3.Text = label3.Text.Replace("♥", "");
                }
                else if (label2.Text == "♥" && dorost == 2)
                {
                    Pic7();
                    label2.Text = label2.Text.Replace("♥", "");
                }
                if (label1.Text == "♥" && dorost == 3 && !isGameOver)
                {
                    isGameOver = true;
                    label4.Text = emtiaz.ToString();
                    this.BackgroundImage = Image.FromFile(@"D:\jang\game-over-01.jpeg");
                    this.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox1.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox18.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label6.Visible = false;
                    label11.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label5.Visible = false;
                    label7.Visible = false;
                    dorost = 0;
                    waveOutDevice.Pause();
                    string soundplay = @"D:\jang\gameovernew.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                        MessageBox.Show("..bazy dobare shoroe shod..");
                        player.Stop();
                    }
                    Form1 rorm1;
                    rorm1 = new Form1();
                    rorm1.Show();
                    this.Hide();
                }
            }
            else if (pictureBox6.Bounds.IntersectsWith(pictureBox9.Bounds))
            {
                dorost += 1;
                string soundplay1 = @"D:\jang\enfejarmoshack.wav";
                using (SoundPlayer player = new SoundPlayer(soundplay1))
                {
                    player.Play();
                }
                if (label3.Text == "♥" && dorost == 1)
                {
                    Pic9();
                    label3.Text = label3.Text.Replace("♥", "");
                }
                else if (label2.Text == "♥" && dorost == 2)
                {
                    Pic9();
                    label2.Text = label2.Text.Replace("♥", "");
                }
                if (label1.Text == "♥" && dorost == 3 && !isGameOver)
                {
                    isGameOver = true;
                    label4.Text = emtiaz.ToString();
                    this.BackgroundImage = Image.FromFile(@"D:\jang\game-over-01.jpeg");
                    this.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox1.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox18.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label6.Visible = false;
                    label11.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label5.Visible = false;
                    label7.Visible = false;
                    dorost = 0;
                    waveOutDevice.Pause();
                    string soundplay = @"D:\jang\gameovernew.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                        MessageBox.Show("..bazy dobare shoroe shod..");
                        player.Stop();
                    }
                    Form1 rorm1;
                    rorm1 = new Form1();
                    rorm1.Show();
                    this.Hide();
                }
            }
            else if (pictureBox6.Bounds.IntersectsWith(pictureBox14.Bounds))
            {
                dorost += 1;
                string soundplay1 = @"D:\jang\enfejarmoshack.wav";
                using (SoundPlayer player = new SoundPlayer(soundplay1))
                {
                    player.Play();
                }
                if (label3.Text == "♥" && dorost == 1)
                {
                    Pic14();
                    label3.Text = label3.Text.Replace("♥", "");
                }
                else if (label2.Text == "♥" && dorost == 2)
                {
                    Pic14();
                    label2.Text = label2.Text.Replace("♥", "");
                }
                if (label1.Text == "♥" && dorost == 3 && !isGameOver)
                {
                    isGameOver = true;
                    label4.Text = emtiaz.ToString();
                    this.BackgroundImage = Image.FromFile(@"D:\jang\game-over-01.jpeg");
                    this.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox1.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox18.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label6.Visible = false;
                    label11.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label5.Visible = false;
                    label7.Visible = false;
                    dorost = 0;
                    waveOutDevice.Pause();
                    string soundplay = @"D:\jang\gameovernew.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                        MessageBox.Show("..bazy dobare shoroe shod..");
                        player.Stop();
                    }
                    Form1 rorm1;
                    rorm1 = new Form1();
                    rorm1.Show();
                    this.Hide();
                }
            }
            else if (pictureBox6.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                dorost += 1;
                string soundplay1 = @"D:\jang\enfejarmoshack.wav";
                using (SoundPlayer player = new SoundPlayer(soundplay1))
                {
                    player.Play();
                }
                if (label3.Text == "♥" && dorost == 1)
                {
                    Pic15();
                    label3.Text = label3.Text.Replace("♥", "");
                }
                else if (label2.Text == "♥" && dorost == 2)
                {
                    Pic15();
                    label2.Text = label2.Text.Replace("♥", "");
                }
                if (label1.Text == "♥" && dorost == 3 && !isGameOver)
                {
                    isGameOver = true;
                    label4.Text = emtiaz.ToString();
                    this.BackgroundImage = Image.FromFile(@"D:\jang\game-over-01.jpeg");
                    this.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox1.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox18.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label6.Visible = false;
                    label11.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label5.Visible = false;
                    label7.Visible = false;
                    dorost = 0;
                    waveOutDevice.Pause();
                    string soundplay = @"D:\jang\gameovernew.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                        MessageBox.Show("..bazy dobare shoroe shod..");
                        player.Stop();
                    }
                    Form1 rorm1;
                    rorm1 = new Form1();
                    rorm1.Show();
                    this.Hide();
                }
            }
            else if (pictureBox6.Bounds.IntersectsWith(pictureBox19.Bounds))
            {
                dorost += 1;
                string soundplay1 = @"D:\jang\enfejarmoshack.wav";
                using (SoundPlayer player = new SoundPlayer(soundplay1))
                {
                    player.Play();
                }
                if (label3.Text == "♥" && dorost == 1)
                {
                    Pic16();
                    label3.Text = label3.Text.Replace("♥", "");
                }
                else if (label2.Text == "♥" && dorost == 2)
                {
                    Pic16();
                    label2.Text = label2.Text.Replace("♥", "");
                }
                if (label1.Text == "♥" && dorost == 3 && !isGameOver)
                {
                    isGameOver = true;
                    label4.Text = emtiaz.ToString();
                    this.BackgroundImage = Image.FromFile(@"D:\jang\game-over-01.jpeg");
                    this.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox1.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox18.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label6.Visible = false;
                    label11.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label5.Visible = false;
                    label7.Visible = false;
                    dorost = 0;
                    waveOutDevice.Pause();
                    string soundplay = @"D:\jang\gameovernew.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                        MessageBox.Show("..bazy dobare shoroe shod..");
                        player.Stop();
                    }
                    Form1 rorm1;
                    rorm1 = new Form1();
                    rorm1.Show();
                    this.Hide();
                }
            }

            if (kar == false)
            {
                if (pictureBox2.Bounds.IntersectsWith(pictureBox9.Bounds))
                {
                    pictureBox2.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic1 = false;
                    pictureBox2.Visible = false;
                    pictureBox9.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox9.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox9.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer3.Start();
                }
                if (pictureBox2.Bounds.IntersectsWith(pictureBox8.Bounds))
                {
                    pictureBox2.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic1 = false;
                    pictureBox2.Visible = false;
                    pictureBox8.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox8.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox8.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer6.Start();
                }
                if (pictureBox2.Bounds.IntersectsWith(pictureBox7.Bounds))
                {
                    pictureBox2.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic1 = false;
                    pictureBox2.Visible = false;
                    pictureBox7.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox7.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox7.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer7.Start();
                }

                if (pictureBox2.Bounds.IntersectsWith(pictureBox14.Bounds))
                {
                    pictureBox2.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic1 = false;
                    pictureBox2.Visible = false;
                    pictureBox14.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox14.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox14.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer8.Start();
                }
                if (pictureBox2.Bounds.IntersectsWith(pictureBox15.Bounds))
                {
                    pictureBox2.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic1 = false;
                    pictureBox2.Visible = false;
                    pictureBox15.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox15.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox15.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer9.Start();
                }
                if (pictureBox2.Bounds.IntersectsWith(pictureBox19.Bounds))
                {
                    pictureBox2.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic1 = false;
                    pictureBox2.Visible = false;
                    pictureBox19.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox19.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox19.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer14.Start();
                }
                if (pictureBox3.Bounds.IntersectsWith(pictureBox9.Bounds))
                {
                    pictureBox3.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic2 = false;
                    pictureBox3.Visible = false;
                    pictureBox9.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox9.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox9.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer3.Start();
                }
                if (pictureBox3.Bounds.IntersectsWith(pictureBox8.Bounds))
                {
                    pictureBox3.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic2 = false;
                    pictureBox3.Visible = false;
                    pictureBox8.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox8.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox8.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer6.Start();
                }
                if (pictureBox3.Bounds.IntersectsWith(pictureBox7.Bounds))
                {
                    pictureBox3.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic2 = false;
                    pictureBox3.Visible = false;
                    pictureBox7.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox7.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox7.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer7.Start();
                }
                if (pictureBox3.Bounds.IntersectsWith(pictureBox14.Bounds))
                {
                    pictureBox3.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic2 = false;
                    pictureBox3.Visible = false;
                    pictureBox14.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox14.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox14.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer8.Start();
                }
                if (pictureBox3.Bounds.IntersectsWith(pictureBox15.Bounds))
                {
                    pictureBox3.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic2 = false;
                    pictureBox3.Visible = false;
                    pictureBox15.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox15.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox15.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer9.Start();
                }
                if (pictureBox3.Bounds.IntersectsWith(pictureBox19.Bounds))
                {
                    pictureBox3.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic2 = false;
                    pictureBox3.Visible = false;
                    pictureBox19.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox19.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox19.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer14.Start();
                }
                if (pictureBox4.Bounds.IntersectsWith(pictureBox9.Bounds))
                {
                    pictureBox4.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic3 = false;
                    pictureBox4.Visible = false;
                    pictureBox9.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox9.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox9.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer3.Start();
                }
                if (pictureBox4.Bounds.IntersectsWith(pictureBox8.Bounds))
                {
                    pictureBox4.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic3 = false;
                    pictureBox4.Visible = false;
                    pictureBox8.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox8.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox8.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer6.Start();
                }
                if (pictureBox4.Bounds.IntersectsWith(pictureBox7.Bounds))
                {
                    pictureBox4.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic3 = false;
                    pictureBox4.Visible = false;
                    pictureBox7.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox7.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox7.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer7.Start();
                }
                if (pictureBox4.Bounds.IntersectsWith(pictureBox14.Bounds))
                {
                    pictureBox4.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic3 = false;
                    pictureBox4.Visible = false;
                    pictureBox14.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox14.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox14.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer8.Start();
                }
                if (pictureBox4.Bounds.IntersectsWith(pictureBox15.Bounds))
                {
                    pictureBox4.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic3 = false;
                    pictureBox4.Visible = false;
                    pictureBox15.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox15.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox15.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer9.Start();
                }
                if (pictureBox4.Bounds.IntersectsWith(pictureBox19.Bounds))
                {
                    pictureBox4.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic3 = false;
                    pictureBox4.Visible = false;
                    pictureBox19.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox19.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox19.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer14.Start();
                }
                if (pictureBox11.Bounds.IntersectsWith(pictureBox9.Bounds))
                {
                    pictureBox11.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic6 = false;
                    pictureBox11.Visible = false;
                    pictureBox9.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox9.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox9.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer3.Start();
                }
                if (pictureBox11.Bounds.IntersectsWith(pictureBox8.Bounds))
                {
                    pictureBox11.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic6 = false;
                    pictureBox11.Visible = false;
                    pictureBox8.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox8.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox8.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer6.Start();
                }
                if (pictureBox11.Bounds.IntersectsWith(pictureBox7.Bounds))
                {
                    pictureBox11.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic6 = false;
                    pictureBox11.Visible = false;
                    pictureBox7.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox7.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox7.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer7.Start();
                }
                if (pictureBox11.Bounds.IntersectsWith(pictureBox14.Bounds))
                {
                    pictureBox11.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic6 = false;
                    pictureBox11.Visible = false;
                    pictureBox14.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox14.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox14.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer8.Start();
                }
                if (pictureBox11.Bounds.IntersectsWith(pictureBox15.Bounds))
                {
                    pictureBox11.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic6 = false;
                    pictureBox11.Visible = false;
                    pictureBox15.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox15.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox15.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer9.Start();
                }
                if (pictureBox11.Bounds.IntersectsWith(pictureBox19.Bounds))
                {
                    pictureBox11.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic6 = false;
                    pictureBox11.Visible = false;
                    pictureBox19.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox19.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox19.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer14.Start();
                }
                if (pictureBox12.Bounds.IntersectsWith(pictureBox9.Bounds))
                {
                    pictureBox12.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic8 = false;
                    pictureBox12.Visible = false;
                    pictureBox9.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox9.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox9.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer3.Start();
                }
                if (pictureBox12.Bounds.IntersectsWith(pictureBox8.Bounds))
                {
                    pictureBox12.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic8 = false;
                    pictureBox12.Visible = false;
                    pictureBox8.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox8.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox8.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer6.Start();
                }
                if (pictureBox12.Bounds.IntersectsWith(pictureBox7.Bounds))
                {
                    pictureBox12.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic8 = false;
                    pictureBox12.Visible = false;
                    pictureBox7.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox7.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox7.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer7.Start();
                }
                if (pictureBox12.Bounds.IntersectsWith(pictureBox14.Bounds))
                {
                    pictureBox12.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic8 = false;
                    pictureBox12.Visible = false;
                    pictureBox14.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox14.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox14.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer8.Start();
                }
                if (pictureBox12.Bounds.IntersectsWith(pictureBox15.Bounds))
                {
                    pictureBox12.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic8 = false;
                    pictureBox12.Visible = false;
                    pictureBox15.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox15.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox15.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer9.Start();
                }
                if (pictureBox12.Bounds.IntersectsWith(pictureBox19.Bounds))
                {
                    pictureBox12.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic8 = false;
                    pictureBox12.Visible = false;
                    pictureBox19.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox19.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox19.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer14.Start();
                }
                if (pictureBox5.Bounds.IntersectsWith(pictureBox9.Bounds))
                {
                    pictureBox5.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic4 = false;
                    pictureBox5.Visible = false;
                    pictureBox9.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox9.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox9.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer3.Start();
                }
                if (pictureBox5.Bounds.IntersectsWith(pictureBox8.Bounds))
                {
                    pictureBox5.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic4 = false;
                    pictureBox5.Visible = false;
                    pictureBox8.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox8.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox8.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer6.Start();
                }
                if (pictureBox5.Bounds.IntersectsWith(pictureBox7.Bounds))
                {
                    pictureBox5.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic4 = false;
                    pictureBox5.Visible = false;
                    pictureBox7.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox7.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox7.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer7.Start();
                }
                if (pictureBox5.Bounds.IntersectsWith(pictureBox14.Bounds))
                {
                    pictureBox5.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic4 = false;
                    pictureBox5.Visible = false;
                    pictureBox14.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox14.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox14.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer8.Start();
                }
                if (pictureBox5.Bounds.IntersectsWith(pictureBox15.Bounds))
                {
                    pictureBox5.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic4 = false;
                    pictureBox5.Visible = false;
                    pictureBox15.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox15.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox15.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer9.Start();
                }
                if (pictureBox5.Bounds.IntersectsWith(pictureBox19.Bounds))
                {
                    pictureBox5.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic4 = false;
                    pictureBox5.Visible = false;
                    pictureBox19.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox19.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox19.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer14.Start();
                }
                if (pictureBox13.Bounds.IntersectsWith(pictureBox9.Bounds))
                {
                    pictureBox13.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic7 = false;
                    pictureBox13.Visible = false;
                    pictureBox9.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox9.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox9.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer3.Start();
                }
                if (pictureBox13.Bounds.IntersectsWith(pictureBox8.Bounds))
                {
                    pictureBox13.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic7 = false;
                    pictureBox13.Visible = false;
                    pictureBox8.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox8.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox8.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer6.Start();
                }
                if (pictureBox13.Bounds.IntersectsWith(pictureBox7.Bounds))
                {
                    pictureBox13.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic7 = false;
                    pictureBox13.Visible = false;
                    pictureBox7.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox7.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox7.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer7.Start();
                }
                if (pictureBox13.Bounds.IntersectsWith(pictureBox14.Bounds))
                {
                    pictureBox13.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic7 = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox14.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox14.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer8.Start();
                }
                if (pictureBox13.Bounds.IntersectsWith(pictureBox15.Bounds))
                {
                    pictureBox13.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic7 = false;
                    pictureBox13.Visible = false;
                    pictureBox15.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox15.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox15.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer9.Start();
                }
                if (pictureBox13.Bounds.IntersectsWith(pictureBox19.Bounds))
                {
                    pictureBox13.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic7 = false;
                    pictureBox13.Visible = false;
                    pictureBox19.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox19.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox19.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer14.Start();
                }
                if (pictureBox10.Bounds.IntersectsWith(pictureBox9.Bounds))
                {
                    pictureBox10.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic5 = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox9.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox9.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer3.Start();
                }
                if (pictureBox10.Bounds.IntersectsWith(pictureBox8.Bounds))
                {
                    pictureBox10.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic5 = false;
                    pictureBox10.Visible = false;
                    pictureBox8.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox8.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox8.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer6.Start();
                }
                if (pictureBox10.Bounds.IntersectsWith(pictureBox7.Bounds))
                {
                    pictureBox10.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic5 = false;
                    pictureBox10.Visible = false;
                    pictureBox7.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox7.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox7.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer7.Start();
                }
                if (pictureBox10.Bounds.IntersectsWith(pictureBox14.Bounds))
                {
                    pictureBox10.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic5 = false;
                    pictureBox10.Visible = false;
                    pictureBox14.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox14.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox14.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer8.Start();
                }
                if (pictureBox10.Bounds.IntersectsWith(pictureBox15.Bounds))
                {
                    pictureBox10.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic5 = false;
                    pictureBox10.Visible = false;
                    pictureBox15.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox15.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox15.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer9.Start();
                }
                if (pictureBox10.Bounds.IntersectsWith(pictureBox19.Bounds))
                {
                    pictureBox10.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                    emtiaz += 2;
                    label4.Text = emtiaz.ToString();
                    pic5 = false;
                    pictureBox10.Visible = false;
                    pictureBox19.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                    pictureBox19.BackgroundImageLayout = ImageLayout.Tile;
                    pictureBox19.BackColor = Color.Transparent;
                    string soundplay = @"D:\jang\enfejar.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    timer14.Start();
                }
            }



















            int karr = 0;
            if (kar == true)
            {
                if (pictureBox2.Bounds.IntersectsWith(pictureBox9.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox2.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox2.Visible = false;
                        pic1 = false;
                    }
                    if (karr == 2)
                    {
                        pictureBox2.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic1 = false;
                        pictureBox2.Visible = false;
                        pictureBox9.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox9.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox9.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer3.Start();
                        karr = 0;
                    }
                }
                if (pictureBox2.Bounds.IntersectsWith(pictureBox8.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox2.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox2.Visible = false;
                        pic1 = false;
                    }
                    if (karr == 2)
                    {
                        pictureBox2.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic1 = false;
                        pictureBox2.Visible = false;
                        pictureBox8.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox8.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox8.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer6.Start();
                        karr = 0;
                    }
                }
                if (pictureBox2.Bounds.IntersectsWith(pictureBox7.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox2.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox2.Visible = false;
                        pic1 = false;
                    }
                    if (karr == 2)
                    {
                        pictureBox2.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic1 = false;
                        pictureBox2.Visible = false;
                        pictureBox7.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox7.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox7.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer7.Start();
                        karr = 0;
                    }
                }

                if (pictureBox2.Bounds.IntersectsWith(pictureBox14.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox2.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox2.Visible = false;
                        pic1 = false;
                    }
                    if (karr == 2)
                    {
                        pictureBox2.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic1 = false;
                        pictureBox2.Visible = false;
                        pictureBox14.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox14.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox14.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer8.Start();
                        karr = 0;
                    }
                }
                if (pictureBox2.Bounds.IntersectsWith(pictureBox15.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox2.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox2.Visible = false;
                        pic1 = false;
                    }
                    if (karr == 2)
                    {
                        pictureBox2.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic1 = false;
                        pictureBox2.Visible = false;
                        pictureBox15.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox15.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox15.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer9.Start();
                        karr = 0;
                    }
                }
                if (pictureBox2.Bounds.IntersectsWith(pictureBox19.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox2.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox2.Visible = false;
                        pic1 = false;
                    }
                    if (karr == 2)
                    {
                        pictureBox2.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic1 = false;
                        pictureBox2.Visible = false;
                        pictureBox19.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox19.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox19.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer14.Start();
                        karr = 0;
                    }
                }
                if (pictureBox3.Bounds.IntersectsWith(pictureBox9.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox3.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        pictureBox3.Visible = false;
                        pic2 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox3.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic2 = false;
                        pictureBox3.Visible = false;
                        pictureBox9.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox9.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox9.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer3.Start();
                        karr = 0;
                    }
                }
                if (pictureBox3.Bounds.IntersectsWith(pictureBox8.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox3.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        pictureBox3.Visible = false;
                        pic2 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox3.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic2 = false;
                        pictureBox3.Visible = false;
                        pictureBox8.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox8.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox8.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer6.Start();
                    }
                }
                if (pictureBox3.Bounds.IntersectsWith(pictureBox7.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox3.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        pictureBox3.Visible = false;
                        pic2 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox3.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic2 = false;
                        pictureBox3.Visible = false;
                        pictureBox7.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox7.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox7.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer7.Start();
                    }
                }
                if (pictureBox3.Bounds.IntersectsWith(pictureBox14.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox3.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        pictureBox3.Visible = false;
                        pic2 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox3.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic2 = false;
                        pictureBox3.Visible = false;
                        pictureBox14.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox14.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox14.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer8.Start();
                    }
                }
                if (pictureBox3.Bounds.IntersectsWith(pictureBox15.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox3.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        pictureBox3.Visible = false;
                        pic2 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox3.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic2 = false;
                        pictureBox3.Visible = false;
                        pictureBox15.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox15.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox15.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer9.Start();
                    }
                }
                if (pictureBox3.Bounds.IntersectsWith(pictureBox19.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox3.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        pictureBox3.Visible = false;
                        pic2 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox3.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic2 = false;
                        pictureBox3.Visible = false;
                        pictureBox19.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox19.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox19.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer14.Start();
                    }
                }
                if (pictureBox4.Bounds.IntersectsWith(pictureBox9.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox4.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox4.Visible = false;
                        pic3 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox4.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic3 = false;
                        pictureBox4.Visible = false;
                        pictureBox9.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox9.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox9.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer3.Start();
                    }
                }
                if (pictureBox4.Bounds.IntersectsWith(pictureBox8.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox4.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox4.Visible = false;
                        pic3 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox4.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic3 = false;
                        pictureBox4.Visible = false;
                        pictureBox8.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox8.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox8.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer6.Start();
                    }
                }
                if (pictureBox4.Bounds.IntersectsWith(pictureBox7.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox4.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox4.Visible = false;
                        pic3 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox4.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic3 = false;
                        pictureBox4.Visible = false;
                        pictureBox7.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox7.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox7.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer7.Start();
                    }
                }
                if (pictureBox4.Bounds.IntersectsWith(pictureBox14.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox4.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox4.Visible = false;
                        pic3 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox4.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic3 = false;
                        pictureBox4.Visible = false;
                        pictureBox14.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox14.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox14.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer8.Start();
                    }
                }
                if (pictureBox4.Bounds.IntersectsWith(pictureBox15.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox4.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox4.Visible = false;
                        pic3 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox4.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic3 = false;
                        pictureBox4.Visible = false;
                        pictureBox15.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox15.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox15.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer9.Start();
                    }
                }
                if (pictureBox4.Bounds.IntersectsWith(pictureBox19.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox4.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox4.Visible = false;
                        pic3 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox4.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic3 = false;
                        pictureBox4.Visible = false;
                        pictureBox19.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox19.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox19.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer14.Start();
                    }
                }
                if (pictureBox11.Bounds.IntersectsWith(pictureBox9.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox11.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox11.Visible = false;
                        pic6 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox11.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic6 = false;
                        pictureBox11.Visible = false;
                        pictureBox9.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox9.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox9.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer3.Start();
                    }
                }
                if (pictureBox11.Bounds.IntersectsWith(pictureBox8.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox11.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox11.Visible = false;
                        pic6 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox11.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic6 = false;
                        pictureBox11.Visible = false;
                        pictureBox8.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox8.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox8.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer6.Start();
                    }
                }
                if (pictureBox11.Bounds.IntersectsWith(pictureBox7.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox11.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox11.Visible = false;
                        pic6 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox11.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic6 = false;
                        pictureBox11.Visible = false;
                        pictureBox7.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox7.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox7.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer7.Start();
                    }
                }
                if (pictureBox11.Bounds.IntersectsWith(pictureBox14.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox11.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox11.Visible = false;
                        pic6 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox11.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic6 = false;
                        pictureBox11.Visible = false;
                        pictureBox14.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox14.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox14.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer8.Start();
                    }
                }
                if (pictureBox11.Bounds.IntersectsWith(pictureBox15.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox11.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox11.Visible = false;
                        pic6 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox11.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic6 = false;
                        pictureBox11.Visible = false;
                        pictureBox15.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox15.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox15.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer9.Start();
                    }
                }
                if (pictureBox11.Bounds.IntersectsWith(pictureBox19.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox11.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox11.Visible = false;
                        pic6 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox11.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic6 = false;
                        pictureBox11.Visible = false;
                        pictureBox19.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox19.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox19.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer14.Start();
                    }
                }
                if (pictureBox12.Bounds.IntersectsWith(pictureBox9.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox12.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox12.Visible = false;
                        pic8 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox12.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic8 = false;
                        pictureBox12.Visible = false;
                        pictureBox9.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox9.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox9.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer3.Start();
                    }
                }
                if (pictureBox12.Bounds.IntersectsWith(pictureBox8.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox12.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox12.Visible = false;
                        pic8 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox12.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic8 = false;
                        pictureBox12.Visible = false;
                        pictureBox8.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox8.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox8.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer6.Start();
                    }
                }
                if (pictureBox12.Bounds.IntersectsWith(pictureBox7.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox12.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox12.Visible = false;
                        pic8 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox12.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic8 = false;
                        pictureBox12.Visible = false;
                        pictureBox7.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox7.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox7.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer7.Start();
                    }
                }
                if (pictureBox12.Bounds.IntersectsWith(pictureBox14.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox12.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox12.Visible = false;
                        pic8 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox12.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic8 = false;
                        pictureBox12.Visible = false;
                        pictureBox14.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox14.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox14.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer8.Start();
                    }
                }
                if (pictureBox12.Bounds.IntersectsWith(pictureBox15.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox12.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox12.Visible = false;
                        pic8 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox12.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic8 = false;
                        pictureBox12.Visible = false;
                        pictureBox15.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox15.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox15.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer9.Start();
                    }
                }
                if (pictureBox12.Bounds.IntersectsWith(pictureBox19.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox12.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox12.Visible = false;
                        pic8 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox12.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic8 = false;
                        pictureBox12.Visible = false;
                        pictureBox19.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox19.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox19.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer14.Start();
                    }
                }
                if (pictureBox5.Bounds.IntersectsWith(pictureBox9.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox5.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        pictureBox5.Visible = false;
                        pic4 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox5.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic4 = false;
                        pictureBox5.Visible = false;
                        pictureBox9.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox9.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox9.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer3.Start();
                    }
                }
                if (pictureBox5.Bounds.IntersectsWith(pictureBox8.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox5.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        pictureBox5.Visible = false;
                        pic4 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox5.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic4 = false;
                        pictureBox5.Visible = false;
                        pictureBox8.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox8.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox8.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer6.Start();
                    }
                }
                if (pictureBox5.Bounds.IntersectsWith(pictureBox7.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox5.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        pictureBox5.Visible = false;
                        pic4 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox5.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic4 = false;
                        pictureBox5.Visible = false;
                        pictureBox7.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox7.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox7.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer7.Start();
                    }
                }
                if (pictureBox5.Bounds.IntersectsWith(pictureBox14.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox5.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        pictureBox5.Visible = false;
                        pic4 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox5.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic4 = false;
                        pictureBox5.Visible = false;
                        pictureBox14.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox14.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox14.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer8.Start();
                    }
                }
                if (pictureBox5.Bounds.IntersectsWith(pictureBox15.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox5.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        pictureBox5.Visible = false;
                        pic4 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox5.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic4 = false;
                        pictureBox5.Visible = false;
                        pictureBox15.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox15.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox15.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer9.Start();
                    }
                }
                if (pictureBox5.Bounds.IntersectsWith(pictureBox19.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox5.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        pictureBox5.Visible = false;
                        pic4 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox5.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic4 = false;
                        pictureBox5.Visible = false;
                        pictureBox19.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox19.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox19.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer14.Start();
                    }
                }
                if (pictureBox13.Bounds.IntersectsWith(pictureBox9.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox13.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox13.Visible = false;
                        pic7 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox13.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic7 = false;
                        pictureBox13.Visible = false;
                        pictureBox9.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox9.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox9.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer3.Start();
                    }
                }
                if (pictureBox13.Bounds.IntersectsWith(pictureBox8.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox13.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        pictureBox13.Visible = false;
                        pic7 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox13.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic7 = false;
                        pictureBox13.Visible = false;
                        pictureBox8.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox8.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox8.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer6.Start();
                    }
                }
                if (pictureBox13.Bounds.IntersectsWith(pictureBox7.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox13.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox13.Visible = false;
                        pic7 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox13.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic7 = false;
                        pictureBox13.Visible = false;
                        pictureBox7.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox7.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox7.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer7.Start();
                    }
                }
                if (pictureBox13.Bounds.IntersectsWith(pictureBox14.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox13.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox13.Visible = false;
                        pic7 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox13.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic7 = false;
                        pictureBox13.Visible = false;
                        pictureBox14.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox14.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox14.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer8.Start();
                    }
                }
                if (pictureBox13.Bounds.IntersectsWith(pictureBox15.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox13.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox13.Visible = false;
                        pic7 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox13.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic7 = false;
                        pictureBox13.Visible = false;
                        pictureBox15.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox15.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox15.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer9.Start();
                    }
                }
                if (pictureBox13.Bounds.IntersectsWith(pictureBox19.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox13.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        pictureBox13.Visible = false;
                        pic7 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox13.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic7 = false;
                        pictureBox13.Visible = false;
                        pictureBox19.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox19.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox19.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer14.Start();
                    }
                }
                if (pictureBox10.Bounds.IntersectsWith(pictureBox9.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox10.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        pictureBox10.Visible = false;
                        pic5 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox10.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic5 = false;
                        pictureBox10.Visible = false;
                        pictureBox9.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox9.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox9.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer3.Start();
                    }
                }
                if (pictureBox10.Bounds.IntersectsWith(pictureBox8.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox10.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        pictureBox10.Visible = false;
                        pic5 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox10.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic5 = false;
                        pictureBox10.Visible = false;
                        pictureBox8.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox8.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox8.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer6.Start();
                    }
                }
                if (pictureBox10.Bounds.IntersectsWith(pictureBox7.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox10.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        pictureBox10.Visible = false;
                        pic5 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox10.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic5 = false;
                        pictureBox10.Visible = false;
                        pictureBox7.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox7.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox7.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer7.Start();
                    }
                }
                if (pictureBox10.Bounds.IntersectsWith(pictureBox14.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox10.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        pictureBox10.Visible = false;
                        pic5 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox10.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic5 = false;
                        pictureBox10.Visible = false;
                        pictureBox14.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox14.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox14.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer8.Start();
                    }
                }
                if (pictureBox10.Bounds.IntersectsWith(pictureBox15.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox10.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        pictureBox10.Visible = false;
                        pic5 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox10.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic5 = false;
                        pictureBox10.Visible = false;
                        pictureBox15.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox15.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox15.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer9.Start();
                    }
                }
                if (pictureBox10.Bounds.IntersectsWith(pictureBox19.Bounds))
                {
                    karr += 1;
                    if (karr == 1)
                    {
                        pictureBox10.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        pictureBox10.Visible = false;
                        pic5 = false;
                    }
                    if (karr == 2)
                    {
                        karr = 0;
                        pictureBox10.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                        emtiaz += 2;
                        label4.Text = emtiaz.ToString();
                        pic5 = false;
                        pictureBox10.Visible = false;
                        pictureBox19.Image = Image.FromFile(@"D:\jang\enfejarasly.png");
                        pictureBox19.BackgroundImageLayout = ImageLayout.Tile;
                        pictureBox19.BackColor = Color.Transparent;
                        string soundplay = @"D:\jang\enfejar.wav";
                        using (SoundPlayer player = new SoundPlayer(soundplay))
                        {
                            player.Play();
                        }
                        timer14.Start();
                    }
                }
            }
        }
















        private int emtiaz = 0;
        private void pictureBox11_Move(object sender, EventArgs e)
        {
            if (pic6)
            {
                pictureBox11.Visible = true;
            }
            if (pictureBox11.Location.Y <= -16)
            {
                pictureBox11.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                pic6 = false;
                pictureBox11.Visible = false;
            }
        }
        private void pictureBox13_Move(object sender, EventArgs e)
        {
            if (pic7)
            {
                pictureBox13.Visible = true;

            }
            if (pictureBox13.Location.Y <= -16)
            {
                pictureBox13.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                pic7 = false;
                pictureBox13.Visible = false;
            }
        }
        private void pictureBox12_Move(object sender, EventArgs e)
        {
            if (pic8)
            {
                pictureBox12.Visible = true;

            }
            if (pictureBox12.Location.Y <= -16)
            {
                pictureBox12.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                pic8 = false;
                pictureBox12.Visible = false;
            }
        }
        private void pictureBox8_Move(object sender, EventArgs e)
        {
            if (pictureBox8.Location.Y == 535)
            {
                Pic8();
                emtiaz += 1;
                timer3.Start();
                emtiazat();
                label4.Text = emtiaz.ToString();
            }
            else if (pictureBox9.Location.Y == 535)
            {
                Pic9();
                emtiaz += 1;
                timer6.Start();
                emtiazat();
                label4.Text = emtiaz.ToString();
            }
            else if (pictureBox7.Location.Y == 535)
            {
                Pic7();
                emtiaz += 1;
                timer7.Start();
                emtiazat();
                label4.Text = emtiaz.ToString();
            }
            else if (pictureBox14.Location.Y >= 535)
            {
                Pic14();
                emtiaz += 1;
                timer8.Start();
                emtiazat();
                label4.Text = emtiaz.ToString();
            }
            else if (pictureBox15.Location.Y >= 535)
            {
                Pic15();
                emtiaz += 1;
                timer9.Start();
                emtiazat();
                label4.Text = emtiaz.ToString();
            }
            else if (label6.Location.Y >= 535 && pictureBox14.Location.Y >= 125)
            {
                postgal();
            }
            else if (pictureBox1.Location.Y >= 535)
            {
                setare();
                shahabb();
            }
        }
        private void pictureBox15_Move(object sender, EventArgs e)
        {
        }
        private void label6_Move(object sender, EventArgs e)
        {
            if (pictureBox6.Bounds.IntersectsWith(label6.Bounds))
            {
                if (label1.Text == "")
                {
                    dorost -= 1;
                    string soundplay = @"D:\jang\mixkit-game-bonus-reached-2065.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    label1.Text = "♥";
                }
                else if (label2.Text == "")
                {
                    dorost -= 1;
                    string soundplay = @"D:\jang\mixkit-game-bonus-reached-2065.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    postgal();
                    label2.Text = "♥";
                }
                else if (label3.Text == "")
                {
                    dorost -= 1;
                    string soundplay = @"D:\jang\mixkit-game-bonus-reached-2065.wav";
                    using (SoundPlayer player = new SoundPlayer(soundplay))
                    {
                        player.Play();
                    }
                    postgal();
                    label3.Text = "♥";
                }
            }
        }
        int dorost = 0;
        private void pictureBox6_Move(object sender, EventArgs e)
        {
            if (pictureBox6.Location.X <= -5)
            {
                pictureBox6.Location = new Point(25, 403);
                pictureBox2.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                pictureBox3.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                pictureBox4.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                pictureBox5.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                pictureBox11.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                pictureBox10.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                pictureBox12.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                pictureBox13.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
            }
            else if (pictureBox6.Location.X == 405)
            {
                pictureBox6.Location = new Point(380, 403);
                pictureBox2.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                pictureBox3.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                pictureBox4.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                pictureBox5.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                pictureBox11.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                pictureBox10.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
                pictureBox12.Location = new Point(pictureBox6.Location.X + 50, pictureBox6.Location.Y);
                pictureBox13.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
            }
        }
        private void Form1_Move(object sender, EventArgs e)
        {
            label4.Text = emtiaz.ToString();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            sora();
            control();
            if (pictureBox9.Location.Y > 125)
            {
                dosh4 = true;
                dosh5 = true;
            }
            if (pictureBox9.Location.Y > 225)
            {
                dosh6 = true;
            }
            if (pictureBox14.Location.Y > 125)
            {
                ghab = true;
            }
            if (pictureBox8.Location.Y > 125)
            {
                setaree = true;
                setare1 = true;
                dom = true;
                shahab = true;
            }
            if (pic1 == true && pic2 == true)
            {
                label11.Text = "";
            }
            if (pic1 == false && pic2 == false)
            {
                label11.Text = "🚀";
            }
            if (pic3 == true && pic4 == true)
            {
                label8.Text = "";
            }
            if (pic3 == false && pic4 == false)
            {
                label8.Text = "🚀";
            }
            if (pic5 == true && pic6 == true)
            {
                label9.Text = "";
            }
            if (pic5 == false && pic6 == false)
            {
                label9.Text = "🚀";
            }
            if (pic7 == true && pic8 == true)
            {
                label10.Text = "";
            }
            if (pic7 == false && pic8 == false)
            {
                label10.Text = "🚀";
            }
            if (Y == true && T == true && roh == 1 && roh1 == 1 && tarkib == true)
            {
                timer13.Start();
                pictureBox6.Visible = false;
                tarkib = false;
            }
            if (Y == true && T == true && roh == 2 && roh1 == 2 && tarkib == true)
            {
                timer13.Start();
                pictureBox6.Visible = true;
                tarkib = false;
                roh = 0;
                roh1 = 0;
            }
            if (global.change == true)
            {
                this.BackgroundImage = Image.FromFile(@"D:\jang\pictur1.jpg");
                this.BackgroundImageLayout = ImageLayout.Tile;
            }
            if (global1.change1 == true)
            {
                this.BackgroundImage = Image.FromFile(@"D:\jang\pictur2.jpg");
                this.BackgroundImageLayout = ImageLayout.Tile;
            }
            if (global2.change2 == true)
            {
                this.BackgroundImage = Image.FromFile(@"D:\jang\pictur3jpg.jpg");
                this.BackgroundImageLayout = ImageLayout.Tile;
            }
            if (moshack.moshack1 == true)
            {
                pictureBox6.Image = Image.FromFile(@"D:\jang\moshack1.png");
                pictureBox6.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox6.BackColor = Color.Transparent;
            }
            if (moshack1.moshack2 == true)
            {
                pictureBox6.Image = Image.FromFile(@"D:\jang\moshack2.png");
                pictureBox6.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox6.BackColor = Color.Transparent;
            }
            if (moshack2.moshack3 == true)
            {
                pictureBox6.Image = Image.FromFile(@"D:\jang\moshack3.png");
                pictureBox6.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox6.BackColor = Color.Transparent;
            }
            if (tir.tir1 == true)
            {
                pictureBox2.Image = Image.FromFile(@"D:\jang\tir1edit.png");
                pictureBox2.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox2.BackColor = Color.Transparent;
                pictureBox3.Image = Image.FromFile(@"D:\jang\tir1edit.png");
                pictureBox3.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox3.BackColor = Color.Transparent;
                pictureBox4.Image = Image.FromFile(@"D:\jang\tir1edit.png");
                pictureBox4.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox4.BackColor = Color.Transparent;
                pictureBox5.Image = Image.FromFile(@"D:\jang\tir1edit.png");
                pictureBox5.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox5.BackColor = Color.Transparent;
                pictureBox10.Image = Image.FromFile(@"D:\jang\tir1edit.png");
                pictureBox10.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox10.BackColor = Color.Transparent;
                pictureBox11.Image = Image.FromFile(@"D:\jang\tir1edit.png");
                pictureBox11.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox11.BackColor = Color.Transparent;
                pictureBox13.Image = Image.FromFile(@"D:\jang\tir1edit.png");
                pictureBox13.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox13.BackColor = Color.Transparent;
                pictureBox12.Image = Image.FromFile(@"D:\jang\tir1edit.png");
                pictureBox12.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox12.BackColor = Color.Transparent;
            }
            if (tir1.tir2 == true)
            {
                pictureBox2.Image = Image.FromFile(@"D:\jang\tir2edit.png");
                pictureBox2.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox2.BackColor = Color.Transparent;
                pictureBox3.Image = Image.FromFile(@"D:\jang\tir2edit.png");
                pictureBox3.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox3.BackColor = Color.Transparent;
                pictureBox4.Image = Image.FromFile(@"D:\jang\tir2edit.png");
                pictureBox4.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox4.BackColor = Color.Transparent;
                pictureBox5.Image = Image.FromFile(@"D:\jang\tir2edit.png");
                pictureBox5.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox5.BackColor = Color.Transparent;
                pictureBox10.Image = Image.FromFile(@"D:\jang\tir2edit.png");
                pictureBox10.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox10.BackColor = Color.Transparent;
                pictureBox11.Image = Image.FromFile(@"D:\jang\tir2edit.png");
                pictureBox11.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox11.BackColor = Color.Transparent;
                pictureBox13.Image = Image.FromFile(@"D:\jang\tir2edit.png");
                pictureBox13.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox13.BackColor = Color.Transparent;
                pictureBox12.Image = Image.FromFile(@"D:\jang\tir2edit.png");
                pictureBox12.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox12.BackColor = Color.Transparent;
            }
            if (tir2.tir3 == true)
            {
                pictureBox2.Image = Image.FromFile(@"D:\jang\tir3.png");
                pictureBox2.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox2.BackColor = Color.Transparent;
                pictureBox3.Image = Image.FromFile(@"D:\jang\tir3.png");
                pictureBox3.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox3.BackColor = Color.Transparent;
                pictureBox4.Image = Image.FromFile(@"D:\jang\tir3.png");
                pictureBox4.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox4.BackColor = Color.Transparent;
                pictureBox5.Image = Image.FromFile(@"D:\jang\tir3.png");
                pictureBox5.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox5.BackColor = Color.Transparent;
                pictureBox10.Image = Image.FromFile(@"D:\jang\tir3.png");
                pictureBox10.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox10.BackColor = Color.Transparent;
                pictureBox11.Image = Image.FromFile(@"D:\jang\tir3.png");
                pictureBox11.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox11.BackColor = Color.Transparent;
                pictureBox13.Image = Image.FromFile(@"D:\jang\tir3.png");
                pictureBox13.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox13.BackColor = Color.Transparent;
                pictureBox12.Image = Image.FromFile(@"D:\jang\tir3.png");
                pictureBox12.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox12.BackColor = Color.Transparent;
            }
            if (eazy.eazy1 == true)
            {
                timer1.Interval = 100;
                check();
                if (pic1)
                {
                    int tir = pictureBox2.Location.X;
                    int tir1 = pictureBox2.Location.Y - 5;
                    pictureBox2.Location = new Point(tir, tir1);
                }
                if (pic2)
                {
                    int bomb = pictureBox3.Location.X;
                    int bomb1 = pictureBox3.Location.Y - 5;
                    pictureBox3.Location = new Point(bomb, bomb1);
                }
                if (pic3)
                {
                    int bomb = pictureBox4.Location.X;
                    int bomb1 = pictureBox4.Location.Y - 5;
                    pictureBox4.Location = new Point(bomb, bomb1);
                }
                if (pic4)
                {
                    int bo = pictureBox5.Location.X;
                    int bo1 = pictureBox5.Location.Y - 5;
                    pictureBox5.Location = new Point(bo, bo1);

                }
                if (pic5)
                {
                    int tir = pictureBox10.Location.X;
                    int tir1 = pictureBox10.Location.Y - 5;
                    pictureBox10.Location = new Point(tir, tir1);
                }
                if (pic6)
                {
                    int bomb = pictureBox11.Location.X;
                    int bomb1 = pictureBox11.Location.Y - 5;
                    pictureBox11.Location = new Point(bomb, bomb1);
                }
                if (pic7)
                {
                    int tir = pictureBox13.Location.X;
                    int tir1 = pictureBox13.Location.Y - 5;
                    pictureBox13.Location = new Point(tir, tir1);
                }
                if (pic8)
                {
                    int bomb = pictureBox12.Location.X;
                    int bomb1 = pictureBox12.Location.Y - 5;
                    pictureBox12.Location = new Point(bomb, bomb1);
                }
                if (!dosh1)
                {
                    int tir = pictureBox8.Location.X;
                    int tir1 = pictureBox8.Location.Y + 1;
                    pictureBox8.Location = new Point(tir, tir1);
                }
                if (!dosh2)
                {
                    int bomb = pictureBox7.Location.X;
                    int bomb1 = pictureBox7.Location.Y + 1;
                    pictureBox7.Location = new Point(bomb, bomb1);
                }
                if (!dosh3)
                {
                    int bomb = pictureBox9.Location.X;
                    int bomb1 = pictureBox9.Location.Y + 1;
                    pictureBox9.Location = new Point(bomb, bomb1);
                }
                if (dosh4)
                {
                    int bomb = pictureBox15.Location.X;
                    int bomb1 = pictureBox15.Location.Y + 1;
                    pictureBox15.Location = new Point(bomb, bomb1);
                }
                if (dosh5)
                {
                    int bomb = pictureBox14.Location.X;
                    int bomb1 = pictureBox14.Location.Y + 1;
                    pictureBox14.Location = new Point(bomb, bomb1);
                }
                if (dosh6)
                {
                    int bomb = pictureBox19.Location.X;
                    int bomb1 = pictureBox19.Location.Y + 1;
                    pictureBox19.Location = new Point(bomb, bomb1);
                }
                if (ghab)
                {
                    int bomb = label6.Location.X;
                    int bomb1 = label6.Location.Y + 1;
                    label6.Location = new Point(bomb, bomb1);
                }
                if (setaree)
                {
                    int bomb = pictureBox1.Location.X;
                    int bomb1 = pictureBox1.Location.Y + 1;
                    pictureBox1.Location = new Point(bomb, bomb1);
                }
                if (setare1)
                {
                    int bomb = pictureBox16.Location.X;
                    int bomb1 = pictureBox16.Location.Y + 1;
                    pictureBox16.Location = new Point(bomb, bomb1);
                }
                if (shahab)
                {
                    int bomb = pictureBox17.Location.X - 5;
                    int bomb1 = pictureBox17.Location.Y;
                    pictureBox17.Location = new Point(bomb, bomb1);
                }
                if (dom)
                {
                    int bomb = pictureBox18.Location.X + 5;
                    int bomb1 = pictureBox18.Location.Y;
                    pictureBox18.Location = new Point(bomb, bomb1);
                }
                check();
            }
            if (medium.medium1 == true)
            {
                timer1.Interval = 50;
                check();
                if (pic1)
                {
                    int tir = pictureBox2.Location.X;
                    int tir1 = pictureBox2.Location.Y - 5;
                    pictureBox2.Location = new Point(tir, tir1);
                }
                if (pic2)
                {
                    int bomb = pictureBox3.Location.X;
                    int bomb1 = pictureBox3.Location.Y - 5;
                    pictureBox3.Location = new Point(bomb, bomb1);
                }
                if (pic3)
                {
                    int bomb = pictureBox4.Location.X;
                    int bomb1 = pictureBox4.Location.Y - 5;
                    pictureBox4.Location = new Point(bomb, bomb1);
                }
                if (pic4)
                {
                    int bo = pictureBox5.Location.X;
                    int bo1 = pictureBox5.Location.Y - 5;
                    pictureBox5.Location = new Point(bo, bo1);

                }
                if (pic5)
                {
                    int tir = pictureBox10.Location.X;
                    int tir1 = pictureBox10.Location.Y - 5;
                    pictureBox10.Location = new Point(tir, tir1);
                }
                if (pic6)
                {
                    int bomb = pictureBox11.Location.X;
                    int bomb1 = pictureBox11.Location.Y - 5;
                    pictureBox11.Location = new Point(bomb, bomb1);
                }
                if (pic7)
                {
                    int tir = pictureBox13.Location.X;
                    int tir1 = pictureBox13.Location.Y - 5;
                    pictureBox13.Location = new Point(tir, tir1);
                }
                if (pic8)
                {
                    int bomb = pictureBox12.Location.X;
                    int bomb1 = pictureBox12.Location.Y - 5;
                    pictureBox12.Location = new Point(bomb, bomb1);
                }
                if (!dosh1)
                {
                    int tir = pictureBox8.Location.X;
                    int tir1 = pictureBox8.Location.Y + 5;
                    pictureBox8.Location = new Point(tir, tir1);
                }
                if (!dosh2)
                {
                    int bomb = pictureBox7.Location.X;
                    int bomb1 = pictureBox7.Location.Y + 5;
                    pictureBox7.Location = new Point(bomb, bomb1);
                }
                if (!dosh3)
                {
                    int bomb = pictureBox9.Location.X;
                    int bomb1 = pictureBox9.Location.Y + 5;
                    pictureBox9.Location = new Point(bomb, bomb1);
                }
                if (dosh4)
                {
                    int bomb = pictureBox15.Location.X;
                    int bomb1 = pictureBox15.Location.Y + 5;
                    pictureBox15.Location = new Point(bomb, bomb1);
                }
                if (dosh5)
                {
                    int bomb = pictureBox14.Location.X;
                    int bomb1 = pictureBox14.Location.Y + 5;
                    pictureBox14.Location = new Point(bomb, bomb1);
                }
                if (dosh6)
                {
                    int bomb = pictureBox19.Location.X;
                    int bomb1 = pictureBox19.Location.Y + 5;
                    pictureBox19.Location = new Point(bomb, bomb1);
                }
                if (ghab)
                {
                    int bomb = label6.Location.X;
                    int bomb1 = label6.Location.Y + 5;
                    label6.Location = new Point(bomb, bomb1);
                }
                if (setaree)
                {
                    int bomb = pictureBox1.Location.X;
                    int bomb1 = pictureBox1.Location.Y + 5;
                    pictureBox1.Location = new Point(bomb, bomb1);
                }
                if (setare1)
                {
                    int bomb = pictureBox16.Location.X;
                    int bomb1 = pictureBox16.Location.Y + 5;
                    pictureBox16.Location = new Point(bomb, bomb1);
                }
                if (shahab)
                {
                    int bomb = pictureBox17.Location.X - 5;
                    int bomb1 = pictureBox17.Location.Y;
                    pictureBox17.Location = new Point(bomb, bomb1);
                }
                if (dom)
                {
                    int bomb = pictureBox18.Location.X + 5;
                    int bomb1 = pictureBox18.Location.Y;
                    pictureBox18.Location = new Point(bomb, bomb1);
                }
                check();
            }
            if (hard.hard1 == true)
            {
                timer1.Interval = 1;
                check();
                if (pic1)
                {
                    int tir = pictureBox2.Location.X;
                    int tir1 = pictureBox2.Location.Y - 10;
                    pictureBox2.Location = new Point(tir, tir1);
                }
                if (pic2)
                {
                    int bomb = pictureBox3.Location.X;
                    int bomb1 = pictureBox3.Location.Y - 10;
                    pictureBox3.Location = new Point(bomb, bomb1);
                }
                if (pic3)
                {
                    int bomb = pictureBox4.Location.X;
                    int bomb1 = pictureBox4.Location.Y - 10;
                    pictureBox4.Location = new Point(bomb, bomb1);
                }
                if (pic4)
                {
                    int bo = pictureBox5.Location.X;
                    int bo1 = pictureBox5.Location.Y - 10;
                    pictureBox5.Location = new Point(bo, bo1);

                }
                if (pic5)
                {
                    int tir = pictureBox10.Location.X;
                    int tir1 = pictureBox10.Location.Y - 10;
                    pictureBox10.Location = new Point(tir, tir1);
                }
                if (pic6)
                {
                    int bomb = pictureBox11.Location.X;
                    int bomb1 = pictureBox11.Location.Y - 10;
                    pictureBox11.Location = new Point(bomb, bomb1);
                }
                if (pic7)
                {
                    int tir = pictureBox13.Location.X;
                    int tir1 = pictureBox13.Location.Y - 10;
                    pictureBox13.Location = new Point(tir, tir1);
                }
                if (pic8)
                {
                    int bomb = pictureBox12.Location.X;
                    int bomb1 = pictureBox12.Location.Y - 10;
                    pictureBox12.Location = new Point(bomb, bomb1);
                }
                if (!dosh1)
                {
                    int tir = pictureBox8.Location.X;
                    int tir1 = pictureBox8.Location.Y + 20;
                    pictureBox8.Location = new Point(tir, tir1);
                }
                if (!dosh2)
                {
                    int bomb = pictureBox7.Location.X;
                    int bomb1 = pictureBox7.Location.Y + 20;
                    pictureBox7.Location = new Point(bomb, bomb1);
                }
                if (!dosh3)
                {
                    int bomb = pictureBox9.Location.X;
                    int bomb1 = pictureBox9.Location.Y + 20;
                    pictureBox9.Location = new Point(bomb, bomb1);
                }
                if (dosh4)
                {
                    int bomb = pictureBox15.Location.X;
                    int bomb1 = pictureBox15.Location.Y + 20;
                    pictureBox15.Location = new Point(bomb, bomb1);
                }
                if (dosh5)
                {
                    int bomb = pictureBox14.Location.X;
                    int bomb1 = pictureBox14.Location.Y + 20;
                    pictureBox14.Location = new Point(bomb, bomb1);
                }
                if (dosh6)
                {
                    int bomb = pictureBox19.Location.X;
                    int bomb1 = pictureBox19.Location.Y + 20;
                    pictureBox19.Location = new Point(bomb, bomb1);
                }
                if (ghab)
                {
                    int bomb = label6.Location.X;
                    int bomb1 = label6.Location.Y + 10;
                    label6.Location = new Point(bomb, bomb1);
                }
                if (setaree)
                {
                    int bomb = pictureBox1.Location.X;
                    int bomb1 = pictureBox1.Location.Y + 10;
                    pictureBox1.Location = new Point(bomb, bomb1);
                }
                if (setare1)
                {
                    int bomb = pictureBox16.Location.X;
                    int bomb1 = pictureBox16.Location.Y + 10;
                    pictureBox16.Location = new Point(bomb, bomb1);
                }
                if (shahab)
                {
                    int bomb = pictureBox17.Location.X - 10;
                    int bomb1 = pictureBox17.Location.Y;
                    pictureBox17.Location = new Point(bomb, bomb1);
                }
                if (dom)
                {
                    int bomb = pictureBox18.Location.X + 10;
                    int bomb1 = pictureBox18.Location.Y;
                    pictureBox18.Location = new Point(bomb, bomb1);
                }
                check();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (global.change == true)
            {
                this.BackgroundImage = Image.FromFile(@"D:\jang\pictur1.jpg");
                this.BackgroundImageLayout = ImageLayout.Tile;
            }
            if (global1.change1 == true)
            {
                this.BackgroundImage = Image.FromFile(@"D:\jang\pictur2.jpg");
                this.BackgroundImageLayout = ImageLayout.Tile;
            }
            if (global2.change2 == true)
            {
                this.BackgroundImage = Image.FromFile(@"D:\jang\pictur3jpg.jpg");
                this.BackgroundImageLayout = ImageLayout.Tile;
            }
            if (moshack.moshack1 == true)
            {
                pictureBox6.Image = Image.FromFile(@"D:\jang\moshack1.png");
                pictureBox6.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox6.BackColor = Color.Transparent;
            }
            if (moshack1.moshack2 == true)
            {
                pictureBox6.Image = Image.FromFile(@"D:\jang\moshack2.png");
                pictureBox6.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox6.BackColor = Color.Transparent;
            }
            if (moshack2.moshack3 == true)
            {
                pictureBox6.Image = Image.FromFile(@"D:\jang\moshack3.png");
                pictureBox6.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox6.BackColor = Color.Transparent;
            }
            if (tir.tir1 == true)
            {
                pictureBox2.Image = Image.FromFile(@"D:\jang\tir1edit.png");
                pictureBox2.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox2.BackColor = Color.Transparent;
                pictureBox3.Image = Image.FromFile(@"D:\jang\tir1edit.png");
                pictureBox3.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox3.BackColor = Color.Transparent;
                pictureBox4.Image = Image.FromFile(@"D:\jang\tir1edit.png");
                pictureBox4.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox4.BackColor = Color.Transparent;
                pictureBox5.Image = Image.FromFile(@"D:\jang\tir1edit.png");
                 pictureBox5.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox5.BackColor = Color.Transparent;
                pictureBox10.Image = Image.FromFile(@"D:\jang\tir1edit.png");
                pictureBox10.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox10.BackColor = Color.Transparent;
                pictureBox11.Image = Image.FromFile(@"D:\jang\tir1edit.png");
                pictureBox11.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox11.BackColor = Color.Transparent;
                pictureBox13.Image = Image.FromFile(@"D:\jang\tir1edit.png");
                pictureBox13.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox13.BackColor = Color.Transparent;
                pictureBox12.Image = Image.FromFile(@"D:\jang\tir1edit.png");
                pictureBox12.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox12.BackColor = Color.Transparent;
            }
            if (tir1.tir2 == true)
            {
                pictureBox2.Image = Image.FromFile(@"D:\jang\tir2edit.png");
                pictureBox2.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox2.BackColor = Color.Transparent;
                pictureBox3.Image = Image.FromFile(@"D:\jang\tir2edit.png");
                pictureBox3.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox3.BackColor = Color.Transparent;
                pictureBox4.Image = Image.FromFile(@"D:\jang\tir2edit.png");
                pictureBox4.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox4.BackColor = Color.Transparent;
                pictureBox5.Image = Image.FromFile(@"D:\jang\tir2edit.png");
                pictureBox5.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox5.BackColor = Color.Transparent;
                pictureBox10.Image = Image.FromFile(@"D:\jang\tir2edit.png");
                pictureBox10.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox10.BackColor = Color.Transparent;
                pictureBox11.Image = Image.FromFile(@"D:\jang\tir2edit.png");
                pictureBox11.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox11.BackColor = Color.Transparent;
                pictureBox13.Image = Image.FromFile(@"D:\jang\tir2edit.png");
                pictureBox13.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox13.BackColor = Color.Transparent;
                pictureBox12.Image = Image.FromFile(@"D:\jang\tir2edit.png");
                pictureBox12.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox12.BackColor = Color.Transparent;
            }
            if (tir2.tir3 == true)
            {
                pictureBox2.Image = Image.FromFile(@"D:\jang\tir3.png");
                pictureBox2.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox2.BackColor = Color.Transparent;
                pictureBox3.Image = Image.FromFile(@"D:\jang\tir3.png");
                pictureBox3.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox3.BackColor = Color.Transparent;
                pictureBox4.Image = Image.FromFile(@"D:\jang\tir3.png");
                pictureBox4.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox4.BackColor = Color.Transparent;
                pictureBox5.Image = Image.FromFile(@"D:\jang\tir3.png");
                pictureBox5.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox5.BackColor = Color.Transparent;
                pictureBox10.Image = Image.FromFile(@"D:\jang\tir3.png");
                pictureBox10.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox10.BackColor = Color.Transparent;
                pictureBox11.Image = Image.FromFile(@"D:\jang\tir3.png");
                pictureBox11.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox11.BackColor = Color.Transparent;
                pictureBox13.Image = Image.FromFile(@"D:\jang\tir3.png");
                pictureBox13.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox13.BackColor = Color.Transparent;
                pictureBox12.Image = Image.FromFile(@"D:\jang\tir3.png");
                pictureBox12.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox12.BackColor = Color.Transparent;
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
            waveOutDevice.Pause();
        }
    }
}