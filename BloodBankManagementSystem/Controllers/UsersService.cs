using BloodBankManagementSystem.Common;
using BloodBankManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BloodBankManagementSystem.Controllers
{
    /// <summary>
    /// Represents a service for managing users in a blood bank.
    /// </summary>
    public class UsersService
    {
        /// <summary>
        /// Retrieves a user by their ID.
        /// </summary>
        /// <param name="id">The ID of the user to retrieve.</param>
        /// <returns>The user with the specified ID, or null if no such user exists.</returns>
        public Users GetUserById(int id)
        {
            using (var context = new BloodBankDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.UserID == id);
                return user;
            }
        }

        /// <summary>
        /// Checks whether a user with the specified email which is unique which is and password exists in the database.
        /// </summary>
        /// <param name="email">The email of the user to check.</param>
        /// <param name="password">The password of the user to check.</param>
        /// <returns>True if a user with the specified email and password exists, otherwise false.</returns>
        public bool IsUserValid(string email, string password)
        {
            using (var context = new BloodBankDbContext())
            {
                var userExists = context.Users.Any(u => u.Email.Equals(email) && u.Password.Equals(password));
                return userExists;
            }
        }

        /// <summary>
        /// Determines whether the user with the specified email and password has admin privileges.
        /// </summary>
        /// <param name="email">The email of the user to check.</param>
        /// <param name="password">The password of the user to check.</param>
        /// <returns>True if the user has admin privileges, false otherwise.</returns>
        public bool IsUserAdmin(string email, string password)
        {
            using (var context = new BloodBankDbContext())
            {
                var isAdmin = context.Users.Any(u => u.Email == email && u.Role == GlobalConstants.AdminRole);
                return isAdmin;
            }
        }

        /// <summary>
        /// Searches for all users in the database based on a search input. The method filters the user records based on the provided search input, which can be either a user ID, first name, last name or email address. If the search input is not recognized, all users except admins are returned.
        /// </summary>
        /// <param name="searchInput">The search input to use for the query. This can be either a user ID, first name, last name or email address.</param>
        /// <returns>A list of objects representing the filtered user records.</returns>
        public List<object> SearchAllUsers(string searchInput)
        {
            using (var context = new BloodBankDbContext())
            {
                var usersQuery = context.Users.Where(u => u.Role != GlobalConstants.AdminRole);

                if (int.TryParse(searchInput, out int userId))
                {
                    usersQuery = usersQuery.Where(u => u.UserID == userId);
                }
                else if (!string.IsNullOrWhiteSpace(searchInput))
                {
                    var searchTerm = searchInput.Split(' ');

                    if (searchTerm.Length == 2)
                    {
                        var firstName = searchTerm[0];
                        var lastName = searchTerm[1];

                        usersQuery = usersQuery.Where(u => u.FirstName.Contains(firstName) && u.LastName.Contains(lastName));
                    }
                    else
                    {
                        usersQuery = usersQuery.Where(u => u.FirstName.Contains(searchInput) || u.LastName.Contains(searchInput) || u.Email.Contains(searchInput));
                    }
                }

                var users = usersQuery.Select(u => new
                {
                    u.UserID,
                    u.FirstName,
                    u.LastName,
                    u.Email,
                    u.Password
                })
                .ToList();

                return users.Cast<object>().ToList();
            }
        }

        /// <summary>
        /// Gets the full name of the user with the specified email address which is unique for every user.
        /// </summary>
        /// <param name="email">The email address of the user to retrieve.</param>
        /// <returns>The full name of the user, or an empty string if the user does not exist.</returns>
        public string GetUserNameByEmail(string email)
        {
            using (var context = new BloodBankDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Email == email);
                return user.FirstName + " " + user.LastName;
            }
        }

        /// <summary>
        /// Deletes a user with the specified ID from the database.
        /// </summary>
        /// <param name="userId">The ID of the user to delete.</param>
        public void DeleteUser(int userId)
        {
            using (var context = new BloodBankDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.UserID == userId);
                if (user != null)
                {
                    context.Users.Remove(user);
                    context.SaveChanges();
                }
            }
        }

        // <summary>
        /// Determines whether the specified email address is already used by any user in the database.
        /// </summary>
        /// <param name="email">The email address to check.</param>
        /// <returns><c>true</c> if the email address is already used by a user; otherwise, <c>false</c>.</returns>
        public bool IsEmailUsed(string email)
        {
            using (var context = new BloodBankDbContext())
            {
                return context.Users.Any(u => u.Email == email);
            }
        }

        /// <summary>
        /// Determines whether the specified email address is already used by a user other than the one with the specified ID.
        /// </summary>
        /// <param name="id">The ID of the user to exclude from the search.</param>
        /// <param name="email">The email address to check.</param>
        /// <returns><c>true</c> if the email address is already used by another user; otherwise, <c>false</c>.</returns>
        public bool IsEmailUsedByAnotherUser(int id, string email)
        {
            using (var context = new BloodBankDbContext())
            {
                return context.Users.Any(u => u.Email == email && u.UserID != id);
            }
        }

        /// <summary>
        /// This method creates a new Users object with the provided information and sets the user's role to the default role defined in the GlobalConstants class and it adds the new user to the database.
        /// </summary>
        /// <param name="firstName">The user's first name.</param>
        /// <param name="lastName">The user's last name.</param>
        /// <param name="email">The user's email address.</param>
        /// <param name="password">The user's password.</param>
        /// <exception cref="Exception">Thrown when there is an error adding the user to the database.</exception>
        /// <remarks>
        /// </remarks>
        public void AddUser(string firstName, string lastName, string email, string password)
        {
            try
            {
                using (var context = new BloodBankDbContext())
                {
                    Users newUser = new Users()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Email = email,
                        Password = password,
                        Role = GlobalConstants.UserRole
                    };

                    context.Users.Add(newUser);
                    context.SaveChanges();

                    MessageBox.Show("User added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Updates the user's information with the specified ID in the database.
        /// </summary>
        /// <param name="userId">The ID of the user to be updated.</param>
        /// <param name="firstName">The optional updated first name of the user.</param>
        /// <param name="lastName">The optional updated last name of the user.</param>
        /// <param name="email">The optional updated email address of the user.</param>
        /// <param name="password">The optional updated password of the user.</param>
        /// <remarks>
        /// This method attempts to update the user's information in the database using the specified values for first name,
        /// last name, email address, and password. If any of these values are null or empty, they will not be updated. 
        /// If the user is found in the database and any of the specified values are updated, a success message will be displayed. 
        /// If the user is not found, an error message will be displayed.
        /// </remarks>
        /// <exception cref="Exception">Thrown when an error occurs while attempting to update the user in the database.</exception>
        public void EditUser(int userId, string firstName, string lastName, string email, string password)
        {
            try
            {
                using (var context = new BloodBankDbContext())
                {
                    var user = context.Users.FirstOrDefault(u => u.UserID == userId);

                    if (user != null)
                    {
                        user.FirstName = firstName;
                        user.LastName = lastName;
                        user.Email = email;
                        user.Password = password;
                        MessageBox.Show("User edited successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error editing user: " + ex.Message);
            }
        }
    }
}



