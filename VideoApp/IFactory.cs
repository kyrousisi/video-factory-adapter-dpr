namespace VideoApp
{
    public interface IFactory
    {
        IVideo createVideo(int duration);

        IVideoPlayer CreateVideoPlayer();
    }
}
