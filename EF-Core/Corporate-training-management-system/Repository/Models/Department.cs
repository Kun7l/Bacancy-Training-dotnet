using System;
using System.Collections.Generic;
using System.Text;

namespace Corporate_training_management_system.Repository.Models
{
    public class Department
    {
       public int Id { get; set; }
        public string Name { get; set; }

        public string Location { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
