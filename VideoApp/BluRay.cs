namespace VideoApp
{
    public class BluRay : IVideo
    {
        public const int CAPACITY = 170;
        private int duration;

        public BluRay(int duration)
        {
            this.duration = duration;
        }


        public int getDuration()
        {
            return duration;
        }
    }
}
