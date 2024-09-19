namespace VideoApp
{
    class BluRayAdapter : IVideoPlayer
    {
        private BluRayPlayer bluRayPlayer;

        public BluRayAdapter(BluRayPlayer bluRayPlayer)
        {
            this.bluRayPlayer = bluRayPlayer;
        }
        
        public void play(IVideo video)
        {
            if (!(video is BluRay))
            {
                throw new System.ArgumentException("Video should a BluRay");
            }

            bluRayPlayer.play((BluRay)video);
        }
    }
}
