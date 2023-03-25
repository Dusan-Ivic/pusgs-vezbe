using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadatak1.Interfaces;
using Zadatak1.Models;

namespace Zadatak1.Services
{
    public class ProfessorService : ISingletonProfessorService
    {
        private List<Professor> professors = new List<Professor>();

        public void CreateProfessor(Professor professor)
        {
            professors.Add(professor);
        }

        public List<Professor> GetAllProfessors()
        {
            return professors;
        }
    }
}
