using Microsoft.EntityFrameworkCore;

namespace EauClaireSalon.Models
{
  public class EauClaireSalonContext : DbContext
  {
    public DbSet<Stylist> Stylists { get; set; }
    public DbSet<Client> Clients { get; set; }

    public EauClaireSalonContext(DbContextOptions options) : base(options) { }
  }
}
