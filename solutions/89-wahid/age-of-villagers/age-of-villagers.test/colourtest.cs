using age_of_villagers.nation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace age_of_villagers.test
{
    class colourtest
    {
        public void bdcolourtest()
        {
            Color s = Color.Green;
            bangladeshifarmers c= new bangladeshifarmers();
            Assert.AreEqual(s, c.getTerrainColor());
        }
    }
}
