using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordGame;
namespace WordGame.Tests
{
    [TestClass]
    public class MadLibsTest
    {
        [TestMethod]
        public void DoIPass_TestToSeeIfThisWorks_True()
        {
            MadLibs newObject = new MadLibs();
            Assert.AreEqual(true, newObject.DoIPass());
        }
    }
}
