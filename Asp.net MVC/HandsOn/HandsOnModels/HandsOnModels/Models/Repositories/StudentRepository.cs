using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnModels.Models;
namespace HandsOnModels.Models.Repositories
{
    public class StudentRepository
    {
        public static List<Student> Students = new List<Student>()
        {
            new Student(){Sid=1,Sname="Rohan",DOB=DateTime.Parse("12.2.1998"),Adress="Chennai"},
            new Student(){Sid=2,Sname="Karan",DOB=DateTime.Parse("12.2.1999"),Adress="Hyderabad"},
        };
        public List<Student> GetStudents()
        {
            return Students;
        }
        public Student GetStudent(int sid)
        {
            return Students.SingleOrDefault(i=>i.Sid==sid);
        }
        public void Add(Student student)
        {
            Students.Add(student);
        }
    }
}
