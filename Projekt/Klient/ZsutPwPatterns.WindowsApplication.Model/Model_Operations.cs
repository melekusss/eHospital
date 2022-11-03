namespace ZsutPw.Patterns.WindowsApplication.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ZsutPwPatterns.WindowsApplication.Model.Data;

    public partial class Model : IOperations
    { 
        public void LoadSelectionList()
        {
            Task.Run(() => this.LoadSelectionListTask());
        }
        private void LoadSelectionListTask()
        {
            INetwork networkClient = NetworkClientFactory.GetNetworkClient();

            try
            {
                List<FavouritePatientData> selectionList = networkClient.GetSelectionList();

                this.SelectionList = selectionList;
            }
            catch (Exception)
            {
            }
        }
    }
}
