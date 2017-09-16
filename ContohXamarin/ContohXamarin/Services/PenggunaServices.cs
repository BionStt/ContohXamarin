using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

using System.Net.Http;

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

        public async Task<bool> Login()
    }
}
