namespace Doctor.Tests
{
    using Doctor.Web.Application.Dtos;
    using Doctor.Web.Application.Queries;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;

    [TestClass]
    public class DoctorQueryHandlerTests
    {
        [TestMethod]
        public void FavouritePatients_Returns2Patients()
        {
            DoctorQueryHandler doctorQueryHandler = new DoctorQueryHandler();
            var visits = FakeVisitsRepository.TwoFavouritePatients;

            int count = doctorQueryHandler.FavouritePatients(visits).Count;

            Assert.AreEqual(2, count, "Patients count should be {0} and not {1}", 2, count);
        }

        [TestMethod]
        public void FavouritePatients_InappropriateDataOrEmptyData_ThrowsArgumentException()
        {
            DoctorQueryHandler doctorQueryHandler = new DoctorQueryHandler();
            var visits = FakeVisitsRepository.InappropriateOrEmptyDataOfPatients;

            Func<Dictionary<string,int>> action = () => doctorQueryHandler.FavouritePatients(visits);

            Assert.ThrowsException<ArgumentException>(action, "Inapproperiate input exception");

        }
    }
}
