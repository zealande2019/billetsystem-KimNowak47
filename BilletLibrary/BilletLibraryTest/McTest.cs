using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;

namespace BilletLibraryTest
{
    [TestClass]
    public class MCTest
    {
        [TestMethod]
        public void MCPrisTest()
        {
            MC mc = new MC();

            decimal result = mc.Pris();

            Assert.AreEqual(125, result);


        }

        [TestMethod]
        public void MCKøretøjTest()
        {
            MC mc = new MC();

            string result = mc.Køretøj();

            Assert.AreEqual("MC", result);


        }
    }
}
