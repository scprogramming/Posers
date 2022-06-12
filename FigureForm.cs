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
        private List<int> quantityList = new List<int>();

        public List<Interval> intervals = new List<Interval>();
        public List<int> times = new List<int>();
        public int startTime;
        private bool playPauseToggle = true;

        private bool wasSkip = false;

        private int secondsSpent = 0;
        private int figuresCompleted = 0;

        private int currentTimeInterval = 0;

        private int figCount = 0;

        public FigureForm()
        {
            InitializeComponent();
        }

        private void buildTimes()
        {
            foreach (Interval interval in intervals)
            {
                quantityList.Add(interval.getQuantity());
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
            figCount = quantityList[0];
            currentTimeInterval = startTime;
            times.RemoveAt(0);
            quantityList.RemoveAt(0);

            FiguresLeftLabel.Text = "Figures Left: " + figCount.ToString();

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
            if (!wasSkip)
            {
                figuresCompleted += 1;
            }
        }

        private void updateStats()
        {

            if (File.Exists("stats.txt"))
            {
                int currentSeconds = 0;
                int currentSessions = 0;
                int currentFigures = 0;
                int lineNum = 0;

                IEnumerable<string> lines = File.ReadLines("stats.txt");

                foreach (string line in lines)
                {
                    if (lineNum == 0)
                    {
                        currentSeconds = Int32.Parse(line.Substring(line.IndexOf("]") + 1));
                    }else if (lineNum == 1)
                    {
                        currentSessions = Int32.Parse(line.Substring(line.IndexOf("]") + 1));
                    }else if (lineNum == 2)
                    {
                        currentFigures = Int32.Parse(line.Substring(line.IndexOf("]") + 1));
                    }
                    lineNum++;
                }

                File.Delete("stats.txt");

                using (StreamWriter writer = new StreamWriter("stats.txt"))
                {
                    writer.WriteLine("[TimeSpentDrawing]" + (currentSeconds + secondsSpent).ToString());
                    writer.WriteLine("[NumberOfSessions]" + (currentSessions + 1).ToString());
                    writer.WriteLine("[NumberOfFigures]" + (figuresCompleted + currentFigures).ToString());
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter("stats.txt"))
                {
                    writer.WriteLine("[TimeSpentDrawing]" + secondsSpent.ToString());
                    writer.WriteLine("[NumberOfSessions]1");
                    writer.WriteLine("[NumberOfFigures]" + figuresCompleted.ToString());
                }
            }
        }

        private void updateTime()
        {
            FigureTimer.Stop();

            if (times.Count != 0)
            {
                startTime = times[0];
                currentTimeInterval = startTime;
                times.RemoveAt(0);

                nextImage();

                FigureTimer.Start();
            }
            else
            {
                MessageBox.Show("Session completed!");
                FigureTimer.Tick -= timerTick;
                updateStats();
                this.Close();
            }

            figCount -= 1;

            if (figCount == 0 && quantityList.Count != 0)
            {
                figCount = quantityList[0];
                quantityList.RemoveAt(0);
            }

            FiguresLeftLabel.Text = "Figures Left: " + figCount.ToString();


        }

        private void timerTick(object sends, EventArgs e)
        {
            startTime--;
            secondsSpent += 1;
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
            wasSkip = true;
            nextImage();
            wasSkip = false;

            startTime = currentTimeInterval;
            FigureTimer.Start();
        }

        private void SkipTimeButton_Click(object sender, EventArgs e)
        {
            updateTime();
        }
    }
}
