namespace Packt.Shared;
using System.Runtime.CompilerServices; // CompilerGeneratedAttribute
using Packt.Shared; // CoderAttribute
using static System.Console;
public class Animal
{
  [Coder("Mark Price", "22 August 2021")]
  [Coder("Johnni Rasmussen", "13 September 2021")] 
  public void Speak()
  {
    WriteLine("Woof...");
  }
}
