using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  // We tell .NET that HomeController should inherit or extend functionality from ASP.NET Core's built-in Controller class that we import with our using statement
  public class HomeController : Controller
  {
    // This is a route!
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; } // The return is the "action"

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/")]
    public string Letter() { return "Our virtual postcard will go here soon!"; }

  }
}