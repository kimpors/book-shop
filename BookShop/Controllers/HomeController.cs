using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers;

public class HomeController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}
