namespace ZsutPw.Patterns.WindowsApplication.Model
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    using System.Net.Http;
    using ZsutPwPatterns.WindowsApplication.Model.Data;

    public class NetworkClient : INetwork
    {
        private readonly ServiceClient serviceClient;

        public NetworkClient(string serviceHost, int servicePort)
        {
            Debug.Assert(condition: !String.IsNullOrEmpty(serviceHost) && servicePort > 0);

            this.serviceClient = new ServiceClient(serviceHost, servicePort);
        }

        public List<FavouritePatientData> GetSelectionList()
        {
            string callUri = String.Format("doctors-favourite-patients");

            Dictionary<string, int> resultDictionary = this.serviceClient.CallWebService<Dictionary<string,int>>(HttpMethod.Get, callUri);
            List<FavouritePatientData> selectionList = new List<FavouritePatientData>();
            foreach (KeyValuePair<string, int> selection in resultDictionary)
            {
                FavouritePatientData dataExample = new FavouritePatientData() { NameSurname = selection.Key, Number = selection.Value };
                selectionList.Add(dataExample);


            }

            return selectionList;
        }
    }
}
