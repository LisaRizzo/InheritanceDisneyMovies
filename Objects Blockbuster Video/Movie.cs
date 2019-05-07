using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Blockbuster_Video
{
  class Movie
  {
    public string Title { get; set; }
    public string Category { get; set; }
    public int RunTime { get; set; }
    public int Debut{ get; set; }
    public List<string> Scenes { get; set; }

    public Movie(string Title, string Category, int Runtime, int Debut, List<string> Scenes)
    {
      this.Title = Title;
      this.Category = Category;
      this.RunTime = Runtime;
      this.Debut = Debut;
      this.Scenes = Scenes;
    }

    public virtual void PrintInfo()
    {
      Console.WriteLine("Title: " + Title);
      Console.WriteLine("Genre: " + Category);
      Console.WriteLine("Debut: " + Debut);
      Console.WriteLine("Length: " + RunTime + " mins");
      PrintScenes();
    }

    public void PrintScenes()
    {
      for (int i = 0; i < Scenes.Count; i++)
      {
        Console.WriteLine($"Scene {i+1}: {Scenes[i]}");
      }
    }

    public virtual void Play()
    {
      Console.WriteLine("The play method only works on physical media");
    }
  }
}
