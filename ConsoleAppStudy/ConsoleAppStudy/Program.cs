using System;

namespace ConsoleAppStudy
{
    class FirstProgram
    {
        static void Main(string[] args)
        {
            //declaração de variaveis
            string nome1;
            string nome2;
            int idade1;
            int idade2;
            Console.WriteLine("EXERCICIO: Fazer um programa para ler os dados de duas pessoas e mostrar quem é a mais velha.");
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            idade1 = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            idade2 = int.Parse(Console.ReadLine());
            if (idade1 > idade2) {
                Console.WriteLine(nome1 + " é a pessoa mais velha!");
            } else {
                Console.WriteLine(nome2 + " é a pessoa mais velha!");
            }
        }
    }
}
