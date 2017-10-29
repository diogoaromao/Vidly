using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        List<Movie> movies = new List<Movie>
        {
            new Movie
            {
                Id = 1,
                Name = "Shrek!"
            },
            new Movie
            {
                Id = 2,
                Name = "Finding Nemo!"
            }
        };

        // GET: Movies
        public ActionResult Index()
        {
            return View(movies);
        }

        public ActionResult Detail(int id)
        {
            var movie = movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }
    }
}