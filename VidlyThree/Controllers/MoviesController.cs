using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyThree.Models;
using VidlyThree.ViewModels;

namespace VidlyThree.Controllers
{
    public class MoviesController : Controller {
        // GET: Movies/Random
        public ActionResult Random() {

            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer> {
                new Customer{Id=1, Name="Javier" },
                new Customer{Id=2, Name="Illy" },
                new Customer{Id=3, Name="Jose" },
            };

            var viewModel = new RandomViewModel() { Customers = customers, Movie = movie };

            return View(viewModel);

            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home");
        }

        public ActionResult Index() {
            var movies = GetMovies();

            return View(movies);            
        }

        private IEnumerable<Movie> GetMovies() {
             return new List<Movie> {
                new Movie{Id=1, Name="Shrek" },
                new Movie{Id=2, Name="Wall-e" },
            };
        }
    }
}