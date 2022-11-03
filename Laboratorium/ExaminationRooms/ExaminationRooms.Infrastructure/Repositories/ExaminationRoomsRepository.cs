namespace ExaminationRooms.Infrastructure
{
    using Dapper;
    using ExaminationRooms.Domain;
    using ExaminationRooms.Domain.ExaminationRoomAggregate;
    using System;
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ExaminationRoomsRepository : IExaminationRoomsRepository
    {
        
        private static readonly ExaminationRoom[] examinationroomsglobal = new ExaminationRoom[] {
            new ExaminationRoom(1, "1", new Certification[] { new Certification(2, new DateTime(2008, 6, 15, 21, 15, 07), 2) }),
            new ExaminationRoom(3, "2", new Certification[] { new Certification(3, new DateTime(2010, 3, 11, 11, 15, 07), 2)}),
            new ExaminationRoom(4, "3", new Certification[] { new Certification(4, new DateTime(2015, 4, 12, 11, 13, 08), 2)})
        };
        public ExaminationRoomsRepository()
        {
        }

        public async Task AddExaminationRoomAsync(ExaminationRoom examinationRoom)
        {
            throw new NotImplementedException();
        }


        public async Task<IEnumerable<ExaminationRoom>> GetAllAsync()
        {


            return examinationroomsglobal;

            

        }

        public IEnumerable<ExaminationRoom> GetByCertificationType(int certificationType)
        {
            throw new NotImplementedException();
        }
    }
}
