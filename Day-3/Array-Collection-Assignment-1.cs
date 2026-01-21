using Day_3;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Day_3
{
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }

    class Records
    {
        
        int max_student = 5;
        Student[] students = new Student[5];

        // with array
        void addStudentWithArray(string name,int age)
        {
            if (students[max_student - 1] != null) {
                Console.WriteLine("List is full");
            }
            else
            {
                for (int i = 0; i < max_student; i++)
                {
                    if (students[i] == null)
                    {
                        students[i] = new Student { id = i, name = name, age = age };
                        break;
                    }
                }
            }
        }

        Student searchWithIdArray(int id)
        {
            for(int i = 0; i < students.Length; i++)
            {
               if (students[i].id == id)
               {
                  Console.WriteLine($"{students[i].id} {students[i].name} {students[i].age}");
                    return students[i];
               }                
            }
            return null;
        }


        // For - List
        List<Student> list = new List<Student>();

        void addStudentWithList(string name,int age)
        {
            list.Add(new Student {id = list.Count,name = name, age = age});
        }
        Student searchStudentWithIdList(int id)
        {
           return list.Find(s => s.id == id);
        }

        //Dictionary

        Dictionary<int, Student> dict = new Dictionary<int, Student>();

        void addStudentWithDictionary(string name,int age)
        {
            dict.Add(dict.Count, new Student { id = dict.Count, name = name, age = age });
        }

       Student searchStudentWithIdDictionary(int id)
        {
            if (dict.ContainsKey(id))
            {
                return dict[id];
            }
            else
            {
                return null;
            }
        }


        //public static void Main(string[] args)
        //        {
        //            Records r = new Records();

        //            // r.addStudentWithArray( "krunal", 20);
        //            // r.addStudentWithArray( "nil", 20);
        //            // r.addStudentWithArray( "sunny", 20);
        //            // r.addStudentWithArray( "dev", 20);
        //            // r.addStudentWithArray( "shiv", 20);
        //            // r.addStudentWithArray( "raj", 20);
        //            //Student s = r.searchWithIdArray(0);
        //            // s.name = "anjali";
        //            // Console.WriteLine(s.name);

        //            r.addStudentWithList("krunal", 67);
        //            Console.WriteLine(r.list[0].age);
        //            Student listStudent = r.searchStudentWithIdList(0);
        //            listStudent.name = "listName";
        //            Console.WriteLine(listStudent.name);


        //            r.addStudentWithDictionary("Anill", 23);
        //            Console.WriteLine(r.dict[0].name);
        //            Student newStudent = r.searchStudentWithIdDictionary(0);
        //            newStudent.name = "New name";
        //            Console.WriteLine(newStudent.name);

        //        }
    }
}
