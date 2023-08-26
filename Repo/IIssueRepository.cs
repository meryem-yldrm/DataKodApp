using DataKodBlazorServer.Data;

namespace DataKodApp.Repo;
public interface IIssueRepository
{
        Task<IEnumerable<Issue>> GetIssues();
        Task<Issue> GetIssue(string name);
        Task<Issue> AddIssue(Issue issue);
}
