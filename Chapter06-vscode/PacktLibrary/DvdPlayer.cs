using static System.Console;
namespace Packt.Shared;
public class DvdPlayer : IPlayable
{
    public void Play()
    {
        WriteLine("DvdPlayer is playing");
    }
    public void Pause()
    {
        WriteLine("DvdPlayer is pausing");
    }
}