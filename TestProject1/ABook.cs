using ProjectLib;

namespace TestProject1
{
    [TestClass]
    public class ABook
    {
        [TestMethod]
        public void ABookHasATotalTax() 
        {
            var someRate = new TaxRate { Rate = .1 };
            var sut = new Book { Title = "The Wolf", Cost = 100};

            sut.Tax(someRate);
           
            Assert.AreEqual(10, sut.Tax(someRate));

            


        }

        [TestMethod]

        public void ABookHasTotalCostWithTax()
        {
            var someRate = new TaxRate { Rate = .1 };
            var sut = new Book { Title = "The Wolf", Cost = 100 };

            sut.CostWithTax(someRate);

            Assert.AreEqual(110, sut.CostWithTax(someRate));    


        }

        [TestMethod]

        public void ABookCanBeRemoved()
        {
            var sut = new Book { Title = "Titanic", Cost = 117 };
            sut.RemoveBook();

            Assert.AreEqual("", sut.Title);
        }
    }
}