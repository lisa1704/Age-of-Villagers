﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ageOfVillagers
{
    public partial class MenuForm : Form
    {
        private string text="";
        private string currentselect;
        private string currentNationName;
        List<string> VillageNameList = new List<string>();
        public MenuForm()
        {
            InitializeComponent();
        }

        public void label1_Click(object sender, EventArgs e)
        {
            
        }

        public void VillageName_TextChanged(object sender, EventArgs e)
        {
            string Vname = VillageName.Text;
            //MessageBox.Show(VillageName.Text);
        }

        public void Nation_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(Nation.Text);
            currentNationName = Nation.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            currentselect = "tree";
            text += "Adding a tree. ";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            currentselect = "water";
            text += "Adding water. ";
        }

        private void houseButton_CheckedChanged(object sender, EventArgs e)
        {
            currentselect = "house";
            text += "Adding a house. ";
        }

        public void NewVillage_Click(object sender, EventArgs e)
        {
            Village v = new Village();
            v.CreateVillage(Nation.Text, VillageName.Text);
            VillageNameList.Add(VillageName.Text);
            text += "Creating the village. ";
        }

        public void OpenVillage_Click(object sender, EventArgs e)
        {
            foreach (string i in VillageNameList)
            {
                if (VillageName.Text == i)
                {
                    Village v = new Village();
                    v.Open(VillageName.Text);
                }

            }
            text += "Opening the village. ";
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Village v = new Village();
            v.Save();
            text += "Saving the village. ";
        }

        public void MenuForm_Load(object sender, EventArgs e)
        {
            //Village.Load();
            text += "Loading the village. ";

        }

        public String GetVillageName()
        {
            return VillageName.Text;
        }
        public String GetDrawingState()
        {
            return text;
        }

        //public string testShape(string currentNationName, string currentselect, int x, int y) { 
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel2.CreateGraphics();
            Shape nation = NationFactory.GetNation(currentNationName);
            IShape shape = nation.GetItem(currentselect);
            shape.draw(Cursor.Position.X, Cursor.Position.Y, g);
            //return shape.draw(x, y);
        }

        
    }
}