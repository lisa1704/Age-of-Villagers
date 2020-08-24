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
        Nation drawingSpaceNation;
        Village village;
        
     
        public AgeOfVillagers()
        { 
            // Initialize graphics, pen and village
            
            InitializeComponent();
            g = drawingSpace.CreateGraphics();
           
            village = new Village();
            
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }


        //  village looks different for different nations by selecting index

        private void selectNation_SelectedIndexChanged(object sender, EventArgs e)
        {
            // create nation based on selection
            NationFactory nationFactory = new NationFactory();
            drawingSpaceNation = nationFactory.Build(selectNation.Text);

            // clear the drawing space
         
               drawingSpaceNation.SetBackground(g);

                // open the village with selected nation

                OpenVillage(village, drawingSpaceNation);
         






        }





      

    
        // clear drawing space for creating new village
        private void buttonNewVillage_Click(object sender, EventArgs e)
        {
            drawingSpaceNation = null;
            selectNation.Text="Select Nation";
            treeButton.Checked = false;
            houseButton.Checked = false;
            waterSourceButton.Checked = false;
            villageNameEditor.Text="Village name";
          

            village = new Village();
            g.Clear(drawingSpace.BackColor);
        }


        // save the village object 
        public void buttonSaveVillage_Click(object sender, EventArgs e)
        {
           //Get the village name from villageNameEditor
            village.VillageName = villageNameEditor.Text;
           
            // connert the village object in Json 
            var jsonVillage = JsonConvert.SerializeObject(village);

            // open savefileDialog to save the village in preferred location
     

           SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                InitialDirectory = @"E:\",
                Title = "Save a village (.json file)",

               
                CheckPathExists = true,

                DefaultExt = "aov",
                Filter = "aov files (*.aov)|*.aov",
                FilterIndex = 2,
                RestoreDirectory = true,
             
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            { 
                //write the village.json in the selected location

                var filePath = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(filePath, jsonVillage);




            }

           

        }
        //// open the village.json from the machine
        private void buttonOpenVillage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"E:\",
                Title = "Open a village (.json file)",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "aov",
                Filter = "aov files (*.aov)|*.aov",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog1.FileName;

                // Convert the village.json file to village object
                village = JsonConvert.DeserializeObject<Village>(File.ReadAllText(filePath));

                // Open the uploaded village in the DrawingSpace 
                villageNameEditor.Text = village.villageName;

                OpenVillage(village, drawingSpaceNation);





            }


        }

        // Open a villege from village object and selected nation
        private void OpenVillage(Village village,Nation nation )
        {
            try
            {
           
                drawingSpaceNation.SetBackground(g);



                // Draw village items from saved item position in the village object

           
                village.housePosition.ForEach(house => drawingSpaceNation.DrawHouse(g, house));
                village.treePosition.ForEach(tree => drawingSpaceNation.DrawTree(g, tree));
                village.waterSoucePosition.ForEach(waterSource => drawingSpaceNation.DrawWaterSource(g, waterSource));

               
            }
            catch (Exception e)
            {
                string message = "Select Nation to Open The Village";
                MessageBox.Show(message);


               


            }
           




        }

        // Build Nation from selected nation name
        

      
        // draw items by clicking in the drawing space
        private void drawingSpace_MouseClick(object sender, MouseEventArgs e)
        {
            
           // mouse click location

       

            Point location = new Point(e.Location.X, e.Location.Y);

            //draw house
            try
            {
                if (houseButton.Checked)
                {
                    drawingSpaceNation.DrawHouse(g, location);

                    // save the house postion in the village

                    village.housePosition.Add(location);

                }
                // draw tree 
                else if (treeButton.Checked)
                {


                    drawingSpaceNation.DrawTree(g,location);
                    village.treePosition.Add(location);
                }
                //draw water source

                else if (waterSourceButton.Checked)
                {
                    drawingSpaceNation.DrawWaterSource(g, location);
                    village.waterSoucePosition.Add(location);

                }
            }
            catch (Exception)
            {
                string message = "Select NAtion to Draw Items";
                MessageBox.Show(message);

            }
         

        }
    }
}
