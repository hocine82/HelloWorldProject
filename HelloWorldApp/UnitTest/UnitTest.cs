using System;
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
            WriteToConsole wc = new WriteToConsole();
            LogData lg = new LogData(wc);
            bool isInserted = lg.insert();
            Assert.AreEqual(isInserted, true);
        }

        [TestMethod]
        public void TestDataBaseWrite_WillReturnTrue()
        {
            WriteToDatabase wd = new WriteToDatabase();
            LogData lg = new LogData(wd);
            bool isInserted = lg.insert();
            Assert.AreEqual(isInserted, true);
        }

    }
}
