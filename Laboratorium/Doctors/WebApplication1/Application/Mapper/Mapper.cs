namespace WebApplication1.Application.Mapper
{
    using Solution1.ClassLibrary1;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using WebApplication1.Application.DoctorDto;

    public static class Mapper
    {
        public static DoctorDto Map(this Doctor Doctor)
        {
            if (Doctor == null)
                return null;

            return new DoctorDto
            {
                Salary = Doctor.Salary,
                MainSpecialization = Doctor.MainSpecialization,
                YearsOfWork = Doctor.YearsOfWork,
                Specialization = Doctor?.Specialization.Select(s => s.Type),
                Age = Doctor.Age,
                Name = Doctor.Name,
                Surname = Doctor.Surname
            };
        }
    }
}
