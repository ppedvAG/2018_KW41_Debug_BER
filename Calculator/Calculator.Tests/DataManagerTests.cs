using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass]
    public class DataManagerTests
    {
        [TestMethod]
        public void DataManager_CountKäse()
        {
            var mock = new Mock<IDataManager>();
            mock.Setup(x => x.GetAllKäse()).Returns(() => 
            {
                var k1 = new Käse() { Name = "K1" };
                var k2 = new Käse() { Name = "K1" };
                var k3 = new Käse() { Name = "K1" };
                var k4 = new Käse() { Name = "K1" };
                return new[] { k1, k2, k3, k4 };
            });
            Core core = new Core() { Datamanager = mock.Object };

            var result = core.ZähleKäse();

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void MyTestMethod()
        {
            Assert.Inconclusive();
        }
    }
}
