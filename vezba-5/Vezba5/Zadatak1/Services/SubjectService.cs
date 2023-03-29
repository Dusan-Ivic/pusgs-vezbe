using AutoMapper;
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
    public class SubjectService : ISubjectService
    {
        private readonly FacultyDbContext _dbContext;
        private readonly IMapper _mapper;

        public SubjectService(FacultyDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public List<SubjectDTO> GetAllSubjects()
        {
            List<Subject> subjects = _dbContext.Subjects.ToList();
            return _mapper.Map<List<SubjectDTO>>(subjects);
        }

        public SubjectDTO CreateSubject(SubjectDTO subjectDTO)
        {
            Subject subject = _mapper.Map<Subject>(subjectDTO);

            _dbContext.Subjects.Add(subject);
            _dbContext.SaveChanges();

            return _mapper.Map<SubjectDTO>(subject);
        }
    }
}
