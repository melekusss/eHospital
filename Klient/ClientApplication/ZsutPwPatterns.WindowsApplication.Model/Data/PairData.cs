using System;
using System.Collections.Generic;
using System.Text;

namespace ZsutPwPatterns.WindowsApplication.Model.Data
{
    public class PairData
    {
        public DoctorData Doctor { get; set; }
        public ExaminationRoomData ExaminationRoom { get; set; }
        public PairData(DoctorData doctor, ExaminationRoomData room)
        {
            this.Doctor = doctor;
            this.ExaminationRoom = room;

        }
    }
}
