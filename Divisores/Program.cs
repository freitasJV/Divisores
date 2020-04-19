using System;

namespace Divisores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número inteiro: ");
            int x = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
