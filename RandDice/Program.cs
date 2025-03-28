using System;
using System.Runtime.InteropServices;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random r1 = new Random(int.Parse(args[1]));
            int soma=0;

            for (int i = 0; i < int.Parse(args[0]); i++)
                soma+=r1.Next(1, 7);

            Console.WriteLine(soma);
        }
    }
}