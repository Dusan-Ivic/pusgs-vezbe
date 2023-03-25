using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadatak1.Interfaces;
using Zadatak1.Models;

namespace Zadatak1.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentController : ControllerBase
    {
        private readonly IScopedStudentService _scopedStudentService;
        private readonly IScopedGetterService _scopedGetterService;

        public StudentController(IScopedStudentService scopedStudentService, IScopedGetterService scopedGetterService)
        {
            _scopedStudentService = scopedStudentService;
            _scopedGetterService = scopedGetterService;
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            _scopedStudentService.CreateStudent(student);
            return Ok(_scopedGetterService.GetAllStudents());
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_scopedStudentService.GetAllStudents());
        }
    }
}
