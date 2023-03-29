using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Zadatak1.Interfaces;
using Zadatak1.Models.DTO;

namespace Zadatak1.Controllers
{
    [ApiController]
    [Route("api/professors")]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorService _professorService;

        public ProfessorController(IProfessorService professorService)
        {
            _professorService = professorService;
        }

        [HttpGet]
        public IActionResult GetProfessors()
        {
            return Ok(_professorService.GetAllProfessors());
        }

        [HttpPost]
        public IActionResult CreateProfessor(ProfessorDTO professorDTO)
        {
            return Ok(_professorService.CreateProfessor(professorDTO));
        }
    }
}
