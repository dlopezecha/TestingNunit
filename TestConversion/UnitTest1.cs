using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestConversion
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMetodoConv1()
        {
            //Testing de decimal a binario
            string resultado = Conversion.Program.MetodoConv1(20);
            Assert.AreEqual("10100", resultado);
        }

        [TestMethod]
        public void TestMetodoConv1Fail()
        {
            //Testing de decimal a binario erroneo
            string resultado = Conversion.Program.MetodoConv1(20);
            Assert.AreNotEqual("10101", resultado);
        }

        [TestMethod]
        public void TestBinarioDecimal()
        {
            //Testeo de Binario a Decimal que sea exitoso
            int resultado = Conversion.Program.BinarioDecimal(10100);
            Assert.AreEqual(20, resultado);
        }

        [TestMethod]
        public void TestBinarioDecimalFail()
        {
            //Testeo de Binario a Decimal que sea erroneo
            int resultado = Conversion.Program.BinarioDecimal(10101);
            Assert.AreNotEqual(20, resultado);
        }

        [TestMethod]
        public void TestBinarioDecimalFail2()
        {
            //Testeo de Binario a Decimal que sea erroneo
            int resultado = Conversion.Program.BinarioDecimal(20);
            Assert.AreEqual((-1), resultado);
        }

        [TestMethod]
        public void TestDecimalOctal()
        {
            //Testeo de Decimal a octal exitoso
            long resultado = Conversion.Program.DecimalOctal(20);
            Assert.AreEqual(24, resultado);

            //Testeo de Decimal a octal fallido
            resultado = Conversion.Program.DecimalOctal(21);
            Assert.AreNotEqual(24, resultado);
        }

        [TestMethod]
        public void TestOctalDecimal()
        {
            //Testeo de octal a Decimal exitoso
            long resultado = Conversion.Program.OctalDecimal(24);
            Assert.AreEqual(20, resultado);

            //Testeo de octal a Decimal fallido
            resultado = Conversion.Program.OctalDecimal(24);
            Assert.AreNotEqual(21, resultado);
        }

        [TestMethod]
        public void TestHexToDec1()
        {
            //Testeo de Hex a Dec exitoso
            long resultado = Conversion.Program.HexToDec1("20");
            Assert.AreEqual(32, resultado);

            //Testeo de Hex a Dec fallido
            resultado = Conversion.Program.HexToDec1("20");
            Assert.AreNotEqual(30, resultado);
        }

        [TestMethod]
        public void TestHexToDec2()
        {
            //Testeo de Hex a Dec exitoso
            decimal resultado = Conversion.Program.HexToDec2("20");
            Assert.AreEqual(32, resultado);

            //Testeo de Hex a Dec fallido
            resultado = Conversion.Program.HexToDec2("20");
            Assert.AreNotEqual(30, resultado);
        }

        [TestMethod]
        public void TestdecimalHexadecimal()
        {
            //Testeo de decimal a Hex exitoso
            string resultado = Conversion.Program.decimalHexadecimal(32);
            Assert.AreEqual("20", resultado);

            //Testeo de decimal a Hex fallido
            resultado = Conversion.Program.decimalHexadecimal(32);
            Assert.AreNotEqual("21", resultado);
        }
    }
}
