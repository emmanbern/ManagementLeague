using LeagueAppManagement.Data;
using LeagueAppManagement.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace LeagueAppManagementTest.Services
{
    [TestClass]
    public class EnumerationServiceTest
    {

        private EnumerationService _service;
        [TestInitialize]
        public void TestInitialize()
        {
            _service = new EnumerationService();
        }

        [TestMethod]
        public void Test_GetAllEnumString()
        {
            var result = _service.GetStringsFromEnumeration<GradeEnum>();

            Assert.AreEqual("A", result.First());
            Assert.AreEqual("B", result.ElementAt(1));
            Assert.AreEqual("D", result.Last());
        }

        [TestMethod]
        public void Test_GetEnumerationValues()
        {
            var result = _service.GetEnumerationValues<GradeEnum>();

            Assert.AreEqual(4, result.Count);
            Assert.AreEqual("A", result.First().Key);
            Assert.AreEqual(1, result.First().Value);
        }
    }
}
