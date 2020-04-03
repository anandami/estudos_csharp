using System;
using System.Globalization;

namespace SegundoProjeto {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine("Entre com seu nome completo.");
            Console.Write("R: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Quantos quartos há na sua casa?");
            Console.Write("R: ");
            int room = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto");
            Console.Write("R: ");
            float value = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            Console.Write("R: ");
            string[] vet = Console.ReadLine().Split(' ');
            string name2 = vet[0];
            int age = int.Parse(vet[1]);
            float height = float.Parse(vet[2],CultureInfo.InvariantCulture);

            Console.WriteLine("SAÍDAS DE DADOS");
            Console.WriteLine(name1);
            Console.WriteLine(room);
            Console.WriteLine(value);
            Console.WriteLine(name2);
            Console.WriteLine(age);
            Console.WriteLine(height);
        }
    }
}
