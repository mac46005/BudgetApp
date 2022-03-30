using System.Net.Http;

namespace BudgetDB_APIAccess_ClassLib.API
{
    /// <summary>
    /// Contacts the api with the given URL
    /// </summary>
    public interface IAPIClient
    {
        HttpClient APIClientObject { get; }
    }
}