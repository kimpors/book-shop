namespace BookShop.Models;

public record Book(
    int Id,
    string Name,
    string Author,
    string Type,
    string Description,
    decimal Price);
