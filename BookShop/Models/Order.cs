namespace BookShop.Models;

public class Order
{
  private int _quantity;
  public required Book Book { get; set; }

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
