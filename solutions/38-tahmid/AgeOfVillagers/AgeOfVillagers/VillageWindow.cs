using AgeOfVillagers.Interface;
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
        Graphics g;
        Pen pen;
        ItemFactory itemFactory;
        public VillageWindow()
        {
            InitializeComponent();

            g = drawing_panel.CreateGraphics();
            pen = new Pen(Color.Black);
            itemFactory = new ItemFactory();


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
        


        private void Open_village(object sender, EventArgs e)
        {
             
           

        }

        private void VillageWindow_Load(object sender, EventArgs e)
        {

        }

        private void drawing_panel_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            
            IItem villageItem = itemFactory.GetItem(g, pen, point,Constants.BDWATERSOURCE_HINT);
            villageItem.placeItem();

            
            
        }
    }
}
