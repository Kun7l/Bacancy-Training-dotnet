
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EF_Demo
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public Double Fees { get; set; }
        public int DurationInMonths { get; set; }

        public virtual ICollection<Batch> Batches { get; set; }

        public virtual ICollection<Student> Students { get; set; }

    }
}
