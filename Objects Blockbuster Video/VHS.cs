using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Blockbuster_Video
{
  //inheritance
  class VHS : Movie
  {
    public int CurrentTime { get; set;}

    //constructor
    public VHS(string Title, string Category, int Runtime, int Debut, List<string> Scenes)
      : base(Title, Category, Runtime, Debut, Scenes)
    {
      CurrentTime = 0;
    }

    //A property called CurrentTime
    //A method called Play() that plays the scene at the current time and then increments CurrentTime.
    //A method called Rewind that returns nothing and sets CurrentTime to 0.
    public override void Play()
    {
      if (CurrentTime < Scenes.Count)
      { 
        string scene = Scenes[CurrentTime];
        Console.WriteLine($"The movie is starting at {scene}. Get your popcorn!");
        CurrentTime++;
      }
        else
      {
        Rewind();
      }
    }

    public void Rewind()
    {
      Console.WriteLine("Movie done! Rewinding...");
      CurrentTime = 0;
    }
  }
}
