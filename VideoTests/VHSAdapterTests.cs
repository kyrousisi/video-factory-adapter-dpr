using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using VideoApp;

namespace VideoTests
{
    [TestClass]
    public class VHSAdapterTests
    {
        [TestMethod]
        public void PlayVideoExceptionTest()
        {
            IFactory vhsTestFactory = new VHSFactory();
            IVideoPlayer vhsAdapter = vhsTestFactory.CreateVideoPlayer();

            Assert.ThrowsException<ArgumentException>(() => vhsAdapter.play(new DVD(55)));
        }
    }
}
