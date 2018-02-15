using Microsoft.AspNetCore.Mvc;
using FindReplace.Models;

namespace FindReplace.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/")]
    public ActionResult Result()
    {
      string text = Request.Form["text"];
      string find = Request.Form["find"];
      string replace = Request.Form["replace"];
      FindAndReplace newFind = new FindAndReplace(text, find, replace);
      newFind.ReplaceAll();
      return View("Result", newFind);
    }
  }
}
