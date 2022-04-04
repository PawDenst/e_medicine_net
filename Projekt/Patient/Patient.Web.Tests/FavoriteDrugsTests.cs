using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient.Web.Application.Queries;

namespace Patient.Web.Tests
{
    [TestClass]
    public class FavoriteDrugsTests

    {
        private FakeServiceClient testData = new FakeServiceClient();
        [TestMethod]
        public void FavoriteDrugs_DataWith2Drugs_returns2Drugs()
        {
            PatientQueryHandler handler = new PatientQueryHandler();

            var druglist=handler.FavoriteDrugs(testData.SimplePrescriptionListWithTwoFavoriteDrugs);
            int count = druglist.Count;
            Assert.AreEqual(2, count, "Favorite drugs should be {0} and not {1}", 2, count);
        }

        [TestMethod]
        public void FavoriteDrugs_DataWith1Drug_returns1Drug()
        {
            PatientQueryHandler handler = new PatientQueryHandler();

            var druglist = handler.FavoriteDrugs(testData.SimplePrescriptionListWithOneFavoriteDrug);
            int count = druglist.Count;
            Assert.AreEqual(1, count, "Favorite drugs should be {0} and not {1}", 1, count);
        }
    }
}
