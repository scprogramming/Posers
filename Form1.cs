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

        private void PickImageFolderButton_Click(object sender, EventArgs e)
        {
            images = new List<string>();
            int imagesFound = 0;

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    foreach (string file in files)
                    {
                        if (ImageExtensions.Contains(Path.GetExtension(file).ToUpperInvariant()))
                        {
                            images.Add(file);
                            imagesFound++;
                        }
                        
                    }

                    FolderPathText.Text = fbd.SelectedPath;
                    ImagesFoundLabel.Text = "Found " + imagesFound.ToString() + " images in the folder";
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
            figureForm.images = images;
            

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
            SessionOptionList.View = View.Details;
        }

        private void SaveConfigurationButton_Click(object sender, EventArgs e)
        {
            bool exists = System.IO.Directory.Exists("config");

            if (!exists)
            {
                System.IO.Directory.CreateDirectory("config");
            }
        }
    }
}