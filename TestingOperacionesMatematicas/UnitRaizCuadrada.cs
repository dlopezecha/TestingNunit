using System;
using OperacionesMatematicas;
using Xunit;

namespace TestsOperacionesMatematicas
{
    public class UnitRaizCuadrada
    {
        private readonly RaizCuadrada oClass = new RaizCuadrada();

        [Fact]
        public void TestFactorialRaizCuadrada()
        {
            // Arrange
            // Crear los elementos y dependencias de ejecución
            int dValue = 16;
            double dExpected = 4;

            // Act
            // Calculamos
            double dResult = this.oClass.calcular(dValue);

            // Assert
            // El resultado debe ser 2
            Assert.Equal(dExpected, dResult);
        }

        [Fact]
        public void TestFactorialCero()
        {
            // Arrange
            // Crear los elementos y dependencias de ejecución
            int dValue = 0;
            double dExpected = 0;

            // Act
            // Calculamos
            double dResult = this.oClass.calcular(dValue);

            // Assert
            // El resultado debe ser 2
            Assert.Equal(dExpected, dResult);
        }

        [Fact]
        public void TestFactorialNumeroNegativo()
        {
            // Arrange
            // Crear los elementos y dependencias de ejecución
            int dValue = -15;
            double dExpected = 0;

            // Act
            // Calculamos
            double dResult = this.oClass.calcular(dValue);

            // Assert
            // El resultado debe ser 2
            Assert.Equal(dExpected, dResult);
        }

        [Fact]
        public void TestFactorialValorInexacto()
        {
            // Arrange
            // Crear los elementos y dependencias de ejecución
            int dValue = 5;
            double dExpected = 2.23;

            // Act
            // Calculamos
            double dResult = this.oClass.calcular(dValue);
            Console.WriteLine(dResult);

            // Assert
            // El resultado debe ser 2
            Assert.NotStrictEqual(dExpected, dResult);
        }
    }
}
