using System;
using GameTop.Interface;

namespace GameTop
{
    public class jogoFoda
    {
        private readonly iJogador _jogadora;

        private readonly iJogador _jogadorb;

        public jogoFoda(iJogador jogador1, iJogador jogador2)
        {
            _jogadora = jogador1;
            _jogadorb = jogador2;
        }
        public void IniciarJogo()
        {
            Console.Write( _jogadora.Chuta());
            Console.Write( _jogadora.Corre());
            Console.Write( _jogadora.Passe());

            Console.Write( "\n proximo jogador \n");

            Console.Write( _jogadorb.Chuta());
            Console.Write( _jogadorb.Corre());
            Console.Write( _jogadorb.Passe());
        }

    }
}