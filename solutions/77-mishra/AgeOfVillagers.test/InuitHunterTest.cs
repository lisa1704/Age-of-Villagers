using System;
using System.Collections.Generic;
using System.Text;
using AgeOfVillagers;
using System.Drawing;
using Xunit;

namespace AgeOfVillagers.test
{
	public class InuitHunterTest
	{
		private static string stringtype = "Inuit Hunter";
		Nations nations = new Nations(stringtype);

		Point point = new Point(90, 80);
		public void InuitHunterHousetest()
		{
			Point test = nations.getNation(point).DrawHouse(p);
			Assert.Equal(point, test);

		}

	}
}
