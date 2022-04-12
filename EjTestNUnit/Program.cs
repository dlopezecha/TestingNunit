using System;

namespace EjTestNUnit
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
        }

        public static string Something()
        {
            return "algo";
        }

        /*
        public static bool Loguin(string v1, string v2)
        {
            return (v1 == "mpajaro" && v2 == "123456");
        }
        */
        public static bool Loguin(string v1, string v2) =>
            (v1 == "mpajaro" && v2 == "123456");
    }
}
