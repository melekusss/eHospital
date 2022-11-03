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

    public NetworkClient( string serviceHost, int servicePort )
    {
      Debug.Assert( condition: !String.IsNullOrEmpty( serviceHost ) && servicePort > 0 );

      this.serviceClient = new ServiceClient( serviceHost, servicePort );
    }

    public NodeData[ ] GetNodes( string searchText )
    {
      string callUri = String.Format( "Network/GetNodes?searchText={0}", searchText );

      NodeData[ ] nodes = this.serviceClient.CallWebService<NodeData[ ]>( HttpMethod.Get, callUri );

      return nodes;
    }
    public List<PairData> GetSelectorList()
    {
        string callUri = string.Format("examination-rooms-selection");

        List<PairData> result = this.serviceClient.CallWebService<List<PairData>>(HttpMethod.Get, callUri);
        //List<DoctorRoomData> selectionList = new List<DoctorRoomData>();
        //foreach (KeyValuePair<string, string> selection in resultDictionary)
        //{
        //DoctorRoomData dataExample = new DoctorRoomData() { Surname = selection.Key, Number = selection.Value };
        //selectionList.Add(dataExample);

        //}

            return result;
        }
    }

}
