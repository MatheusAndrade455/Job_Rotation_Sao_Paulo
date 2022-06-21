using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra;
            int j = 1;                                

            Console.WriteLine("Escreva uma palavra ou frase para ser invertida:");
            palavra = Console.ReadLine();

            char[] characters = palavra.ToCharArray();            
            char[] inverso = palavra.ToCharArray();

            for (int i = 0; i < characters.Length; i++)            
            {               
               inverso[i] = characters[characters.Length - j];   
               j++;           
            }
            Console.Write("\nA string invertida fica: ");
            Console.Write(inverso);            
        }
    }
}