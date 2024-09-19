using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoApp;

namespace VideoTests
{
    [TestClass]
    public class DVDPlayerTests
    {
        [TestMethod]
        public void PlayVideoSuccessTest()
        {
            DVDPlayer dvdPlayer = new DVDPlayer();
            dvdPlayer.play(new DVD(55));
        }
    }
}
