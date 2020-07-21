using Microsoft.AspNetCore.Mvc;
using Cars.Models;
using System.Collections.Generic;

namespace Cars.Controllers
{
  public class DealershipController : Controller
  {
    [HttpGet("/dealership")]
    public ActionResult Dealership()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
      Car yugo = new Car("1980 Yugo Koral", 700, 5600);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
      Car amc = new Car("1976 AMC Pacer", 400, 198000);
      List<Car> carsInDealership = Car.GetAll();
      return View(carsInDealership);
    }

    [Route("/car")]
    public ActionResult Car()
    {
      return View();
    }
  }
}