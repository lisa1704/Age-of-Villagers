﻿using AgeOfVillagers.Environment_extending_Classes;
using AgeOfVillagers.FactoryClasses;
using AgeOfVillagers.Interface;
using AgeOfVillagers.Model_Class_Folder;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
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

        GameControlCommandFactory commandFactory;
        GameFactory gameFactory;

        EnvironmentFactory environmentFactory;
        Environment environment;

        IGames game;

        List<IItem> itemList;

        StateModel previouslySavedState;

       
        public VillageWindow()
        {
            InitializeComponent();

            g = drawing_panel.CreateGraphics();
            pen = new Pen(Color.Black);

            shapeFactory = new ShapeFactory();
            itemFactory = new ItemFactory();
            environmentFactory = new EnvironmentFactory();
            commandFactory = new GameControlCommandFactory();
            gameFactory = new GameFactory();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

       

        private void Save_Village(object sender, EventArgs e)
        {
            game = gameFactory.getGame();
            GameControlCommand onCommand = commandFactory.GetGameControlCommand(Constants.SAVE_KEY, game, tbVillageName.Text, itemList);
            GameKeyInvoker gameKeyInvoker = new GameKeyInvoker(onCommand);
            gameKeyInvoker.click();

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

            environment = environmentFactory.getEnvironment(Nation_Name, BD, Egyptians, Arabians, Hunters, Tree, House, WaterSource, g, Constants.DEFAULT_NATION, Constants.DEFAULT_COLOR);
            environment.setEnvironment();

            
            game = gameFactory.getGame();
            
            GameControlCommand onCommand = commandFactory.GetGameControlCommand(Constants.NEW_KEY, game, drawing_panel, village_name,sVillageName);
            GameKeyInvoker gameKeyInvoker = new GameKeyInvoker(onCommand);
            gameKeyInvoker.click();
            itemList = new List<IItem>();
            






    }
        


        private void Open_village(object sender, EventArgs e)
        {
            environment = environmentFactory.getEnvironment(Nation_Name, BD, Egyptians, Arabians, Hunters, Tree, House, WaterSource, g,Constants.DEFAULT_NATION, Constants.DEFAULT_COLOR);
            environment.setEnvironment();

            previouslySavedState = new StateModel();

            game = gameFactory.getGame();
            
            GameControlCommand onCommand = commandFactory.GetGameControlCommand(Constants.OPEN_KEY, game,  village_name, selectedNation,previouslySavedState);
            GameKeyInvoker gameKeyInvoker = new GameKeyInvoker(onCommand);

            gameKeyInvoker.click();
            //itemlist




        }

        private void VillageWindow_Load(object sender, EventArgs e)
        {

        }

        private void drawing_panel_MouseClick(object sender, MouseEventArgs e)
        {
            selectedNation = Constants.BD_NATION;
            Point point = new Point(e.X, e.Y);
            IItem item = itemFactory.GetItem(point, selectedItem,g,pen);
            item.placeItem(selectedNation); ;
            itemList.Add(item);
            
            

            
            
        }

       

       

        

        

        private void Mouse_Click_Bangladeshi_Farmer(object sender, MouseEventArgs e)
        {
            selectedNation = Constants.BD_NATION;
            environment = environmentFactory.getEnvironment(Nation_Name, BD, Egyptians, Arabians, Hunters, Tree, House, WaterSource, g, selectedNation,Constants.BANGLADESHI_COLOR);
            environment.setEnvironment();

        }

        private void Mouse_Click_Inuit_Hunters(object sender, MouseEventArgs e)
        {
            selectedNation = Constants.INUIT_NATION;
            environment = environmentFactory.getEnvironment(Nation_Name, Hunters, BD, Egyptians, Arabians, Tree, House, WaterSource, g, selectedNation, Constants.INUIT_COLOR);
            environment.setEnvironment();

        }

        private void Mouse_Click_Egyptian_Kings(object sender, MouseEventArgs e)
        {
            selectedNation = Constants.EGYPT_NATION;
            environment = environmentFactory.getEnvironment(Nation_Name, Egyptians, Hunters, BD, Arabians, Tree, House, WaterSource, g, selectedNation, Constants.EGYPTIAN_COLOR);
            environment.setEnvironment();
        }

        private void Mouse_ClickTree(object sender, MouseEventArgs e)
        {
            selectedItem = Constants.TREE_ITEM;
        }

        private void Mouse_ClickHouse(object sender, MouseEventArgs e)
        {
            selectedItem = Constants.HOUSE_ITEM;
        }

        private void Mouse_ClickWaterSource(object sender, MouseEventArgs e)
        {
            selectedItem = Constants.WATER_SOURCE_ITEM;
        }

        private void Mouse_Click_Arab_Bedouin(object sender, MouseEventArgs e)
        {
            selectedNation = Constants.ARAB_NATION;
            environment = environmentFactory.getEnvironment(Nation_Name, Arabians, Egyptians, Hunters, BD, Tree, House, WaterSource, g, selectedNation, Constants.ARABIAN_COLOR);
            environment.setEnvironment();
        }

        private void drawing_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
