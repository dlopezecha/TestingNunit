using OperacionesMatematicas;
using Xunit;

namespace TestsOperacionesMatematicas
{
    public class UnitFactorial
    {
        // Se crean Atributos globales
        private readonly Factorial oClassFact = new Factorial();

        [Fact]
        public void TestFactorialZero()
        {
            // Arrange
            // Crear los elementos y dependencias de ejecución
            //Factorial oClassFact = new Factorial();

            // Act
            // Calculamos el factorial de 0
            int result = this.oClassFact.calcular(0);

            // Assert
            // El resultado debe ser 1
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestFactorialCinco()
        {
            // Arrange
            // Crear los elementos y dependencias de ejecución
            //Factorial oClassFact = new Factorial();

            // Act
            // Calculamos el factorial de 0
            int result = this.oClassFact.calcular(5);

            // Assert
            // El resultado debe ser 1
            Assert.Equal(120, result);
        }

        [Fact]
        public void TestFactorialNegativeNumber()
        {
            // Arrange
            // Crear los elementos y dependencias de ejecución
            //Factorial oClassFact = new Factorial();

            // Act
            // Calculamos el factorial de 0
            int result = this.oClassFact.calcular(-50);

            // Assert
            // El resultado debe ser 1
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestDynamic()
        {
            //Act
            int result = this.oClassFact.DynamicCalcular(5);
            // Assert
            // El resultado debe ser 120
            Assert.Equal(120, result);
        }
    }
}
