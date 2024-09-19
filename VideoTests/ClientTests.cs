using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoApp;

namespace VideoTests
{
    [TestClass]
    public class ClientTests
    {
        [TestMethod]
        public void mainTest()
        {
            Client.Main(null);
        }
    }
}
