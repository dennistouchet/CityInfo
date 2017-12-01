using CityInfo.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Services
{
    public class LocalMailService : IMailService
    {
        private string _mailTo = "admin@dennistouchet.com";
        private string _mailFrom = "noreply@dennistouchet.com";

        public void Send(string subject, string body)
        {
            // mock send mail - outpupt to debug window
            Debug.WriteLine($"Mail from {_mailFrom}, with LocalMailService.");
            Debug.WriteLine($"Subject: {subject}");
            Debug.WriteLine($"Message: {body}");
        }
    }
}
