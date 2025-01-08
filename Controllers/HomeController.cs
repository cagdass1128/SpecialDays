using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OzelGunler.Data;
using OzelGunler.Models;
using System.Diagnostics;

namespace OzelGunler.Controllers
{
    public class HomeController : Controller
    {
        private readonly DaysDbContext daysDbContext;
        public HomeController(DaysDbContext daysDbContext)
        {
            this.daysDbContext = daysDbContext;
        }


        public IActionResult Index()
        {
            var yil = DateTime.Now.Year;
            var ay = DateTime.Now.Month;
            var ayAdi = DateTime.Now.ToString("MMMM");


            var ozelGunler =  daysDbContext.OzelGunler.Where(g => g.Tarih.Year == yil && g.Tarih.Month == ay).ToList();


            ViewBag.AyAd� = ayAdi; //Hangi ayda ise kullan�c�ya vitrinde onu g�sterir.


            return View(ozelGunler);
        }















    }
}