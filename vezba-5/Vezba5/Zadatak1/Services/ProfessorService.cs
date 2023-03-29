using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadatak1.Data;
using Zadatak1.Interfaces;
using Zadatak1.Models;
using Zadatak1.Models.DTO;

namespace Zadatak1.Services
{
    public class ProfessorService : IProfessorService
    {
        private readonly FacultyDbContext _dbContext;
        private readonly IMapper _mapper;

        public ProfessorService(FacultyDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public List<ProfessorDTO> GetAllProfessors()
        {
            List<Professor> professors = _dbContext.Professors.Include(x => x.Subjects).ToList();
            return _mapper.Map<List<ProfessorDTO>>(professors);
        }

        public ProfessorDTO CreateProfessor(ProfessorDTO professorDTO)
        {
            Professor professor = _mapper.Map<Professor>(professorDTO);

            _dbContext.Professors.Add(professor);
            _dbContext.SaveChanges();

            return _mapper.Map<ProfessorDTO>(professor);
        }
    }
}
