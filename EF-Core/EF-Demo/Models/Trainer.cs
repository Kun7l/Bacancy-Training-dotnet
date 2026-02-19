using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Demo
{
    public class Trainer
    {
       public int Id { get; set; }

        public string Name { get; set; }

        public int ExperienceYears { get; set; }

        public virtual ICollection<Batch> Batches { get; set; }
    }
}
