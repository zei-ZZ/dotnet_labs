using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TP3.Models;

namespace TP3.Controllers
{
    public class CustomerController : Controller
    {
        private readonly AppDbContext _db;

        public CustomerController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Customers.ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Errors = ModelState.Values
.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            var members = _db.MembershipTypes.ToList();
            ViewBag.member = members.Select(members => new SelectListItem()
            {
                Text = members.Name,
                Value = members.Id.ToString()
            });
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer c)
        {
            if (!ModelState.IsValid)
            {
                var members = _db.MembershipTypes.ToList();
                ViewBag.member = members.Select(member => new SelectListItem()
                {
                    Text = member.Name,
                    Value = member.Id.ToString()

                });
                return View();
            }
            c.Id = new Guid();
            _db.Customers.Add(c);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
