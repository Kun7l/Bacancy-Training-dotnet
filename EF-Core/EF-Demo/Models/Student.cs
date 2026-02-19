using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;

namespace EF_Demo
{
    internal class Student
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
        public DateOnly CreatedDate { get; set; }

        
        public ICollection<Course> courses { get; set; }

    }
}
