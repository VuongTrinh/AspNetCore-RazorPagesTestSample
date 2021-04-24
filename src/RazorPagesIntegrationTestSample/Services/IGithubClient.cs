using System.Threading.Tasks;

namespace RazorPagesIntegrationTestSample.Services
{
    public interface IGithubClient
    {
        Task<GithubUser> GetUserAsync(string userName);
    }
}
