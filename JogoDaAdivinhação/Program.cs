using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaAdivinhação
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boas vindas
            Console.WriteLine("Bem-vindo(a) ao jogo da adivinhação");

            // Menu
            Console.WriteLine("[ 1 ] Iniciar jogo.     [ 2 ] Sair");
            int menuEscolha = Convert.ToInt32(Console.ReadLine());

            if (menuEscolha == 1)
            {

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
            // -----------------------------------------------------------------
            while (true)
            {
                // Gerador de números.
                Random random = new Random();
                string nunRandom = random.Next(1, 6).ToString();
                // --------------------------------
                Console.WriteLine("============================================");
                string nunEscolhido = Console.ReadLine();

                // Anti-bug
                bool error = false;
                if (nunEscolhido == "")
                {
                    error = true;
                }
                //-------------------------------------------------------

                // Condições para determinar se o jogador venceu ou não.
                if (nunEscolhido == nunRandom && error == false)
                {
                    Console.WriteLine("Parabéns, você acertou.");
                }
                else if (error == true)
                {
                    Console.WriteLine("Você digitou um número inválido");
                }
                else if (nunEscolhido != nunRandom)
                {
                    Console.WriteLine("Você errou, tente novamente.");
                    Console.WriteLine($"O número que estava pensando era {nunRandom}");
                }
                else if (nunEscolhido == "0")
                {
                    Environment.Exit(0);
                }
                // -------------------------------------------------------------
            }
        }
    }
}
