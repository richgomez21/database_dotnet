using Microsoft.EntityFrameworkCore;
using WebsiteBlogs.Models;

namespace WebsiteBlogs.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Blog> Blogs {get; set;}
    public DbSet<Comment> Comments {get; set;}
    public DbSet<Post> Posts {get; set;}
    public DbSet<Tag> Tags {get; set;}
    public DbSet<User> Users {get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=websiteblogs.db");
}