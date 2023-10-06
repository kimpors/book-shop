namespace BookShop.Models;

public class Order
{
  public Order(Book book, int quantity = 1)
  {
    Id = book.Id;
    Book = book;
    Quantity = quantity;
  }

  public int Id { get; init; }

  public Book Book { get; init; }

  public int Quantity { get; set; }
}
