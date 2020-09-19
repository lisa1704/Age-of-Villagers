using AgeOfVillagers.Factories;
using AgeOfVillagers.Nation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class OpenVillageWindow : Form
    {
        private readonly VillageWindow villageWin;
        private string filePath;

        public OpenVillageWindow(VillageWindow vw)
        {
            InitializeComponent();
            this.villageWin = vw;
        }


        private void OpenVillageWindow_Load(object sender, EventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            
        }

        private void nationLabel_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            
        }

        private void villageLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
