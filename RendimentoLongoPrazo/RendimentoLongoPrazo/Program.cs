using System;

namespace RendimentoLongoPrazo {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine("CALCULO DE RENDIMENTO A LONGO PRAZO");
            //atualização posterior - adicionar a quantidade de tempo em anos que o usuário deseja manter suas aplicações
            int ano = 5;
            double fatorRendimento = 1.0036;
            double valorInvestido = 1000.0;

            for (int i=0; i<ano; i++) {
                
                //calcula o rendimento anual, mês a mês
                for (int j=0; j<12; j++) {
                    valorInvestido *= fatorRendimento;

                }

                Console.WriteLine("Você possuirá ao final do ano " + (int)(i+1) + " o equivalente a R$" + valorInvestido);
                Console.WriteLine("Desta quantidade R$" + (valorInvestido - 1000.0) + " corresponde ao rendimento.");


                //ao final de cada ano sem retirada, aumenta em 0,10% o rendimento
                fatorRendimento += 0.0010;
            }



        }
    }
}
