using Microsoft.AspNetCore.Mvc;
using BookShop.Models;
using BookShop.Data;

namespace BookShop.Controllers;

public class OrderController : Controller
{
  private OrderRepository _orders;
  private IBookRepository _books;

  public OrderController(OrderRepository orders, IBookRepository books)
    => (_orders, _books) = (orders, books);

  public IActionResult Index()
  {
    return View(_orders.Orders);
  }

  public RedirectToActionResult Add(int id)
  {
    var book = _books.Books
      .FirstOrDefault(u => u.Id == id);

    _orders.Add(new Order(book));
    return RedirectToAction(nameof(Index));
  }

  public RedirectToActionResult Remove(int id)
  {
    _orders.Remove(id);
    return RedirectToAction(nameof(Index));
  }
}
