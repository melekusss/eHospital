namespace Doctor.Web.Application.Dtos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class VisitDto
    {
        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public string VisitDate { get; set; }
        public string RoomNumber { get; set; }
    }
}
