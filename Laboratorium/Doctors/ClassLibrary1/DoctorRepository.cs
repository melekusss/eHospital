namespace Solution1.ClassLibrary1

{
    using Dapper;
    using System;
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DoctorRepository : IDocotorRepository
    {
        private static readonly Doctor[] doctors = new Doctor[] {
            new Doctor(1,2000,"Onkolog",20,"Jan","Nowak",68, new List<Specialization> {new Specialization(1,2)}),
            new Doctor(2,5000,"dentysta",22,"Jan","kowalczyk",48, new List<Specialization> {new Specialization(1,3)}),
            new Doctor(3,3000,"kardiolog",24,"Jan","kowalski",88, new List<Specialization> {new Specialization(1,5)})
        };
        public DoctorRepository()
        {
        }

       

        public async Task AddDoctorAsync(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        
        public async Task<IEnumerable<Doctor>> GetAllAsync()
        {




            return doctors;
        }

        

        public IEnumerable<Doctor> GetBySpecializationType(int SpecializationType)
        {
            throw new NotImplementedException();
        }

        
    }
}
