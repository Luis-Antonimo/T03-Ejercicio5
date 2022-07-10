using System;

namespace T03Ejercicio5
{
    class Program
    {
        static void Main()
        {
            int a = 10;
            int b = 20;
            int c = 30;
            int d = 40;
            Console.WriteLine("Las variables originales son A:{0} B:{1} C:{2} D:{3}", a, b, c, d);
            d = b;
            b = c;
            c = a;
            a = d;
            Console.WriteLine("Las variables modificadas son A:{0} B:{1} C:{2} D:{3}", a, b, c, d);
        }
    }
}