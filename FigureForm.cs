using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Posers
{
    public partial class FigureForm : Form
    {
        public List<string> images = new List<string>();
        public List<string> imageHolder = new List<string>();

        public List<Interval> intervals = new List<Interval>();
        public List<int> times = new List<int>();
        public int startTime;
        private bool playPauseToggle = true;

        public FigureForm()
        {
            InitializeComponent();
        }

        private void buildTimes()
        {
            foreach (Interval interval in intervals)
            {
                for (int i = 0; i < interval.getQuantity(); i++)
                {
                    if (interval.getUnit().Equals("Minutes"))
                    {
                        times.Add(interval.getTime() * 60);
                    }
                    else
                    {
                        times.Add(interval.getTime());
                    }
                    
                }
            }
        }

        private void shuffle(IList<string> listIn)
        {
            Random rand = new Random();

            for (int i = listIn.Count - 1; i > 0; i--)
            {
                int k = rand.Next(i + 1);
                string value = listIn[k];
                listIn[k] = listIn[i];
                listIn[i] = value;
            }
        }

        private void FigureForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FigureTimer.Stop();
            FigureTimer.Tick -= timerTick;
            FigureTimer = new System.Windows.Forms.Timer();
        }

        private void FigureForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormClosing += new FormClosingEventHandler(FigureForm_FormClosing);
            PausePlayButton.Text = "⏸";

            shuffle(images);

            figureImage.Image = Image.FromFile(images[0]);
            imageHolder.Add(images[0]);
            images.RemoveAt(0);
            

            buildTimes();

            startTime = times[0];
            times.RemoveAt(0);

            FigureTimer.Tick += timerTick;
            FigureTimer.Interval = 1000;
            FigureTimer.Start();
            
        }

        private void nextImage()
        {
            if (images.Count != 0)
            {
                figureImage.Image = Image.FromFile(images[0]);
                imageHolder.Add(images[0]);
                images.RemoveAt(0);
            }
            else
            {
                foreach (string image in imageHolder)
                {
                    images.Add(image);
                }

                imageHolder = new List<string>();
                shuffle(images);
                figureImage.Image = Image.FromFile(images[0]);
                imageHolder.Add(images[0]);
                images.RemoveAt(0);
            }
        }

        private void updateTime()
        {
            FigureTimer.Stop();

            if (times.Count != 0)
            {
                startTime = times[0] + 1;
                times.RemoveAt(0);

                nextImage();

                FigureTimer.Start();
            }
            else
            {
                MessageBox.Show("Session completed!");
                FigureTimer.Tick -= timerTick;
                this.Close();
            }
        }

        private void timerTick(object sends, EventArgs e)
        {
            startTime--;
            TimeLabel.Text = startTime.ToString();

            if (startTime == 0)
            {
                updateTime();
            }
        }

        private void PausePlayButton_Click(object sender, EventArgs e)
        {
            if (playPauseToggle)
            {
                PausePlayButton.Text = "▶";
                playPauseToggle = false;
                FigureTimer.Stop();
            }
            else
            {
                PausePlayButton.Text = "⏸";
                playPauseToggle = true;
                FigureTimer.Start();
            }
        }

        private void SkipImageButton_Click(object sender, EventArgs e)
        {
            FigureTimer.Stop();
            nextImage();
            FigureTimer.Start();
        }

        private void SkipTimeButton_Click(object sender, EventArgs e)
        {
            updateTime();
        }
    }
}
