
namespace Trabalho_02___ClubeDaLeitura.Amigos
{
    public class TelaAmigo
    {
        public char ControleAmigos()
        {

            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("     Controle de Amigos    ");
            Console.WriteLine("---------------------------");

            Console.WriteLine();

            Console.WriteLine("1 - Inserir novos amigos");
            Console.WriteLine("2 - Editar amigos ");
            Console.WriteLine("3 - Excluir Amigos");
            Console.WriteLine("4 - Visualizar amigos cadastrados");
            Console.WriteLine("5 - Visualizar emprestimos de amigos");
            Console.WriteLine("S - Sair");

            Console.WriteLine();
            Console.Write("Infome uma opção válida:");
            char opcao = Console.ReadLine()[0];
            return opcao;
        }

        public Amigo ObterDados()
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

        internal void CadastrarAmigos()
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("     Cadastrar Amigo       ");
            Console.WriteLine("---------------------------");

            ObterDados();

            Console.ReadLine();
        }
    }
}
