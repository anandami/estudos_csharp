using System;

namespace EstruturaCondicional {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine("Escola o exercicio que deseja resolver: ");
            Console.WriteLine("[1] Para escolher apontador de valores positivos e negativos.");
            Console.WriteLine("[2] Para escolher apontador de valores pares ou ímpares.");
            Console.WriteLine("[3] Para escolher apontador de dois múltiplos.");
            Console.WriteLine("[4] Contador de início e fim de jogo.");
            Console.WriteLine("[5] Calcule sua conta da lanchonete.");
            Console.WriteLine("[6] Intervalo de valores.");
            Console.WriteLine("[0] Para sair.");
            Console.Write("R:");
            int resp = int.Parse(Console.ReadLine());
            switch (resp) {
                case 0:
                    Console.WriteLine("Saiu!");
                    break;
                case 1:
                    string retorno1 = exercicio1();
                    Console.WriteLine("O número digitado é " + retorno1);
                    break;
                case 2:
                    string retorno2 = exercicio2();
                    Console.WriteLine("O número digitado é " + retorno2);
                    break;
                case 3:
                    string retorno3 = exercicio3();
                    Console.WriteLine("Os números digitados" + retorno3);
                    break;
                case 4:
                    int retorno4 = exercicio4();
                    Console.WriteLine("O tempo de duracao do jogo é de " + retorno4 + " horas.");
                    break;
                case 5:
                    float retorno5 = exercicio5();
                    Console.WriteLine("O total da conta é R$" + retorno5);
                    break;
                case 6:
                    string retorno6 = exercicio6();
                    Console.WriteLine("O intervalo é: " + retorno6);
                    break;
                default:
                    Console.WriteLine("Valor digitado não corresponde a uma função especificada:");
                    break;

            }
        }

        static string exercicio1() {
            Console.WriteLine("Digite um número inteiro");
            Console.Write("R:");
            int num = int.Parse(Console.ReadLine());
            string resp = "";
            if (num > 0) {
                resp = "Valor positivo";
            }
            else if (num < 0) {
                resp = "Valor negativo";
            } 
            else {
                resp = "Valor 0";
            }
            return resp;
        }

        static string exercicio2() {
            Console.WriteLine("Digite um número inteiro");
            Console.Write("R:");
            int num = int.Parse(Console.ReadLine());
            string resp = "";
            if (num % 2 == 0) {
                resp = "PAR";
            } 
            else {
                resp = "ÍMPAR";
            }
            return resp;
        }

        static string exercicio3 () {
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            string resp = "";
            if (num1%num2==0 || num2 % num1 == 0) {
                resp = " são múltiplos";
            } else {
                resp = " não são múltiplos";
            }

            return resp;
        }

        static int exercicio4 () {
            int duracao = 0;
            Console.WriteLine("Digite o horario de início do jogo:");
            Console.Write("R:");
            int inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o horario de fim do jogo.");
            Console.Write("R:");
            int fim = int.Parse(Console.ReadLine());
            if ((inicio > 24) || (fim > 24)) {
                Console.WriteLine("O valor digitado é inválido. Por favor, digite somente horas no formato 0-24h.");
                duracao = 0;
            }
            else if (inicio >= fim) {
                duracao = 24 - inicio;
                duracao += fim;
            } 
            else {
                duracao = fim - inicio;
            }

            return duracao;

        }

        static float exercicio5 () {
            float final = 0f;
            Console.WriteLine("--- SISTEMA LANCHONETE HelloWorldBurger ---");
            string saida = "S";
            float tot = 0f;
            while (saida == "S"){
                Console.WriteLine("-- Digite o código do item abaixo para calcular --");
                Console.WriteLine("CODIGO   ESPECIFICAÇÃO    PREÇO");
                Console.WriteLine("1        Cachorro Quente  R$4.00");
                Console.WriteLine("2        X-Salada         R$4.50");
                Console.WriteLine("3        X-Bacon          R$5.00");
                Console.WriteLine("4        Torrada Simples  R$2.00");
                Console.WriteLine("5        Refrigerante     R$1.50");
                Console.WriteLine("--------------------------------");
                Console.Write("CÓDIGO: ");
                int cod = int.Parse(Console.ReadLine());
                Console.Write("Quantidade do Item:");
                int quant = int.Parse(Console.ReadLine());
                
                //Seleciona o item
                switch (cod) {
                    case 1:
                        tot = 4f * quant;
                        break;
                    case 2:
                        tot = 4.5f * quant;
                        break;
                    case 3:
                        tot = 5f * quant;
                        break;
                    case 4:
                        tot = 2f * quant;
                        break;
                    case 5:
                        tot = 1.5f * quant;
                        break;
                    default:
                        tot = 0f;
                        break;
                     
                }
                Console.WriteLine("TOTAL: R$" + tot);
                final += tot;
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Deseja adicionar mais algum produto? ['S' para continuar ou qualquer tecla para sair]");
                Console.Write("R: ");
                saida = Console.ReadLine();
            }
            return final;
        }

        static string exercicio6 () {
            Console.WriteLine("Digite um valor qualquer que diremos em qual dos seguintes intervalos([0, 25], (25, 50], (50, 75], (75, 100]) este valor se encontra.");
            Console.Write("R:");
            float num = Console.Read();

            string intervalo = "";

            if (num >= 0 && num <= 25) {
                intervalo = ("Intervalo [0,25]");
            } else if (num > 25 && num <= 50) {
                intervalo = ("Intervalo[25, 50]");
            } else if (num > 50 && num <= 75) {
                intervalo = ("Intervalo[50, 75]");
            } else if (num > 75 && num <= 100) {
                intervalo = ("Intervalo[75, 100]");
            } else {
                intervalo = ("Fora do intervalo");
            }

            return intervalo;
        }
    }
}
