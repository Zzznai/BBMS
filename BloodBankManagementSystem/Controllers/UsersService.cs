using BloodBankManagementSystem.Common;
using BloodBankManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BloodBankManagementSystem.Controllers
{
    public class UsersService
    {
        public Users GetUserById(int id)
        {
            using (var context = new BloodBankDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.UserID == id);
                return user;
            }
        }

        public bool IsUserValid(string email, string password)
        {
            using (var context = new BloodBankDbContext())
            {
                var userExists = context.Users.Any(u => u.Email.Equals(email) && u.Password.Equals(password));
                return userExists;
            }
        }
        public bool IsUserAdmin(string email, string password)
        {
            using (var context = new BloodBankDbContext())
            {
                var isAdmin = context.Users.Any(u => u.Email==email && u.Role == GlobalConstants.AdminRole);
                return isAdmin;
            }
        }
        public Users GetUserByEmailAndPassword(string email, string password)
        {
            using (var context = new BloodBankDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
                return user;
            }
        }
        public List<object> GetAllUsers()
        {
            using (var context = new BloodBankDbContext())
            {
                var users = context.Users.Where(u => u.Role != GlobalConstants.AdminRole)
                                         .Select(u => new
                                         {
                                             u.FirstName,
                                             u.LastName,
                                             u.Email,
                                             u.Password
                                         })
                                         .ToList();
                return users.Cast<object>().ToList();
            }
        }
        public string GetUserNameByEmail(string email)
        {
            using (var context = new BloodBankDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Email == email);
                return user.FirstName + " " + user.LastName;
            }
        }
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
        public bool IsEmailUsed(string email)
        { 
            using (var context = new BloodBankDbContext())
            {
                return context.Users.Any(u => u.Email == email);
            }
        }

        public bool IsEmailUsedByAnotherUser(int id, string email)
        {
            using (var context = new BloodBankDbContext())
            {
                return context.Users.Any(u => u.Email == email && u.UserID != id);
            }
        }

        public bool AddUser(string firstName, string lastName, string email, string password )
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to add the user {firstName} {lastName}?",
                                                  "Confirm Add User",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
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
                        return true;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return false;
        }

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

                        context.SaveChanges();
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
