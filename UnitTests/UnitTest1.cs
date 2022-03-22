using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World";
        private const string Expected_option1 = "Option 1";

        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                unitTesting.Program.Main();

                var results = sw.ToString().Trim();
                Assert.AreEqual(Expected, results);

            }
        }
        [TestMethod]
        public void TestMethodMenu_Option1()
        {
            using (var option1SW = new StringWriter())
            {
                Console.SetOut(option1SW);
                unitTesting.Program.Retun(1);

                var optionResults = option1SW.ToString().Trim();
                Assert.AreEqual(Expected_option1, optionResults);
            }
        }
    }
}
