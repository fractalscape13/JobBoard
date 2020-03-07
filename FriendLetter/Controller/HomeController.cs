using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  // We tell .NET that HomeController should inherit or extend functionality from ASP.NET Core's built-in Controller class that we import with our using statement
  public class HomeController : Controller
  {
    // This is a route!
    public string Hello() { return "Hello friend!"; } // The return is the "action"

    public string Goodbye() { return "Goodbye friend."; }

  }
}