using ProductsApp.Models;

namespace ProductsApp.Services
{
    public interface IProductDataService
    {
        List<ProductModel> GetAllProducts();
        List<ProductModel> SerachProducts(string searchIterm);
        ProductModel GetProductById(int id);
        int Insert(ProductModel product);
        int Delete(ProductModel product);
        int Update(ProductModel product);
    }
}
