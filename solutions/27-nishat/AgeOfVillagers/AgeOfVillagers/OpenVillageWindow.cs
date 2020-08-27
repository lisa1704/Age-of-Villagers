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
    public partial class OpenVillageWindow : Form
    {
        private List<INationFactory> nationlist;
        private Villagewindow villagewindow;

        public OpenVillageWindow(List<INationFactory> nationlist, Villagewindow villagewindow)
        {
            InitializeComponent();
            this.nationlist = nationlist;
            this.villagewindow = villagewindow;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            if (txtvillagepath.Text != "")
            {
                INationFactory factory = (INationFactory)cboxnation.SelectedItem;
                INation nation = factory.GetNation();
                var dataString = System.IO.File.ReadAllText(txtvillagepath.Text);
                var settings = new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.All
                };
                IState state = JsonConvert.DeserializeObject<IState>(dataString,settings);
                villagewindow.village = new Village(nation, "");
                villagewindow.village.SetState(state);
                villagewindow.lblnation.Text = nation.GetNationName();
                villagewindow.lblvillage.Text = state.GetVillageName();
                villagewindow.village.initiate(villagewindow.g,villagewindow.p);
                this.Dispose();
            }
        }

        private void OpenVillageWindow_Load(object sender, EventArgs e)
        {
            cboxnation.DataSource = nationlist;
            cboxnation.DisplayMember = "NationName";
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "age of villagers file|*.aov";
            openFileDialog.Title = "open village";
            openFileDialog.ShowDialog();
            txtvillagepath.Text = openFileDialog.FileName;
        }
    }
}
