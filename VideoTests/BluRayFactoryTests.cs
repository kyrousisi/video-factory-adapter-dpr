using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VideoApp;

namespace VideoTests
{
    [TestClass]
    public class BluRayFactoryTests
    {
        [TestMethod]
        public void CreateVideoSuccessTest()
        {
            IFactory bluRayTestFactory = new BluRayFactory();
            IVideo bluRayTestVideo = bluRayTestFactory.createVideo(new Random().Next(BluRay.CAPACITY));

            Assert.IsNotNull(bluRayTestVideo);
        }

        [TestMethod]
        public void CreateVideoExceptionTest()
        {
            IFactory bluRayTestFactory = new BluRayFactory();

            Assert.ThrowsException<ArgumentException>(() => bluRayTestFactory.createVideo(BluRay.CAPACITY + 1));
        }

        [TestMethod]
        public void CreateVideoPlayerSuccessTest()
        {
            IFactory bluRayTestFactory = new BluRayFactory();
            IVideoPlayer bluRayPlayer = bluRayTestFactory.CreateVideoPlayer();

            Assert.IsNotNull(bluRayPlayer);
        }
    }
}
