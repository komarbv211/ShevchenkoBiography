using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShevchenkoBiography.Models;

namespace ShevchenkoBiography.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Title"] = "Головна";
            return View();
        }

        public ActionResult Biography()
        {
            ViewData["Title"] = "Біографія";
            return View();
        }

        public ActionResult Paintings()
        {
            ViewData["Title"] = "Картини";
            var paintings = GetPaintings();
            return View(paintings);
        }

        private List<Painting> GetPaintings()
        {
            return new List<Painting>
            {
                new Painting { Id = 1, Title = "Катерина", Year = 1842, ImagePath = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6d/%D0%A8%D0%B5%D0%B2%D1%87%D0%B5%D0%BD%D0%BA%D0%BE_%D0%A2._%D0%93._%D0%9A%D0%B0%D1%82%D0%B5%D1%80%D0%B8%D0%BD%D0%B0._1842.jpg/356px-%D0%A8%D0%B5%D0%B2%D1%87%D0%B5%D0%BD%D0%BA%D0%BE_%D0%A2._%D0%93._%D0%9A%D0%B0%D1%82%D0%B5%D1%80%D0%B8%D0%BD%D0%B0._1842.jpg" },
                new Painting { Id = 2, Title = "Циганка-ворожка", Year = 1841, ImagePath = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e0/%D0%A8%D0%B5%D0%B2%D1%87%D0%B5%D0%BD%D0%BA%D0%BE_%D0%A2._%D0%93._%281841%29_%D0%A6%D0%B8%D0%B3%D0%B0%D0%BD%D0%BA%D0%B0-%D0%B2%D0%BE%D1%80%D0%BE%D0%B6%D0%BA%D0%B0.jpg/640px-%D0%A8%D0%B5%D0%B2%D1%87%D0%B5%D0%BD%D0%BA%D0%BE_%D0%A2._%D0%93._%281841%29_%D0%A6%D0%B8%D0%B3%D0%B0%D0%BD%D0%BA%D0%B0-%D0%B2%D0%BE%D1%80%D0%BE%D0%B6%D0%BA%D0%B0.jpg" },
                new Painting { Id = 3, Title = "Автопортрет", Year = 1840, ImagePath = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4f/Taras_Shevchenko_selfportrait_oil_1840-2.jpg/1200px-Taras_Shevchenko_selfportrait_oil_1840-2.jpg" },
                new Painting { Id = 4, Title = "Селянська родина", Year = 1843, ImagePath = "https://upload.wikimedia.org/wikipedia/commons/7/7a/%D0%A8%D0%B5%D0%B2%D1%87%D0%B5%D0%BD%D0%BA%D0%BE_%D0%A2._%D0%93._%281843%29_%D0%A1%D0%B5%D0%BB%D1%8F%D0%BD%D1%81%D1%8C%D0%BA%D0%B0_%D1%80%D0%BE%D0%B4%D0%B8%D0%BD%D0%B0.jpg" },
                new Painting { Id = 5, Title = "Церква всіх святих у Києво-Печерській лаврі", Year = 1846, ImagePath = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0c/Taras_Shevchenko_painting_0144.jpg/1280px-Taras_Shevchenko_painting_0144.jpg" },
                new Painting { Id = 6, Title = "Натурник", Year = 1840, ImagePath = "https://www.t-shevchenko.name/files/THSh/paints/1961-07a/029.jpg" },
                new Painting { Id = 7, Title = "Дари в Чигрині ", Year = 1844, ImagePath = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/be/Taras_Shevchenko_painting_0091.jpg/1024px-Taras_Shevchenko_painting_0091.jpg" },
                new Painting { Id = 8, Title = "На пасіці", Year = 1843, ImagePath = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0e/At_apiary_%28Taras_Shevchenko%29.jpg/800px-At_apiary_%28Taras_Shevchenko%29.jpg" },
                new Painting { Id = 9, Title = "Перерване побачення", Year = 1840, ImagePath = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a4/Taras_Shevchenko_painting_0018.jpg/800px-Taras_Shevchenko_painting_0018.jpg" },
                new Painting { Id = 10, Title = "Портрет Євгена Павловича Гребінки", Year = 1837, ImagePath = "https://upload.wikimedia.org/wikipedia/commons/d/d6/Portrait_of_an_unknown_man_%28Taras_Shevchenko%29.jpg" }
            };
        }
    }
}
