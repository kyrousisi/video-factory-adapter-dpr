using System;

namespace VideoApp
{
    public class BluRayPlayer
    {
        public void play(BluRay bluRay)
        {
            Console.WriteLine("Playing BluRay with duration: " + bluRay.getDuration());
        }
    }
}
