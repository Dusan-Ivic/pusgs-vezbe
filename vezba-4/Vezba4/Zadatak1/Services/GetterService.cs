using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadatak1.Interfaces;
using Zadatak1.Models;

namespace Zadatak1.Services
{
    public class GetterService : IScopedGetterService
    {
        private readonly IScopedStudentService _studentService;

        public GetterService(IScopedStudentService studentService)
        {
            _studentService = studentService;
        }

        public List<Student> GetAllStudents()
        {
            return _studentService.GetAllStudents();
        }
    }
}
