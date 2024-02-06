using BlogEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogEFCore.Data;

public class DataContext : DbContext
{
    private const string connectionString =
"Data Source=.\\SQLSERVER;Database=BlogEFCore;Integrated Security=True;Encrypt=False;";

    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserRole> UsersRoles { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<PostTag> PostsTags { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(connectionString);
}
