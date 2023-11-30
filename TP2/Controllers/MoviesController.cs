using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TP2.Models;

namespace TP2.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationdbContext _context;

        public MoviesController(ApplicationdbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var movies=_context.movies.ToList();
            return View(movies);
        }
        public IActionResult Create()

        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Movie movie)
        {
            _context.movies.Add(movie);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Movie movie)
        {
            _context.movies.Update(movie);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete() {  return View(); }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var m = _context.movies.Find(id);
            if (m is not null)
            {
                _context.movies.Remove(m);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
