using AgeOfVillagers.FactoryClasses;
using AgeOfVillagers.Interface;
using AgeOfVillagers.JSON_Handling_Classes_Folder;
using AgeOfVillagers.Model_Class_Folder;
using AgeOfVillagers.Shape_extended_classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class AOV : IGames
    {
        List<IItem> itemList;
        IElementOpener village_itemOpener, village_name_opener;
        public void createVillage(Panel drawing_panel, System.Windows.Forms.Label village_name,string sVillageName)
        {
            village_name.Text = sVillageName;
            drawing_panel.Invalidate();
        }

        public List<IItem> openVillage(string selectedNation, Label labelVillageName, State previouslySavedState, Graphics graphics, Pen pen)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "age of villagers file|*.aov";
            openFileDialog.Title = "open village";
            openFileDialog.ShowDialog();
            //exception needed
            var dataString = System.IO.File.ReadAllText(openFileDialog.FileName);
            var settings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All
            };

            string json = dataString;

            previouslySavedState = JsonConvert.DeserializeObject<State>(json, settings);
            itemList = previouslySavedState.ItemList;
            ElementOpenerFactory elementOpenerFactory = new ElementOpenerFactory();
            village_name_opener = elementOpenerFactory.GetElementOpener(Constants.VILLAGE_NAME_OPENER, labelVillageName, previouslySavedState.VillageName);
            village_name_opener.displayElements();
            village_itemOpener = elementOpenerFactory.GetElementOpener(Constants.VILLAGE_ITEM_OPENER, selectedNation, itemList);
            return itemList;
           
        }

        public void saveVillage(List<DrawnItemsInformation> drawnItemsInfoList, string villageName)
        {
            

            State currentState = new State()
            {
                VillageName = villageName,
                DrawnItemsInformationList=drawnItemsInfoList

            };

            

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "save village|*.aov";
            saveFileDialog1.Title = "Save village";
            saveFileDialog1.ShowDialog();
            JsonConversion objectToJson = new JsonConversion();
            objectToJson.serialize(currentState, saveFileDialog1.FileName);

           
        }
    }
}
