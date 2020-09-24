using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porjeto_Final
{
    public class Jogador
    {

        private string nome;
        private int pontos;

        public string Nome { get => nome; set => nome = value; }
        public int Pontos { get => pontos; set => pontos = value; }
        public string mostraResultado()
        {
            string aux = "";
            aux = Nome + "\t\t" + Pontos.ToString() + " Pontos";
            return aux;
        }


    }
}
