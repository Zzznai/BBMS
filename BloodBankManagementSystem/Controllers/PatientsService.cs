using BloodBankManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem.Controllers
{
    public class PatientsService
    {
        public int GetPatientsCount()
        {
            using (var context = new BloodBankDbContext())
            {
                return context.Patients.Count();
            }
        }
        public Patient GetPatientById(int id)
        {
            using (var context = new BloodBankDbContext())
            {
                var patient = context.Patients.FirstOrDefault(d => d.PatientID == id);
                return patient;
            }
        }
        public void AddPatient(Patient patient)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to add the patient {patient.PatientFirstName} {patient.PatientLastName}?",
                                                  "Confirm Add Patient",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
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
        }
        public void EditPatient(Patient patient)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to edit the patient {patient.PatientFirstName} {patient.PatientLastName}?",
                                                  "Confirm Edit Patient",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
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
        }

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
