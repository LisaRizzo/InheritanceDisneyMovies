using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Blockbuster_Video
{
  class DVD : Movie
  {
    public DVD(string Title, string Category, int Runtime, int Debut, List<string> Scenes) 
      : base(Title, Category, Runtime, Debut, Scenes)
    {

    }
    public override void Play()
    {
      PrintScenes();
      Console.WriteLine("What scene would you like to see?");
      string input = Console.ReadLine();
      int index = int.Parse(input);

      string scene = Scenes[index];
      Console.WriteLine($"The movie is starting at {scene}. Get your popcorn!");
    }
  }
}
