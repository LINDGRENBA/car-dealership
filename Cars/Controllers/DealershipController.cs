using Microsoft.AspNetCore.Mvc;
using Cars.Models;

namespace Cars.Controllers
{
  public class DealershipController: Controller
  {
    [Route("/dealership")]
    public ActionResult Dealership()
    {
      return View();
    }

    [Route("/car")]
    public ActionResult Car()
    {
      return View();
    }
  }
}