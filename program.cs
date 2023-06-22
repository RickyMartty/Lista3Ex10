using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] p = new int[10];
            int d, f=0;

            for (int i = 0; i < 10; i++)
            {
                do
                {

                    Console.Write("Digite um N° positivo:");
                    p[i] = int.Parse(Console.ReadLine());

                    if (p[i] > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Nº Aceito.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("N° não foi aceito");
                    }
                    Console.ForegroundColor = ConsoleColor.White;

                } while (p[i] < 0);
            }
            Console.Clear();

            d = p.Max();
            Console.WriteLine($"O maior valor é {d}");

            for( int i = 0;i < 10;i++)
            {
                f = f + p[i];
            }
            Console.WriteLine($"A soma dos valores é de {f}");

            d = f / 10;
            Console.WriteLine($"A média aritmética é de {d}");
        }
    }
}
