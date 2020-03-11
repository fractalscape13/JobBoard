using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;

namespace JobBoard.Controllers
{
  // We tell .NET that HomeController should inherit or extend functionality from ASP.NET Core's built-in Controller class that we import with our using statement
  public class HomeController : Controller
  {
  
    [HttpGet("/")]
    public ActionResult Index() 
    { 
      return View();
    }
  }
}