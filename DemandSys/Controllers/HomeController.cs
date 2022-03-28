using DemandSys.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;

namespace DemandSys.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            /*            
             *            Codigo = codigo;
            Tipo = tipo;
            Link = link;
            Titulo = titulo;*/
            List<Home> listHome = new List<Home>();
            listHome.AddRange(new List<Home> {
                new Home(1,"pesquisa", "google.com","google"),
                new Home(2,"video", "youtube.com", "youtube"),
                new Home(3,"site", "yahoo.com", "yahoo"),
                new Home(4,"site", "kabum.com", "kabum"),
                new Home(5,"site", "aliexpress.com", "aliexpress"),
                new Home(6,"site", "shopee.com", "shopee"),
                new Home(7,"site", "macoratti.com", "macoratti"),
                new Home(8,"pesquisa", "google.com","google"),
                new Home(9,"video", "youtube.com", "youtube"),
                new Home(10,"site", "yahoo.com", "yahoo"),
                new Home(11,"site", "kabum.com", "kabum"),
                new Home(12,"site", "aliexpress.com", "aliexpress"),
                new Home(13,"site", "shopee.com", "shopee"),
                new Home(14,"site", "macoratti.com", "macoratti"),
                new Home(15,"pesquisa", "google.com","google"),
                new Home(16,"video", "youtube.com", "youtube"),
                new Home(17,"site", "yahoo.com", "yahoo"),
                new Home(18,"site", "kabum.com", "kabum"),
                new Home(19,"site", "aliexpress.com", "aliexpress"),
                new Home(20,"site", "shopee.com", "shopee"),
                new Home(21,"site", "macoratti.com", "macoratti"),
                new Home(22,"pesquisa", "google.com","google"),
                new Home(23,"video", "youtube.com", "youtube"),
                new Home(24,"site", "yahoo.com", "yahoo"),
                new Home(25,"site", "kabum.com", "kabum"),
                new Home(26,"site", "aliexpress.com", "aliexpress"),
                new Home(27,"site", "shopee.com", "shopee"),
                new Home(28,"site", "macoratti.com", "macoratti"),
                new Home(29,"pesquisa", "google.com","google"),
                new Home(30,"video", "youtube.com", "youtube"),
                new Home(31,"site", "yahoo.com", "yahoo"),
                new Home(32,"site", "kabum.com", "kabum"),
                new Home(33,"site", "aliexpress.com", "aliexpress"),
                new Home(34,"site", "shopee.com", "shopee"),
                new Home(35,"site", "macoratti.com", "macoratti"),

            });
            return View(listHome);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
