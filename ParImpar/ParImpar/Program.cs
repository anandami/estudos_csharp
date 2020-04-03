using System;

namespace ParImpar {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine("Entre com um número inteiro:");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) {
                Console.WriteLine("O número é par");
            } else {
                Console.WriteLine("O número é ímpar");
            }
        }
    }
}
