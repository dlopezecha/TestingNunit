using Microsoft.VisualStudio.TestTools.UnitTesting;
/*
 * Este es un proyecto MSTEST de .core
 */
namespace TestEjTestNunit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSomething()
        {
            string sResult = EjTestNUnit.Program.Something();
            Assert.AreEqual("algo", sResult);
        }

        [TestMethod]
        public void TestLoguin()
        {
            bool bResult = EjTestNUnit.Program.Loguin("mpajaro", "123456");
            Assert.AreEqual(true, bResult);
        }
    }
}
