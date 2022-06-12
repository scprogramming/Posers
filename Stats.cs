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
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Stats_Load(object sender, EventArgs e)
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
                }
                else if (lineNum == 1)
                {
                    currentSessions = Int32.Parse(line.Substring(line.IndexOf("]") + 1));
                }
                else if (lineNum == 2)
                {
                    currentFigures = Int32.Parse(line.Substring(line.IndexOf("]") + 1));
                }
                lineNum++;
            }

            TimeSpan time = TimeSpan.FromSeconds(currentSeconds);

            TimeSpentLabel.Text = time.ToString(@"hh") + " hours " + time.ToString(@"mm") + " minutes " + time.ToString(@"ss") + " seconds";
            SessionCountLabel.Text = currentSessions.ToString();
            FiguresDrawnLabel.Text = currentFigures.ToString();

        }
    }
}
