using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Blockbuster_Video
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the Disney Movie List Application!");

      Blockbuster b = new Blockbuster();
      b.CheckOut();
    }
  }
}
