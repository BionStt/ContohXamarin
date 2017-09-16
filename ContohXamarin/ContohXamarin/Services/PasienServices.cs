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

        public async Task TambahPasien(Pasien pasien)
        {
            var strUri = new Uri(Path.Combine(backendUrl, "api/Pasien"));
            var newPasien = JsonConvert.SerializeObject(pasien);
            var content = new StringContent(newPasien, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PostAsync(strUri, content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Status Code:" + response.StatusCode.ToString());
            }
        }

        public async Task UpdatePasien(Pasien pasien)
        {
            var strUri = new Uri(Path.Combine(backendUrl, "api/Pasien/"+pasien.PasienID.ToString()));
            var editPasien = JsonConvert.SerializeObject(pasien);
            var content = new StringContent(editPasien, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PutAsync(strUri, content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Status Code:" + response.StatusCode.ToString());
            }
        }

        public async Task DeletePasien(Pasien pasien)
        {
            var strUri = new Uri(Path.Combine(backendUrl, "api/Pasien/" + pasien.PasienID.ToString()));
            HttpResponseMessage response = await _client.DeleteAsync(strUri);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Status Code:" + response.StatusCode.ToString());
            }
        }
    }
}
