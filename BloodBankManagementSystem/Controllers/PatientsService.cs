using BloodBankManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
