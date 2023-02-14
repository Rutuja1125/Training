using Demo.DataModels;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using System.Text.Json;
using Newtonsoft.Json;

namespace DemoUI.Services
{
    public class ProductService : IProductServices
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var result = await httpClient.GetAsync("api/product/GetProduct");
            //string jsonString = JsonSerializer.Serialize(result);
            //List<string> strings = new List<string>();
            //foreach (var item in jsonString.Split(','))
            //{
            //    strings.Add(item);
            //}
            //return (IEnumerable<Product>)strings;
            var result1 = await result.Content.ReadAsStringAsync();
            var display = JsonConvert.DeserializeObject<List<Product>>(result1);
            return display;
        }
    }
}
