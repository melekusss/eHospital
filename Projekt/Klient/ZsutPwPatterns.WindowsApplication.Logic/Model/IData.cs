namespace ZsutPw.Patterns.WindowsApplication.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using System.ComponentModel;
    using ZsutPwPatterns.WindowsApplication.Logic.Model.Data;

    public interface IData : INotifyPropertyChanged
    {
        string SearchText { get; set; }

        List<FavouritePatientData> FavouritePatientsList { get; }

        FavouritePatientData SelectedFavouritePatientData { get; set; }

        List<PrescriptionData> PrescriptionList { get; }

        PrescriptionData SelectedPrescriptionData{ get; set; }

        List<VisitData> VisitList { get; }

        VisitData SelectedVisitData { get; set; }

        TemporaryPrescriptionData AssignedPrescriptionData { get; set; }

        string SearchPrescriptionDoctorId { get; set; }
        string SearchVisitDoctorId { get; set; }
        string SearchFavouritePatientDoctorId { get; set; }
    }
}
