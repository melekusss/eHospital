namespace WebApplication1.Application.DoctorDto
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Solution1.ClassLibrary1;


    public class DoctorDto
    {

        public int Salary { get; set; }
        public string MainSpecialization { get; set; }
        public int YearsOfWork { get; set; }

        public int Age { get; set; }
        public string Name { get; set;}

        public string Surname { get; set;}

        public IEnumerable<int> Specialization { get; set; }
       

    }
}
