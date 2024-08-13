using Microsoft.EntityFrameworkCore;
using Vessels.Models;
namespace Vessels.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Vessel> Vessels { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      modelBuilder.Entity<Vessel>().HasData([
        new Vessel{ Id =1, ArrivalDate = DateTime.Now, DepartureDate= new DateTime(2024, 09, 25), Name = "Ship 1", Status= "Intransit"},
              new Vessel{ Id =3, ArrivalDate = DateTime.Now, DepartureDate= new DateTime(2024, 12, 25), Name = "Ship 2", Status= "Loading"},
              new Vessel{ Id =5, ArrivalDate = DateTime.Now, DepartureDate= new DateTime(2025, 06, 25), Name = "Ship 3", Status= "Docked"},
            ]);
    }
  }
}