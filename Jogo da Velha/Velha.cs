 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Velha
{
    public class Velha
    {
        /// <summary>
        ///
        ///   O método analisa o registro de uma partida de jogo da velha e determina
        ///   quem venceu.
        ///
        /// </summary>
        ///
        /// <param name="partida">
        ///
        ///   A partida é registrada numa sequência de coordenadas separadas por
        ///   espaços:
        ///   
        ///     "x:2,2 o:2,1 x:3,3 o:1,1 x:3,1 o:1,3 x:3,2"
        ///       
        ///   Cada coordenada é formada da seguinte forma:
        ///   
        ///     - O símbolo do jogador seguido de dois pontos: 'x:' ou 'o:'
        ///     - A coordenada da linha e da coluna escolhida pelo jogador.
        ///       Os índices das linhas e das colunas variam entre 1 e 3.
        ///
        /// </param>
        /// 
        /// <returns>
        ///
        ///   O resultado é um inteiro identificando o empate ou o jogador vencedor da
        ///   seguinte forma:
        ///     -1  O jogador 'x' venceu a partida.
        ///      0  Nenhum jogador venceu a partida.
        ///      1  O jogador 'o' venceu a partida. 
        ///
        /// </returns>
        public int QuemVenceu(string partida)
        {
            tabuleiro = new int[3, 3] {
                {0,0,0},
                {0,0,0},
                {0,0,0}
            };
            string[] jogadas = partida.Split(' '); // Primeiro passo, dividir a partida em jogadas
            
            for( int i = 0; i < jogadas.Length; i++)
            {
                string jogada = jogadas[i];

                string[] jogadaDividida = jogada.Split(':');

                string jogador = jogadaDividida[0];
                string movimento = jogadaDividida[1];

                string[] movimentoDividido = movimento.Split(',');

                int linha = Convert.ToInt32(movimentoDividido[0]) -1;
                int coluna = Convert.ToInt32(movimentoDividido[1]) -1;

                int jogadorInt = (jogador == "x") ? -1 : 1;

                tabuleiro[linha, coluna] = jogadorInt;

                if ( 
                    (tabuleiro[0, 0] == tabuleiro[0, 1] && tabuleiro[0, 0] == tabuleiro[0, 2] && tabuleiro[0, 0] == jogadorInt) ||
                    (tabuleiro[1, 0] == tabuleiro[1, 1] && tabuleiro[1, 0] == tabuleiro[1, 2] && tabuleiro[1, 0] == jogadorInt) ||
                    (tabuleiro[2, 0] == tabuleiro[2, 1] && tabuleiro[2, 0] == tabuleiro[2, 2] && tabuleiro[2, 0] == jogadorInt) ||
                    
                    (tabuleiro[0, 0] == tabuleiro[1, 0] && tabuleiro[0, 0] == tabuleiro[2, 0] && tabuleiro[0, 0] == jogadorInt) ||
                    (tabuleiro[0, 1] == tabuleiro[1, 1] && tabuleiro[0, 1] == tabuleiro[2, 1] && tabuleiro[0, 1] == jogadorInt) ||
                    (tabuleiro[0, 2] == tabuleiro[1, 2] && tabuleiro[0, 2] == tabuleiro[2, 2] && tabuleiro[0, 2] == jogadorInt) ||
                    
                    (tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[0, 0] == tabuleiro[2, 2] && tabuleiro[0, 0] == jogadorInt) ||
                    (tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[0, 2] == tabuleiro[2, 0] && tabuleiro[0, 2] == jogadorInt)

                    )
                {
                    return jogadorInt;    

                }

            }

            

            return 0;
        }

        public int[,] tabuleiro;

    

    }
}
