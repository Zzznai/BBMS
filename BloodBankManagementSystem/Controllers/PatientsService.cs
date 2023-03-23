using BloodBankManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BloodBankManagementSystem.Controllers
{
    /// <summary>
    /// Represents a service for managing patients in a blood bank.
    /// </summary>
    public class PatientsService
    {
        /// <summary>
        /// Returns the number of patients in the database.
        /// </summary>
        /// <returns>The number of patients in the database.</returns>
        public int GetPatientsCount()
        {
            using (var context = new BloodBankDbContext())
            {
                return context.Patients.Count();
            }
        }

        /// <summary>
        /// Returns the patient with the specified ID from the database.
        /// </summary>
        /// <param name="id">The ID of the patient to retrieve.</param>
        /// <returns>The patient with the specified ID, or null if no such patient exists.</returns>
        public Patient GetPatientById(int id)
        {
            using (var context = new BloodBankDbContext())
            {
                var patient = context.Patients.FirstOrDefault(d => d.PatientID == id);
                return patient;
            }
        }

        /// <summary>
        /// Adds the specified patient to the database.
        /// </summary>
        /// <param name="patient">The patient to add to the database.</param>
        /// <exception cref="Exception">Thrown if there is an error while adding the patient to the database.</exception>
        /// <remarks>
        /// If the patient is successfully added to the database, a message box is displayed indicating that the patient was added successfully. 
        /// </remarks>
        /// <exception cref="Exception">Thrown if an error occurs while adding the patient to the database.</exception>
        public void AddPatient(Patient patient)
        {
            try
            {
                using (var context = new BloodBankDbContext())
                {
                    context.Patients.Add(patient);
                    context.SaveChanges();

                    MessageBox.Show("Patient added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding patient", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Updates an existing patient's information in the database.
        /// </summary>
        /// <param name="patient">The Patient object containing the updated information for the patient.</param>
        /// <remarks>
        /// If a patient with the same PatientID as the one passed in as a parameter is found in the database, 
        /// the patient's information is updated and the changes are saved to the database. If no patient with 
        /// the specified PatientID is found in the database. 
        /// </remarks>
        /// <exception cref="Exception">Thrown if any exception occurs during the execution of the method.</exception>
        public void EditPatient(Patient patient)
        {

            try
            {
                using (var context = new BloodBankDbContext())
                {
                    var existingPatient = context.Patients.FirstOrDefault(p => p.PatientID == patient.PatientID);
                    if (existingPatient != null)
                    {
                        existingPatient.PatientFirstName = patient.PatientFirstName;
                        existingPatient.PatientLastName = patient.PatientLastName;
                        existingPatient.PatientGender = patient.PatientGender;
                        existingPatient.PatientBirthDate = patient.PatientBirthDate;
                        existingPatient.PatientAge = patient.PatientAge;
                        existingPatient.BloodGroup = patient.BloodGroup;
                        existingPatient.ContactNumber = patient.ContactNumber;
                        existingPatient.Address = patient.Address;

                        context.SaveChanges();
                        MessageBox.Show("Patient updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Patient not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editing patient", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Deletes a patient from the Blood Bank's database.
        /// </summary>
        /// <param name="PatientId">The ID of the patient to be deleted.</param>
        /// <remarks>
        /// If a patient with the specified PatientId is found in the database and has not yet received any blood transfusion, 
        /// the patient is removed from the database using the Remove method, and the changes are saved to the database 
        /// using the SaveChanges method. If the patient has already received a blood transfusion, the method throws an 
        /// ArgumentException with a message indicating that the patient cannot be deleted from the system.
        /// </remarks>
        /// <exception cref="ArgumentException">Thrown if the patient has already received a blood transfusion.</exception>
        public void DeletePatient(int PatientId)
        {
            using (var context = new BloodBankDbContext())
            {
                var patient = context.Patients.FirstOrDefault(p => p.PatientID == PatientId);
                if (patient != null)
                {
                    var bloodTransfusionRecord = context.BloodTransfusion.FirstOrDefault(bt => bt.DestinationPatientID == PatientId);
                    if (bloodTransfusionRecord == null)
                    {
                        context.Patients.Remove(patient);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new ArgumentException($"Cannot delete a patient who already has received blood in the system!");
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Retrieves a list of blood transfusions based on the specified search input.The search can include patient first name, last name, blood group, or a combination of first and last name.If the search input is null or whitespace, all blood transfusions are returned.
        /// </summary>
        /// <param name="searchInput">The search input to use for filtering the blood transfusions. It can be a patient's first name, last name, blood group, or a combination of first and last name.</param>
        /// <returns>The method returns a list of anonymous objects with properties including the ID and date of the transfusion, the first and last name of the patient, their blood group, the blood group received, the quantity transfused, and the patient's age.</returns>
        public List<object> SearchAllPatients(string searchInput)
        {
            using (var context = new BloodBankDbContext())
            {
                var patientsQuery = context.Patients.AsQueryable();

                if (int.TryParse(searchInput, out int patientId))
                {
                    patientsQuery = patientsQuery.Where(p => p.PatientID == patientId);
                }
                else if (!string.IsNullOrWhiteSpace(searchInput))
                {
                    var searchTerm = searchInput.Split(' ');

                    if (searchTerm.Length == 2)
                    {
                        var firstName = searchTerm[0];
                        var lastName = searchTerm[1];

                        patientsQuery = patientsQuery.Where(p => p.PatientFirstName.Contains(firstName) && p.PatientLastName.Contains(lastName));
                    }
                    else
                    {
                        patientsQuery = patientsQuery.Where(p => p.PatientFirstName.Contains(searchInput) || p.PatientLastName.Contains(searchInput));
                    }
                }

                var patients = patientsQuery.Select(p => new
                {
                    Id = p.PatientID,
                    FirstName = p.PatientFirstName,
                    LastName = p.PatientLastName,
                    Gender = p.PatientGender,
                    Age = p.PatientAge,
                    BloodGroup = p.BloodGroup,
                    ContactNumber = p.ContactNumber,
                    Address = p.Address
                })
                .ToList();

                return patients.Cast<object>().ToList();
            }
        }

        /// <summary>
        /// Retrieves a list of patients based on the specified search input. The search can include patient first name, last name, or a combination of first and last name. If the search input is null or whitespace, all patients are returned. The method returns a list of anonymous objects with a subset of the properties of the Patient entity.
        /// </summary>
        /// <param name="searchInput">The search input to use for filtering the patients.</param>
        /// <returns>The method returns a list of anonymous objects with properties including the ID, first and last name, gender, age, and blood group of the patient.</returns>
        public List<object> SearchAllPatientsForTransfer(string searchInput)
        {
            using (var context = new BloodBankDbContext())
            {
                var patientsQuery = context.Patients.AsQueryable();

                if (int.TryParse(searchInput, out int patientId))
                {
                    patientsQuery = patientsQuery.Where(p => p.PatientID == patientId);
                }
                else if (!string.IsNullOrWhiteSpace(searchInput))
                {
                    var searchTerm = searchInput.Split(' ');

                    if (searchTerm.Length == 2)
                    {
                        var firstName = searchTerm[0];
                        var lastName = searchTerm[1];

                        patientsQuery = patientsQuery.Where(p => p.PatientFirstName.Contains(firstName) && p.PatientLastName.Contains(lastName));
                    }
                    else
                    {
                        patientsQuery = patientsQuery.Where(p => p.PatientFirstName.Contains(searchInput) || p.PatientLastName.Contains(searchInput));
                    }
                }

                var patients = patientsQuery.Select(p => new
                {
                    Id = p.PatientID,
                    FirstName = p.PatientFirstName,
                    LastName = p.PatientLastName,
                    Gender = p.PatientGender,
                    Age = p.PatientAge,
                    BloodGroup = p.BloodGroup
                })
                .ToList();

                return patients.Cast<object>().ToList();
            }
        }
    }
}
