using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class VillageWindow : Form
    {
        public VillageWindow()
        {
            InitializeComponent();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void House(object sender, EventArgs e)
        {

        }

        private void Tree(object sender, EventArgs e)
        {

        }

        private void WaterSource(object sender, EventArgs e)
        {

        }

        private void Save_Village(object sender, EventArgs e)
        {
            pr.setObj(village_name, drawing_panel,g);

        }
        Dummy pr = new Dummy();
        private void New_Village(object sender, EventArgs e)
        {
            Regex pattern = new Regex(@"^[a-zA-Z]+$");

            string sVillageName = tbVillageName.Text;
            if (!pattern.IsMatch(sVillageName)) {

                MessageBox.Show(Constants.error_message);
                return;
            }

            
            
            GameFactory gameFactory = new GameFactory();
            IGames game = gameFactory.getGame();
            CommandFactory commandFactory = new CommandFactory();
            Command onCommand = commandFactory.CreateCommand("New", game, drawing_panel, village_name,sVillageName);
            GameKeyInvoker gameKeyInvoker = new GameKeyInvoker(onCommand);
            gameKeyInvoker.click();
           



        }
        Graphics g;


        private void Open_village(object sender, EventArgs e)
        {
             g= drawing_panel.CreateGraphics();
            village_name.Text = "Okay";
            pr.setName(village_name,drawing_panel);
            
            Pen p = new Pen(Color.Black);
            g.DrawEllipse(p, 10, 10, 100, 100);
            g.DrawLine(p, 150, 150, 300, 300);

            pr.openVillage(village_name);
            
            //pr.setPanel(drawing_panel);
            
        }

        private void VillageWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
