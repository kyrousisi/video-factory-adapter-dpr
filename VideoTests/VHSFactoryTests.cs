using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VideoApp;

namespace VideoTests
{
    [TestClass]
    public class VHSFactoryTests
    {
        [TestMethod]
        public void CreateVideoSuccessTest()
        {
            IFactory vhsTestFactory = new VHSFactory();
            IVideo vhsTestVideo = vhsTestFactory.createVideo(new Random().Next(VHS.CAPACITY));

            Assert.IsNotNull(vhsTestVideo);
        }

        [TestMethod]
        public void CreateVideoExceptionTest()
        {
            IFactory vhsTestFactory = new VHSFactory();

            Assert.ThrowsException<ArgumentException>(() => vhsTestFactory.createVideo(VHS.CAPACITY + 1));
        }

        [TestMethod]
        public void CreateVideoPlayerSuccessTest()
        {
            IFactory vhsTestFactory = new VHSFactory();
            IVideoPlayer vhsPlayer = vhsTestFactory.CreateVideoPlayer();

            Assert.IsNotNull(vhsPlayer);
        }
    }
}
