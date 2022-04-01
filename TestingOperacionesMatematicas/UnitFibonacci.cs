using OperacionesMatematicas;
using Xunit;

namespace TestsOperacionesMatematicas
{
    public class UnitFibonacci
    {
        private readonly Fibonacci oClass = new Fibonacci();

        [Fact]
        public void TestFibonacci()
        {
            // Arrange
            // Crear los elementos y dependencias de ejecución
            int iDim = 5;
            int[,] iExpected = new int[5, 5] {
                { 1,0,0,0,0 },
                { 1,1,0,0,0 },
                { 1,2,1,0,0 },
                { 1,3,3,1,0 },
                { 1,4,6,4,1 }
            };

            // Act
            // Calculamos el resultado del fibonacci
            int[,] iResult = this.oClass.calcular(iDim);

            // Assert
            // El resultado debe ser igual a la matriz propuesta
            Assert.Equal(iExpected, iResult);
        }

        [Fact]
        public void TestFibonacciBadResult()
        {
            // Arrange
            // Crear los elementos y dependencias de ejecución
            int iDim = 5;
            int[,] iExpected = new int[4, 5] {
                { 1,1,0,0,0 },
                { 1,1,0,0,0 },
                { 1,2,1,0,0 },
                { 1,3,3,1,0 }
            };

            // Act
            // Calculamos el resultado del fibonacci erroneo
            int[,] iResult = this.oClass.calcular(iDim);

            // Assert
            // El resultado debe ser diferente a la matriz propuesta
            Assert.NotEqual(iExpected, iResult);
        }
    }
}
