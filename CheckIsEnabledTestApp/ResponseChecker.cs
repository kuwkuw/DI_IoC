using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Ninject;

namespace CheckIsEnabledTestApp
{
    class ResponseChecker
    {
        private ILoger _loger = new ConsoleLoger();
        [Inject]
        public ILoger Loger
        {
            get { return _loger; }
            set { _loger = value; }
        }

        HttpClient _httpClient;
        public ResponseChecker()
        {
            _httpClient = new HttpClient();   
        }

        public async  void CheckResponse(string resourceUrl)
        {
            try
            {
                Console.WriteLine("Connection...");
                var response = await _httpClient.GetAsync(resourceUrl);
                response.EnsureSuccessStatusCode();
                Console.WriteLine("Connection Ok");
                Loger.Log(ResponseStatus.Ok, resourceUrl);
            }
            catch (Exception)
            {
                Console.WriteLine("Connection fail.");
                Loger.Log(ResponseStatus.Error, resourceUrl);
            }

            
        }
    }
}
