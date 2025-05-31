

using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.Win32;
using Trabalho_02___ClubeDaLeitura.Caixas;
using Trabalho_02___ClubeDaLeitura.Compartilhado;

namespace Trabalho_02___ClubeDaLeitura.Amigos
{
    public class TelaAmigo : TelaBase
    {
        private RepositorioAmigo repositorioAmigo;
        private RepositorioCaixas repositorioCaixas;

        public TelaAmigo(RepositorioAmigo repositorioAmigo,RepositorioCaixas repositorioCaixas) : base("Amigo", repositorioAmigo)
        {
            this.repositorioAmigo = repositorioAmigo;
            this.repositorioCaixas = repositorioCaixas;
        }

        public int ControleAmigos()
        {

            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("     Controle de Amigos    ");
            Console.WriteLine("---------------------------");

            Console.WriteLine();

            Console.WriteLine("1 - Inserir novos amigos");
            Console.WriteLine("2 - Visualizar amigos cadastrados ");
            Console.WriteLine("3 - Editar Amigos");
            Console.WriteLine("4 - Excluir Amigos");
            Console.WriteLine("5 - Visualizar emprestimos de amigos");
            Console.WriteLine("6 - Sair");

            Console.WriteLine();
            Console.Write("Infome uma opção válida:");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }

        protected override Amigo ObterDados()
        {
            Console.WriteLine("Informe o nome do amigo");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o nome do Responsável");
            string nomeResponsavel = Console.ReadLine();

            Console.WriteLine("Informe um Telefone");
            string telefone = Console.ReadLine();



            Amigo amigo = new Amigo();

            amigo.nome = nome;
            amigo.nomeResponsavel = nomeResponsavel;
            amigo.telefone = telefone;

            return amigo;
        }
        public override void VisualizarRegistros()
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

        public void Emprestimos()
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("     Emprestimos Amigo     ");
            Console.WriteLine("---------------------------");
            Console.WriteLine();

        } // FINALIZAR APÓS ETAPA 3
    }
}
