using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoApp;

namespace VideoTests
{
    [TestClass]
    public class BluRayPlayerTests
    {
        [TestMethod]
        public void PlayVideoSuccessTest()
        {
            BluRayPlayer bluRayPlayer = new BluRayPlayer();
            bluRayPlayer.play(new BluRay(55));
        }
    }
}
