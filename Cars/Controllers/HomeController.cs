using Microsoft.AspNetCore.Mvc;
using Cars.Models;

namespace Cars.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      // Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
      // Car yugo = new Car("1980 Yugo Koral", 700, 5600);
      // Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
      // Car amc = new Car("1976 AMC Pacer", 400, 198000);
      // List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc};
      return View();
    }
  }
}