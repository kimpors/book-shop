using BookShop.Models;

namespace BookShop.Data;

public class OrderRepository
{
  public List<Order> Orders { get; set; } = new();

  public void Add(Order order)
  {
    if (Orders.Any(u => u.Id == order.Id))
    {
      return;
    }

    Orders.Add(order);
  }

  public bool Remove(int id)
  {
    var temp = Orders.
      FirstOrDefault(u => u.Id == id);

    if (temp is not null)
    {
      return Orders.Remove(temp);
    }

    return false;
  }
}
