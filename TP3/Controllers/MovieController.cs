using Microsoft.AspNetCore.Mvc;
using System.Net;
using TP3.Models;

namespace TP3.Controllers
{
    public class MovieController : Controller
    {
        public readonly AppDbContext _appDbContext;

        public MovieController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            return View(_appDbContext.Movies.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Movie m) {
            m.Id = new Guid();
            string filename = UploadFile(m);
            m.Photo = filename;
            _appDbContext.Movies.Add(m);
            _appDbContext.SaveChanges();
            return RedirectToAction(nameof(Index));


        }
        private string UploadFile(Movie m)
        {
            string file = string.Empty;
            if(m.ImageFile != null) {
                string filePath = Path.Combine( "uploads", Guid.NewGuid().ToString()+m.ImageFile.FileName);
                file = filePath;
                using(var filestream = new FileStream(Path.Combine("wwwroot", filePath), FileMode.Create))
                {
                    m.ImageFile.CopyTo(filestream);
                }
            }
            return file;
        }
    }
}
