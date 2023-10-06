using BookShop.Models;

namespace BookShop.Data;

public class OrderRepository
{
  public List<Order> Orders { get; set; } = new();

  public void Add(Order order)
  {
    Order temp = Orders.FirstOrDefault(u => u.Book == order.Book);

    if (temp is null)
    {
      Orders.Add(order);
      return;
    }

    temp.Quantity++;
  }
}
