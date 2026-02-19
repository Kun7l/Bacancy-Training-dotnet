using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Demo
{
    internal class StudentNotFound : Exception 
    {
        public StudentNotFound(string message) : base(message) { }
    }
}
