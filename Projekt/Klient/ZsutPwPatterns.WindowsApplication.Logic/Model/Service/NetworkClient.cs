namespace ZsutPw.Patterns.WindowsApplication.Model
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    using System.Net.Http;
    using ZsutPwPatterns.WindowsApplication.Logic.Model.Data;
    using System.Text.Json;

    public class NetworkClient : INetwork
    {
        private readonly ServiceClient serviceClient;

        public NetworkClient(string serviceHost)
        {
            Debug.Assert(condition: !String.IsNullOrEmpty(serviceHost));

            this.serviceClient = new ServiceClient(serviceHost);
        }

        public void AssignPrescription(PrescriptionToSendData prescription)
        {
            string callUri = string.Format("assign-prescription");
            var body = JsonSerializer.Serialize(prescription);
            string result = this.serviceClient.PostCallWebService(HttpMethod.Post,callUri , body).Result; ;
        }


        public List<PrescriptionData> GetPrescriptionByDoctorIdList(string doctorId)

        {
            string callUri = string.Format("doctors-prescriptions?doctorId={0}", doctorId);
            List<PrescriptionData> result = (List<PrescriptionData>)this.serviceClient.CallWebService<IEnumerable<PrescriptionData>>(HttpMethod.Get, callUri);
            return result;
        }

        public List<FavouritePatientData> GetFavouritePatients(string doctorId)
        {
            string callUri = string.Format("doctors-favourite-patients"+"?doctorId="+doctorId);

            Dictionary<string, int> resultDictionary = this.serviceClient.CallWebService<Dictionary<string, int>>(HttpMethod.Get, callUri);
            List<FavouritePatientData> selectionList = new List<FavouritePatientData>();
            foreach (KeyValuePair<string, int> selection in resultDictionary)
            {
                FavouritePatientData dataExample = new FavouritePatientData() { NameSurname = selection.Key, Number = selection.Value };
                selectionList.Add(dataExample);

            }

            return selectionList;
        }

        public List<VisitData> GetVisitByDoctorIdList(string doctorId)
        {
            string callUri = string.Format("visits-calendar" + "?doctorId=" + doctorId);
            List<VisitData> result = this.serviceClient.CallWebService<List<VisitData>>(HttpMethod.Get, callUri);
            return result;
        }

       
    }
}
