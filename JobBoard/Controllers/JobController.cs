using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JobBoard.Models;


namespace JobBoard.Controllers
{
  // We tell .NET that HomeController should inherit or extend functionality from ASP.NET Core's built-in Controller class that we import with our using statement
  public class JobController : Controller
  {
  
    [HttpGet("/jobboard")]
    public ActionResult Index() 
    {  
      List<JobOpening> allItems = JobOpening.GetAll();  //static method called on the class as opposed to the instance of the object
      return View(allItems);
    }

    [HttpGet("/jobboard/new")]
    public ActionResult New() 
    { 
      return View(); 
    }

    [HttpPost("/jobboard")]
    public ActionResult Create(string title, string description, string info)
    {
      JobOpening newjob = new JobOpening(title, description, info);
      return RedirectToAction("Index");
    }
    [HttpPost("/jobboard/delete")]
    public ActionResult Delete(int id)
    {
      JobOpening.RemoveItem(id);
      return RedirectToAction("Index");
    }
    [HttpGet("/jobboard/{id}")]
    public ActionResult Detail(int id)
    {
      JobOpening currentItem = JobOpening.Find(id); //static method called on the class as opposed to the instance of the object
      return View(currentItem);
    }

  }
}