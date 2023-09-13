using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data.Entities;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyShopDataContext _context;
        public HomeController(MyShopDataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
		public IActionResult Product()
		{
			return View();
		}
		[HttpGet]
        public IActionResult AddUpdateUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUpdateUser(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
            return View(user);
        }
    }
}
