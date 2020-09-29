using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador1 : iJogador
     {         
         public readonly string _Nome;
          
         public Jogador1(string nome = "Ronaldo")
         {
             _Nome = nome;
         }

         public string Chuta()
         {
             return $"{_Nome} está chutando ";
         }
         public string Corre()
         {
             return $"{_Nome} está correndo ";
         }
         public string Passe()
         {
             return $"{_Nome} está passando ";
         }
     }
}