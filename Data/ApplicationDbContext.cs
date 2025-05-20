using Microsoft.EntityFrameworkCore;
using PatientRegistrationService.Models;

namespace PatientRegistrationService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Patient> Patients { get; set; }
    }
}
