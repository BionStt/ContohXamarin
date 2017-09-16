using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using ContohXamarin.Models;
using System.IO;
using Newtonsoft.Json;

namespace ContohXamarin.Services
{
    public class PasienServices
    {
        private const string backendUrl = "http://actualwebapi.azurewebsites.net/";
        private HttpClient _client;

        public PasienServices()
        {
            _client = new HttpClient();
        }

        public async Task<List<Pasien>> GetAllPasien()
        {
            var strUri = new Uri(Path.Combine(backendUrl, "api/Pasien"));
            var response = await _client.GetAsync(strUri);
            if (response.IsSuccessStatusCode)
            {
                var results = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<Pasien>>(results);
                return data;
            }
            else
            {
                throw new Exception("Status Code:" + response.StatusCode.ToString());
            }
        }
    }
}
