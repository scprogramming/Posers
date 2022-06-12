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
    public partial class LoadData : Form
    {
        public LoadData()
        {
            InitializeComponent();
        }

        private void LoadData_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles("config/");

            foreach (string file in files)
            {
                ConfigListbox.Items.Add(Path.GetFileNameWithoutExtension(file));
            }

            ConfigListbox.SelectedIndex = 0;
        }

        public string selectedConfig { get; set; }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.selectedConfig = ConfigListbox.GetItemText(ConfigListbox.SelectedItem);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
