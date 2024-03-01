using AssessmentDemousinglist.Modal;
using Microsoft.EntityFrameworkCore;
using System;

namespace AssessmentDemousinglist.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employee { get; set; }
    }
}
