using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DSED_06_AdoptAPet.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace DSED_06_AdoptAPet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            ViewBag.Welcome = "Welcome";

            ViewBag.Cover = @"/images/coverphoto.jpg";

            ViewBag.UserNew = new User()
            {
                FirstName = "Animal",
                LastName = "Loving Friend"
            };

            //========== COA
            //Gets or sets the absolute path to the directory that contains the web-servable application content files.
            string webRootPath = _webHostEnvironment.WebRootPath;
            FileInfo filePath = new FileInfo(Path.Combine(webRootPath, "COA.txt"));

            string[] lines = System.IO.File.ReadAllLines(filePath.ToString());

            ViewData["Conditions"] = lines;






            return View();
        }


        public IActionResult Blog()
        {

            string webRootPath = _webHostEnvironment.WebRootPath;
            FileInfo filePath = new FileInfo(Path.Combine(webRootPath, "Video1.txt"));
            FileInfo filePath2 = new FileInfo(Path.Combine(webRootPath, "Video2.txt"));

            string[] lines = System.IO.File.ReadAllLines(filePath.ToString());
            string[] lines2 = System.IO.File.ReadAllLines(filePath2.ToString());

            ViewData["Video1"] = lines;
            ViewData["Video2"] = lines2;


            return View();
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
