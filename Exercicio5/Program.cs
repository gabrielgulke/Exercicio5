using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 5 \nNúmeros pares entre 1 e 100");

            for (int i = 1; i <= 50; i++)
                Console.WriteLine(i * 2);
            Console.ReadKey();
        }
    }
}
