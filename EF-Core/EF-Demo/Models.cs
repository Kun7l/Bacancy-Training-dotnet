using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateOnly CreatedDate { get; set; }

        public string Department { get; set; }

    }

    internal class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Double Fees { get; set; }
        public int DurationInMonths { get; set; }
    }
}
