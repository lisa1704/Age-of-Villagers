﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ageOfVillagers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test()
        {
            MenuForm menuform = new MenuForm();
            Assert.AreEqual("white",menuform.testShape("Inuit Hunters","tree",0,0));
        }
    }
}