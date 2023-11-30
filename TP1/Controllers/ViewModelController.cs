using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using TP1.Models;

namespace TP1.Controllers
{
    public class ViewModelController : Controller
    {
        
        public IActionResult Index()
        {
            var movieViewModel = new ViewModel
            {
                Movie = new Movie { Name = "movie1" },
                Customers = new List<Customer>
            {
                new Customer {Name="customer1"},
                new Customer {Name="customer2"}

            }
            };
            return View(movieViewModel);
        }
        public IActionResult CustomerDetails(int id)
        {
            // Logique pour récupérer les détails du client par son Id
            

    return View(customer);
        }
    }
}
