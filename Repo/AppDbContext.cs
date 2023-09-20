using DataKodBlazorServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Linq;

namespace DataKodApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            var selectedIssues = Issues
                .Where(issue => issue.FirstName == "Meryem" && issue.Browser=="Opera")
                .OrderBy(issue => issue.BrowserVersion)
                .ToList();

           
            foreach (var issue in selectedIssues)
            {
                Console.WriteLine($"{issue.FirstName} {issue.LastName}");
            }
        }

        public DbSet<Issue> Issues { get; set; }
    }
}
