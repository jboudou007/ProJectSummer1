using ProjectLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class ATaxRate
    {
        [TestMethod]

        public void ATaxRateCanBeUpdated()
        {
            var sut = new TaxRate();

            sut.UpdateRate(.05);

            Assert.AreEqual(.05, sut.Rate);
        }
    }
}
