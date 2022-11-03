namespace ZsutPw.Patterns.WindowsApplication.Model
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using ZsutPwPatterns.WindowsApplication.Logic.Model.Data;

    public interface INetwork
    {
        List<FavouritePatientData> GetFavouritePatients(string doctorId);
        List<VisitData> GetVisitByDoctorIdList(string id);

        List<PrescriptionData> GetPrescriptionByDoctorIdList(string id);

        void AssignPrescription(PrescriptionToSendData prescription);

    }
}
