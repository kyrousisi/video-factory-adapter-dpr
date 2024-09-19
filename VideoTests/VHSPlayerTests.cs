using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoApp;

namespace VideoTests
{
    [TestClass]
    public class VHSPlayerTests
    {
        [TestMethod]
        public void PlayVideoSuccessTest()
        {
            VHSPlayer vhsPlayer = new VHSPlayer();
            vhsPlayer.play(new VHS(55));
        }
    }
}
