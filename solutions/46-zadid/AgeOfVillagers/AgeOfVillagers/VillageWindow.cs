using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AgeOfVillagers.Nations;

namespace AgeOfVillagers
{
    
    public partial class VillageWindow : Form
    {
        readonly Graphics graphic;
        public string villname, villtype;

        public Nation nation;
        Village myVillage;
        VillageSerializer myVillageSerializer;

        public VillageWindow()
        {
            InitializeComponent();
            graphic = drawpanel.CreateGraphics();

            myVillage = new Village();
            myVillageSerializer = new VillageSerializer();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            NationType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Drawpanel_MouseClick(object sender, MouseEventArgs e)
        {
            Point location = new Point(e.Location.X, e.Location.Y);

            if(house.Checked)
            {
                nation.DrawHouse(graphic, location);
                myVillage.housePosition.Add(location);
            }
            else if(tree.Checked && nation.hasTree==true)
            {
                nation.DrawTree(graphic, location);
                myVillage.treePosition.Add(location);
            }
            else if(watersource.Checked && nation.hasWaterSource==true)
            {
                nation.DrawWaterResource(graphic, location);
                myVillage.waterSourcePosition.Add(location);
            }
        }

        private void NationtypeSelectedIndexChanged(object sender, EventArgs e)
        {
            villtype = NationType.SelectedItem.ToString();

            Debug.WriteLine(villname);
            Debug.WriteLine(villtype);

            NationCreator nationCreator = new NationCreator();

            nation = (Nation)nationCreator.GetNation(villtype);
            ReDraw(myVillage);
        }

        private void RefreshForm(object sender, EventArgs e)
        {
            foreach (var item in sidepanel.Controls)
                if(item.GetType().Equals(typeof(TextBox)))
                {
                    TextBox t = item as TextBox;
                    t.Text = string.Empty;
                }
            foreach(var item in sidepanel.Controls)
                if(item.GetType().Equals(typeof(RadioButton)))
                {
                    RadioButton rb = item as RadioButton;
                    rb.Checked = false;
                }
            NationType.ResetText();
            NationType.Text = "Village type";
            drawpanel.Invalidate();
            myVillage = new Village();
        }

        private void SaveForm(object sender, EventArgs e)
        {
            villname = villagename.Text;
            myVillage.setName(villname);
            myVillageSerializer.saveState(myVillage);
        }

        private void OpenForm(object sender, EventArgs e)
        {
            myVillage = myVillageSerializer.openState();

            villagename.Text = myVillage.villageName;

            ReDraw(myVillage);
        }

        private void ReDraw(Village vi)
        {
            nation.BackgoundColor(graphic);

            vi.housePosition.ForEach(house => nation.DrawHouse(graphic, house));
            vi.treePosition.ForEach(tree => nation.DrawTree(graphic, tree));
            vi.waterSourcePosition.ForEach(watersource => nation.DrawWaterResource(graphic, watersource));
        }
    }
}
