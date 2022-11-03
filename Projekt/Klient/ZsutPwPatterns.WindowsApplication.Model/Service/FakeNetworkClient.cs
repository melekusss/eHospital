namespace ZsutPw.Patterns.WindowsApplication.Model
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using ZsutPwPatterns.WindowsApplication.Model.Data;

    public class FakeNetworkClient : INetwork
    {
        private static readonly Dictionary<string, int> fakeDicitionary = new Dictionary<string, int> { { "Jan Kowalski", 2 }, { "Adam Nowak", 2 } };


        public List<FavouritePatientData> GetSelectionList()
        {
            List<FavouritePatientData> data = new List<FavouritePatientData>();

            foreach (KeyValuePair<string, int> selection in fakeDicitionary)
            {
                FavouritePatientData dataExample = new FavouritePatientData() { NameSurname = selection.Key, Number = selection.Value };
                data.Add(dataExample);


            }
            return data;
        }
    }
}
