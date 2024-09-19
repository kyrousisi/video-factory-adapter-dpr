namespace VideoApp
{
    public class VHS : IVideo
    {
        public const int CAPACITY = 90;
        private int duration;

        public VHS(int duration)
        {
            this.duration = duration;
        }

        public int getDuration()
        {
            return duration;
        }
    }
}
