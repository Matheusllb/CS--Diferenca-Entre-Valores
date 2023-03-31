using System;
using System.Globalization;

namespace CsE3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EXERCICIO 3
            Console.WriteLine("Calculando a diferenca entre valores inteiros\n\nValor A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor C: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor D: ");
            int d = int.Parse(Console.ReadLine());

            int dif = (a * b - c * d);

            Console.WriteLine("\nDiferença: " + dif);
            Console.WriteLine("\nFim do Programa!\n");
        }
    }
}
