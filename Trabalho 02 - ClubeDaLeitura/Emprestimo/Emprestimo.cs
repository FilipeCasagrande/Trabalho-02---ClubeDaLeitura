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
        public int id;
        public string amigo;
        public string revista;
        public DateTime data;
        public string situacao;

        public override void AtualizarRegistro(EntidadeBase entidade) // MUDAR
        {
            Emprestimo caixaAtualizado = (Emprestimo)entidade;

            this.amigo = caixaAtualizado.amigo;
            this.revista = caixaAtualizado.revista;

        }

        public override string Validar() // MUDAR
        {
            string erros = "";

            string padraoTelefone = @"^\(\d{2}\) \d{4,5}-\d{4}$";

            if (amigo.Length > 50)
                erros += "O campo \"Etiqueta\" deve conter no máximo 50 caracteres.\n";
            return erros;
        }
    }
}

