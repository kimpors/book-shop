using Microsoft.AspNetCore.Mvc;
using BookShop.Models;

namespace BookShop.Components;

public class Paging : ViewComponent
{
  public IViewComponentResult Invoke(PageInfo info)
  {
     return View(info.TotalPages());
  }
}


