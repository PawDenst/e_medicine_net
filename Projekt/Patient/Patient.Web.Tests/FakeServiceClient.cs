
namespace Patient.Web.Tests
{
    using Patient.Web.Application.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class FakeServiceClient
    {

        public IEnumerable<PrescriptionDto> SimplePrescriptionListWithOneFavoriteDrug = new List<PrescriptionDto> { new PrescriptionDto { DoctorName = "Jan", DoctorSurname = "Kowalski", PatientName = "Jakub", PatientSurname = "Nowak", Drugs = new string[] { "Paracetamol", "Kodeina" }, PatientId = 1, DoctorId = 2, DateOfIssue = "10/06/2021", ExpirationDate = "11/09/2021" }, new PrescriptionDto { DoctorName = "Stefan", DoctorSurname = "Testowy", PatientName = "Maciek", PatientSurname = "Zapasowy", Drugs = new string[] { "Kofeina", "Viagra","Paracetamol" }, PatientId = 2, DoctorId = 3, DateOfIssue = "10/06/2021", ExpirationDate = "29/07/2021" } };
        public IEnumerable<PrescriptionDto> SimplePrescriptionListWithTwoFavoriteDrugs = new List<PrescriptionDto> { new PrescriptionDto { DoctorName = "Jan", DoctorSurname = "Kowalski", PatientName = "Jakub", PatientSurname = "Nowak", Drugs = new string[] { "Paracetamol", "Kodeina", "Kofeina" }, PatientId = 1, DoctorId = 2, DateOfIssue = "10/06/2021", ExpirationDate = "11/09/2021" }, new PrescriptionDto { DoctorName = "Stefan", DoctorSurname = "Testowy", PatientName = "Maciek", PatientSurname = "Zapasowy", Drugs = new string[] { "Kofeina", "Viagra", "Paracetamol" }, PatientId = 2, DoctorId = 3, DateOfIssue = "10/06/2021", ExpirationDate = "29/07/2021" } };



    }
}
