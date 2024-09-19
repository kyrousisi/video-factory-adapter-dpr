using System;

namespace VideoApp
{
    public class Client
    {
        public static void Main(string[] args)
        {
            IFactory vhsFactory = new VHSFactory();

            IFactory dvdFactory = new DVDFactory();

            IFactory bluRayFactory = new BluRayFactory();

            IVideo vhs = vhsFactory.createVideo(new Random().Next(VHS.CAPACITY));

            IVideoPlayer vhsPlayer = vhsFactory.CreateVideoPlayer();

            IVideo dvd = dvdFactory.createVideo(new Random().Next(DVD.CAPACITY));

            IVideoPlayer dvdPlayer = dvdFactory.CreateVideoPlayer();

            IVideo bluRay = bluRayFactory.createVideo(new Random().Next(BluRay.CAPACITY));

            IVideoPlayer bluRayPlayer = bluRayFactory.CreateVideoPlayer();

            vhsPlayer.play(vhs);

            dvdPlayer.play(dvd);

            bluRayPlayer.play(bluRay);
        }
    }
}
