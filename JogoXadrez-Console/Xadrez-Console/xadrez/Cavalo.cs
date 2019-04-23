﻿using System;
using tabuleiro;
using tabuleiro.Enums;

namespace Xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "C";
        }
    }
}
