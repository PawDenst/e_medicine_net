namespace Visits.Domain.VisitAggregate
{
    using Visits.Domain.SeedWork;
    using System;
using System.Collections.Generic;
using System.Text;


   public class Visit : Entity
    {
        

        public Patient Patient { get; set; }
        public string VisitDate { get; private set; }
        public string RoomNumber { get; private set; }
        public Doctor Doctor { get;  set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }



        public Visit(int id, string visitDate, string roomNumber,  Doctor doctor, Patient patient) : base(id)
        {
            Doctor = doctor;
            VisitDate = visitDate;
            RoomNumber = roomNumber;
            Patient = patient;
        }
        public Visit(int id, string visitDate, string roomNumber) : base(id)
        {
            
            VisitDate = visitDate;
            RoomNumber = roomNumber;
           
        }
        public Visit(int id, string visitDate, string roomNumber, int DoctorId, int PatientId) : base(id)
        {
            this.DoctorId = DoctorId;
            this.PatientId = PatientId;
            VisitDate = visitDate;
            RoomNumber = roomNumber;

        }

        public void SetDoctor(Doctor doctor)
        {
            Doctor=doctor;
        }
        public void SetPatient(Patient patient)
        {
            Patient = patient;
        }

    }
}
