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
            double len = 160;
            double x = 16;
            Pen p = new Pen(Color.Black);
            Pen pe= new Pen(Color.Red);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            Point p1 = new Point(100,100);
            Point p3 = new Point(180, 0);
            decimal angle = 60;

            double b = (240 * (Math.PI)) / 180;

            Point p2 = new Point(260,100);//(int)(160 /Math.Tan(b)), 100+160);
            //g.DrawEllipse(p, p1.X,p1.Y, 100, 100);

            g.DrawRectangle(p, 100, 100, 160, 160);
            g.DrawLine(pe, p1,p2);
            g.DrawLine(pe, p2, p3);
            g.DrawLine(pe, p3, p1);
            g.DrawRectangle(pe, 260, 260, 20, 20);
            //pr.openVillage(village_name);
            
            //pr.setPanel(drawing_panel);

        }

        private void VillageWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
