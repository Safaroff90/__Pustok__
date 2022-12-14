
using _Pustok.DAL;
using _Pustok.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace _Pustok.Controllers
{
    public class HomeController : Controller
    {
        private readonly PustokContext _context;

        public HomeController(PustokContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {

            HomeViewModel homeVM = new HomeViewModel
            {
                SpecialBooks = _context.Books.Include(x => x.Author).Where(x => x.IsSpecial).Take(20).ToList(),
                NewBooks = _context.Books.Include(x => x.Author).Where(x => x.IsNew).Take(20).ToList(),
                DiscountedBooks = _context.Books.Include(x => x.Author).Where(x => x.DiscountPercent > 0).Take(20).ToList()
            };
            return View(homeVM);
        }

    }
}