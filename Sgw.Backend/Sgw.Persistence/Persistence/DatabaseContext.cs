using Microsoft.EntityFrameworkCore;
using Sgw.Persistence.DataModels.Post;
using Sgw.Persistence.DataModels.User;

namespace Sgw.Persistence.Persistence;

public class DatabaseContext : DbContext
{
    public DbSet<PostData> Posts { get; set; }
    public DbSet<UserData> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql();
}