namespace VideoApp
{
    class VHSAdapter : IVideoPlayer
    {
        private VHSPlayer vhsPlayer;

        public VHSAdapter(VHSPlayer vhsPlayer)
        {
            this.vhsPlayer = vhsPlayer;
        }

        public void play(IVideo video)
        {
            if (!(video is VHS))
            {
                throw new System.ArgumentException("Video should be a VHS");
            }

            vhsPlayer.play((VHS)video);
        }
    }
}
