using System;
using System.Collections.Generic;
using System.Text;
using empty_project;
using Xunit;
using System.Windows.Forms;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace AgeofVillegersTest
{
    public class NationTreeTest
    {
        [Fact]
        public void TreeTest()
        {
            AbstractNation bangladeshiFarmersTree = new BangladeshiFarmers(new Panel());
            Assert.AreEqual(bangladeshiFarmersTree.getTreeType().GetType(), new BangladeshiFarmersTree().GetType());

            AbstractNation arabBedouinTree = new ArabBedouin(new Panel());
            Assert.AreEqual(arabBedouinTree.getTreeType().GetType(), new ArabBedouinTree().GetType());

            AbstractNation egyptianKingsTree = new EgyptianKings(new Panel());
            Assert.AreEqual(egyptianKingsTree.getTreeType().GetType(), new EgyptianKingsTree().GetType());
        }
    }
}
