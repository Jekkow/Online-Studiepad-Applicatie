using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Studiepad.Logic
{
    public class Person
    {
        DataAccess.DataAccess data = new DataAccess.DataAccess();

        protected string firstName;
        protected string lastName;
        protected int role;
        private string username;
        private string password;

        protected string Username { get => username; set => username = value; }
        protected string Password { get => password; set => password = value; }

        public Person(string firstName, string lastName, int role)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.role = role;
        }
        //Overloading Person
        public Person(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public Person()
        {

        }

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public int GetRole()
        {
            return role;
        }

        public void Login(string username, string password)
        {

        }

        public void Logout()
        {
          
        }
    }
}
