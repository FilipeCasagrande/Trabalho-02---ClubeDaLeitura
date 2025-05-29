
namespace Trabalho_02___ClubeDaLeitura.Amigos
{
    public class TelaAmigo
    {
        RepositorioAmigo repositorio = new RepositorioAmigo();

        public char ControleAmigos()
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
        public void CadastrarAmigos()
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("     Cadastrar Amigo       ");
            Console.WriteLine("---------------------------");

            Amigo amigo = ObterDados();

            repositorio.CadastrarRegistro(amigo);

            Console.WriteLine($"Amigo {amigo.nome} cadastrado com sucesso!");
            Console.ReadLine();
        }

        public void VisualizarAmigos()
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("     Visualizar Amigos     ");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Visualização de Amigos");

            Console.WriteLine();

            Console.WriteLine(
                "{0, -10} | {1, -20} | {2, -30}" ,
                 "Nome", "Nome do Responsavel", "Telefone"
            );

            Amigo[] amigos = repositorio.SelecionarRegistros();

            for (int i = 0; i < amigos.Length; i++)
            {
                Amigo a = amigos[i];

                if (a == null)
                    continue;

                Console.WriteLine(
                   "{0, -10} | {1, -20} | {2, -30} ",
                    a.nome, a.nomeResponsavel, a.telefone
                );
            }
            Console.ReadLine();
        }
        public void EditarAmigo()
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("     Editar Amigo       ");
            Console.WriteLine("---------------------------");

            Console.WriteLine($"Edição de Amigos");

            Console.WriteLine();
            VisualizarAmigos();

            Console.Write("Digite o nome do amigo que deseja editar: ");
            string nomeAmigo = Console.ReadLine();

            Console.WriteLine("Digite Os novos Dados");

           Amigo registroAtualizado = ObterDados();

            repositorio.EditarRegistro(nomeAmigo, registroAtualizado);

            Console.WriteLine($"\n{registroAtualizado.nome} editado com sucesso!");
            Console.ReadLine();
        }
    }
}
