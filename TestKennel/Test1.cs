using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoggyDaycare.Business;
using DoggyDaycare.Database;
using System.Data;
namespace TestKennel
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Test_FailedDailyRate()
        {
            OracleDBKennelRepo repository = new OracleDBKennelRepo();
            KennelBusinessRules dailyRate = new KennelBusinessRules(repository);
            bool validRate = dailyRate.IsDailyRateValid(-90);
            Assert.IsTrue(validRate);
        }

        [TestMethod]
        public void Test_SuccessfulDailyRate()
        {
            OracleDBKennelRepo repository = new OracleDBKennelRepo();
            KennelBusinessRules dailyRate = new KennelBusinessRules(repository);
            bool validRate = dailyRate.IsDailyRateValid(80);
            Assert.IsTrue(validRate);
        }

        [TestMethod]
        public void Test_ValidNumberOfNights()
        {
            OracleDBBookingRepo repository = new OracleDBBookingRepo();
            BookingBusinessRules rules = new BookingBusinessRules(repository);
            decimal totalRate = rules.CalculateTotalCost(5, 25.5m);
            Assert.AreEqual(127.5m, totalRate);

        }

        [TestMethod]
        public void Test_InvalidKennelSize()
        {
            OracleDBKennelRepo kennelSize = new OracleDBKennelRepo();
            KennelBusinessRules validKennelSize = new KennelBusinessRules(kennelSize);
            bool validateKennelSize = validKennelSize.isKennelSizeValid("Xtra-Small");
            Assert.IsTrue(validateKennelSize);
        }

        [TestMethod]
        public void Test_ValidKennelSize()
        {
            OracleDBKennelRepo kennelSize = new OracleDBKennelRepo();
            KennelBusinessRules validKennelSize = new KennelBusinessRules(kennelSize);
            bool validateKennelSize = validKennelSize.isKennelSizeValid("L");
            Assert.IsTrue(validateKennelSize);
        }

    }
    }

