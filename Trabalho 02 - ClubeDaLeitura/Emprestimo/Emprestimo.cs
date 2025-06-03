using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_02___ClubeDaLeitura.Compartilhado;

namespace Trabalho_02___ClubeDaLeitura.Emprestimo
{
    public class Emprestimo : EntidadeBase
    {
        public int idAmigo;
        public string nome;
        public string revista;
        public DateTime data;
        public string situacao;

        public override void AtualizarRegistro(EntidadeBase entidade)
        {
            Emprestimo emprestimoAtualizado = (Emprestimo)entidade;

            this.idAmigo = emprestimoAtualizado.idAmigo;
            this.revista = emprestimoAtualizado.revista;

        }

        public override string Validar() 
        {
            string erros = "";
            return erros;
        }
    }
}

