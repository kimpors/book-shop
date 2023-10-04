using Microsoft.AspNetCore.Mvc;
using BookShop.Models;
using BookShop.Data;

namespace BookShop.Controllers;

public class HomeController : Controller
{
  private IBookRepository _repo;

  public int ItemsPerPage { get; set; }

  public HomeController(IBookRepository repo)
  {
    _repo = repo;
    ItemsPerPage = 4;
  }

  public IActionResult Index(int id)
  {
    return View(new PageViewModel()
    {
      Books = _repo.Books.Skip(id * ItemsPerPage).Take(ItemsPerPage),
      Info = new PageInfo(id, ItemsPerPage, _repo.Books.Count())
    });
  }
}
