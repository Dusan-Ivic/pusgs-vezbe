using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadatak1.Interfaces;
using Zadatak1.Models.DTO;

namespace Zadatak1.Controllers
{
    [ApiController]
    [Route("api/subjects")]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectService _subjectService;

        public SubjectController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        [HttpGet]
        public IActionResult GetSubjects()
        {
            return Ok(_subjectService.GetAllSubjects());
        }

        [HttpPost]
        public IActionResult CreateSubject(SubjectDTO subjectDTO)
        {
            return Ok(_subjectService.CreateSubject(subjectDTO));
        }
    }
}
