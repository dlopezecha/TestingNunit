using System;
using System.Collections.Generic;

namespace Conversion
{
    public class Program
    {
        //Atributos
        static Dictionary<char, int> Hexdecval = new Dictionary<char, int>
        {
            {'0', 0},  {'1', 1},  {'2', 2},  {'3', 3},
            {'4', 4},  {'5', 5},  {'6', 6},  {'7', 7},
            {'8', 8},  {'9', 9},  {'A', 10}, {'B', 11},
            {'C', 12}, {'D', 13}, {'E', 14}, {'F', 15}
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Binario: {0}", MetodoConv1(20));
            Console.WriteLine("Decimal: {0}", BinarioDecimal(1010101011));
            Console.WriteLine("Octal:   {0}", DecimalOctal(20));
            Console.WriteLine("Hexadecimal: {0}", decimalHexadecimal(20));
        }

        public static string MetodoConv1(long xVal)
        {
            return Convert.ToString(xVal, 2);

        }

        //Convertir de Binario a decirmal
        public static int BinarioDecimal(long binario)
        {
            int numero = 0;
            int digito = 0;
            const int DIVISOR = 10;
            for (long i = binario, j = 0; i > 0; i /= DIVISOR, j++)
            {
                digito = (int)i % DIVISOR;
                if (digito != 1 && digito != 0)
                {
                    return -1;
                }
                numero += digito * (int)Math.Pow(2, j);
            }
            return numero;
        }//End BinarioDecimal

        //Convierte un numero de decimal a octal
        public static long DecimalOctal(int numero)
        {
            long octal = 0;
            const int DIVISOR = 8;
            long digito = 0;
            for (int i = numero % DIVISOR, j = 0; numero > 0; numero /= DIVISOR, i = numero % DIVISOR, j++)
            {
                digito = i % DIVISOR;
                octal += digito * (long)Math.Pow(10, j);
            }
            return octal;
        }//EndOctal

        // Convierte de octal a decimal
        public static int OctalDecimal(long octal)
        {
            int numero = 0;
            int digito = 0;
            const int DIVISOR = 10;
            for (long i = octal, j = 0; i > 0; i /= DIVISOR, j++)
            {
                digito = (int)i % DIVISOR;
                if (!(digito >= 0 && digito <= 7))
                {
                    return -1;
                }
                numero += digito * (int)Math.Pow(8, j);
            }
            return numero;
        }

        //Conversor #1
        public static long HexToDec1(string numero)
        {
            return Int32.Parse(numero, System.Globalization.NumberStyles.HexNumber);
        }

        //Conversor #2
        public static decimal HexToDec2(string hex)
        {
            decimal result = 0;
            hex = hex.ToLower();
            for (int i = 0; i < hex.Length; i++)
            {
                char valAt = hex[hex.Length - 1 - i];
                result += Hexdecval[valAt] * (int)Math.Pow(16, i);
            }
            return result;
        }
        public static string decimalHexadecimal(int numero)
        {

            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F' };

            string hexadecimal = "";

            const int DIVISOR = 16;
            long resto = 0;

            for (int i = numero % DIVISOR, j = 0; numero > 0; numero /= DIVISOR, i = numero % DIVISOR, j++)
            {
                resto = i % DIVISOR;
                if (resto >= 10)
                {
                    hexadecimal = letras[resto - 10] + hexadecimal;

                }
                else
                {
                    hexadecimal = resto + hexadecimal;
                }
            }
            return hexadecimal;

        }
    }
}
