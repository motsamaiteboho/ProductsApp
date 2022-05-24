using System.ComponentModel.DataAnnotations;

namespace ProductsApp.Models
{
    public class ProductModel
    {
        [Display(Name ="id Number")]
        public int id { get; set; }

        [Display(Name ="Product Name")]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name ="Product Price")]
        public decimal Price { get; set; }

        [Display(Name ="Product Discription")]
        public string Description { get; set; }
    }
}
