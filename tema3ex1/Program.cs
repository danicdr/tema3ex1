using System;
//Scrieti o functie care va calcula suma cifrelor unui numar.
namespace MyFirstProgram2._1
{
    class Program
    {
        static int SumaCifrelor(int numar)
        {
            int suma = 0;
            while (numar != 0)
            {
                suma += numar % 10;
                numar /= 10;
            }
            return suma;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar:");
            int numar = int.Parse(Console.ReadLine());
            int suma = SumaCifrelor(numar);
            Console.WriteLine(suma);
        }
    }
}
