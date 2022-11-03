namespace ExaminationRoomsSelector.Web.Application.Queries
{
    using ExaminationRoomsSelector.Web.Application.DataServiceClients;
    using ExaminationRoomsSelector.Web.Application.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public class ExaminationRoomsSelectorQueryHandler : IExaminationRoomsSelectorHandler
    {
        private readonly IExaminationRoomsServiceClient examinationRoomsServiceClient;
        private readonly IDoctorsServiceClient doctorsServiceClient;

        public ExaminationRoomsSelectorQueryHandler(IExaminationRoomsServiceClient examinationRoomsServiceClient, IDoctorsServiceClient doctorsServiceClient)
        {
            this.examinationRoomsServiceClient = examinationRoomsServiceClient;
            this.doctorsServiceClient = doctorsServiceClient;
        }

        public ExaminationRoomsSelectorQueryHandler()
        {
           
        }

        public async Task<List<PairDto>> GetExaminationRoomsSelectionAsync()
        {  
            var doctors = await doctorsServiceClient.GetAllDoctorsAsync();
            Task<IEnumerable<ExaminationRoomDto>> task = examinationRoomsServiceClient.GetAllExaminationRoomsAsync();
            var rooms2 = await task;
            var rooms = (List<ExaminationRoomDto>)rooms2;
            List<PairDto> solution = new List<PairDto>();


            foreach (DoctorDto d in doctors) {
                List<int> queue = new List<int>();
                foreach (ExaminationRoomDto r in rooms) {

                    var infoQuery =
                             (from spec in d.Specialization select spec).Intersect
                             (from cert in r.Certifications select cert);

                    

                    int fit = infoQuery.Count();

                    queue.Add(fit);


                   }

                if (queue.Max() == 0) continue;
                int place = queue.IndexOf(queue.Max());
                PairDto p = new PairDto(d, rooms.ElementAt<ExaminationRoomDto>(place));
                solution.Add(p);
                rooms.Remove(rooms.ElementAt<ExaminationRoomDto>(place));  

            }

            return  solution;
        }
        public List<PairDto> GetExaminationRoomsSelectionAsync(IEnumerable<DoctorDto> doctors,IEnumerable<ExaminationRoomDto> examinationRooms)
        {
            List<PairDto> solution = new List<PairDto>();
            
                var rooms = (List<ExaminationRoomDto>)examinationRooms;
                


                foreach (DoctorDto doctor in doctors)
                {
                    if (doctor.Specialization.Equals(new List<int> { }) || doctor.Name.Equals("") || doctor.Surname.Equals("") || doctor.MainSpecialization.Equals("") || doctor.Salary<0 || doctor.YearsOfWork<0 || doctor.Age<0 )
                    {
                        throw new ArgumentException();
                    }
                    List<int> queue = new List<int>();
                    foreach (ExaminationRoomDto examinationRoom in rooms)
                    {
                        if (examinationRoom.Certifications.Equals(new List<int> { }) || examinationRoom.Number.Equals("")) {
                            throw new ArgumentException();
                        }
                   
                        var infoQuery =
                                 (from spec in doctor.Specialization select spec).Intersect
                                 (from cert in examinationRoom.Certifications select cert);



                        int fit = infoQuery.Count();

                        queue.Add(fit);


                    }

                    if (queue.Max() == 0) continue;
                    int place = queue.IndexOf(queue.Max());
                    
                    PairDto p = new PairDto(doctor, rooms.ElementAt<ExaminationRoomDto>(place));
                    solution.Add(p);
                    rooms.Remove(rooms.ElementAt<ExaminationRoomDto>(place));

                }

           

            return solution;
        }


    }
}
