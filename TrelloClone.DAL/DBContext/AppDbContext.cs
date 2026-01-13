using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TrelloClone.DAL.Entities;

namespace TrelloClone.DAL.DBContext;

public class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Board> Boards { get; set; }
    public virtual DbSet<Card>  Cards { get; set; }
    public virtual DbSet<List> Lists { get; set; }

    private string GetConnectionString()
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
        return configuration.GetConnectionString("DefaultConnectionString") ?? string.Empty;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(GetConnectionString());
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Set up ràng buộc dữ liệu
        //Fluent API
    }
}