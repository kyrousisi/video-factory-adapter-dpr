namespace VideoApp
{
    public class VHSFactory : IFactory
    {
        public IVideo createVideo(int duration)
        {
            if (duration > VHS.CAPACITY)
            {
                throw new System.ArgumentException("Cannot create video: Duration is larger than the capacity");
            }
            return new VHS(duration);
        }

        public IVideoPlayer CreateVideoPlayer()
        {
            return new VHSAdapter(new VHSPlayer());
        }
    }
}
