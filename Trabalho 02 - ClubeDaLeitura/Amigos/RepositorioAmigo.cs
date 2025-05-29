using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Trabalho_02___ClubeDaLeitura.Amigos
{
    public class RepositorioAmigo
    {
        private Amigo[] amigos = new Amigo[100];
        public int contadorAmigo = 0;


        public void CadastrarRegistro(Amigo amigo)
        {
            amigos[contadorAmigo] = amigo;
            contadorAmigo++;
        }

        public Amigo[] SelecionarRegistros()
        {
            return amigos;
        }

        public bool EditarRegistro(string nomeAmigo, Amigo registroAtualizado)
        {
            Amigo registroSelecionado = SelecionarAmigo(nomeAmigo);

            if (registroSelecionado == null)
                return false;

            registroSelecionado.AtualizarRegistro(registroAtualizado);

            return true;
        }

        public Amigo SelecionarAmigo(string nomeAmigo)
        {
            for (int i = 0; i < amigos.Length; i++)
            {
                Amigo amigo = amigos[i];

                if (amigo == null)
                    continue;

                if (amigo.nome == nomeAmigo)
                    return amigo;
            }

            return null;
        }

    }
}
