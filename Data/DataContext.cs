using BlogEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogEFCore.Data;

public class DataContext : DbContext
{
    private const string connectionString =
"Data Source=.\\SQLSERVER;Database=Blog;Integrated Security=True;Encrypt=False;";

    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(connectionString);
}
