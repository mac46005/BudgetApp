using System.Net.Http;

namespace BudgetDB_APIAccess_ClassLib.API
{
    public interface IAPIClient
    {
        HttpClient APIClientObject { get; }
    }
}