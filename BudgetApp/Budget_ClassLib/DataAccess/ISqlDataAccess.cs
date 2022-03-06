
namespace Budget_ClassLib.DataAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string connectionName, string storedProcedure,U parameter = default);
        Task ModifyData<T, U>(string connectionName, string storedProcedure, U parameter = default);
    }
}