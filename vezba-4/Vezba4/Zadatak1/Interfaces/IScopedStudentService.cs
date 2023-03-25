using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadatak1.Models;

namespace Zadatak1.Interfaces
{
    public interface IScopedStudentService
    {
        void CreateStudent(Student student);
        List<Student> GetAllStudents();
    }
}
