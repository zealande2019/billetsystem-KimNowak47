using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;

namespace BilletLibraryTest
{
    [TestClass]
    public class BilTest
    {
        [TestMethod]
        public void BilPrisTest()
        {
            Bil bil = new Bil();

            decimal result = bil.Pris();

            Assert.AreEqual(240, result);

            
        }

        [TestMethod]
        public void BilK�ret�jTest()
        {
            Bil bil = new Bil();

            string result = bil.K�ret�j();

            Assert.AreEqual("Bil", result);


        }

    }
}
