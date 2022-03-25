using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BudgetDB_APIAccess_ClassLib.API
{
    public class APIClient
    {

        IConfiguration _configuration;




        private HttpClient _apiClient;
        public HttpClient APIClientObject
        {
            get
            {
                return _apiClient;
            }
        }




        public APIClient(IConfiguration configuration)
        {
            _configuration = configuration;
        }




        private void InitializeClient()
        {
            _apiClient = new HttpClient();
            _apiClient.BaseAddress = new Uri(_configuration.GetConnectionString("BudgetAPI"));
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }


    }
}
