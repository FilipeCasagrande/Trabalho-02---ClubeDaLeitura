using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_02___ClubeDaLeitura.Amigos;
using Trabalho_02___ClubeDaLeitura.Caixas;
using Trabalho_02___ClubeDaLeitura.Compartilhado;
using Trabalho_02___ClubeDaLeitura.Revistas;

namespace Trabalho_02___ClubeDaLeitura.Emprestimo
{
    public class TelaEmprestimo : TelaBase
    {
        private RepositorioEmprestimo repositorioEmprestimo;
        private RepositorioRevistas repositorioRevistas;
        private RepositorioCaixas repositorioCaixas;
        private RepositorioAmigo RepositorioAmigo;

        public TelaEmprestimo(
            RepositorioEmprestimo repositorioEmprestimo,
            RepositorioRevistas repositorioRevistas,
            RepositorioAmigo repositorioAmigo,
            RepositorioCaixas repositorioCaixas) :
            base("Emprestimo", repositorioEmprestimo)
        {
            this.repositorioEmprestimo = repositorioEmprestimo;
            this.repositorioRevistas = repositorioRevistas;
            this.repositorioCaixas = repositorioCaixas;
            this.RepositorioAmigo = repositorioAmigo;
        }
        public int ControleDeRevistas()
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("     Controle de Revistas  ");
            Console.WriteLine("---------------------------");

            Console.WriteLine();

            Console.WriteLine("1 - Inserir novas Revistas");
            Console.WriteLine("2 - Visualizar Todos  ");
            Console.WriteLine("3 - Editar Revistas");
            Console.WriteLine("4 - Excluir Revistas");
            Console.WriteLine("5 - Visualizar Caixas");
            Console.WriteLine("6 - Sair");

            Console.WriteLine();
            Console.Write("Infome uma opção válida:");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }
        protected override Emprestimo ObterDados()
        {
            Console.WriteLine("Informe Nome do Amigo que alugou: ");
            string amigo = Console.ReadLine();

            Console.WriteLine("Informe a revista que alugou: ");
            string revista = Console.ReadLine();

            Console.WriteLine("Informe a Data que foi alugado: ");
            DateTime data = DateTime.Now;

            Console.WriteLine("Informar a situação: ");
            string situacao = Console.ReadLine();

            Emprestimo emprestimo = new Emprestimo();

            emprestimo.amigo = amigo;
            emprestimo.revista = revista;
            emprestimo.data = data;
            emprestimo.situacao = situacao;

            return emprestimo;
        }
        public override void VisualizarRegistros()
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("  Visualizar Emprestimos   ");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Visualização de Amigos");

            Console.WriteLine();

            Console.WriteLine(
                "{0, -10} | {1, -10} | {2, -20} | {3, -30} | {4, -30}",
                 "ID", "Amigo", "Revista", "Data", "Situação"
            );

            EntidadeBase[] emprestimo = repositorioRevistas.SelecionarRegistros();

            for (int i = 0; i < emprestimo.Length; i++)
            {
                Emprestimo e = (Emprestimo)emprestimo[i];

                if (e == null)
                    continue;

                Console.WriteLine(
                   "{0, -10} | {1, -10} | {2, -20} | {3, -30} | {4, -30} ",
                    e.id, e.amigo, e.revista, e.data, e.situacao
                );
            }
            Console.ReadLine();
        }
    }
}
