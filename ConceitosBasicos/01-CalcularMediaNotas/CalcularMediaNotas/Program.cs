using System;
using System.Runtime.Serialization;

namespace CalcularMediaNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota: ");
            float nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            float nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a última nota: ");
            float nota3 = float.Parse(Console.ReadLine());

            float soma = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"A média final é: {soma:F2}");

        }
    }
}