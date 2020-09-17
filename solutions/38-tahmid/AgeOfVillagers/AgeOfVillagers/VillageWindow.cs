using AgeOfVillagers.Environment_extending_Classes;
using AgeOfVillagers.FactoryClasses;
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
        String selectedItem, selectedNation;
        ShapeFactory shapeFactory;
        ItemFactory itemFactory;
        public VillageWindow()
        {
            InitializeComponent();

            g = drawing_panel.CreateGraphics();
            pen = new Pen(Color.Black);
            shapeFactory = new ShapeFactory();
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
            selectedNation = Constants.BD_NATION;
            Point point = new Point(e.X, e.Y);
            IItem item = itemFactory.GetItem(point, selectedItem);
            Shapes nationShapedItem = shapeFactory.GetShape(g, pen, point,selectedNation+selectedItem);
            item.placeItem(nationShapedItem);
            

            
            
        }

       

       

        

        

        private void Mouse_Click_Bangladeshi_Farmer(object sender, MouseEventArgs e)
        {
            
        }

        private void Mouse_Click_Inuit_Hunters(object sender, MouseEventArgs e)
        {

        }

        private void Mouse_Click_Egyptian_Kings(object sender, MouseEventArgs e)
        {

        }

        private void Mouse_ClickTree(object sender, MouseEventArgs e)
        {

        }

        private void Mouse_ClickHouse(object sender, MouseEventArgs e)
        {

        }

        private void Mouse_ClickWaterSource(object sender, MouseEventArgs e)
        {

        }

        private void Mouse_Click_Arab_Bedouin(object sender, MouseEventArgs e)
        {

        }

        private void drawing_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
