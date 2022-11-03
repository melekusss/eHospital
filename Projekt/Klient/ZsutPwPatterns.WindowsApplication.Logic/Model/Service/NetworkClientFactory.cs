﻿
namespace ZsutPw.Patterns.WindowsApplication.Model
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    public static class NetworkClientFactory
    {
        public static INetwork GetDoctorClient()
        {
            
            return new NetworkClient("localhost:8084"); 

        }

    }
}