using Microsoft.EntityFrameworkCore;
using RealEstate.Models;

namespace RealEstate.Data
{
    public class RealEstateContext : DbContext
    {
        public RealEstateContext(DbContextOptions<RealEstateContext> options)
            : base(options) { }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Property> Properties { get; set; }
    }
}
