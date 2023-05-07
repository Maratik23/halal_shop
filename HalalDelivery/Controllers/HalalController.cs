using System.Linq;
using Microsoft.AspNetCore.Mvc;
using HalalDelivery.Data;

namespace HalalDelivery.Controllers
{
    public class HalalController : Controller
    {
        private readonly HalalDeliveryDbContext _context;
        
        public HalalController(HalalDeliveryDbContext context)
        {
            _context = context;
        }
        
        [Route("Halal/{id:int}")]
        public IActionResult Index(int id)
        {
            var Halal = _context.Halals.FirstOrDefault(x => x.Id == id);

            return View(Halal);
        }
    }
}