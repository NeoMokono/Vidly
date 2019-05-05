using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            //1. instance of the movie model
            var movie = new Movie() { Name = "shrek" }; 
            return View(movie);
        }
    }
}