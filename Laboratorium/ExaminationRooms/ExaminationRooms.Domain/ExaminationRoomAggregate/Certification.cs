namespace ExaminationRooms.Domain.ExaminationRoomAggregate
{
    using ExaminationRooms.Domain.SeedWork;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Certification : Entity
    {
        public DateTime GrantedAt { get;  set; }
        public int Type {get;  set;}

        public Certification(int Id, DateTime grantedAt, int type) : base(Id)
        {
            GrantedAt = grantedAt;
            Type = type;
        }
    }
}
