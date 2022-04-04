using System;

namespace Patient.Web.Application
{
    internal class Constants
    {
        public static string VisitsConnectionString = Environment.GetEnvironmentVariable("Visitsaddr");
        public static string PrescriptionsConnectionString = Environment.GetEnvironmentVariable("Prescriptionaddr");
    }
}