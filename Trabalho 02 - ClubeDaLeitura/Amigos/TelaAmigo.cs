namespace Trabalho_02___ClubeDaLeitura.Amigos
{
    public class TelaAmigo
    {
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






    }
}
