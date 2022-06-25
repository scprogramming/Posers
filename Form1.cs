namespace Posers
{
    public partial class MainForm : Form
    {
        private List<string> images = new List<string>();
        private List<string> ImageExtensions = new List<string> { ".JPG", ".JPE", ".BMP", ".GIF", ".PNG" };
        public MainForm()
        {
            InitializeComponent();
        }

        private void populateImages(string path)
        {
            int imagesFound = 0;

            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                if (ImageExtensions.Contains(Path.GetExtension(file).ToUpperInvariant()))
                {
                    images.Add(file);
                    imagesFound++;
                }

            }

            FolderPathText.Text = path;
            ImagesFoundLabel.Text = "Found " + imagesFound.ToString() + " images in the folder";
        }

        private void PickImageFolderButton_Click(object sender, EventArgs e)
        {
            images = new List<string>();
            

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    populateImages(fbd.SelectedPath);
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int quantity;
            int time;
            string unit;

            bool quantityParse = int.TryParse(QuantityText.Text, out quantity);
            bool timeParse = int.TryParse(TimeText.Text, out time);
            unit = TimeUnitCombo.Text;

            if (quantityParse && timeParse)
            {
                string[] row = { quantity.ToString(), time.ToString(), unit };
                ListViewItem item = new ListViewItem(row);
                SessionOptionList.Items.Add(item);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Quantity and time must both be integers");
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {


            FigureForm figureForm = new FigureForm();
            List<string> deepImageCopy = new List<string>();

            foreach(string image in images)
            {
                deepImageCopy.Add(image);
            }

            figureForm.images = deepImageCopy;


            ListView.ListViewItemCollection items = SessionOptionList.Items;


            foreach (ListViewItem item in items)
            {
                Interval interval = new Interval();
                interval.setQuantity(int.Parse(item.SubItems[0].Text));
                interval.setTime(int.Parse(item.SubItems[1].Text));
                interval.setUnit(item.SubItems[2].Text);

                figureForm.intervals.Add(interval);
            }
            figureForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string defaultConf = "";

            if (File.Exists("default.txt"))
            {

                IEnumerable<string> lines = File.ReadLines("default.txt");

                foreach (string line in lines)
                {
                    defaultConf = line;
                }

                FolderPathText.Clear();
                SessionOptionList.Items.Clear();

                lines = File.ReadLines(defaultConf);
                int lineNum = 0;

                foreach (string line in lines)
                {
                    if (lineNum == 0)
                    {
                        FolderPathText.Text = line;
                        populateImages(line);
                        lineNum += 1;
                    }
                    else
                    {
                        string[] durationLine = line.Split(",");

                        string[] row = { durationLine[0], durationLine[1], durationLine[2] };
                        ListViewItem item = new ListViewItem(row);
                        SessionOptionList.Items.Add(item);
                    }
                }
            }

            SessionOptionList.View = View.Details;
            TimeUnitCombo.SelectedIndex = 0;
        }

        private void SaveConfigurationButton_Click(object sender, EventArgs e)
        {

            if (SessionOptionList.Items.Count != 0 && !FolderPathText.Text.Equals(""))
            {
                bool exists = System.IO.Directory.Exists("config");

                if (!exists)
                {
                    System.IO.Directory.CreateDirectory("config");
                }

                string fileName = Microsoft.VisualBasic.Interaction.InputBox("Please input a name for the configuration", "Config Title");

                if (File.Exists("config/" + fileName + ".conf"))
                {
                    DialogResult res = MessageBox.Show("File already exists, would you like to overwrite it?", "Overwrite File?", MessageBoxButtons.YesNo);

                    if (res != DialogResult.No)
                    {
                        File.Delete("config/" + fileName + ".conf");
                    }
                    else
                    {
                        return;
                    }

                }

                using (StreamWriter writer = new StreamWriter("config/" + fileName + ".conf"))
                {
                    writer.WriteLine(FolderPathText.Text);

                    ListView.ListViewItemCollection items = SessionOptionList.Items;

                    foreach (ListViewItem item in items)
                    {
                        writer.WriteLine(item.SubItems[0].Text + "," + item.SubItems[1].Text + "," + item.SubItems[2].Text);
                    }
                }
            }
            else
            {
                MessageBox.Show("You must input a file path and at least one session entry!");
            }


        }

        private void LoadConfigurationButton_Click(object sender, EventArgs e)
        {

            if (Directory.Exists("config"))
            {
                FolderPathText.Clear();
                SessionOptionList.Items.Clear();

                using (LoadData loadDataForm = new LoadData())
                {
                    DialogResult result = loadDataForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        string selectedConfig = loadDataForm.selectedConfig;

                        IEnumerable<string> lines = File.ReadLines("config/" + selectedConfig + ".conf");
                        int lineNum = 0;

                        foreach (string line in lines)
                        {
                            if (lineNum == 0)
                            {
                                FolderPathText.Text = line;
                                populateImages(line);
                                lineNum += 1;
                            }
                            else
                            {
                                string[] durationLine = line.Split(",");

                                string[] row = { durationLine[0], durationLine[1], durationLine[2] };
                                ListViewItem item = new ListViewItem(row);
                                SessionOptionList.Items.Add(item);
                            }
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("No configurations available");
            }
            
        }

        private void StatsButton_Click(object sender, EventArgs e)
        {
            if (File.Exists("stats.txt"))
            {
                Stats statForm = new Stats();
                statForm.Show();
            }
            else
            {
                MessageBox.Show("No stats exist yet!");
            }
            
        }
    }
}