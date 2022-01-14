using Microsoft.AspNetCore.Mvc;

namespace PierresTreatAndFlavor.Controllers
{
  public class Homecontroller : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}