using System.Threading.Tasks;

namespace RazorPagesIntegrationTestSample.Services
{
    public interface IQuoteService
    {
        Task<string> GenerateQuote();
    }
}
