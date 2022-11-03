namespace TestProject
{
    using ExaminationRoomsSelector.Web.Application.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class FakeDoctorRepository
    {

        
        public static IEnumerable<DoctorDto> InappoperiateData { get; } =  new List<DoctorDto>()
        {
            new DoctorDto{ Salary=-1000, MainSpecialization="", YearsOfWork=-233,Age=-225,Name="",Surname="",Specialization= new List<int>{} },
            new DoctorDto{ Salary=0, MainSpecialization="-1", YearsOfWork=23,Age=25,Name="1",Surname="1",Specialization=new List<int>{1,23,4 } }
        };

        public static IEnumerable<DoctorDto> ThreeListMatch { get; } = new List<DoctorDto>()
        {
            new DoctorDto{ Salary=10000, MainSpecialization="Onkolog", YearsOfWork=33,Age=25,Name="Waldemar",Surname="Pawlak",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=20000, MainSpecialization="Dermatolog", YearsOfWork=23,Age=25,Name="Aleksander",Surname="Szekal",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=5000, MainSpecialization="Pediatra", YearsOfWork=23,Age=25,Name="Aleksandra",Surname="Alala",Specialization=new List<int>{1,2,3}}
        };

        public static IEnumerable<DoctorDto> ThreeListEverything { get; } = new List<DoctorDto>()
        {
            new DoctorDto{ Salary=10000, MainSpecialization="Onkolog", YearsOfWork=33,Age=25,Name="Waldemar",Surname="Pawlak",Specialization= new List<int>{4,5,6} },
            new DoctorDto{ Salary=20000, MainSpecialization="Dermatolog", YearsOfWork=23,Age=25,Name="Aleksander",Surname="Szekal",Specialization=new List<int>{4}},
            new DoctorDto{ Salary=5000, MainSpecialization="Pediatra", YearsOfWork=23,Age=25,Name="Aleksandra",Surname="Alala",Specialization=new List<int>{6}}
        };

        public static IEnumerable<DoctorDto> BigDataList { get; } = new List<DoctorDto>()
        {
            new DoctorDto{ Salary=10000, MainSpecialization="Onkolog", YearsOfWork=33,Age=25,Name="Waldemar",Surname="Pawlak",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=20000, MainSpecialization="Dermatolog", YearsOfWork=23,Age=25,Name="Aleksander",Surname="Szekal",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=5000, MainSpecialization="Pediatra", YearsOfWork=23,Age=25,Name="Aleksandra",Surname="Alala",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=12000, MainSpecialization="Chirurg", YearsOfWork=53,Age=25,Name="Agnieszka",Surname="Popek",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=10000, MainSpecialization="Onkolog", YearsOfWork=33,Age=25,Name="Waldemar",Surname="Pawlak",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=20000, MainSpecialization="Dermatolog", YearsOfWork=23,Age=25,Name="Aleksander",Surname="Szekal",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=5000, MainSpecialization="Pediatra", YearsOfWork=23,Age=25,Name="Aleksandra",Surname="Alala",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=12000, MainSpecialization="Chirurg", YearsOfWork=53,Age=25,Name="Agnieszka",Surname="Popek",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=10000, MainSpecialization="Onkolog", YearsOfWork=33,Age=25,Name="Waldemar",Surname="Pawlak",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=20000, MainSpecialization="Dermatolog", YearsOfWork=23,Age=25,Name="Aleksander",Surname="Szekal",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=5000, MainSpecialization="Pediatra", YearsOfWork=23,Age=25,Name="Aleksandra",Surname="Alala",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=12000, MainSpecialization="Chirurg", YearsOfWork=53,Age=25,Name="Agnieszka",Surname="Popek",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=10000, MainSpecialization="Onkolog", YearsOfWork=33,Age=25,Name="Waldemar",Surname="Pawlak",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=20000, MainSpecialization="Dermatolog", YearsOfWork=23,Age=25,Name="Aleksander",Surname="Szekal",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=5000, MainSpecialization="Pediatra", YearsOfWork=23,Age=25,Name="Aleksandra",Surname="Alala",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=12000, MainSpecialization="Chirurg", YearsOfWork=53,Age=25,Name="Agnieszka",Surname="Popek",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=10000, MainSpecialization="Onkolog", YearsOfWork=33,Age=25,Name="Waldemar",Surname="Pawlak",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=20000, MainSpecialization="Dermatolog", YearsOfWork=23,Age=25,Name="Aleksander",Surname="Szekal",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=5000, MainSpecialization="Pediatra", YearsOfWork=23,Age=25,Name="Aleksandra",Surname="Alala",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=12000, MainSpecialization="Chirurg", YearsOfWork=53,Age=25,Name="Agnieszka",Surname="Popek",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=10000, MainSpecialization="Onkolog", YearsOfWork=33,Age=25,Name="Waldemar",Surname="Pawlak",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=20000, MainSpecialization="Dermatolog", YearsOfWork=23,Age=25,Name="Aleksander",Surname="Szekal",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=5000, MainSpecialization="Pediatra", YearsOfWork=23,Age=25,Name="Aleksandra",Surname="Alala",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=12000, MainSpecialization="Chirurg", YearsOfWork=53,Age=25,Name="Agnieszka",Surname="Popek",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=10000, MainSpecialization="Onkolog", YearsOfWork=33,Age=25,Name="Waldemar",Surname="Pawlak",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=20000, MainSpecialization="Dermatolog", YearsOfWork=23,Age=25,Name="Aleksander",Surname="Szekal",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=5000, MainSpecialization="Pediatra", YearsOfWork=23,Age=25,Name="Aleksandra",Surname="Alala",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=12000, MainSpecialization="Chirurg", YearsOfWork=53,Age=25,Name="Agnieszka",Surname="Popek",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=10000, MainSpecialization="Onkolog", YearsOfWork=33,Age=25,Name="Waldemar",Surname="Pawlak",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=20000, MainSpecialization="Dermatolog", YearsOfWork=23,Age=25,Name="Aleksander",Surname="Szekal",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=5000, MainSpecialization="Pediatra", YearsOfWork=23,Age=25,Name="Aleksandra",Surname="Alala",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=12000, MainSpecialization="Chirurg", YearsOfWork=53,Age=25,Name="Agnieszka",Surname="Popek",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=10000, MainSpecialization="Onkolog", YearsOfWork=33,Age=25,Name="Waldemar",Surname="Pawlak",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=20000, MainSpecialization="Dermatolog", YearsOfWork=23,Age=25,Name="Aleksander",Surname="Szekal",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=5000, MainSpecialization="Pediatra", YearsOfWork=23,Age=25,Name="Aleksandra",Surname="Alala",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=12000, MainSpecialization="Chirurg", YearsOfWork=53,Age=25,Name="Agnieszka",Surname="Popek",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=10000, MainSpecialization="Onkolog", YearsOfWork=33,Age=25,Name="Waldemar",Surname="Pawlak",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=20000, MainSpecialization="Dermatolog", YearsOfWork=23,Age=25,Name="Aleksander",Surname="Szekal",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=5000, MainSpecialization="Pediatra", YearsOfWork=23,Age=25,Name="Aleksandra",Surname="Alala",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=12000, MainSpecialization="Chirurg", YearsOfWork=53,Age=25,Name="Agnieszka",Surname="Popek",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=10000, MainSpecialization="Onkolog", YearsOfWork=33,Age=25,Name="Waldemar",Surname="Pawlak",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=20000, MainSpecialization="Dermatolog", YearsOfWork=23,Age=25,Name="Aleksander",Surname="Szekal",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=5000, MainSpecialization="Pediatra", YearsOfWork=23,Age=25,Name="Aleksandra",Surname="Alala",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=12000, MainSpecialization="Chirurg", YearsOfWork=53,Age=25,Name="Agnieszka",Surname="Popek",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=10000, MainSpecialization="Onkolog", YearsOfWork=33,Age=25,Name="Waldemar",Surname="Pawlak",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=20000, MainSpecialization="Dermatolog", YearsOfWork=23,Age=25,Name="Aleksander",Surname="Szekal",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=5000, MainSpecialization="Pediatra", YearsOfWork=23,Age=25,Name="Aleksandra",Surname="Alala",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=12000, MainSpecialization="Chirurg", YearsOfWork=53,Age=25,Name="Agnieszka",Surname="Popek",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=10000, MainSpecialization="Onkolog", YearsOfWork=33,Age=25,Name="Waldemar",Surname="Pawlak",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=20000, MainSpecialization="Dermatolog", YearsOfWork=23,Age=25,Name="Aleksander",Surname="Szekal",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=5000, MainSpecialization="Pediatra", YearsOfWork=23,Age=25,Name="Aleksandra",Surname="Alala",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=12000, MainSpecialization="Chirurg", YearsOfWork=53,Age=25,Name="Agnieszka",Surname="Popek",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=10000, MainSpecialization="Onkolog", YearsOfWork=33,Age=25,Name="Waldemar",Surname="Pawlak",Specialization= new List<int>{1,2,3} },
            new DoctorDto{ Salary=20000, MainSpecialization="Dermatolog", YearsOfWork=23,Age=25,Name="Aleksander",Surname="Szekal",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=5000, MainSpecialization="Pediatra", YearsOfWork=23,Age=25,Name="Aleksandra",Surname="Alala",Specialization=new List<int>{1,2,3}},
            new DoctorDto{ Salary=12000, MainSpecialization="Chirurg", YearsOfWork=53,Age=25,Name="Agnieszka",Surname="Popek",Specialization= new List<int>{1,2,3} },
        };  
    }
}

