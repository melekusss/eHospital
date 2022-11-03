namespace TestProject
{
    using ExaminationRoomsSelector.Web.Application.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class FakeExaminationRoomRepository
    {
        
        public static IEnumerable<ExaminationRoomDto> InappoperiateData { get; } =  new List<ExaminationRoomDto>()
        {
            new ExaminationRoomDto{ Number="" ,Certifications= new List<int>{ } },
            new ExaminationRoomDto{ Number="2323" ,Certifications= new List<int>{ } }
    
        };

        public static IEnumerable<ExaminationRoomDto> ThreeListMatch { get; } = new List<ExaminationRoomDto>()
        {
            new ExaminationRoomDto{ Number="101" ,Certifications= new List<int>{1} },
            new ExaminationRoomDto{ Number="102" ,Certifications= new List<int>{2} },
            new ExaminationRoomDto{ Number="103" ,Certifications=new List<int>{3}}
            

        };

        public static IEnumerable<ExaminationRoomDto> ThreeListEverything { get; } = new List<ExaminationRoomDto>()
        {
            new ExaminationRoomDto{ Number="101" ,Certifications= new List<int>{4} },
            new ExaminationRoomDto{ Number="102" ,Certifications= new List<int>{5} },
            new ExaminationRoomDto{ Number="103" ,Certifications=new List<int>{6}}


        };
        public static IEnumerable<ExaminationRoomDto> BigData { get; } = new List<ExaminationRoomDto>()
        {
            new ExaminationRoomDto{ Number="101" ,Certifications= new List<int>{4} },
            new ExaminationRoomDto{ Number="102" ,Certifications= new List<int>{5} },
            new ExaminationRoomDto{ Number="103" ,Certifications=new List<int>{6}},
            new ExaminationRoomDto{ Number="101" ,Certifications= new List<int>{4} },
            new ExaminationRoomDto{ Number="102" ,Certifications= new List<int>{5} },
            new ExaminationRoomDto{ Number="103" ,Certifications=new List<int>{6}},
            new ExaminationRoomDto{ Number="101" ,Certifications= new List<int>{4} },
            new ExaminationRoomDto{ Number="102" ,Certifications= new List<int>{5} },
            new ExaminationRoomDto{ Number="103" ,Certifications=new List<int>{6}},
            new ExaminationRoomDto{ Number="101" ,Certifications= new List<int>{4} },
            new ExaminationRoomDto{ Number="102" ,Certifications= new List<int>{5} },
            new ExaminationRoomDto{ Number="103" ,Certifications=new List<int>{6}},
            new ExaminationRoomDto{ Number="101" ,Certifications= new List<int>{4} },
            new ExaminationRoomDto{ Number="102" ,Certifications= new List<int>{5} },
            new ExaminationRoomDto{ Number="103" ,Certifications=new List<int>{6}},
            new ExaminationRoomDto{ Number="101" ,Certifications= new List<int>{4} },
            new ExaminationRoomDto{ Number="102" ,Certifications= new List<int>{5} },
            new ExaminationRoomDto{ Number="103" ,Certifications=new List<int>{6}},
            new ExaminationRoomDto{ Number="101" ,Certifications= new List<int>{4} },
            new ExaminationRoomDto{ Number="102" ,Certifications= new List<int>{5} },
            new ExaminationRoomDto{ Number="103" ,Certifications=new List<int>{6}},
            new ExaminationRoomDto{ Number="101" ,Certifications= new List<int>{4} },
            new ExaminationRoomDto{ Number="102" ,Certifications= new List<int>{5} },
            new ExaminationRoomDto{ Number="103" ,Certifications=new List<int>{6}},
            new ExaminationRoomDto{ Number="101" ,Certifications= new List<int>{4} },
            new ExaminationRoomDto{ Number="102" ,Certifications= new List<int>{5} },
            new ExaminationRoomDto{ Number="103" ,Certifications=new List<int>{6}},
            new ExaminationRoomDto{ Number="101" ,Certifications= new List<int>{4} },
            new ExaminationRoomDto{ Number="102" ,Certifications= new List<int>{5} },
            new ExaminationRoomDto{ Number="103" ,Certifications=new List<int>{6}},
            new ExaminationRoomDto{ Number="101" ,Certifications= new List<int>{4} },
            new ExaminationRoomDto{ Number="102" ,Certifications= new List<int>{5} },
            new ExaminationRoomDto{ Number="103" ,Certifications=new List<int>{6}},
            new ExaminationRoomDto{ Number="101" ,Certifications= new List<int>{4} },
            new ExaminationRoomDto{ Number="102" ,Certifications= new List<int>{5} },
            new ExaminationRoomDto{ Number="103" ,Certifications=new List<int>{6}},
            new ExaminationRoomDto{ Number="101" ,Certifications= new List<int>{4} },
            new ExaminationRoomDto{ Number="102" ,Certifications= new List<int>{5} },
            new ExaminationRoomDto{ Number="103" ,Certifications=new List<int>{6}},
            new ExaminationRoomDto{ Number="101" ,Certifications= new List<int>{4} },
            new ExaminationRoomDto{ Number="102" ,Certifications= new List<int>{5} },
            new ExaminationRoomDto{ Number="103" ,Certifications=new List<int>{6}},
            new ExaminationRoomDto{ Number="101" ,Certifications= new List<int>{4} },
            new ExaminationRoomDto{ Number="102" ,Certifications= new List<int>{5} },
            new ExaminationRoomDto{ Number="103" ,Certifications=new List<int>{6}},
            new ExaminationRoomDto{ Number="101" ,Certifications= new List<int>{4} },
            new ExaminationRoomDto{ Number="102" ,Certifications= new List<int>{5} },
            new ExaminationRoomDto{ Number="103" ,Certifications=new List<int>{6}},
            new ExaminationRoomDto{ Number="101" ,Certifications= new List<int>{4} },
            new ExaminationRoomDto{ Number="102" ,Certifications= new List<int>{5} },
            new ExaminationRoomDto{ Number="103" ,Certifications=new List<int>{6}},
            new ExaminationRoomDto{ Number="101" ,Certifications= new List<int>{4} },
            new ExaminationRoomDto{ Number="102" ,Certifications= new List<int>{5} },
            new ExaminationRoomDto{ Number="103" ,Certifications=new List<int>{6}},
            new ExaminationRoomDto{ Number="101" ,Certifications= new List<int>{4} },
            new ExaminationRoomDto{ Number="102" ,Certifications= new List<int>{5} },
            new ExaminationRoomDto{ Number="103" ,Certifications=new List<int>{6}},
            new ExaminationRoomDto{ Number="101" ,Certifications= new List<int>{4} },
            new ExaminationRoomDto{ Number="102" ,Certifications= new List<int>{5} },
            new ExaminationRoomDto{ Number="103" ,Certifications=new List<int>{6}},
            new ExaminationRoomDto{ Number="101" ,Certifications= new List<int>{4} },
            new ExaminationRoomDto{ Number="102" ,Certifications= new List<int>{5} },
            new ExaminationRoomDto{ Number="103" ,Certifications=new List<int>{6}}


        };

    }

}
