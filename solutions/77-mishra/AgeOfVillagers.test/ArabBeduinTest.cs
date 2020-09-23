using System;
using System.Diagnostics.Contracts;
using Xunit;
using System.Drawing;

namespace AgeOfVillagers.test
{
	public class ArabBeduinTest
	{
		private static string stringtype = "Arab Beduin";
		Nations nations = new Nations(stringtype);
		Point point = new Point(90, 40);

		
		public ArabBeduinTest()
		{
			public void ArabTreetesting()
            {
				Point tests = nation.getNation(point).DrawHouse(p);
				Assert.Equal(point, tests);
            }
		}
	}

}

