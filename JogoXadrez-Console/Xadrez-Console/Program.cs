﻿using System;
using tabuleiro;
using xadrez_Console.Xadrez;
using tabuleiro.Enums;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
            tab.ColocarPeca(new Peao(tab, Cor.Preta), new Posicao(3, 7));

            Tela.Imprimirtabuleiro(tab);

            Console.ReadLine();
        }
    }
}
