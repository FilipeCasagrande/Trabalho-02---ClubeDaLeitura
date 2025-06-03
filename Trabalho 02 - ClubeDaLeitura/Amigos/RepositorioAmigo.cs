using Trabalho_02___ClubeDaLeitura.Compartilhado;
using Trabalho_02___ClubeDaLeitura.Emprestimo;

namespace Trabalho_02___ClubeDaLeitura.Amigos
{
    public class RepositorioAmigo : RepositorioBase
    {
        private RepositorioEmprestimo repositorioEmprestimo;

        public RepositorioAmigo(RepositorioEmprestimo repositorioEmprestimo)
        {
            this.repositorioEmprestimo = repositorioEmprestimo;
        }

        public override bool ExcluirRegistro(int idSelecionado)
        {
            Emprestimo.Emprestimo[] emprestimos = repositorioEmprestimo.SelecionarRegistros()
        .Cast<Emprestimo.Emprestimo>()
        .Where(e => e != null && e.idAmigo == idSelecionado)
        .ToArray();

            if (emprestimos.Length > 0)
            {
                Console.WriteLine(" Não é possível excluir este amigo porque ele possui empréstimos vinculados.");
                Console.ReadLine();
                return false;
            }

            return base.ExcluirRegistro(idSelecionado);
        }
    }
}
