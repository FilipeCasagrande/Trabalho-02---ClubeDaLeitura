﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_02___ClubeDaLeitura.Compartilhado
{
    public class RepositorioBase
    {

        private EntidadeBase[] registros = new EntidadeBase[100];
        private int contadorRegistros = 0;
        private int contadorId = 1;

        public void CadastrarRegistro(EntidadeBase novoRegistro)
        {
            novoRegistro.id = contadorId;
            registros[contadorRegistros] = novoRegistro;
            contadorRegistros++;
            contadorId++;
            
        }

        public bool EditarRegistro(int idSelecionado, EntidadeBase registroAtualizado)
        {
            EntidadeBase registroSelecionado = SelecionarRegistroPorId(idSelecionado);

            if (registroSelecionado == null)
                return false;

            registroSelecionado.AtualizarRegistro(registroAtualizado);

            return true;
        }

        public virtual bool ExcluirRegistro(int idSelecionado)
        {
            for (int i = 0; i < registros.Length; i++)
            {
                if (registros[i] == null)
                    continue;

                else if (registros[i].id == idSelecionado)
                {
                    registros[i] = null;

                    return true;
                }
            }

            return false;
        }

        public EntidadeBase[] SelecionarRegistros()
        {
            return registros;
        }

        public EntidadeBase SelecionarRegistroPorId(int idSelecionado)
        {
            for (int i = 0; i < registros.Length; i++)
            {
                EntidadeBase registro = registros[i];

                if (registro == null)
                    continue;

                if (registro.id == idSelecionado)
                    return registro;
            }
            return null;
        }

    }
}

