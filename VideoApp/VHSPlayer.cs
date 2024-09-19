using System;

namespace VideoApp
{
    public class VHSPlayer
    {
        public void play(VHS vhs)
        {
            Console.WriteLine("Playing VHS with duration: " + vhs.getDuration());
        }
    }
}