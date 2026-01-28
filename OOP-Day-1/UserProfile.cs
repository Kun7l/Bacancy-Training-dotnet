using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Day_1
{
    class InvalidEmailException : Exception
    {
        public InvalidEmailException() : base("Invalid Email")
        {
        }
    }
    internal class UserProfile
    {

        internal string userName;
        internal string? email;
        private string password;

        internal UserProfile(string userName, string email, string password)
        {
            try
            {
                if (verifyEmail(email))
                {
                    this.email = email;
                }
                else
                {
                    throw new InvalidEmailException();
                }
            }
            catch (InvalidEmailException ex) {
                Console.WriteLine($"{ex.Message}");
            }

            this.userName = userName;
            this.password = password;

        }

        private bool verifyEmail(string email) {
            if (email.Length > 20 || !email.Contains('@'))
            {
                return false;
            }
            return true;
        }

        internal bool verifyPassword(string password) { 
            return this.password .Equals(password);
        }
    }

    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    UserProfile profile = new UserProfile("_krun7l", "kunal@gmail.com", "123@password");
        //    Console.WriteLine(profile.email);

        //    //Cant access password directly
        //    //Console.WriteLine(profile.password);

        //    //If everything is public you can directly access password and change it by using (.) dot operator
        //}
    }
}
