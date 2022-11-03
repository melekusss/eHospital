namespace ExaminationRoomsSelector.Web.Application.Dtos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class DoctorDto
    {
        public int Salary { get; set; }
        public string MainSpecialization { get; set; }
        public int YearsOfWork { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
        public List<int> Specialization { get; set; }

    }
}
