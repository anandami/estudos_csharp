using System;

namespace testeDeExcecoes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste de Exceções e callstack");
            Metodo();
            CriacaoDeObjeto();
        }
        static void Metodo(){
            try{
              int result3 = TestaDivisao(10,0);      
              System.Console.WriteLine(result3);
              int result1 = TestaDivisao(10,10);
              System.Console.WriteLine(result1);
              int result2 = TestaDivisao(20,10);
              System.Console.WriteLine(result2);
              
            }
            catch(DivideByZeroException erro){
                System.Console.WriteLine("Foi encontrato um erro no método. Finalizando.");
                string message = erro.Message;
                string track = erro.StackTrace;
                System.Console.WriteLine(message);
                System.Console.WriteLine(track);
            }
                        
        }

        static int TestaDivisao(int dividendo, int divisor){
            
            return dividendo/divisor;
        }

        static void CriacaoDeObjeto(){
            try{
                
                NovaClasse novo = null;
                novo.nome = "teste";
                       
            }
            catch(NullReferenceException classeNula){
                System.Console.WriteLine("Classe sem ref a objeto");
                System.Console.WriteLine(classeNula.Message);
                System.Console.WriteLine(classeNula.StackTrace);
            }
        }

    }
}
