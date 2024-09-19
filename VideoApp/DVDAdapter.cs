namespace VideoApp
{
    class DVDAdapter : IVideoPlayer
    {
        private DVDPlayer dvdPlayer;

        public DVDAdapter(DVDPlayer dvdPlayer)
        {
            this.dvdPlayer = dvdPlayer;
        }

        public void play(IVideo video)
        {
            if (!(video is DVD))
            {
                throw new System.ArgumentException("Video should a DVD");
            }

            dvdPlayer.play((DVD)video);
        }
    }
}
