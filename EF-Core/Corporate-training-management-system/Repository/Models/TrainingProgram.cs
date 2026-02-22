using System;
using System.Collections.Generic;
using System.Text;

namespace Corporate_training_management_system.Repository.Models
{
    public class TrainingProgram
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int DurationInDays { get; set; }
        public DateOnly StartDate { get; set; }

        public int TrainerId { get; set; }

        public virtual Trainer Trainer { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }

        public virtual ICollection<EmployeeTrainingProgram> EmployeeTrainingProgram { get; set; }
    }
}
