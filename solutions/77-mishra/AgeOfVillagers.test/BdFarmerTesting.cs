using System;
using System.Collections.Generic;
using System.Text;
using AgeOfVillagers;

namespace AgeOfVillagers.test
{

	public class BdFarmerTesting
	{

		private static string stringtype = "Bangladeshi Farmers";
		Nations nations = new Nations(stringtype);
		Point point = new Point(90, 80);

		public BdFarmerTesting()
		{
			public void BdfarmersTreeTest()
            {
				Point test = nations.getNation(point).DrawTree(p);
				Assert.Equal(point, test);
            }

		}
	}
}

