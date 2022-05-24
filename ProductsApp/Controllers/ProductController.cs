using Bogus;
using Microsoft.AspNetCore.Mvc;
using ProductsApp.Models;
using ProductsApp.Services;

namespace ProductsApp.Controllers
{
    public class ProductController : Controller
    {
      
        public IActionResult Index()
        {
            ProductsDAO products = new ProductsDAO();
           
            return View(products.GetAllProducts());
        }

        public IActionResult Searchform()
        {
            return View();
        }
        public IActionResult SearchResults( string searchTerm)
        {
            ProductsDAO products = new ProductsDAO();

            List<ProductModel> productsList = products.SerachProducts(searchTerm);
            
            return View("Index", productsList);
        }
        public IActionResult Edit(int id)
        {
            ProductsDAO products = new ProductsDAO();
            var product = products.GetProductById(id);
            return View("Edit", product);
        }
        public IActionResult ProccessEdit(int id)
        {
            ProductsDAO products = new ProductsDAO();
            var product = products.GetProductById(id);
            products.Update(product);
            return View("Index");
        }

    }
}
