using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zadatak1.Models
{
    public class Subject
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Semester { get; set; }
        public long ProfessorId { get; set; }
        public Professor Professor { get; set; }
    }
}
