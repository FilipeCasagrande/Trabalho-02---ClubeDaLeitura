using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_02___ClubeDaLeitura.Amigos
{
    public class RepositorioAmigo
    {
        private Amigo[] amigos = new Amigo[100];
        public int contadorAmigo = 0;


        public void Cadastrarregistro(Amigo amigo)
        {
            amigos[contadorAmigo] = amigo;
            contadorAmigo++;
        }


    }
}
