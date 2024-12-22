using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;
using ProductApp.Data;

namespace ProductApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Действие для отображения формы добавления товара
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Действие для обработки формы добавления товара
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Create");
            }
            return View(product);
        }

        // Действие для отображения списка товаров
        [HttpGet]
        public IActionResult List()
        {
            var products = _context.Products.ToList();  // Извлекаем все товары
            return View(products);  // Передаем товары в представление
        }
    }
}