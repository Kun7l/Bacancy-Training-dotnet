
using Microsoft.EntityFrameworkCore;

namespace EF_Demo
{
    internal class Repository
    {
        private readonly AppDbContext _context;
        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void AddCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public List<Student> ShowAllStudents()
        {
            return _context.Students.ToList();
        }

        public List<Course> ShowAllCourses()
        {
            return _context.Courses.ToList();
        }

        public void EnrollStudentInCourse(int studentId, int courseId)
        {
            var student = _context.Students.Include(s => s.courses).First(s => s.Id == studentId);
            var course = _context.Courses.First(c => c.Id == courseId);


            student.courses.Add(course);

            _context.SaveChanges();
        }

        public void CreateBatch(int courseId, int trainerId,DateOnly StartDate)
        {

            _context.Batches.Add(new Batch { CourseId = courseId,TrainerId = trainerId,StartDate = StartDate});
            
            _context.SaveChanges();
        }

        public void ShowCourseWithStudents(int CourseId)
        {
            var course = _context.Courses.Include(c => c.Students).First(c => c.Id == CourseId);


            Console.WriteLine(course.Title);
            foreach (var student in course.Students)
            {
                Console.WriteLine(student.Name);
            }
        }

        public void ShowTrainerWithBatches(int TrainerId)
        {
            var trainer = _context.Trainers.Include(t => t.Batches).First(t => t.Id == TrainerId);

            Console.WriteLine(trainer.Name);
            foreach (var item in trainer.Batches)
            {
                Console.WriteLine("Batch Id : "+item.Id);
            }
        }
    }
}
