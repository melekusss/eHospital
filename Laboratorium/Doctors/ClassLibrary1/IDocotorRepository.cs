namespace Solution1.ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IDocotorRepository
    {
        


        IEnumerable<Doctor> GetBySpecializationType(int SpecializationType);
        Task AddDoctorAsync(Doctor examinationRoom);
        Task<IEnumerable<Doctor>> GetAllAsync();
    }

}
