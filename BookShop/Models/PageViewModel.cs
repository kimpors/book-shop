namespace BookShop.Models;

public class PageViewModel
{
  public IEnumerable<Book> Books { get; set; }
  public PageInfo Info { get; set; }
}
