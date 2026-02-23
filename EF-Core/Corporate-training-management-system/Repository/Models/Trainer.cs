using System;
using System.Collections.Generic;
using System.Text;

namespace Corporate_training_management_system.Repository.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> ExpertiesLevel { get; set; }

        public virtual ICollection<TrainingProgram> TrainingPrograms { get; set; }
    }
}
