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
            Console.WriteLine("Estou pensando em um número entre 1 e 5.");
            Console.WriteLine("Tente adivinhar que número é este.");
            // -----------------------------------------------------------------
            while (true)
            {
                // Gerador de números.
                Random random = new Random();
                int nunRandom = random.Next(1, 5);
                // --------------------------------
                Console.WriteLine("============================================");
                int nunEscolhido = Convert.ToInt32(Console.ReadLine());

                // Condições para determinar se o jogador venceu ou não.
                if (nunEscolhido == nunRandom)
                {
                    Console.WriteLine("Parabéns, você acertou.");
                }
                else
                {
                    Console.WriteLine("Você errou, tente novamente.");
                }
                // -------------------------------------------------------------
            }
        }
    }
}
