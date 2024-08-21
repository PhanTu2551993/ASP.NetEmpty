using ASP.NetEmpty.Models;

namespace ASP.NetEmpty.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
    }
}
