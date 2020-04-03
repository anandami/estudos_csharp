using System;

namespace CondicaoHora {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12) { //como este bloco de comando é um só, estas chaves são opcionais
                Console.WriteLine("Bom Dia");
            }
            else if(hora < 18){
                Console.WriteLine("Boa Tarde!");
            } 
            else {
                Console.WriteLine("Boa Noite!");
            }
        }
    }
}
