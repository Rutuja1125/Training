using Demo.DataModels;

namespace DemoUI.Services
{
    public interface IProductServices
    {
        Task<Product[]> GetProducts();
    }
}
