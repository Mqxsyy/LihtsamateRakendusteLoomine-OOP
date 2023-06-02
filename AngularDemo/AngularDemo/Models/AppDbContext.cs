using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    private readonly DbContextOptions _options;
    public AppDbContext(DbContextOptions options) : base(options)
    {
        _options = options;
    }

    public DbSet<member> members { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}