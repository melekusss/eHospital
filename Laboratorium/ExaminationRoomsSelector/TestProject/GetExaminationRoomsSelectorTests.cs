namespace TestProject
{
using ExaminationRoomsSelector.Web.Application.Dtos;
    using ExaminationRoomsSelector.Web.Application.Queries;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    [TestClass]
    public class UnitTest1
    {
        IEnumerable<DoctorDto> doctor = new List<DoctorDto>();

        [TestMethod]
        public void GetExaminationRoomsSelection_InappropriateDataOrEmptyData_ThrowsArgumentException()
        {
            ExaminationRoomsSelectorQueryHandler examinationRoomsSelectorQueryHandler = new ExaminationRoomsSelectorQueryHandler();
            var doctors = FakeDoctorRepository.InappoperiateData;
            var examinationRooms = FakeExaminationRoomRepository.InappoperiateData;

            

            Func<List<PairDto>> action = () => examinationRoomsSelectorQueryHandler.GetExaminationRoomsSelectionAsync(doctors, examinationRooms);


            Assert.ThrowsException<ArgumentException>(action, "Inapproperiate input exception");

        }

        [TestMethod]
        public void GetExaminationRoomsSelection_Returns3Pairs()
        {
            ExaminationRoomsSelectorQueryHandler examinationRoomsSelectorQueryHandler = new ExaminationRoomsSelectorQueryHandler();
            var doctors = FakeDoctorRepository.ThreeListMatch;
            var examinationRooms = FakeExaminationRoomRepository.ThreeListMatch;



            int count = examinationRoomsSelectorQueryHandler.GetExaminationRoomsSelectionAsync(doctors, examinationRooms).Count;


            Assert.AreEqual(3, count, "Pairs count should be {0} and not {1}", 3, count);

        }

        [TestMethod]
        public void GetExaminationRoomsSelection_ReturnsEveryPair()
        {
            ExaminationRoomsSelectorQueryHandler examinationRoomsSelectorQueryHandler = new ExaminationRoomsSelectorQueryHandler();
            var doctors = FakeDoctorRepository.ThreeListEverything;
            var examinationRooms = FakeExaminationRoomRepository.ThreeListEverything;



            int count = examinationRoomsSelectorQueryHandler.GetExaminationRoomsSelectionAsync(doctors, examinationRooms).Count;


            Assert.AreEqual(2, count, "Pairs count should be {0} and not {1}", 2, count);

        }

        [TestMethod]
        public void GetExaminationRoomsSelection_BigData()
        {
            ExaminationRoomsSelectorQueryHandler examinationRoomsSelectorQueryHandler = new ExaminationRoomsSelectorQueryHandler();
            var doctors = FakeDoctorRepository.ThreeListEverything;
            var examinationRooms = FakeExaminationRoomRepository.BigData;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var examinationRoomsSelection= examinationRoomsSelectorQueryHandler.GetExaminationRoomsSelectionAsync(doctors, examinationRooms);

            stopwatch.Stop();
            Assert.IsTrue(stopwatch.ElapsedMilliseconds < 200, "Execution time should have been less than 200ms and its actually {0} ms", stopwatch.ElapsedMilliseconds);

        }
    }
}
