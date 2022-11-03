namespace ZsutPw.Patterns.WindowsApplication.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using System.ComponentModel;
    using ZsutPwPatterns.WindowsApplication.Model.Data;

    public interface IData : INotifyPropertyChanged
    {
        string SearchText { get; set; }

        List<FavouritePatientData> SelectionList { get; }

        FavouritePatientData SelectedDoctorRoomData { get; set; }
    }
}
