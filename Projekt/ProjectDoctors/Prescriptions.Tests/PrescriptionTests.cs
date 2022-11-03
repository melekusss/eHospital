namespace Prescriptions.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Prescriptions.Domain.PrescriptionsAggregate;
    using System.Collections.Generic;

    [TestClass]
    public class PrescriptionTests
    {
         
            
        [TestMethod]
        public void AddDrug_ReturnsDrugsListWithSize3()
        {
            Prescription prescription = new Prescription(0, "22.4.2021", new Doctor(0), new List<Drug> { new Drug(1, "ibuprom"), new Drug(2, "izotek") }, "22.05.2022", new Patient(0));
            prescription.AddDrug(FakePrescriptionsRepository.OneDrug);

            int count = prescription.Drugs.Count;

            Assert.AreEqual(3, count, "Drugs count should be {0} and not {1}", 3, count);

        }

        [TestMethod]
        public void AddDrugs_ReturnsDrugsListWithSize5()
        {
            Prescription prescription = new Prescription(0, "22.4.2021", new Doctor(0), new List<Drug> { new Drug(1, "ibuprom"), new Drug(2, "izotek") }, "22.05.2022", new Patient(0));
            prescription.AddDrugs(FakePrescriptionsRepository.ThreeDrugs);

            int count = prescription.Drugs.Count;

            Assert.AreEqual(5, count, "Drugs count should be {0} and not {1}", 5, count);

        }
    }
}
