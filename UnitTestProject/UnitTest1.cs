using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World! from Sarita";
        [TestMethod]
        public void TestMethod1()
        { 
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                ConsoleAppForMSBuild.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
