using Microsoft.AspNetCore.Mvc;

namespace OrderTracker.Controllers
{
  public class HomeController : Controller
  {

    // [HttpGet("/hello")]
    // public string Hello() { return "Hello friend!"; }

    // [Route("/goodbye")]
    // public ActionResult GoodBye() { return View(); }

    // [Route("/")]
    // public string Letter() { return "Our virtual To Do List will go here soon!"; }

    [HttpGet("/")]
    public ActionResult Index()
    { return View(); }

  }
}
