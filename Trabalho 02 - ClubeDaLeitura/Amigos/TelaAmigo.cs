
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
            Console.WriteLine("3 - Excluir Amigos");
            Console.WriteLine("4 - Editar Amigos");
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

            Console.WriteLine("Visualização de Amigos");

            Console.WriteLine();

            Console.WriteLine(
                "{0, -10} | {1, -20} | {2, -30}" ,
                 "Nome", "Nome do Responsavel", "Telefone"
            );

            Amigo[] amigos = repositorio.SelecionarRegistros();

            for (int i = 0; i < amigos.Length; i++)
            {
                Amigo f = amigos[i];

                if (f == null)
                    continue;

                Console.WriteLine(
                   "{0, -10} | {1, -20} | {2, -30} ",
                    f.nome, f.nomeResponsavel, f.telefone
                );
            }

            Console.ReadLine();
        }
    
    }
}
