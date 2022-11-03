namespace ZsutPwPatterns.WindowsApplication.Tests2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ZsutPwPatterns.WindowsApplication.Logic.Model.Data;

    public class FakeTemporaryPrescriptionForm
    {
       public static TemporaryPrescriptionData threeDrugsPrescription = new TemporaryPrescriptionData() 
       {
           dateOfIssue= "22.04.2020", 
           doctorName= "Andrzej", 
           doctorSurname= "Masny", 
           drugs = "Paracetamol,Ibuprom,Morfina", 
           expirationDate= "22.05.2020", 
           patientName="Albert", 
           patientSurname="Zdrowy" 
       };
        
    }
}
