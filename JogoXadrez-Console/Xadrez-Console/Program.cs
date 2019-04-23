using System;
using tabuleiro;
using xadrez;
using tabuleiro.Enums;
using tabuleiro.exceptions;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.Imprimirtabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partida.ExecutarMovimento(origem, destino);
                }

                Tela.Imprimirtabuleiro(partida.tab);

                //PosicaoXadrez pos = new PosicaoXadrez('c', 7);

                //Console.WriteLine(pos);
                //Console.WriteLine(pos.ToPosicao());

                Console.ReadLine();
            }                
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
