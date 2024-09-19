namespace VideoApp
{
    public class DVD : IVideo
    {
        public const int CAPACITY = 120;
        private int duration;

        public DVD(int duration)
        {
            this.duration = duration;
        }


        public int getDuration()
        {
            return duration;
        }
    }
}
