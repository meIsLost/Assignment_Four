using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppC.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOwnFC;

namespace WebAppC.Manager.Tests
{
    [TestClass()]
    public class FootballPlayersManagerTests
    {
        private FootballPlayersManager manager = new FootballPlayersManager();



        [TestMethod()]
        public void GetAllTest()
        {
            List<FootballPlayer> testList = manager.GetAll();

            Assert.AreEqual(5, testList.Count);
        }

        [TestMethod()]
        public void DeleteTest()
        {
             manager.Delete(2);

            Assert.IsNull(manager.GetById(2));
        }




        [TestMethod()]
            public void AddTest()
            {
                FootballPlayer player1 = new FootballPlayer(4, "Kiwi", 21, 23);

                FootballPlayer addedfootballPlayer = manager.Add(player1);

                Assert.AreEqual(6, addedfootballPlayer.Id);
                Assert.AreEqual(6, manager.GetAll().Count);
            }

        
    }
}