using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona está chutando\n";
        }

        public string Corre()
        {
            return "Maradona está correndo\n";
        }

        public string Passe()
        {
            return "Maradona está passando\n";
        }
    }
}