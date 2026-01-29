using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Day_2
{
    interface IUser
    {
        void createUser();
    }
    interface IAdminUser : IUser
    {
        void createAdmin();
    }
    class User : IUser
    {
        public void createUser()
        {
            Console.WriteLine("User created");
        }
    }

    //Here admin has to implemenet both IUser and IAdminUser but to reduce code we directly inherit User so the implementation of IUser comes with it.
    class Admin : User, IAdminUser
    {
        public void createAdmin()
        {
            Console.WriteLine("Admin created");
        }
    }

    class TestProg
    {
        //static void Main(string[] args)
        //{
        //    Admin admin = new Admin();  
        //    admin.createAdmin();
        //    admin.createUser();
        //}
    }
}
