using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevistaEntidade = Trabalho_02___ClubeDaLeitura.Revistas.Revistas;

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
        private RepositorioAmigo repositorioAmigo;

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
            this.repositorioAmigo = repositorioAmigo;
        }
        public int ControleDeEmprestimos()
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("  Controle de Emprestimos  ");
            Console.WriteLine("---------------------------");

            Console.WriteLine();

            Console.WriteLine("1 - Emprestimos");
            Console.WriteLine("2 - Visualizar Todos");
            Console.WriteLine("3 - Editar Emprestimos");
            Console.WriteLine("4 - Excluir Emprestimos");
            Console.WriteLine("5 - Visualizar Revistas");
            Console.WriteLine("6 - Visualizar Amigos");
            Console.WriteLine("7 - Registrar Devolução");
            Console.WriteLine("8 - Sair");

            Console.WriteLine();
            Console.Write("Infome uma opção válida:");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }
        protected override Emprestimo ObterDados()
        {
            Console.WriteLine("Lista de revistas disponíveis");
            
            VisualizarRevistas();



            Console.WriteLine("Informe Nome do Amigo que alugou: ");
            string amigo = Console.ReadLine();

            Console.WriteLine("Informe a revista que alugou: ");
            string revista = Console.ReadLine();

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

            EntidadeBase[] emprestimo = repositorioEmprestimo.SelecionarRegistros();

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
        public void VisualizarRevistas()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("    Revistas Disponíveis     ");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("{0,-5} | {1,-20} | {2,-15} | {3,-15}",
                "ID", "Título", "Edição/Ano", "Status");

            EntidadeBase[] revistas = repositorioRevistas.SelecionarRegistros();

            for (int i = 0; i < revistas.Length; i++)
            {
                RevistaEntidade r = (RevistaEntidade)revistas[i];

                if (r == null)
                    continue;

                Console.WriteLine("{0,-5} | {1,-20} | {2,-15} | {3,-15}",
                    r.id, r.titulo, r.numeroAno, r.status);
            }
            Console.ReadLine();
        }
        public  void VisualizarAmigos()
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("     Visualizar Amigos     ");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Visualização de Amigos");

            Console.WriteLine();

            Console.WriteLine(
                "{0, -10} | {1, -10} | {2, -20} | {3, -30}",
                 "ID", "Nome", "Nome do Responsavel", "Telefone"
            );

            EntidadeBase[] amigos = repositorioAmigo.SelecionarRegistros();

            for (int i = 0; i < amigos.Length; i++)
            {
                Amigo a = (Amigo)amigos[i];

                if (a == null)
                    continue;

                Console.WriteLine(
                   "{0, -10} | {1, -10} | {2, -20} | {3, -30} ",
                    a.id, a.nome, a.nomeResponsavel, a.telefone
                );
            }
            Console.ReadLine();
        }
    }
}
