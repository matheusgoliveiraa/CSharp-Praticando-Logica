using System;

namespace CelsiusFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em graus Cº: ");
            int celsius = int.Parse(Console.ReadLine());

            double temperatura = celsius * 1.8;
            float Fahrenheit = (float)(temperatura + 32);

            Console.WriteLine("A temperatura de graus celsius para Fahrenheit é: " + Fahrenheit);
        }
    }
}