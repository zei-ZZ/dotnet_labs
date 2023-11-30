using Microsoft.AspNetCore.Mvc;
using TP1.Models;

namespace TP1.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            Movie movie = new Movie()
            {
                Name =
            "movie 1"
            };
            List<Movie> movies = new List<Movie>()
                {
                new Movie{Name="movie 2"},
                new Movie{Name="movie 3"},
                };
            return View(movies);
        }
        public IActionResult Edit(int id)
        {
            return Content("Test Id" + id);
        }
        public IActionResult released(int month,int year) {
            return Content("Test release month and year" + month + " " + year); 
       }
    }
}
