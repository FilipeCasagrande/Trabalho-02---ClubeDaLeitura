using System.Runtime.CompilerServices;
using Trabalho_02___ClubeDaLeitura.Amigos;
using Trabalho_02___ClubeDaLeitura.Caixas;
using Trabalho_02___ClubeDaLeitura.Compartilhado;

namespace Trabalho_02___ClubeDaLeitura.Revistas
{
    public class TelaRevistas : TelaBase
    {
        private RepositorioRevistas repositorioRevistas;
        private RepositorioCaixas repositorioCaixas;
        private RepositorioAmigo RepositorioAmigo;

        public TelaRevistas(RepositorioRevistas repositorioRevistas,
            RepositorioAmigo repositorioAmigo, 
            RepositorioCaixas repositorioCaixas) : 
            base("Revistas", repositorioRevistas)
        {
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
        protected override Revistas ObterDados()
        {
            
            Console.WriteLine("Informe o nome do título");
            string titulo = Console.ReadLine();

            Console.WriteLine("Informe a Edição e Ano de publicação ");
            int numeroEdicao= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o Ano de publicação ");
            int ano = Convert.ToInt32(Console.ReadLine());

            string status = "Disponível";

            Console.WriteLine("Infrome a cor da Caixa para incluir a revista");
            string caixas = Console.ReadLine().ToLower();

            Revistas revista = new Revistas();

            revista.titulo = titulo;
            revista.numeroEdicao = numeroEdicao;
            revista.ano = ano;
            revista.status = status;
            revista.caixas = caixas;

            Console.WriteLine($"A Revista {revista.titulo} está Disponível");
            
            
            return revista;
        }
        public override void VisualizarRegistros()
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("     Visualizar Revistas   ");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Visualização de Amigos");

            Console.WriteLine();

            Console.WriteLine(
                "{0, -10} | {1, -10} | {2, -20} | {3, -30} | {4, -20}",
                 "ID", "titulo", "Edição", "ano", "Status"
            );

            EntidadeBase[] revistas = repositorioRevistas.SelecionarRegistros();

            for (int i = 0; i < revistas.Length; i++)
            {
                Revistas r = (Revistas)revistas[i];

                if (r == null)
                    continue;

                Console.WriteLine(
                   "{0, -10} | {1, -10} | {2, -20} | {3, -30} | {4, -20} ",
                    r.id, r.titulo, r.numeroEdicao, r.ano , r.status
                );
            }
            Console.ReadLine();
        }
    }
}
