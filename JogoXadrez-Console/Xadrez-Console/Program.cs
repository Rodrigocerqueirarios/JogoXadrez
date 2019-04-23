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
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
                tab.ColocarPeca(new Peao(tab, Cor.Branca), new Posicao(3, 7));

                Tela.Imprimirtabuleiro(tab);

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
