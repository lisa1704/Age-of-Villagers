﻿using System;
using System.Collection.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Age_of_Villagers
{

	class Village
	{
		public string villageName = "untitled";
		public List<Axes> houses = new List<Axes>();
		public List<Axes> trees = new List<Axes>();
		public List<Axes> waterS = new List<Axes>();
	}

}