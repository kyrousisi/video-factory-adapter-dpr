using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VideoApp;

namespace VideoTests
{
    [TestClass]
    public class DVDFactoryTests
    {
        [TestMethod]
        public void CreateVideoSuccessTest()
        {
            IFactory dvdTestFactory = new DVDFactory();
            IVideo dvdTestVideo = dvdTestFactory.createVideo(new Random().Next(DVD.CAPACITY));

            Assert.IsNotNull(dvdTestVideo);
        }

        [TestMethod]
        public void CreateVideoExceptionTest()
        {
            IFactory dvdTestFactory = new DVDFactory();

            Assert.ThrowsException<ArgumentException>(() => dvdTestFactory.createVideo(DVD.CAPACITY + 1));
        }

        [TestMethod]
        public void CreateVideoPlayerSuccessTest()
        {
            IFactory dvdTestFactory = new DVDFactory();
            IVideoPlayer dvdPlayer = dvdTestFactory.CreateVideoPlayer();

            Assert.IsNotNull(dvdPlayer);
        }
    }
}
