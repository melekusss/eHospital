namespace ProjectDoctors.Infrastructure
{
    using System;


    internal class Constants
    {
        public static string connectionString = Environment.GetEnvironmentVariable("databaseconnection");
    }
}
