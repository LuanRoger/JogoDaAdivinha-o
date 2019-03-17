using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace JogoDaAdivinhação
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boas vindas
            Console.WriteLine("Bem-vindo(a) ao jogo da adivinhação");
            //-----------------------------------------------------------

            // Menu
            Console.WriteLine("[ 1 ] Iniciar jogo.     [ 2 ] Sair");
            int menuEscolha = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(3000);
            int vezes = 0;
            if (menuEscolha == 1)
            {
                Console.WriteLine("Quantas vezes você vai jogar?");
                vezes = Convert.ToInt32(Console.ReadLine());
            }
            else if (menuEscolha == 2)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Você digitou um número inválido");
                return;
            }
            //----------------------------------------------------------------
            Console.WriteLine("Estou pensando em um número entre 1 e 5.");
            Console.WriteLine("Tente adivinhar que número é este. (0 para sair do jogo.)");
            //-----------------------------------------------------------------

            // Variaveis
            int pontuacao = 0;
            //---------------------------
            for (; vezes != -1; vezes--)
            {
                // Gerador de números.
                Random random = new Random();
                string nunRandom = random.Next(1, 6).ToString();
                //--------------------------------
                Console.WriteLine("============================================");
                string nunEscolhido = Console.ReadLine();

                // Anti-bug
                bool error = false;
                if (nunEscolhido == "")
                {
                    error = true;
                }
                //-------------------------------------------------------

                // Condições.
                if (nunEscolhido == nunRandom && error == false)
                {
                    Console.WriteLine($"Parabéns, você acertou. Faltam {vezes} números");
                    pontuacao = pontuacao + 1;
                }
                else if (error == true)
                {
                    Console.WriteLine("Você digitou um número inválido");
                    error = false;
                }
                else if (nunEscolhido != nunRandom && error == false && nunEscolhido != "0")
                {
                    Console.WriteLine($"Você errou, o número que estava pensando era {nunRandom}");
                    Console.WriteLine($"Faltam {vezes} números");
                }
                else if (nunEscolhido == "0")
                {
                    Console.WriteLine($"Sua pontuação foi de {pontuacao}/{vezes}");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                //-------------------------------------------------------------
            }
            Console.WriteLine($"Sua pontuação foi de {pontuacao}/{vezes + 1}");
            Console.ReadKey();
            Environment.Exit(0);

        }
    }
}
