using Microsoft.EntityFrameworkCore;
using CarInsurance.Models;

namespace CarInsurance.Data
{
    public class InsuredContext : DbContext
    {
        public InsuredContext(DbContextOptions<InsuredContext> options) : base(options)
        {
        }
        public DbSet<Insuree> Insuree { get; set; }               
    }
}
