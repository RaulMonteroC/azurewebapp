using Microsoft.EntityFrameworkCore;

namespace AzureApp.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Person> People { get; set; }
}