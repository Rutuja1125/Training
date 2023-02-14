using Demo.DataModels;

namespace DemoUI.Services
{
    public interface IProductServices
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
