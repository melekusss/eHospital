﻿//===============================================================================
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

    public static class NetworkClientFactory
    {
        public static INetwork GetNetworkClient()
        {


            const string serviceHost = "localhost";
            const int servicePort = 8081;

            return new NetworkClient(serviceHost, servicePort);


        }
    }
}
