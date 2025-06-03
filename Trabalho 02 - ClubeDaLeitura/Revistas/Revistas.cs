using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

using Trabalho_02___ClubeDaLeitura.Compartilhado;


namespace Trabalho_02___ClubeDaLeitura.Revistas
{
     public class Revistas : EntidadeBase
    {
        public int caixaId;
        public string titulo;
        public int numeroEdicao;
        public int ano;
        public string status;
        public string caixas;
        

        

        public override void AtualizarRegistro(EntidadeBase entidade)
        {
            Revistas revistaAtualizado = (Revistas)entidade;

            this.titulo = revistaAtualizado.titulo;
            this.numeroEdicao = revistaAtualizado.numeroEdicao;
            this.ano = revistaAtualizado.ano;
            this.status = revistaAtualizado.status;
            this.caixas = revistaAtualizado.caixas;

        }
        public override string Validar()
        {
            string erros = "";

            if (titulo.Length < 2 || titulo.Length > 100 )
                erros += "O campo \"Título\" deve conter no entre 2 e 100 caracteres.\n";

            if (numeroEdicao <= 0)
                erros += "O campo \"Edição\" deve conter um número maior que 0.\n";
            if (ano <= 0)
                erros += "O campo \"Ano\" deve conter um número maior que 0.\n";

            if (caixas != "branco" && caixas != "azul" && caixas != "verde" && caixas != "vermelho" && caixas != "amarelo")
                erros += "A revista deve ser incluida em uma caixa com cor válida .\n";
            
            if (status != "Disponível" && status != "Emprestada" && status != "Reservada")
                erros += "O campo \"Status\" deve conter Disponível, Emprestada ou Reservada.\n";

            return erros;
        }
    }
}
