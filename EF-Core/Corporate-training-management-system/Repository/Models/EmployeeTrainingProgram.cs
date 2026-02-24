using System;
using System.Collections.Generic;
using System.Text;

namespace Corporate_training_management_system.Repository.Models
{
    public class EmployeeTrainingProgram
    {
        public int EmployeeId { get; set; }
        public int TrainingProgramId { get; set; }

        public DateOnly EnrollmentDate { get; set; }
        public int Score { get; set; } = 0;

        public virtual Employee Employee { get; set; }
        public virtual TrainingProgram TrainingProgram { get; set; }
    }
}
