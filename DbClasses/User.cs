using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolGrades.DbClasses
{
    class User
    {
        string username;
        string lastName;
        string firstName;
        string description;
        string email;
        string password;
        DateTime create_time;
        string salt;
        int idUserCategory;

        public string Username { get => username; set => username = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Password { get => password; set => password = value; }
        public string Description { get => description; set => description = value; }
        public string Salt { get => salt; set => salt = value; }

        public User(string Username, string Password)
        {
            this.username = Username;
            this.password = Password;
        }
    }
}
