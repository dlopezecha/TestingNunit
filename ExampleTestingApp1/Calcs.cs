using System;

namespace ExampleTestingApp1
{
    public class Calcs
    {
        public int Sumar(int Val1, int Val2)
        {
            return Val1 + Val2;
        }

        public int Restar(int Val1, int Val2)
        {
            return Val1 - Val2;
        }

        public int Multiplicar(int Val1, int Val2)
        {
            return Val1 * Val2;
        }

        public int Dividir(int Val1, int Val2)
        {
            if (Val2 == 0)
            {
                return 0;
            }
            return Val1 / Val2;
        }
    }
}
