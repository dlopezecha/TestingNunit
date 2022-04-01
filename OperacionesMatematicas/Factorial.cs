using System;

namespace OperacionesMatematicas
{
    public class Factorial
    {
        public int calcular(int iNum)
        {
            //Creación de variables
            int iFactorial = 1;

            // Calcular el factorial
            for (int i = 1; i <= iNum; i++)
            {
                iFactorial *= i;
            }
            return iFactorial;
        }

        public int DynamicCalcular(int iNum)
        {
            if (iNum == 1)
            {
                return iNum;
            }
            return iNum *= DynamicCalcular(iNum - 1);
        }
    }
}
