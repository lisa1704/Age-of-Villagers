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
        }
    }
}
