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

        public async Task DELETEAsync(int ID)
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

        public async Task<User> GETAsync(int ID)
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

        public async Task<IEnumerable<User>> GETAsync()
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

        public async Task POSTAsync(User obj)
        {
            try
            {
                using (HttpResponseMessage respone = await _apiClient.APIClientObject.PostAsJsonAsync("/api/UsersEndPoint/", obj))
                {
                    // TODO: log success?
                    if (respone.IsSuccessStatusCode)
                    {

                    }
                    else
                    {
                        throw new Exception(respone.ReasonPhrase);
                    }
                }
            }
            catch (HttpRequestException ex)
            {

                throw ex;
            }
        }




        public async Task PUTAsync(User obj, int ID)
        {
            throw new NotImplementedException();
        }
    }
}
