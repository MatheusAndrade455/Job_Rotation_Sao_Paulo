using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            double n1 = 0, n2 = 1, aux;

            Console.WriteLine("Digite o número que deseja verificar se pertence a sequência de Fibonacci:");
            num = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i​​​​​​​ < 100; i++)
            {                
                aux = n1;
                n1 = n2;
                n2 = n1 + aux;                

                if (n2 == num || num == 0)
                {
                    Console.WriteLine("O número informado pertence a sequência de Fibonacci!");
                    break;
                }
                else if (n2 > num || num < 0)
                {
                    Console.WriteLine("O número informado não pertence a sequência de Fibonacci!");
                    break;
                }
            }
        }
    }
}