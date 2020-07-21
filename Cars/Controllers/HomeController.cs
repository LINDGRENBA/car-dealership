using Microsoft.AspNetCore.Mvc;
using Cars.Models;

namespace Cars.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}