using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VideoApp;

namespace VideoTests
{
    [TestClass]
    public class BluRayAdapterTests
    {
        [TestMethod]
        public void PlayVideoExceptionTest()
        {
            IFactory bluRayTestFactory = new BluRayFactory();
            IVideoPlayer bluRayAdapter = bluRayTestFactory.CreateVideoPlayer();

            Assert.ThrowsException<ArgumentException>(() => bluRayAdapter.play(new DVD(55)));
        }
    }
}
