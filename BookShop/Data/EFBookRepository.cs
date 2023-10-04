using BookShop.Models;

namespace BookShop.Data;

public class EFBookRepository : IBookRepository
{
  private AppDbContext _ctx;

  public EFBookRepository(AppDbContext ctx)
    => _ctx = ctx;

  public IQueryable<Book> Books 
    => _ctx.Books;

  public void SaveBook(Book book)
  {
    if (book.Id == 0)
    {
      _ctx.Books.Add(book);
    }
    else
    {
      var entry = _ctx.Books
        .FirstOrDefault(u => u.Id == book.Id);

      if (entry is null)
      {
        entry = book;
      }
    }

    _ctx.SaveChanges();
  }
}

