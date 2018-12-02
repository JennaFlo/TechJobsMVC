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
        
       
        public IActionResult Results(string searchType, string searchTerm)
        {
            ViewBag.title = "Search";
            //jobdata class-methods: Load data method: 
            if (searchTerm == null && searchType.Equals("all"))
            {
                ViewBag.jobs = JobData.FindAll();
            }
            else if(searchTerm != null && searchType.Equals("all"))
            {
                ViewBag.jobs = JobData.FindByValue(searchTerm);
            }
            else if(searchTerm == null && searchType.Equals("all")== false)
            {
                ViewBag.jobs = new List<string> { };
            }
            else
            {
                ViewBag.jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
            }
            ViewBag.columns = ListController.columnChoices;
            return View("Index");
        }
        

    }
}
