using PastaTabuleiro;
using System;

namespace ProjetoCSharpProfundo05Xadrez_Console
{
     class Tela
     {
        
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                for(int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.Peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.WriteLine(tab.Peca(i,j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
     }
}
