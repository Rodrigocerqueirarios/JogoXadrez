using System;
using tabuleiro;
using tabuleiro.Enums;

namespace xadrez_Console.Xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
