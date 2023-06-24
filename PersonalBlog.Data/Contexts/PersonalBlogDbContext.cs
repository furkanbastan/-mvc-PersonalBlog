using System.Reflection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using PersonalBlog.Entity.Entities;
using PersonalBlog.Entity.Entities.Identity;

namespace PersonalBlog.Data.Contexts;

public class PersonalBlogDbContext :IdentityDbContext<AppUser, AppRole, Guid, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>
{
    public PersonalBlogDbContext(DbContextOptions<PersonalBlogDbContext> options) : base(options)
    {
        
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source =C:\\Users\\bbast\\OneDrive\\Masaüstü\\PersonalBlog\\PersonalBlog.Data\\DB\\PersonalBlog.db;");
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<Article> Articles { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<ArticleCategory> ArticleCategories { get; set; }
}
public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<PersonalBlogDbContext>
{
    public PersonalBlogDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<PersonalBlogDbContext> dbContextOptionsBuilder = new();
        dbContextOptionsBuilder.UseSqlite("Data Source =C:\\Users\\bbast\\OneDrive\\Masaüstü\\PersonalBlog\\PersonalBlog.Data\\DB\\PersonalBlog.db;");
        return new(dbContextOptionsBuilder.Options);
    }
}
