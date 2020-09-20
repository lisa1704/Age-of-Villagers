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
        private string filePath = "";

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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "AgeOfVillagers file|*.aov";
            openFileDialog.Title = "Open Village";
            openFileDialog.ShowDialog();
            filePath = openFileDialog.FileName;
        }

        private void nationLabel_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (filePath != "")
            {
                villageWin.nationLabel.Text = nationComBox.Text;
                NationFactory nFactory = new NationFactory(nationComBox.Text);
                INation newnation = nFactory.getNation();

                var dataString = System.IO.File.ReadAllText(filePath);
                var settings = new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.All
                };
                villageWin.village = JsonConvert.DeserializeObject<Village>(dataString, settings);
                villageWin.village.nation = newnation;
                villageWin.villageLabel.Text = villageWin.village.villageName;
                new VillagerManager(villageWin.village).loadVillage(villageWin.g, villageWin.p);
                this.Dispose();
            }
            else 
            { 
                DialogResult dialog = MessageBox.Show("Choose Village file !");
            }
        }

        private void villageLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
