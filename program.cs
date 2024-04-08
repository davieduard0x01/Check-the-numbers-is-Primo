using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Números de 1 - 100 Primos");
            for (int i = 2; i <= 100; i++)
            {
                bool nprimo = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        nprimo = false;
                        
                    }
                }
                if (nprimo)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
