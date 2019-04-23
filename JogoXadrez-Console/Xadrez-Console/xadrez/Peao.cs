using System;
using tabuleiro;
using tabuleiro.Enums;

namespace xadrez
{
    class Peao// : Peca
    {
        public Peao(Tabuleiro tab, Cor cor)// : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "P";
        }
    }
}
