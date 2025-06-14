﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_02___ClubeDaLeitura.Compartilhado
{
    public abstract class EntidadeBase
    {

        public int id;
        public string nome;
        public string telefone;

        public abstract void AtualizarRegistro(EntidadeBase registroAtualizado);
        public abstract string Validar();
    }
}

