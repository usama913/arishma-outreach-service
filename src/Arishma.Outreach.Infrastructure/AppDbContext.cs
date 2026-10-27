using Microsoft.EntityFrameworkCore;
using Arishma.Outreach.Domain;
namespace Arishma.Outreach.Infrastructure;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Campaign> Campaigns => Set<Campaign>();
    protected override void OnModelCreating(ModelBuilder b)
    {
        b.Entity<Campaign>().ToTable("campaigns");
        base.OnModelCreating(b);
    }
}
