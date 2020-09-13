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
    public partial class NewVillageSelectorwindow : Form
    {
        private List<INationFactory> nationlist;
        private Villagewindow villagewindow;

        public NewVillageSelectorwindow(List<INationFactory> nationlist, Villagewindow villagewindow)
        {
            InitializeComponent();
            this.nationlist = nationlist;
            this.villagewindow = villagewindow;
        }

        private void NewVillageSelectorwindow_Load(object sender, EventArgs e)
        {
            cboxnation.DataSource = nationlist;
            cboxnation.DisplayMember = "NationName";
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btndone_Click(object sender, EventArgs e)
        {
            if (txtvillagename.TextLength!=0)
            {
                INationFactory factory = (INationFactory)cboxnation.SelectedItem;
                INation nation = factory.GetNation();
                villagewindow.village = new Village(nation, txtvillagename.Text);
                villagewindow.lblnation.Text = nation.GetNationName();
                villagewindow.lblvillage.Text = txtvillagename.Text;
                villagewindow.village.initiate(villagewindow.g, villagewindow.p);
                this.Dispose();
            }
        }
    }
}
