using System;
using System.Collections.Generic;
using System.Text;

namespace ZsutPwPatterns.Application.Tests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ZsutPw.Patterns.Application.Controller;
    using ZsutPw.Patterns.Application.Model;
    using ZsutPwPatterns.Application.Model.Data;

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
