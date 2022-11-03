﻿namespace ZsutPw.Patterns.WindowsApplication.Model
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
            //if DEBUG
            // return new FakeNetworkClient();

            //#else
            const string serviceHost = "localhost";
            const int servicePort = 44380;

            return new NetworkClient(serviceHost, servicePort);

            //#endif
        }
    }
}
