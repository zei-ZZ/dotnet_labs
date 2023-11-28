using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;
using TP4.Models;
using TP4.Services;

namespace TP4.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IMembershipTypeService _membershipTypeService;

        public CustomerController(ICustomerService customerService, IMembershipTypeService membershipTypeService)
        {
            _customerService = customerService;
            _membershipTypeService = membershipTypeService;
        }

        public IActionResult Index()
        {
            var customers = _customerService.GetAllCustomers();
            return View(customers);
        }

        public IActionResult Create()
        {
            ViewBag.Errors = ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage)
                .ToList();

            var members = _membershipTypeService.GetAllMemebershipTypes();
            ViewBag.Member = members.Select(member => new SelectListItem()
            {
                Text = member.Name,
                Value = member.Id.ToString()
            });

            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer c)
        {
            if (!ModelState.IsValid)
            {
                var members = _membershipTypeService.GetAllMemebershipTypes();
                ViewBag.Member = members.Select(member => new SelectListItem()
                {
                    Text = member.Name,
                    Value = member.Id.ToString()
                });

                return View();
            }

            c.Id = Guid.NewGuid();
            _customerService.AddCustomer(c);
            return RedirectToAction(nameof(Index));
        }
    }
}
