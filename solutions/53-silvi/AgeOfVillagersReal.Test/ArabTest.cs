
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using AgeOfVillagers;
using Xunit;

namespace AgeOfVillagersReal.Test
{
    public class ArabTest
    {
        ArabItemFactory arab = new ArabItemFactory();


        


     
        


        [Fact]

        public void ArabBedouinHouseTest()
        {
            
            Point pt5 = new Point(112, 111);

            try
            {
                ArabBedouinHouse arabHouse = new ArabBedouinHouse(pt5);
                Assert.True(true);
            }
            catch
            {
                Assert.False(false);
            }
        }



        [Fact]

        public void ArabBedouinTreeTest()
        {
            
            Point pt8 = new Point(101, 100);

            try
            {
                ArabBedouinTree arabTree = new ArabBedouinTree(pt8);
                Assert.True(true);
            }
            catch
            {
                Assert.False(false);
            }
        }


        
    }

}

