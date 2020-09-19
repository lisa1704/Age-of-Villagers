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
using Age_Of_Villagers.FileManager;
using Newtonsoft.Json;
namespace Age_Of_Villagers
{
public partial class AgeOfVillagers : Form
{
    Graphics g;
    Nation drawingSpaceNation;
    Village village;
    File_Manager fileManager;


    public AgeOfVillagers()
    {
        // Initialize graphics, pen and village

        InitializeComponent();
        g = drawingSpace.CreateGraphics();

        village = new Village();
        fileManager = new File_Manager();



    }

    private void Form1_Load(object sender, EventArgs e)
    {



    }


    // village looks different for different nations by selecting index

    private void selectNation_SelectedIndexChanged(object sender, EventArgs e)
    {
        // create nation based on selection
        NationFactory nationFactory = new NationFactory();
        drawingSpaceNation = nationFactory.Build(selectNation.Text);

        // clear the drawing space

        drawingSpaceNation.SetBackground(g);

        // open the village with selected nation

        village.OpenVillage(village, drawingSpaceNation,g);







    }

    // clear drawing space for creating new village
    private void buttonNewVillage_Click(object sender, EventArgs e)
    {
        drawingSpaceNation = null;
        selectNation.Text = "Select Nation";
        treeButton.Checked = false;
        houseButton.Checked = false;
        waterSourceButton.Checked = false;
        villageNameEditor.Text = "Village name";


        village = new Village();
        g.Clear(drawingSpace.BackColor);
    }


    // save the village object
    public void buttonSaveVillage_Click(object sender, EventArgs e)
    {
        //Get the village name from villageNameEditor
        village.VillageName = villageNameEditor.Text;

        // connert the village object in Json
        fileManager.SaveVillage(village);




    }
    //// open the village.json from the machine
    private void buttonOpenVillage_Click(object sender, EventArgs e)
    {
        village = fileManager.LoadVillage();


        // Open the uploaded village in the DrawingSpace
        villageNameEditor.Text = village.villageName;

        village.OpenVillage(village, drawingSpaceNation,g);





    }




    // Open a villege from village object and selected nation
   

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
            else if (treeButton.Checked && drawingSpaceNation.hasTree)
            {


                drawingSpaceNation.DrawTree(g, location);
                village.treePosition.Add(location);
            }
            //draw water source

            else if (waterSourceButton.Checked && drawingSpaceNation.hasWaterSource)
            {
                drawingSpaceNation.DrawWaterSource(g, location);
                village.waterSoucePosition.Add(location);

            }
        }
        catch (Exception)
        {
            string message = "Select Nation to Draw Items";
            MessageBox.Show(message);

        }


    }

        private void drawingSpace_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
