using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLibrary;
using NUnit.Framework;

namespace TugasLibraryUnitTest
{
    [TestFixture]
    public class TugasLibraryUnitTest
    {
        private Day day;
        private User user;

        [SetUp]
        public void Init()
        {
            day = new Day();
            user = new User();
        }

        [Test]
        public void DayTest()
        {
            Assert.AreEqual("Senin", day.NameOfDay(1)); 
        }

        [Test]
        public void UserTest()
        {
            Assert.IsTrue(user.IsValidUser("admin", "admin"));
            Assert.IsFalse(user.IsValidUser("admin", "adefddmin"));
        }
    }
}
