using System.Linq;
using Microsoft.AspNetCore.Mvc;
using HalalDelivery.Data;
using HalalDelivery.Models;

namespace HalalDeliverylivery.Controllers
{
    public class CatalogController : Controller
    {
        private readonly HalalDeliveryDbContext _context;
        
        public CatalogController(HalalDeliveryDbContext dbContext)
        {
            _context = dbContext;
        }

        public IActionResult AllProducts()
        {
            var catalog = new AllProductsModel
            {
                Halals = _context.Halals.ToList(), AdditionalProducts = _context.AdditionalProducts.ToList()
            };

            return View(catalog);
        }
    }
}