using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using MadLibsGame.Models;

namespace MadLibsGame.Tests
{
    [TestClass]
    public class MadLibsTest
    {
        [TestMethod]
        public void GetSetOccupation_GetsSetsOccupation_String()
        {
            MadLibs newGame = new MadLibs();
            newGame.SetOccupation("Farmer");
            Assert.AreEqual("Farmer", newGame.GetOccupation());
        }

        [TestMethod]
        public void GetSetNounOne_GetSetsNounOne_String()
        {
            MadLibs newGame = new MadLibs();
            newGame.SetNounOne("Gizmo");
            Assert.AreEqual("Gizmo", newGame.GetNounOne());
        }

        [TestMethod]
        public void GetSetAdjectiveOne_GetSetsAdjectiveOne_String()
        {
            MadLibs newGame = new MadLibs();
            newGame.SetAdjectiveOne("run");
            Assert.AreEqual("run", newGame.GetAdjectiveOne());
        }
    }
}
