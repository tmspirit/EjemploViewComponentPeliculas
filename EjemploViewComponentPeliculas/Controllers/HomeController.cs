using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EjemploViewComponentPeliculas.Models;
using EjemploViewComponentPeliculas.Repositories;

namespace EjemploViewComponentPeliculas.Controllers
{

    public class HomeController : Controller
    {
        RepositoryPeliculas repo;
        public HomeController(RepositoryPeliculas repo)
        {
            this.repo = repo;
        }
        public IActionResult Index(int genero)
        {
            List<Pelicula> peliculas = repo.GetPeliculasGenero(genero);
            return View(peliculas);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
