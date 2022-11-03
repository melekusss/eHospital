namespace ZsutPwPatterns.Application.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ZsutPw.Patterns.Application.Controller;
    using ZsutPwPatterns.Application.Model.Data;

    public class FakeTemporaryPrescriptionForm
    {
        public static TemporaryPrescriptionData threeDrugsPrescription = new TemporaryPrescriptionData()
        {
            dateOfIssue = "22.04.2020",
            doctorName = "Andrzej",
            doctorSurname = "Masny",
            drugs = "Paracetamol,Ibuprom,Morfina",
            expirationDate = "22.05.2020",
            patientName = "Albert",
            patientSurname = "Zdrowy"
        };

    }
}
