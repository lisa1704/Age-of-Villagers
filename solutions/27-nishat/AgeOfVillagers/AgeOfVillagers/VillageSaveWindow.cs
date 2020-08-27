using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class VillageSaveWindow : Form
    {
        private Villagewindow villagewindow;

        public VillageSaveWindow(Villagewindow villagewindow)
        {
            InitializeComponent();
            this.villagewindow = villagewindow;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (villagewindow.village != null)
            {
                IState state = villagewindow.village.GetState();
                state.SetVillageName(txtvillagename.Text);
                this.Dispose();
                Savestate(state);
            }
        }
        private void Savestate(IState state)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "age of villagers file|*.aov";
            saveFileDialog.Title = "Save village";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                var settings = new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.All
                };
                var dataString = JsonConvert.SerializeObject(state, Formatting.Indented, settings);
                System.IO.File.WriteAllText(saveFileDialog.FileName, dataString);
            }
        }

        private void VillageSaveWindow_Load(object sender, EventArgs e)
        {
            txtvillagename.Text = villagewindow.lblvillage.Text;
        }
    }
}
