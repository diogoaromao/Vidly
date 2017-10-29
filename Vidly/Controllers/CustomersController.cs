using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer>
        {
            new Customer
            {
                Id = 1,
                Name = "Diogo Romão"
            },
            new Customer
            {
                Id = 2,
                Name = "Rita Matias"
            }
        };

        // GET: Customers
        public ActionResult Index()
        {
            return View(customers);
        }

        public ActionResult Detail(int id)
        {
            var customer = customers.Where(c => c.Id == id).FirstOrDefault();

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}