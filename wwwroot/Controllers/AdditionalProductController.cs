using System.Linq;
using Microsoft.AspNetCore.Mvc;
using HalalDelivery.Data;

namespace HalalDelivery.Controllers
{
    public class AdditionalProductController : Controller
    {
        private readonly HalalDeliveryDbContext _context;

        public AdditionalProductController(HalalDeliveryDbContext context)
        {
            _context = context;
        }

        [Route("AdditionalProduct/{id:int}")]
        public IActionResult Index(int id)
        {
            var product = _context.AdditionalProducts.FirstOrDefault(x => x.Id == id);
            
            return View(product);
        }
    }
}