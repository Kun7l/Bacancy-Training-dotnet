using System;
using System.Collections.Generic;
using System.Text;

namespace Corporate_training_management_system.Repository.Models
{
    public class Employee
    {
        public int Id { get; set; }    
        public string Name { get; set; }

        public int DepartmentId { get; set; }

    }
}
