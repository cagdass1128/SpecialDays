using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OzelGunler.Data;
using OzelGunler.Models;

namespace OzelGunler.Controllers
{
    public class AdminController : Controller
    {
        private readonly DaysDbContext daysDbContext;

        public AdminController(DaysDbContext daysDbContext)
        {
            this.daysDbContext = daysDbContext;
        }

        public async Task<IActionResult> Index()
        {
            return View(await daysDbContext.OzelGunler.ToListAsync());
        }

        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SpecialDays specialDay)
        {
            if (ModelState.IsValid)
            {
                daysDbContext.Add(specialDay);
                await daysDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(specialDay);

        }












    }
}