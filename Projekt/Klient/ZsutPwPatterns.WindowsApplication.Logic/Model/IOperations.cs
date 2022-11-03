namespace ZsutPw.Patterns.WindowsApplication.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IOperations
    {
        void LoadPrescriptionList();
        void LoadVistList();
        void AssignPrescription();
        void LoadFavouritePatientsList();
    }
}
