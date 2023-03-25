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
    [Route("api/professors")]
    public class ProfessorController : ControllerBase
    {
        private readonly ISingletonProfessorService _singletonProfessorService;

        public ProfessorController(ISingletonProfessorService singletonProfessorService)
        {
            _singletonProfessorService = singletonProfessorService;
        }

        [HttpPost]
        public IActionResult CreateProfessor(Professor professor)
        {
            _singletonProfessorService.CreateProfessor(professor);
            return Ok(_singletonProfessorService.GetAllProfessors());
        }

        [HttpGet]
        public IActionResult GetProfessors()
        {
            return Ok(_singletonProfessorService.GetAllProfessors());
        }
    }
}
