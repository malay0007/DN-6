using Microsoft.AspNetCore.Mvc;
using DN_6.Models;
using System.Collections.Generic;
using System.Linq;

namespace DN_6.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 45000, Category = "Electronics" },
                new Product { Id = 2, Name = "Mobile", Price = 20000, Category = "Electronics" },
                new Product { Id = 3, Name = "Headphones", Price = 1500, Category = "Accessories" },
                new Product { Id = 4, Name = "Keyboard", Price = 800, Category = "Accessories" }
            };

            return View(products);
        }

        public IActionResult Details(int id)
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 45000, Category = "Electronics" },
                new Product { Id = 2, Name = "Mobile", Price = 20000, Category = "Electronics" },
                new Product { Id = 3, Name = "Headphones", Price = 1500, Category = "Accessories" },
                new Product { Id = 4, Name = "Keyboard", Price = 800, Category = "Accessories" }
            };

            Product? product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}