using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadatak1.Models;

namespace Zadatak1.Data
{
    public class FacultyDbContext : DbContext
    {
        public FacultyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Professor> Professors { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
