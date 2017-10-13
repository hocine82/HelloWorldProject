using System;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldApp;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestConsoleOutput_WillReturnTrue()
        {
            Mock<WriteToConsole> wc = new Mock<WriteToConsole>();
            wc.Setup(x => x.Output()).Returns(true);
        }

        [TestMethod]
        public void TestDataBaseWrite_WillReturnTrue()
        {            
            Mock<WriteToDatabase> wd = new Mock<WriteToDatabase>();
            wd.Setup(x => x.Output()).Returns(true);            
        }

    }
}
