using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Blockbuster_Video
{
  class Blockbuster
  {
    List<Movie> Movies { get; set; }

    public Blockbuster()
    {
      Movies = new List<Movie>();

      List<string> ScenesA = new List<string>() {
        "Fathoms Below",
        "Daughters of Triton",
        "Part of Your World",
        "Under the Sea",
        "Kiss the Girl",
        "Vanessa's Song",
        "Part of Your World (Finale)"};

      VHS a = new VHS("The Little Mermaid", "Children/Family", 83, 1989, ScenesA);

      List<string> ScenesB = new List<string>() {
        "Circle of Life",
        "I Just Can't Wait to Be King",
        "Be Prepared",
        "Hakuna Matata",
        "Can You Feel the Love Tonight",
        "Circle of Life(Finale)"};

      VHS b = new VHS("The Lion King", "Children/Family", 88, 1994, ScenesB);

      List<string> ScenesC = new List<string>() {
        "Arabian Nights",
        "One Jump Ahead",
        "Friend Like Me",
        "Prince Ali",
        "A Whole New World"};

      VHS c = new VHS("Aladdin", "Children/Family", 90, 1992, ScenesC);

      List<string> ScenesD = new List<string>() {
      "I'm Wishing",
      "One Song",
      "With a Smile and a Song",
      "Whistle While You Work",
      "Heigh-Ho",
      "Someday My Prince Will Come"};

      DVD d = new DVD("Snow White and the Seven Dwarfs", "Children/Family", 83, 1937, ScenesD);

      List<string> ScenesE = new List<string>() {
      "Cinderella",
      "A Dream Is a Wish Your Heart Makes",
      "The King's Plan",
      "Oh, Sing Sweet Nightingale",
      "A Dream Is a Wish Your Heart Makes",
      "Bibbidi Bobbidi Boo",
      "So This Is Love"};

      DVD e = new DVD("Cinderella", "Children/Family", 75, 1950, ScenesE);

      List<string> ScenesF = new List<string>() {
      "Belle",
      "Gaston",
      "Be Our Guest",
      "Something There",
      "Beauty and the Beast"};

      DVD f = new DVD("Beauty and the Beast", "Children/Family", 84, 1991, ScenesF);

      Movies.Add(a);
      Movies.Add(b);
      Movies.Add(c);
      Movies.Add(d);
      Movies.Add(e);
      Movies.Add(f);
    }
    public void PrintMovies()
    {
      for (int i = 0; i < Movies.Count; i++)
      {
        Console.WriteLine($"Movie {i + 1}. {Movies[i].Title}");
      }
    }

    public void CheckOut()
    {
      PrintMovies();
      Console.WriteLine();
      Console.Write("Select a movie to check out from the list: ");
      int y = int.Parse(Console.ReadLine());
      Movies[y-1].PrintInfo();
    }
  }
}
