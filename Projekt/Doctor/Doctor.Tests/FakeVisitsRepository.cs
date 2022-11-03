namespace Doctor.Tests
{
    using Doctor.Web.Application.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class FakeVisitsRepository
    {
        public static IEnumerable<VisitDto> TwoFavouritePatients { get; } = new List<VisitDto>()
        {
            new VisitDto {DoctorName="Waldemar", DoctorSurname="Kiepski", PatientName="Włodzimierz", PatientSurname="Antonowicz", VisitDate="22.04.2022", RoomNumber="7a"},
            new VisitDto {DoctorName="Waldemar", DoctorSurname="Kiepski", PatientName="Włodzimierz", PatientSurname="Antonowicz", VisitDate="22.05.2021", RoomNumber="7" },
            new VisitDto {DoctorName="Waldemar", DoctorSurname="Kiepski", PatientName="Włodzimierz", PatientSurname="Antonowicz", VisitDate="23.06.2020", RoomNumber="8b" },
            new VisitDto {DoctorName="Waldemar", DoctorSurname="Kiepski", PatientName="Andzrej", PatientSurname="Nieufan", VisitDate="29.03.2021", RoomNumber="7a" },
            new VisitDto {DoctorName="Waldemar", DoctorSurname="Kiepski", PatientName="Andzrej", PatientSurname="Nieufan", VisitDate="28.04.2019", RoomNumber="6"},
            new VisitDto {DoctorName="Waldemar", DoctorSurname="Kiepski", PatientName="Andzrej", PatientSurname="Nieufan", VisitDate="27.12.2002", RoomNumber="5z" },
            new VisitDto {DoctorName="Waldemar", DoctorSurname="Kiepski", PatientName="Klaudiusz", PatientSurname="Nabuchodonozor", VisitDate="21.07.2018", RoomNumber="43a" },
            new VisitDto {DoctorName="Waldemar", DoctorSurname="Kiepski", PatientName="Agnieszka", PatientSurname="Niemieszka", VisitDate="12.04.2005", RoomNumber="77b"}
        };

        public static IEnumerable<VisitDto> InappropriateOrEmptyDataOfPatients { get; } = new List<VisitDto>()
        {
            new VisitDto {DoctorName="", DoctorSurname="Kiepski", PatientName="Włodzimierz", PatientSurname="Antonowicz", VisitDate="22.04.2022", RoomNumber="7a"},
            new VisitDto {DoctorName="Waldemar", DoctorSurname="", PatientName="Włodzimierz", PatientSurname="Antonowicz", VisitDate="22.05.2021", RoomNumber="7" },
            new VisitDto {DoctorName="Waldemar", DoctorSurname="Kiepski", PatientName="", PatientSurname="Antonowicz", VisitDate="23.06.2020", RoomNumber="8b" },
            new VisitDto {DoctorName="Waldemar", DoctorSurname="Kiepski", PatientName="Andzrej", PatientSurname="", VisitDate="29.03.2021", RoomNumber="7a" },
            new VisitDto {DoctorName="Waldemar", DoctorSurname="Kiepski", PatientName="Andzrej", PatientSurname="Nieufan", VisitDate="", RoomNumber="6"},
            new VisitDto {DoctorName="Waldemar", DoctorSurname="Kiepski", PatientName="Andzrej", PatientSurname="Nieufan", VisitDate="27.12.2002", RoomNumber="" },
            new VisitDto {DoctorName="Waldemar", DoctorSurname="Kiepski", PatientName="Klaudiusz", PatientSurname="Nabuchodonozor", VisitDate="21.07.2018", RoomNumber="43a" },
            new VisitDto {DoctorName="Waldemar", DoctorSurname="Kiepski", PatientName="Agnieszka", PatientSurname="Niemieszka", VisitDate="12.04.2005", RoomNumber="77b"}
        };
    }
}
