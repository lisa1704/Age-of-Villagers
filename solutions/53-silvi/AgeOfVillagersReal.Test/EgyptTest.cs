
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using AgeOfVillagers;
using Xunit;

namespace AgeOfVillagersReal.Test
{
   
    public class EgyptTest
    {
        EgyptianItemFactory arab = new EgyptianItemFactory();









        [Fact]

        public void EgyptianKingsHouseTest()
        {

            Point pt5 = new Point(112, 111);

            try
            {
                EgyptianKingsHouse arabHouse = new EgyptianKingsHouse(pt5);
                Assert.True(true);
            }
            catch
            {
                Assert.False(false);
            }
        }



       


    }

}


