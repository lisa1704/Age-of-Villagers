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
using Newtonsoft.Json;
namespace Age_Of_Villagers
{
    public partial class AgeOfVillagers : Form
    {
        Graphics g;

        int x, y, h, w;

        Nation nation;
        Village openVillage;
        Village village;
        Pen p;
        public AgeOfVillagers()
        {
            InitializeComponent();
            g = drawingSpace.CreateGraphics();
            p = new Pen(Color.Black);
            village = new Village();
            openVillage = new Village();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void selectNation_SelectedIndexChanged(object sender, EventArgs e)
        {

            nation = NationFactory(selectNation.Text);
            drawingSpace.BackColor = nation.SetBackground();
            g.Clear(drawingSpace.BackColor);
            OpenVillage(village,nation);
         
               


    

}
        



        private void treeButton_CheckedChanged(object sender, EventArgs e)
        {




        }

        private void drawingSpace_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

        }

        private void drawingSpace_MouseUp(object sender, MouseEventArgs e)
        {
            h = e.X - x;
            w = e.Y - y;


        }

        private void buttonNewVillage_Click(object sender, EventArgs e)
        {

            g.Clear(drawingSpace.BackColor);
        }



        public void buttonSaveVillage_Click(object sender, EventArgs e)
        {
            village.VillageName = villageNameEditor.Text;
            village.NationName = selectNation.Text;


            var jsonVillage = JsonConvert.SerializeObject(village);

            System.IO.File.WriteAllText(@"E:\path.json", jsonVillage);

        }

        private void buttonOpenVillage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"E:\",
                Title = "Open a village (.json file)",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "json",
                Filter = "json files (*.json)|*.json",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog1.FileName;
                openVillage = JsonConvert.DeserializeObject<Village>(File.ReadAllText(filePath));
                OpenVillage(openVillage, NationFactory(openVillage.nationName));





            }


        }

        private void OpenVillage(Village village,Nation nation )
        {

            g.Clear(Color.White);

  

            foreach (Point p in village.housePosition)
            {
                nation.DrawHouse(g, p.x, p.y);
            }
            foreach (Point p in village.treePosition)
            {
                nation.DrawTree(g, p.x, p.y);
            }



        }

        private Nation NationFactory(string nationName)
        {
            Nation nation = null;

            if (nationName == "Arab Bedouin")
            {
                nation = new ArabBeduin();

            }
            else if (nationName == "Bangladeshi Farmers")
            {
                nation = new BangladeshiFarmers();

            }

            else if (nationName == "Egyptian Kings")
            {
                nation = new EgyptianKings();

            }
            else if (nationName == "Inuit Hunters")
            {
                nation = new BangladeshiFarmers();

            }

            else
            {

            }

            return nation;

        }

      

        private void drawHouse(int X,int Y)
        {
           
            g.DrawLine(p, X - 25, Y + 35, X + 25, Y - 25);
            g.DrawLine(p, X + 25, Y - 25, X + 50, Y + 50);
            g.DrawLine(p, X + 50, Y + 50, X - 25, Y + 35);
            g.DrawLine(p, X + 25, Y - 25, X + 75, Y + 25);
            g.DrawLine(p, X + 75, Y + 25, X + 50, Y + 50);
        }

        private void drawingSpace_Click(object sender, EventArgs e)
        {

        }

        private void drawingSpace_MouseClick(object sender, MouseEventArgs e)
        {
            
           
            int X = e.Location.X;
            int y = e.Location.Y;
            if(houseButton.Checked)
            {
                nation.DrawHouse(g, X, y);
                village.housePosition.Add(new Point(X, y));

            }
            else if (treeButton.Checked)
            {
             
                nation.DrawTree(g, X, y);
                village.treePosition.Add(new Point(X, y));
            }
         

        }
    }
}
