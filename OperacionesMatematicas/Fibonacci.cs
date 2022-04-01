/**
* 
* Clase que calculará la secuencia de fibonacci
* 
* @author: Daniel Lopez Echavarria
* 
*/

namespace OperacionesMatematicas
{
    public class Fibonacci
    {
        public int[,] calcular(int iDim)
        {
            // Se crea la estructura de la matriz
            int[,] iMatriz = new int[iDim, iDim];

            // Se inician las operaciones para calcular fibonacci
            for (int f = 0; f < iDim; f++)
            {
                for (int c = 0; c < iDim; c++)
                {
                    int iValor = 0;

                    //Generamos valores del fibonacci
                    if (c == 0 || f == c)
                    {
                        iValor = 1;
                    } else if (f > c)
                    {
                        iValor = iMatriz[f-1, c-1] + iMatriz[f-1, c];
                    }
                    // Asignamos los valores a la matriz
                    iMatriz[f,c] = iValor;
                }
            }
            return iMatriz;
        }
    }
}
