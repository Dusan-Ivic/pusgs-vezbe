using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadatak1.Models.DTO;

namespace Zadatak1.Interfaces
{
    public interface IProfessorService
    {
        List<ProfessorDTO> GetAllProfessors();
        ProfessorDTO CreateProfessor(ProfessorDTO professorDTO);
    }
}
