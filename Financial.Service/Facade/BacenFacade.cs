using Financial.Service.Interface;
using Financial.Service.ValueObjects;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Financial.Service
{
    public class BacenFacade : IBacenFacade
    {
        public BacenFacade()
        {

        }


        public async Task<TaxaJuro> GetTaxaJuro()
        {
            try
            {
                HttpClient client = new HttpClient();
                string url = "http://localhost:5000/api/bacen/taxaJuro/";
                //var response = await client.GetStringAsync(url);
                var response = await client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<TaxaJuro>(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
