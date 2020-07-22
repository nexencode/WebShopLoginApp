using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopLoginApp.User
{
    public class User
    {
        #region Fields and Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int RoleId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        private string password;
        /// <summary>
        /// Address id is a connection with user address in Address Repository
        /// </summary>
        public int AddressId { get; set; }
        public string Telephone { get; set; }
        public bool IsActive { get; set; }
        #endregion

        #region Constructor
        public User()
        {

        }

        public User(int userId, string firstName, string lastName, int age, int roleId, string username, string email, string password, int addressId, string telephone, bool isActive)
        {
            Id = userId;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            RoleId = roleId;
            Username = username;
            Email = email;
            this.password = password;
            AddressId = addressId;
            Telephone = telephone;
            IsActive = isActive;
        }
        #endregion

        #region Methods

        public void PrintUserRole()
        {
            //Role.PrintRole();
        }

        public void PrintUser()
        {
            Console.WriteLine($"ID: {Id}, Name: {FirstName}, Userame: {Username}, Email: {Email}, Age: {Age}");
            Console.WriteLine($"-------------------------");

            //Role.PrintRole();

            Console.WriteLine($"-------------------------");

        }
        #endregion
    }
}
