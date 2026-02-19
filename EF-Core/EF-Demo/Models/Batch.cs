using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EF_Demo
{
    internal class Batch
    {
        [Key]
        public int Id { get; set; }
        public DateOnly StartDate { get; set; }

        [ForeignKey("CourseId")]
        public int CourseId {  get; set; }
        public Course Course { get; set; }

        [ForeignKey("trainerId")]
        public int TrainerId { get; set; }

        public Trainer Trainer { get; set; }


    }
}
