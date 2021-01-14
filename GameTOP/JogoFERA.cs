using System;
using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFERA
    {
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;

        public JogoFERA(iJogador jogadorA, iJogador jogadorB){
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
            System.Console.Write(_jogadorA.Corre());
            System.Console.Write(_jogadorA.Chuta());
            System.Console.Write(_jogadorA.Passe());
            //
            System.Console.Write("\n PRÓXIMO JOGADOR \n");
            //
            System.Console.Write(_jogadorB.Chuta());
            System.Console.Write(_jogadorB.Passe());
            System.Console.Write(_jogadorB.Corre());
        }
    }
}