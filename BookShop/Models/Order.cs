namespace BookShop.Models;

public class Order
{
  private int _quantity;

  public Order(Book book, int quantity = 1)
  {
    Id = book.Id;
    Book = book;
    Quantity = quantity;
  }

  public int Id { get; init; }

  public Book Book { get; init; }

  public int Quantity
  {
      get { return _quantity; }
      set 
      { 
        if (value < 1)
        {
          value = 1;
        }

        _quantity = value;
      }
  }
}
