using System;

namespace testeDeExcecoes3
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                Console.WriteLine("Teste de Exceções e callstack");
                Metodo();
                CriacaoDeObjeto();
            }
            catch(Exception e) {
                System.Console.WriteLine("Foi encontrato um erro. Finalizando.");
                string message = e.Message;
                string track = e.StackTrace;
                System.Console.WriteLine(message);
                System.Console.WriteLine(track);
                System.Console.WriteLine("Fim!");
                
            }
            
        }
        static void Metodo(){
            System.Console.WriteLine("Início do teste de método");
            int result3 = TestaDivisao(10,0);      
            System.Console.WriteLine(result3);
            int result1 = TestaDivisao(10,10);
            System.Console.WriteLine(result1);
            int result2 = TestaDivisao(20,10);
            System.Console.WriteLine(result2);
            System.Console.WriteLine("Fim do teste de método");
                        
        }

        static int TestaDivisao(int dividendo, int divisor){
            
            return dividendo/divisor;
        }

        static void CriacaoDeObjeto(){

            System.Console.WriteLine("Começo do teste de criação de objeto");
            NovaClasse novo = null;
            novo.nome = "teste";
            System.Console.WriteLine("Fim do teste de criacao de objeto");
 
        }

    }
}