using System;

namespace testeDeExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando exceções e a pilha de chamadas");
            Metodo1();
        }
        static void Metodo1(){
            System.Console.WriteLine("Iniciando o método 1");
            Metodo2();
            System.Console.WriteLine("Finalizando o método 1");
        }
        static void Metodo2(){
            System.Console.WriteLine("Iniciando o método 2");
            Metodo3();
            System.Console.WriteLine("Finalizando o método 2");
        }

        static void Metodo3(){
            System.Console.WriteLine("Iniciando o método 3");
            int dividendo = 10;
            int divisor = 0;

            try{
               int resultado = dividendo / divisor;     
            }
            catch(DivideByZeroException){
            
            }
            System.Console.WriteLine("Finalizando o último método");
        }
    }
}
