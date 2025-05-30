using System.Text.RegularExpressions;
using Microsoft.Win32;
using Trabalho_02___ClubeDaLeitura.Compartilhado;

namespace Trabalho_02___ClubeDaLeitura.Amigos
{
    public class Amigo : EntidadeBase
    {
        public int id;
        public string nome;
        public string nomeResponsavel;
        public string telefone;

        public override void AtualizarRegistro(EntidadeBase entidade)
        {
            Amigo amigoAtualizado = (Amigo)entidade;

            this.nome = amigoAtualizado.nome;
            this.nomeResponsavel = amigoAtualizado.nomeResponsavel;
            this.telefone = amigoAtualizado.telefone;
        }

        public override string Validar()
        {
            string erros = "";

            string padraoTelefone = @"^\(\d{2}\) \d{4,5}-\d{4}$";

            if (nome.Length < 3 || nome.Length > 100)
                erros += "O campo \"Nome\" deve conter entre 3 e 100 caracteres.\n";

            else if (nomeResponsavel.Length < 3 || nomeResponsavel.Length > 100)
                erros += "O campo \"Nome do responsável\" deve conter entre 3 e 100 caracteres.\n";

            else if (!Regex.IsMatch(telefone, padraoTelefone))
                erros += "O campo \"Telefone\" deve estar no formato (XX) XXXX-XXXX ou (XX) XXXXX-XXXX.\n";


            return erros;
        }


    }
}
