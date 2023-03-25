using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadatak1.Interfaces;
using Zadatak1.Models;

namespace Zadatak1.Services
{
    public class StudentService : IScopedStudentService
    {
        private List<Student> students = new List<Student>();

        public void CreateStudent(Student student)
        {
            students.Add(student);
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }
    }
}
