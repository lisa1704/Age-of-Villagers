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
        String item, nation;
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
            GameControlCommand onCommand = commandFactory.CreateCommand("New", game, drawing_panel, village_name,sVillageName);
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

       

       

        private void ClickTree(object sender, EventArgs e)
        {
            
                MessageBox.Show("La");
        }

        private void ClickHouse(object sender, EventArgs e)
        {

        }

        private void ClickWaterSource(object sender, EventArgs e)
        {

        }

        private void Click_Bangladeshi_Farmers(object sender, EventArgs e)
        {

        }

        private void Click_Inuit_Hunters(object sender, EventArgs e)
        {

        }

        private void Click_Egyptian_Kings(object sender, EventArgs e)
        {

        }

        private void Click_Arab_Bedouin(object sender, EventArgs e)
        {

        }

        private void drawing_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
