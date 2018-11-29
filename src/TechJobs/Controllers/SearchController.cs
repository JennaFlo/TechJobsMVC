using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }
        /*
        // TODO #1 - Create a Results action method to process*/
        [HttpPost]
        [Route("/Home/Search")]
        public IActionResult Search(string job)
        {
            ListController.columnChoices(job);
            return View("/Home/Search");
        }


        //* search request and display results
        
        /*[HttpPost]
        [Route("/Home/Search")]
        public IActionResult SearchResults(string name)
        {
            //display the search results
            ListController.columnChoices(name)

            return Redirect("/Home");
        } */
        

    }
}
