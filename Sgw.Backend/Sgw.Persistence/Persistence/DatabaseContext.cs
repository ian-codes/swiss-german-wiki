using Microsoft.EntityFrameworkCore;
using Sgw.Persistence.Entities.Post;
using Sgw.Persistence.Entities.User;

namespace Sgw.Persistence.Persistence;

public class DatabaseContext : DbContext
{
    public DbSet<PostEntity> Posts { get; set; }
    public DbSet<UserEntity> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql();
}