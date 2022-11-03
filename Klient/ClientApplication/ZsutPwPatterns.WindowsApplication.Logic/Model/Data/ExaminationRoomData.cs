using System;
using System.Collections.Generic;
using System.Text;

namespace ZsutPwPatterns.WindowsApplication.Model.Data
{
    public class ExaminationRoomData
    {
        public string Number { get; set; }
        public IEnumerable<int> Certifications { get; set; }
    }
}
