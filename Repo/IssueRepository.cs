using DataKodApp.Data;
using DataKodBlazorServer.Data;
using Microsoft.EntityFrameworkCore;


namespace DataKodApp.Repo;
public class IssueRepository : IIssueRepository
{
    private readonly AppDbContext _appDbContext;

    public IssueRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<Issue> AddIssue(Issue issue)
    {
        var result = await _appDbContext.Issues.AddAsync(issue);
        await _appDbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<Issue> GetIssue(string name)
    {
            var result = await _appDbContext.Issues
            .FirstOrDefaultAsync(e => e.FirstName == name);
            return result;
    }

    public async Task<IEnumerable<Issue>> GetIssues()
    {
        return await _appDbContext.Issues.ToListAsync();
    }
}
