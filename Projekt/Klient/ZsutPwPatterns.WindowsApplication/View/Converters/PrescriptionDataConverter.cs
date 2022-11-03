namespace ZsutPw.Patterns.WindowsApplication.View
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    using Windows.UI.Xaml.Data;

    using ZsutPw.Patterns.WindowsApplication.Model;
    using ZsutPwPatterns.WindowsApplication.Logic.Model.Data;

    public class PrescriptionDataConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            PrescriptionData presriptionData = (PrescriptionData)value;
            
            var drugs = "";
            foreach (var drug in presriptionData.drugs){
                drugs += drug+ ", ";
            }


            return String.Format("{2} {3} assigned prescription for {0} {1}\ndrugs: {4}\nfrom {6} to {5}", presriptionData.patientName, presriptionData.patientSurname, presriptionData.doctorName, presriptionData.doctorSurname,  drugs, presriptionData.expirationDate, presriptionData.dateOfIssue);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}