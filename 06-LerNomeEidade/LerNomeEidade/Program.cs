using System;

namespace LerNomeEidade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Olá, {nome}, você tem {idade} anos.");

            Console.ReadLine();
        }
    }
}