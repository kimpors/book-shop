using Microsoft.AspNetCore.Mvc;
using BookShop.Data;

namespace BookShop.Controllers;

public class HomeController : Controller
{
  IBookRepository _repo;

  public HomeController(IBookRepository repo)
    => _repo = repo;

  public IActionResult Index()
  {
    return View(_repo.Books);
  }
}
