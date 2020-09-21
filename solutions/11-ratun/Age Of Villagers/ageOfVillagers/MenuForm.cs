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
        public string currentselect;
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
            MessageBox.Show(VillageName.Text);
        }

        public void Nation_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(Nation.Text);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            currentselect = "tree";
            text += "Adding a tree. ";
        }

        public void House_Click(object sender, EventArgs e)
        {
            currentselect = "house";
            text += "Adding a house. ";
        }

        public void Water_Click(object sender, EventArgs e)
        {
            currentselect = "house";
            text += "Adding new Water Source. ";
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Village v = new Village();
            v.Draw(currentselect, Cursor.Position.X, Cursor.Position.Y);
        }
    }
}