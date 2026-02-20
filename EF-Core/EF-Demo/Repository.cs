
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

        // ----- Student Services -----

        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
        public List<Student> ShowAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student? SelectStudent(int studentId)
        {
            return _context.Students.SingleOrDefault(s=>s.Id == studentId);
        }
        public void UpdateStudent(int studentId,string? newName,string? newEmail)
        {
            var student = _context.Students.SingleOrDefault(s => s.Id == studentId);
            if(student != null)
            {
                if(newName != null)
                {
                    student.Name = newName;
                }
                if (newEmail != null)
                {
                    student.Email = newEmail;
                }
                var state = _context.Entry(student).State;
                Console.WriteLine(state);
                _context.SaveChanges();
                state = _context.Entry(student).State;
                Console.WriteLine(state);
            }
            else
            {
                Console.WriteLine("Student for Id "+studentId+" cannot be found.");
            }
        }
        public void UpdateStudentEmail(int studentId,string Email)
        {
            var student = _context.Students.SingleOrDefault(s => s.Id == studentId);
            if (student != null)
            {
                student.Email = Email;
                var state = _context.Entry(student).State;
                Console.WriteLine(state);
                _context.SaveChanges();
                state = _context.Entry(student).State;
                Console.WriteLine(state);
            }
            else
            {
                throw new StudentNotFound("Student for Id : " + studentId + "  cannot be found");
            }

        }
        public void EnrollStudentInCourse(int studentId, int courseId)
        {
            var student = _context.Students.Include(s => s.courses).First(s => s.Id == studentId);
            var course = _context.Courses.First(c => c.Id == courseId);


            student.courses.Add(course);

            _context.SaveChanges();
        }



        //----- Course Services -----

        public void AddCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

       
        public List<Course> ShowAllCourses()
        {
            return _context.Courses.ToList();
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

        //----- Trainer Services -----

        public void AddTrainer(string name, int experienceInYears)
        {
            _context.Trainers.Add(new Trainer { Name = name, ExperienceYears = experienceInYears });
            _context.SaveChanges();
        }
        public void DeleteTrainer(int trainerId)
        {
            var trainer = _context.Trainers.SingleOrDefault(t=>t.Id == trainerId);

            if (trainer != null)
            {
                _context.Trainers.Remove(trainer);
                var state = _context.Entry(trainer).State;

                Console.WriteLine(state);

                _context.SaveChanges();
                state = _context.Entry(trainer).State;
                Console.WriteLine(state);
                Console.WriteLine(trainer.Name);
            }
            else
            {
                Console.WriteLine("Trainer for Id: "+trainerId+" not found");
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

        public void EagerLoadingExample(int studentId)
        {
            var student = _context.Students.Include(s => s.courses).ThenInclude(c => c.Batches).FirstOrDefault(s=>s.Id == studentId);
            var totalBatches = student.courses.SelectMany(c => c.Batches).Count();

            Console.WriteLine(student.Name +" Has enrolled in "+ student.courses.Count() + " Courses and "+ totalBatches +" Batches");

        }

        public void ExplicitLoading(int studentId)
        {
            var student = _context.Students.SingleOrDefault(s => s.Id == studentId);

            _context.Entry(student).Collection(s => s.courses).Load();

            Console.WriteLine(student.Name);
            foreach (var item in student.courses)
            {
                Console.WriteLine(item.Title);
            }
        }
        public void AttachAndDetachState(int studentId)
        {
            //Student is not tracked because using AsNotracking
            var student = _context.Students.AsNoTracking().FirstOrDefault(s=>s.Id == studentId);
            // Checking state : Detached
            Console.WriteLine(_context.Entry(student).State);
            Console.WriteLine($"Student name before updation : {student.Name}");

            student.Name = "Deep";

            //Now mannually attaching it
            _context.Entry(student).State = EntityState.Modified;

            _context.SaveChanges();

            student = _context.Students.FirstOrDefault(s => s.Id == studentId);
            Console.WriteLine($"Student name after updation : {student.Name}");
        }
        public void AsNoTrackignExample(int studentId)
        {
            var student = _context.Students.AsNoTracking().FirstOrDefault(s => s.Id == studentId);

            Console.WriteLine($"Student name before updation : {student.Name}");

            //Updating student name 
            student.Name = "Updated name";

            _context.SaveChanges();

            //fetching again after updation
            student = _context.Students.FirstOrDefault(s => s.Id == studentId);

            Console.WriteLine($"Student name after updation : {student.Name}");   
        }

        public void LazyLoading(int trainedId)
        {
            var trainer = _context.Trainers.FirstOrDefault(t => t.Id == trainedId);

            Console.WriteLine(trainer.Batches.Count());

        }
        public void NplusOne()
        {
            //without include 
            var courses = _context.Courses.ToList();

            foreach (var course in courses)
            {
                Console.WriteLine(course.Title);
                Console.WriteLine("Enrolled student in "+course.Title);
                foreach (var student in course.Students)
                {
                    Console.WriteLine(student.Name);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
           
            //with include
            var result = _context.Courses.Include(c => c.Students);

            foreach (var course in result)
            {
                Console.WriteLine(course.Title);
                Console.WriteLine("Enrolled student in " + course.Title);
                foreach (var student in course.Students)
                {
                    Console.WriteLine(student.Name);
                }
                Console.WriteLine();
            }
        }
    }
}
