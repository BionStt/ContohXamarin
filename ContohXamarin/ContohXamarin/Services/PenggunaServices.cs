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
    public class PenggunaServices
    {
        private const string backendUrl = "http://actualwebapi.azurewebsites.net/";
        private HttpClient _client;

        public PenggunaServices()
        {
            _client = new HttpClient();
        }

        public async Task<bool> Login(Pengguna pengguna)
        {
            var strUri = new Uri(Path.Combine(backendUrl, "api/Pengguna/Login"));
            var jsonPengguna = JsonConvert.SerializeObject(pengguna);
            var content = new StringContent(jsonPengguna, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PostAsync(strUri, content);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                bool isValid = Convert.ToBoolean(result);
                return isValid;
            }
            return false;
        }


    }
}
