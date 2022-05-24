using Bogus;
using ProductsApp.Models;

namespace ProductsApp.Services
{
    public class HardCodedSampleRepository : IProductDataService
    {
       static  List<ProductModel> productsList = new List<ProductModel>();
        

        public List<ProductModel> GetAllProducts()
        {
            if(productsList.Count == 0)
            {
                productsList.Add(new ProductModel { id = 1, Name = "Mouse Pad", Price = 5.99m, Description = "A square piece of plastic to make a mouse pad" });
                productsList.Add(new ProductModel { id = 2, Name = "Web Cam", Price = 45.99m, Description = "Enables you to attend more Zoom meeting" });
                productsList.Add(new ProductModel { id = 3, Name = "4 TB USB hard drive", Price = 105.99m, Description = "Back up all your work wont be a problem" });
                productsList.Add(new ProductModel { id = 4, Name = "Wireless Mouse Pad", Price = 84.99m, Description = "Notebook using it much easir sudkagjhs sa,dkjs,agf d" });
                for (int i = 0; i < 100; i++)
                {
                    productsList.Add(new Faker<ProductModel>().RuleFor(p => p.id, i + 5)
                        .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                        .RuleFor(p => p.Price, f => f.Random.Decimal(100))
                        .RuleFor(p => p.Description, f => f.Rant.Review()));
                }
            }
            return productsList;
        }

        public ProductModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> SerachProducts(string searchIterm)
        {
            throw new NotImplementedException();
        }
        public int Insert(ProductModel product)
        {
            throw new NotImplementedException();
        }
        public int Delete(ProductModel product)
        {
            throw new NotImplementedException();
        }
        public int Update(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
