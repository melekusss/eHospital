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
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    using System.Net.Http;
    using ZsutPwPatterns.Application.Model.Data;

    public class NetworkClient : INetwork
    {
        private readonly ServiceClient serviceClient;

        public NetworkClient(string serviceHost, int servicePort)
        {
            Debug.Assert(condition: !String.IsNullOrEmpty(serviceHost) && servicePort > 0);

            this.serviceClient = new ServiceClient(serviceHost, servicePort);
        }

        public List<DoctorRoomData> GetSelectionList()
        {
            string callUri = string.Format("examination-rooms-selection");

            List<PairDto> resault = this.serviceClient.CallWebService<List<PairDto>>(HttpMethod.Get, callUri);
            List<DoctorRoomData> selectionList = new List<DoctorRoomData>();
            foreach (PairDto selection in resault)
            {
                DoctorRoomData dataExample = new DoctorRoomData() { Name = selection.doctor, Number = selection.examinationRoom };
                selectionList.Add(dataExample);

            }

            return selectionList;
        }
    }
}
