using System;

namespace VideoApp
{
    public class DVDPlayer
    {
        public void play(DVD dvd)
        {
            Console.WriteLine("Playing DVD with duration: " + dvd.getDuration());
        }
    }
}
