using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VideoApp;

namespace VideoTests
{
    [TestClass]
    public class DVDAdapterTests
    {
        [TestMethod]
        public void PlayVideoExceptionTest()
        {
            IFactory dvdTestFactory = new DVDFactory();
            IVideoPlayer dvdAdapter = dvdTestFactory.CreateVideoPlayer();

            Assert.ThrowsException<ArgumentException>(() => dvdAdapter.play(new VHS(55)));
        }
    }
}
