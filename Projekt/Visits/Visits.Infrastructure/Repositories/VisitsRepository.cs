namespace Visits.Infrastructure
{
    using Dapper;
    using Visits.Domain;
    using Visits.Domain.VisitAggregate;
    using System;
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


   public class VisitsRepository : IVisitsRepository
    {
        public VisitsRepository()
        {

        }

        public async Task AddVisitAsync(Visit visit)
        {
            const string getAddedRowIdQueryQuery = @"SELECT CAST(SCOPE_IDENTITY() as int)";

            
            using (var dbConnection = new SqlConnection(Constants.connectionString))
            {
                
                dbConnection.Open();

                
                using (DbTransaction transaction = dbConnection.BeginTransaction())
                {
                    try
                    {
                        const string insertPatientQuery = @"INSERT INTO Patients (Name, Surname) VALUES (@name,@surname);";
                        int PatientId = await dbConnection.QueryFirstAsync<int>(insertPatientQuery + ";" + getAddedRowIdQueryQuery, new { name = visit.Patient.Name, surname= visit.Patient.Surname }, transaction);

                        const string insertDoctorQuery = @"INSERT INTO Doctors (Name, Surname) VALUES (@name,@surname);";
                        int DoctorId = await dbConnection.QueryFirstAsync<int>(insertDoctorQuery + ";" + getAddedRowIdQueryQuery, new { name = visit.Doctor.Name, surname = visit.Doctor.Surname }, transaction);



                        const string insertVisitQuery = @"INSERT INTO Visits (VisitDate,RoomNumber, DoctorId, PatientId) VALUES (@visitDate,@roomNumber, @doctorId, @patientId);";
                       
                         await dbConnection.QueryAsync(insertVisitQuery, new { visitDate=visit.VisitDate, roomNumber=visit.RoomNumber, doctorId=DoctorId, patientId=PatientId }, transaction);
                        transaction.Commit();
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }



        public async Task<IEnumerable<Visit>> GetAllAsync()
        {
            using (var dbConnection = new SqlConnection(Constants.connectionString))
            { 

                const string selectDoctorsQuery = @"SELECT * FROM Doctors";

                var doctors = await dbConnection.QueryAsync<Doctor>(selectDoctorsQuery);


                const string selectVisitQuery = @"SELECT * FROM Visits";

                var visits = await dbConnection.QueryAsync<Visit>(selectVisitQuery);


                const string selectPatientsQuery = @"SELECT * FROM Patients";

                var patients = await dbConnection.QueryAsync<Patient>(selectPatientsQuery);

                foreach (var visit in visits)
                {
        

                    var patientForGivenVisit = patients.Where(x => x.Id == visit.PatientId);
                    var doctorForGivenVisit = doctors.Where(x => x.Id == visit.DoctorId);         
                    visit.SetPatient(patientForGivenVisit.First());
                    visit.SetDoctor(doctorForGivenVisit.First());
                }

                return visits;
            }
        }

  

        public async Task<IEnumerable<Visit>> GetVisitsByPatientId(int patientId)
        {

            using (var dbConnection = new SqlConnection(Constants.connectionString))
            {
                string selectVisitsQuery = $@"SELECT * FROM Visits V WHERE V.patientId={patientId}";

                var visits = await dbConnection.QueryAsync<Visit>(selectVisitsQuery);

              
                const string selectDoctorsQuery = @"SELECT * FROM Doctors";

                var doctors = await dbConnection.QueryAsync<Doctor>(selectDoctorsQuery);

                const string selectPatientsQuery = @"SELECT * FROM Patients";

                var patients = await dbConnection.QueryAsync<Patient>(selectPatientsQuery);

                foreach (var visit in visits)
                { 
                    var patientForGivenVisit = patients.Where(x => x.Id==visit.PatientId);
                    var doctorForGivenVisit = doctors.Where(x => x.Id == visit.DoctorId);
                    visit.SetDoctor(doctorForGivenVisit.First());
                    visit.SetPatient(patientForGivenVisit.First());
                }

                return visits;
            }
        }

        public async Task<IEnumerable<Visit>> GetVisitsByDoctorId(int doctorId)
        {

            using (var dbConnection = new SqlConnection(Constants.connectionString))
            {
                string selectVisitsQuery = $@"SELECT * FROM Visits V WHERE V.doctorId={doctorId}";

                var visits = await dbConnection.QueryAsync<Visit>(selectVisitsQuery);


                const string selectDoctorsQuery = @"SELECT * FROM Doctors";

                var doctors = await dbConnection.QueryAsync<Doctor>(selectDoctorsQuery);

                const string selectPatientsQuery = @"SELECT * FROM Patients";

                var patients = await dbConnection.QueryAsync<Patient>(selectPatientsQuery);

                foreach (var visit in visits)
                {
                    var patientForGivenVisit = patients.Where(x => x.Id == visit.PatientId);
                    var doctorForGivenVisit = doctors.Where(x => x.Id == visit.DoctorId);
                    visit.SetDoctor(doctorForGivenVisit.First());
                    visit.SetPatient(patientForGivenVisit.First());
                }

                return visits;
            }
        }


    }

}

