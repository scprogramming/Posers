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

        private void FigureForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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

        private void timerTick(object sends, EventArgs e)
        {
            startTime--;
            TimeLabel.Text = startTime.ToString();

            if (startTime == 0)
            {
                FigureTimer.Stop();

                if (times.Count != 0)
                {
                    startTime = times[0] + 1;
                    times.RemoveAt(0);

                    if (images.Count != 0)
                    {
                        figureImage.Image = Image.FromFile(images[0]);
                        imageHolder.Add(images[0]);
                        images.RemoveAt(0);
                    }
                    else
                    {
                        foreach(string image in imageHolder)
                        {
                            images.Add(image);
                        }
                    }
                    

                    FigureTimer.Start();
                }
                else
                {
                    MessageBox.Show("Session completed!");
                    this.Close();
                }
                
                
            }
        }
    }
}
