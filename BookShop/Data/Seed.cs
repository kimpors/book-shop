using BookShop.Models;

namespace BookShop.Data;

public static class Seed
{
  public static void EnsurePopulated(IApplicationBuilder app)
  {
    using (var scope = app.ApplicationServices.CreateScope())
    {
      var ctx = scope.ServiceProvider.GetService<AppDbContext>();
      ctx.Database.EnsureCreated();

      if (!ctx.Books.Any())
      {
        ctx.Books.AddRange(
            new Book (1, "Echoes of Eternity", "John", "Roman", "Lorem ipsum dolor sit amet, qui minim labore adipisicing minim sint cillum sint consectetur cupidatat.", 50m),
            new Book(2, "The Midnight Serenade", "Jack", "Detective", "Lorem ipsum dolor sit amet, qui minim labore adipisicing minim sint cillum sint consectetur cupidatat.", 60m),
            new Book(3, "Whispers in the Shadows", "Bob", "Novel", "Lorem ipsum dolor sit amet, qui minim labore adipisicing minim sint cillum sint consectetur cupidatat.", 80m),
            new Book(4, "Chronicles of the Forgotten", "Victor", "Roman", "Lorem ipsum dolor sit amet, qui minim labore adipisicing minim sint cillum sint consectetur cupidatat.", 90m),
            new Book(5, "The Enigma Equation", "Nick", "Adventure", "Lorem ipsum dolor sit amet, qui minim labore adipisicing minim sint cillum sint consectetur cupidatat.", 110m),
            new Book(6, "A Bridge to Yesterday", "George", "Detective", "Lorem ipsum dolor sit amet, qui minim labore adipisicing minim sint cillum sint consectetur cupidatat.", 54m),
            new Book(7, "Secrets of the Celestial Spheres", "Arnold", "Adventure", "Lorem ipsum dolor sit amet, qui minim labore adipisicing minim sint cillum sint consectetur cupidatat.", 79m),
            new Book(8, "The Lost Labyrinth", "Bill", "Novel", "Lorem ipsum dolor sit amet, qui minim labore adipisicing minim sint cillum sint consectetur cupidatat.", 30m),
            new Book(9, "Fires of Redemption", "Todd", "Detective", "Lorem ipsum dolor sit amet, qui minim labore adipisicing minim sint cillum sint consectetur cupidatat.", 130m),
            new Book(10, "Tales from the Quantum Realm", "Jeremy", "Roman", "Lorem ipsum dolor sit amet, qui minim labore adipisicing minim sint cillum sint consectetur cupidatat.", 45m));
      }

      ctx.SaveChanges();
    }
  }
}
