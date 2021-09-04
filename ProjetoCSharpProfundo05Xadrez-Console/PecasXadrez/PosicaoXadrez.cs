using PastaTabuleiro;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharpProfundo05Xadrez_Console.PecasXadrez
{
    class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao ToPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString()
        {
            return "" + Linha + Coluna;
        }
    }
}
