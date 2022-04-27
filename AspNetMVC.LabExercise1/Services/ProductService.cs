using AspNetMVC.LabExercise1.Models;
using System.Collections.Generic;

namespace AspNetMVC.LabExercise1.Services
{
    public class ProductService
    {
        private List<Product> _products;
        public ProductService()
        {
            _products = new List<Product>();
            CreateProducts();
        }

        public void CreateProducts()
        {
            _products.Add(new Product()
            {
                Id = 1,
                Name = "Apple",
                Description = "Sweet and Sour red fruit",
                Quantity = 5,
                Price = 30
            });
            _products.Add(new Product()
            {
                Id = 2,
                Name = "Orange",
                Description = "Has a sweet-tart taste and is color orange",
                Quantity = 10,
                Price = 25
            });
            _products.Add(new Product()
            {
                Id = 3,
                Name = "Avocado",
                Description = "Violet Outside, green inside",
                Quantity = 3,
                Price = 50
            });
            _products.Add(new Product()
            {
                Id = 4,
                Name = "Jackfruit",
                Description = "Big spiky fruit",
                Quantity = 2,
                Price = 300
            });
            _products.Add(new Product()
            {
                Id = 5,
                Name = "Melon",
                Description = "Smells good. Good to make juice",
                Quantity = 20,
                Price = 120
            });
        }

        public List<Product> GetCatalog()
        {
            return _products;
        }
        public decimal GetGrandTotal()
        {
            decimal total = 0;
            foreach(var product in _products)
            {
                total += product.TotalAmount;
            }
            return total;
        }
    }
}
