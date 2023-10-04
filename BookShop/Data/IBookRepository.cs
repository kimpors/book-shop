using BookShop.Models;

namespace BookShop.Data;

public interface IBookRepository
{
  public IQueryable<Book> Books { get; }

  public void SaveBook(Book book);
}

