using Budget_ClassLib.Models;
using BudgetDB_APIAccess_ClassLib.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BudgetDB_APIAccess_ClassLib.API
{
    public class UsersDataEndpoint : IAPIEndpoint<User, int>
    {


        IAPIClient _apiClient;
        public UsersDataEndpoint(IAPIClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task DeleteAsync(int ID)
        {
            try
            {
                
                using (HttpResponseMessage response = await _apiClient.APIClientObject.PostAsJsonAsync("api/UsersEndpoint", ID))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        // TODO: Log success?
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            catch (HttpRequestException ex)
            {

                throw ex;
            }
        }

        public async Task<User> GetAsync(int ID)
        {
            try
            {
                using (HttpResponseMessage response = await _apiClient.APIClientObject.GetAsync($"api/UsersDataEndpoint/{ID}"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        User user = await response.Content.ReadAsAsync<User>();
                        return user;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            catch (HttpRequestException ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<User>> GetAsync()
        {
            try
            {
                using (HttpResponseMessage response = await _apiClient.APIClientObject.GetAsync("/api/UsersEndPoint"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        IEnumerable<User> users = await response.Content.ReadAsAsync<IEnumerable<User>>();
                        return users;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            catch (HttpRequestException ex)
            {

                throw ex;
            }
        }

        public async Task PostAsync(User obj)
        {
            try
            {
                using (HttpResponseMessage respone = await _apiClient.APIClientObject.PostAsJsonAsync("api/UsersEndPoint", obj))
                {
                    // TODO: log success?
                }
            }
            catch (HttpRequestException ex)
            {

                throw ex;
            }
        }




        public async Task PutAsync(User obj, int ID)
        {
            throw new NotImplementedException();
        }
    }
}
