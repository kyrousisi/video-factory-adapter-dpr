namespace VideoApp
{
    public class DVDFactory : IFactory
    {
        public IVideo createVideo(int duration)
        {
            if (duration > DVD.CAPACITY)
            {
                throw new System.ArgumentException("Cannot create video: Duration is larger than the capacity");
            }

            return new DVD(duration);
        }

        public IVideoPlayer CreateVideoPlayer()
        {
            return new DVDAdapter(new DVDPlayer());
        }
    }
}
