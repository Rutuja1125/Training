using Demo.DataModels;
using System.Text.Json.Serialization;

namespace DemoUI.Services
{
    public class ProductService : IProductServices
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Product[]> GetProducts()       
        
        {
         
           var result =  await httpClient.GetFromJsonAsync<Product[]>("api/product/Getproducts");

            return result; 
            
        }
    }
}
