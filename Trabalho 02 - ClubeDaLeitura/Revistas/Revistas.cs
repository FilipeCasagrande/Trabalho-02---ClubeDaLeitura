using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_02___ClubeDaLeitura.Compartilhado;

namespace Trabalho_02___ClubeDaLeitura.Revistas
{
     public class Revistas : EntidadeBase
    {
        public int id;
        public string titulo;
        public string numeroAno;
        public string status;
        public string caixa;

        public override void AtualizarRegistro(EntidadeBase entidade)
        {
            Revistas caixaAtualizado = (Revistas)entidade;

            this.titulo = caixaAtualizado.titulo;
            this.numeroAno = caixaAtualizado.numeroAno;
            this.status = caixaAtualizado.status;
            this.caixa = caixaAtualizado.caixa;

        }
        public override string Validar()
        {
            string erros = "";

            string padraoTelefone = @"^\(\d{2}\) \d{4,5}-\d{4}$";

            if (titulo.Length > 50)
                erros += "O campo \"Etiqueta\" deve conter no máximo 50 caracteres.\n";
            return erros;
        }
    }
}
