using CrMVDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrMVDemo.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult Register()
        {
            Customer c = new Customer();
            return View(c);
        }
        public ViewResult AddCustomer()
        {
            Customer c = new Customer();
            return View(c);
        }
    }
}
