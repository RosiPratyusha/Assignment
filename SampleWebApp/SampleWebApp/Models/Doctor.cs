using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApp.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string DocName { get; set; }
        public string Specialization { get; set; }
        public string HospitalName { get; set; }
        public string City { get; set; }
        public string Contact { get; set; }
    }
}