namespace BookShop.Models;

public record PageInfo(int CurrentPage, int ItemsPerPage, int TotalItems)
{
  public int TotalPages()
    => (int)Math.Ceiling((decimal)TotalItems / (decimal)ItemsPerPage);
}
