﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PastaTabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; set; }
        public Tabuleiro Tabuleiro { get; set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = null;
            Tabuleiro = tabuleiro;
            Cor = cor;
            QteMovimentos = 0;
        }

        public void incrementarMovimentos()
        {
            QteMovimentos++;
        }

        //Matriz de booleano
        public abstract bool[,] MovimentosPossiveis();
    }
}
