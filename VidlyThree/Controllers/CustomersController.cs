using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyThree.Models;

namespace VidlyThree.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = getCustomers();

            return View(customers);
        }

        public ActionResult Details(int id) {
            var customer = getCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null) {
                return HttpNotFound();
            }else {
                return View(customer);
            }
        }

        public IEnumerable<Customer> getCustomers() {
            return new List<Customer> {
                new Customer{Id=1, Name="Javier" },
                new Customer{Id=2, Name="Illy" },
                new Customer{Id=3, Name="Jose" },
            };
        }
    }
}