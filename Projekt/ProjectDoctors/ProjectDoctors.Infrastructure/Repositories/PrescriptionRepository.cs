namespace Prescriptions.Infrastructure.Repositories
{
    using Dapper;
    using Prescriptions.Domain.PrescriptionsAggregate;
    using ProjectDoctors.Infrastructure;
    using System;
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Threading.Tasks;

    public class PrescriptionRepository : IPrescriptionsRepository
    {
        public PrescriptionRepository()
        {
        }

        public async Task AddPrescriptionAsync(Prescription prescription)
        {
            const string getAddedRowIdQueryQuery = @"SELECT CAST(SCOPE_IDENTITY() as int)";

            using (var dbConnection = new SqlConnection(Constants.connectionString))
            {
                dbConnection.Open();

                using (DbTransaction transaction = dbConnection.BeginTransaction())
                {

                    try
                    {

                        const string insertPatientQuery = @"INSERT INTO Patient (Name, Surname) VALUES (@name, @surname);";
                        int PatientId = await dbConnection.QueryFirstAsync<int>(insertPatientQuery + ";" + getAddedRowIdQueryQuery, new { name = prescription.Patient.Name, surname = prescription.Patient.Surname }, transaction);


                        const string insertDoctorQuery = @"INSERT INTO Doctor (Name, Surname) VALUES (@name, @surname);";
                        int DoctorId = await dbConnection.QueryFirstAsync<int>(insertDoctorQuery + ";" + getAddedRowIdQueryQuery, new { name = prescription.Doctor.Name, surname = prescription.Doctor.Surname }, transaction);

                        var drugIds = new List<int>();

                        const string insertDrugQuery = @"INSERT INTO Drug (DrugName) VALUES (@drugName);";
                        foreach (var drug in prescription.Drugs)
                            drugIds.Add(await dbConnection.QueryFirstAsync<int>(insertDrugQuery + ";" + getAddedRowIdQueryQuery, new { drugName = drug.DrugName }, transaction));

                        const string insertPrescriptionQuery = @"INSERT INTO Prescription (DateOfIssue,DoctorId,ExpirationDate,PatientId) VALUES (@dateOfIssue, @doctorId, @expirationDate, @patientId);";
                        int prescriptionId = await dbConnection.QueryFirstAsync<int>(insertPrescriptionQuery + ";" + getAddedRowIdQueryQuery, new { dateOfIssue = prescription.DateOfIssue, doctorId = DoctorId, expirationDate = prescription.ExpirationDate, patientId = PatientId }, transaction);

                        const string insertPrescriptionDrugQuery = @"INSERT INTO PrescriptionDrug (DrugId, PrescriptionId) VALUES (@drugId,@prescriptionId);";
                        foreach (var drugId in drugIds)
                            await dbConnection.QueryAsync(insertPrescriptionDrugQuery, new { drugId = drugId, prescriptionId = prescriptionId }, transaction);

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

        public async Task<IEnumerable<Prescription>> GetByDoctorIdAsync(int doctorId)
        {
            using (var dbConnection = new SqlConnection(Constants.connectionString))
            {
                const string selectPrescriptionDrugQuery = @"SELECT * FROM PrescriptionDrug";
                var prescriptionDrugs = (await dbConnection.QueryAsync(selectPrescriptionDrugQuery)).Select(x => new { DrugId = x.DrugId, PrescriptionId = x.PrescriptionId });

                var prescriptions = await dbConnection.QueryAsync<Prescription>("Select * from Prescription where DoctorId = @doctorId", new { doctorId = doctorId });


                const string selectDoctorQuery = @"SELECT * FROM Doctor";

                var doctors = await dbConnection.QueryAsync<Doctor>(selectDoctorQuery);

                const string selectPatientQuery = @"SELECT * FROM Patient";

                var patients = await dbConnection.QueryAsync<Patient>(selectPatientQuery);


                const string selectDrugsQuery = @"SELECT * FROM Drug";

                var drugs = await dbConnection.QueryAsync<Drug>(selectDrugsQuery);

                foreach (var prescription in prescriptions)
                {
                    var doctorForGivenPrescription = doctors.Where(x => x.Id == prescription.Doctor.Id);
                    var patientForGivenPrescription = patients.Where(x => x.Id == prescription.Patient.Id);

                    var drugsIdForGivenPrescription = prescriptionDrugs.Where(x => x.PrescriptionId == prescription.Id).Select(x => x.DrugId);
                    var drugForGivenPrescription = drugs.Where(x => drugsIdForGivenPrescription.Contains(x.Id));

                    prescription.SetDoctor(doctorForGivenPrescription.First());
                    prescription.SetPatient(patientForGivenPrescription.First());
                    prescription.AddDrugs(drugForGivenPrescription);

                }

                return prescriptions;
            }
        }
        public async Task<IEnumerable<Prescription>> GetByPatientIdAsync(int patientId)
        {
            using (var dbConnection = new SqlConnection(Constants.connectionString))
            {

                const string selectPrescriptionDrugQuery = @"SELECT * FROM PrescriptionDrug";
                var prescriptionDrugs = (await dbConnection.QueryAsync(selectPrescriptionDrugQuery)).Select(x => new { DrugId = x.DrugId, PrescriptionId = x.PrescriptionId });

                var prescriptions = await dbConnection.QueryAsync<Prescription>("Select * from Prescription where PatientId = @patientId", new { patientId = patientId });

                const string selectDoctorQuery = @"SELECT * FROM Doctor";

                var doctors = await dbConnection.QueryAsync<Doctor>(selectDoctorQuery);

                const string selectPatientQuery = @"SELECT * FROM Patient";

                var patients = await dbConnection.QueryAsync<Patient>(selectPatientQuery);


                const string selectDrugsQuery = @"SELECT * FROM Drug";

                var drugs = await dbConnection.QueryAsync<Drug>(selectDrugsQuery);

                foreach (var prescription in prescriptions)
                {
                    var doctorForGivenPrescription = doctors.Where(x => x.Id == prescription.Doctor.Id);
                    var patientForGivenPrescription = patients.Where(x => x.Id == prescription.Patient.Id);

                    var drugsIdForGivenPrescription = prescriptionDrugs.Where(x => x.PrescriptionId == prescription.Id).Select(x => x.DrugId);
                    var drugForGivenPrescription = drugs.Where(x => drugsIdForGivenPrescription.Contains(x.Id));

                    prescription.SetDoctor(doctorForGivenPrescription.First());
                    prescription.SetPatient(patientForGivenPrescription.First());
                    prescription.AddDrugs(drugForGivenPrescription);

                }

                return prescriptions;
            }
        }

    }
}
