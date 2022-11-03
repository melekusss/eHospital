namespace ZsutPwPatterns.WindowsApplication.Tests2
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ZsutPw.Patterns.WindowsApplication.Controller;
    using ZsutPw.Patterns.WindowsApplication.Model;
    using ZsutPwPatterns.WindowsApplication.Logic.Model.Data;

    [TestClass]
    public class Model_OperationsTests
    {
        [TestMethod]
        public void AssignPrescriptionTask_ReturnsListWithSize3() 
        {
            Model model = new Model(null);

            IEnumerable<string> result = model.AssignPrescriptionTask(FakeTemporaryPrescriptionForm.threeDrugsPrescription).drugs;

            int count = 0;
            foreach (string drug in result)
            {
                count++;
            }

            Assert.AreEqual(3, count, "The child count of the document element should be {0} and not {1}", 3, count);
        }
    }
}
