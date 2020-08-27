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
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "save village|*.aov";
            saveFileDialog1.Title = "Save village";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                var dataString = JsonConvert.SerializeObject(state, Formatting.Indented);
                System.IO.File.WriteAllText(saveFileDialog1.FileName, dataString);
            }
        }

        private void VillageSaveWindow_Load(object sender, EventArgs e)
        {
            txtvillagename.Text = villagewindow.lblvillage.Text;
        }
    }
}
