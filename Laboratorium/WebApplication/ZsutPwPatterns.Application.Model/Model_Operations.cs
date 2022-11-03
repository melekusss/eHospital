//===============================================================================
//
// PlaZa System Platform
//
//===============================================================================
//
// Warsaw University of Technology
// Computer Networks and Services Division
// Copyright © 2020 PlaZa Creators
// All rights reserved.
//
//===============================================================================

namespace ZsutPw.Patterns.Application.Model
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

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
                List<DoctorRoomData> selectionList = networkClient.GetSelectionList();

                this.SelectionList = selectionList;
            }
            catch (Exception)
            {
            }
        }

    }
}

