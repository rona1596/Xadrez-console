using System;
using System.Collections.Generic;
using System.Text;

namespace PastaTabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; set; }
        public Tabuleiro Tabuleiro { get; set; }

        public Peca(Posicao posicao, Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = posicao;
            Tabuleiro = tabuleiro;
            Cor = cor;
            QteMovimentos = 0;
        }
    }
}
