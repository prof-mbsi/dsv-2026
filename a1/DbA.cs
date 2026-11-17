using Microsoft.EntityFrameworkCore;

public class DbA : DbContext
{
    public DbA(
        DbContextOptions<DbA> options)
        : base(options)
    {
    }

    public DbSet<ClA> TbA { get; set; }

    public DbSet<ClB> TbB { get; set; }

    public DbSet<ClC> TbC { get; set; }
}