using System;
using System.Collections.Generic;
using System.Text;

namespace Corporate_training_management_system.Repository.Models
{
    public class Employee
    {
        public int Id { get; set; }    
        public string Name { get; set; }

        public string Email { get; set; }

        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<TrainingProgram> TrainingPrograms { get; set; }

        public virtual ICollection<EmployeeTrainingProgram> EmployeeTrainingPrograms { get; set; }

    }
}
