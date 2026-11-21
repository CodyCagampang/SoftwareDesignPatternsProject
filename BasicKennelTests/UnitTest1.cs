using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DoggyDaycare.Business;
namespace BasicKennelTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SmallKennelAccepts5Kilograms()
        {
            SmallKennelWeight rule = new SmallKennelWeight();
            bool result = rule.validateDogWeight(5);
            Assert.IsTrue(result);
        }
        {
        }
    }
}
