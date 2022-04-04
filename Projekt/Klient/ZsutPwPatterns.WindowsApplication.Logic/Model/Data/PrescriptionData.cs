using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZsutPwPatterns.WindowsApplication.Logic.Model.Data
{
    public class PrescriptionData
    {
        public string dateOfIssue { get; set; }
        public int doctorId { get; set; }
        public string doctorName { get; set; }
        public string doctorSurname { get; set; }
        public IEnumerable<string> drugs { get; set; }
        public string expirationDate { get; set; }
        public int patientId { get; set; }
        public string patientName { get; set; }
        public string patientSurname { get; set; }

    }
}
