using System;

/**
* 
* Clase que calculará la raiz cuadrada de un número dado
* 
* @author: Daniel Lopez Echavarria
* 
*/
namespace OperacionesMatematicas
{
    public class RaizCuadrada
    {
        public double calcular(double dNumber)
        {
            if (dNumber <= 0)
            {
                return 0;
            }
            return Math.Sqrt(dNumber);
        }
    }
}
