using System;
using System.Collections.Generic;
using System.Text;

namespace ZsutPwPatterns.Application.Model.Data
{
    public class TemporaryPrescriptionData
    {
        public string dateOfIssue { get; set; }
        public string doctorName { get; set; }
        public string doctorSurname { get; set; }
        public string drugs { get; set; }
        public string expirationDate { get; set; }
        public string patientName { get; set; }
        public string patientSurname { get; set; }
    }
}
