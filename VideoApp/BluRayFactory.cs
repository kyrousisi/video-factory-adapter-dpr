namespace VideoApp
{
    public class BluRayFactory : IFactory
    {
        public IVideo createVideo(int duration)
        {
            if (duration > BluRay.CAPACITY)
            {
                throw new System.ArgumentException("Cannot create video: Duration is larger than the capacity");
            }

            return new BluRay(duration);
        }

        public IVideoPlayer CreateVideoPlayer()
        {
            return new BluRayAdapter(new BluRayPlayer());
        }
    }
}
