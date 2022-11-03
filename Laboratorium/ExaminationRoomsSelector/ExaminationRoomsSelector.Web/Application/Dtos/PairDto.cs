namespace ExaminationRoomsSelector.Web.Application.Dtos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public struct PairDto
    {
        public String Doctor { get; set; }
        public String ExaminationRoom { get; set; }
        public PairDto(DoctorDto doctor, ExaminationRoomDto room) {
            this.Doctor = doctor.Name;
            this.ExaminationRoom = room.Number;
        
        }

    }
}
