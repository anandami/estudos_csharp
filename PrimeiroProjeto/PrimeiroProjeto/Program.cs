using System;
using System.Globalization;

namespace PrimeiroProjeto {
    class Program {
        static void Main (string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preco é $ {preco1:F2}.");
            Console.WriteLine("{0}, cujo preco é ${1}.", produto2, preco2.ToString("F2"));
            Console.WriteLine("");
            Console.WriteLine("Registro: {0} anos de idade, codigo {1} e gênero: {2}", idade,codigo, genero);
            Console.WriteLine("");
            Console.Write("Medida com oito casas decimais: ");
            Console.WriteLine(medida.ToString("F8", CultureInfo.InvariantCulture));
            Console.Write("Arredondado para três casas decimais:");
            Console.WriteLine(medida.ToString("F3"));
            Console.Write("Separador decimal invariant culture:");
            Console.Write(medida.ToString(CultureInfo.InvariantCulture));

        }
    }
}
