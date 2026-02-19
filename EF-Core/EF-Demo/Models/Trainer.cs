using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Demo
{
    internal class Trainer
    {
       public int Id { get; set; }

        public string Name { get; set; }

        public int ExperienceYears { get; set; }

        public ICollection<Batch> Batches { get; set; }
    }
}
