using DataKodBlazorServer.Data;
using Microsoft.EntityFrameworkCore;

namespace DataKodApp.Data;
public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    {

    }

    public DbSet<Issue> Issues { get; set; }

}
