using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Blockbuster_Video
{
  class VHS : Movie
  {
    public int CurrentTime { get; set;}

    public VHS(string Title, string Category, int Runtime, int Debut, List<string> Scenes)
      : base(Title, Category, Runtime, Debut, Scenes)
    {
      
    }

    //A property called CurrentTime
    //A method called Play() that plays the scene at the current time and then increments CurrentTime.
    //A method called Rewind that returns nothing and sets CurrentTime to 0.
    public override void Play()
    {
        string scene = Scenes[CurrentTime];
        Console.WriteLine(scene);
        CurrentTime++;
    }

    public void Rewind()
    {
      CurrentTime = 0;
    }
  }
}
