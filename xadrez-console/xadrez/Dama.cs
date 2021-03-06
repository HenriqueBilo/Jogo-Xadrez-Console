﻿using tabuleiro;

namespace xadrez
{
    class Dama : Peca
    {
        public Dama(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "D";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);

            //Esquerda = Linha, Coluna - 1
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            //Lógica da Dama
            //Caso a posição seja válida e for possível mover
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                //Se tiver algo na posição e for de cor diferente
                if (tab.peca(pos) != null && tab.peca(pos).cor != this.cor)
                {
                    break;
                }
                pos.definirValores(pos.linha, pos.coluna - 1);
            }

            //Direita = Linha, Coluna + 1
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                //Se tiver algo na posição e for de cor diferente
                if (tab.peca(pos) != null && tab.peca(pos).cor != this.cor)
                {
                    break;
                }
                pos.definirValores(pos.linha, pos.coluna + 1);
            }

            //Acima = Linha - 1, Coluna
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                //Se tiver algo na posição e for de cor diferente
                if (tab.peca(pos) != null && tab.peca(pos).cor != this.cor)
                {
                    break;
                }
                pos.definirValores(pos.linha - 1, pos.coluna);
            }

            //Abaixo = Linha + 1, Coluna
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                //Se tiver algo na posição e for de cor diferente
                if (tab.peca(pos) != null && tab.peca(pos).cor != this.cor)
                {
                    break;
                }
                pos.definirValores(pos.linha + 1, pos.coluna);
            }

            //Noroeste = Linha - 1, Coluna - 1
            pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                //Se tiver algo na posição e for de cor diferente
                if (tab.peca(pos) != null && tab.peca(pos).cor != this.cor)
                {
                    break;
                }
                pos.definirValores(pos.linha - 1, pos.coluna - 1);
            }

            //Nordeste = Linha - 1, Coluna + 1
            pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                //Se tiver algo na posição e for de cor diferente
                if (tab.peca(pos) != null && tab.peca(pos).cor != this.cor)
                {
                    break;
                }
                pos.definirValores(pos.linha - 1, pos.coluna + 1);
            }

            //Sudeste = Linha + 1, Coluna + 1
            pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                //Se tiver algo na posição e for de cor diferente
                if (tab.peca(pos) != null && tab.peca(pos).cor != this.cor)
                {
                    break;
                }
                pos.definirValores(pos.linha + 1, pos.coluna + 1);
            }

            //Sudoeste = Linha + 1, Coluna - 1
            pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                //Se tiver algo na posição e for de cor diferente
                if (tab.peca(pos) != null && tab.peca(pos).cor != this.cor)
                {
                    break;
                }
                pos.definirValores(pos.linha + 1, pos.coluna - 1);
            }

            return mat;
        }
    }
}
