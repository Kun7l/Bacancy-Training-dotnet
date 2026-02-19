
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EF_Demo
{
    internal class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public Double Fees { get; set; }
        public int DurationInMonths { get; set; }

        public ICollection<Batch> Batches { get; set; }

        public ICollection<Student> Students { get; set; }

    }
}
