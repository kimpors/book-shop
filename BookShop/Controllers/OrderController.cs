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

  public IActionResult Add(int id)
  {
    var book = _books.Books
      .FirstOrDefault(u => u.Id == id);

    _orders.Add(new Order()
    {
      Book = book,
      Quantity = 1
    });

    return RedirectToAction(nameof(Index));
  }
}
