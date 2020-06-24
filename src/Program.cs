using System;
using System.Threading;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boas vindas
            Console.WriteLine("Bem-vindo(a) ao jogo da adivinhação");

            // Menu
            Console.WriteLine("[ 1 ] - Iniciar jogo.     [ 2 ] - Sair.");
            int menuEscolha = Convert.ToInt32(Console.ReadLine());
            int times = 0; //Número padrão
            switch(menuEscolha)
            {
                case 1:
                Console.WriteLine("Quantas vezes você vai jogar?");
                times = Convert.ToInt32(Console.ReadLine());
                break;
            
                case 2:
                Environment.Exit(0);
                break;

                default:
                Console.WriteLine("Você digitou um número inválido");
                return;
            }
            int timeWhitoutModifiers = times;

            //Dificuldade
            Console.WriteLine("Selecione a dificuldade:");
            Console.WriteLine("[ 1 ] - Facil.    [ 2 ] - Médio.    [ 3 ] - Difícil.    [ 4 ] - Inpossível.");
            int dificultChoice = Convert.ToInt32(Console.ReadLine());
            int randMax = 0;//Valores que vão ser usados para determinar o range dos números aleatórios gerados
            switch(dificultChoice){
                case 1:
                randMax = 6;
                break;
                case 2:
                randMax = 11;
                break;
                case 3:
                randMax = 31;
                break;
                case 4:
                randMax = 101;
                break;
                default:
                Console.WriteLine("Você digitou um núemro inválido.");
                Environment.Exit(1);
                break;
            }

            Console.WriteLine($"Estou pensando em um número entre 1 e {randMax - 1}.");
            Console.WriteLine("Tente adivinhar que número é este (0 para sair do jogo):");

            int pontuacao = 0;
            while(times != 0){
                Random random = new Random();
                int nunbRandom = random.Next(1, randMax);

                int nunbEscolhido = Convert.ToInt32(Console.ReadLine());//Onde o usuário vai escolher o número
                if(nunbEscolhido == 0){//Verificar se há número dado
                    Environment.Exit(0);
                }

                if(nunbEscolhido == nunbRandom){
                    Console.WriteLine("Você acertou.");
                    pontuacao = pontuacao + 1;
                }else{
                    Console.WriteLine($"Você errou. O número era: {nunbRandom}");
                    Console.WriteLine("Tente novamete:");
                }
                times -= 1;
            }

            Console.WriteLine($"Sua pontuação foi de {pontuacao}/{timeWhitoutModifiers}");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
