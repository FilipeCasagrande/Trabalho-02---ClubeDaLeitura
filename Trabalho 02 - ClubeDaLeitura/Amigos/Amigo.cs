namespace Trabalho_02___ClubeDaLeitura.Amigos
{
     public class Amigo
    {
        public string nome;
        public string nomeResponsavel;
        public string telefone;

        public void AtualizarRegistro(Amigo registroAtualizado)
        {
            Amigo amigoAtualizado = (Amigo)registroAtualizado;

            this.nome = amigoAtualizado.nome;
            this.nomeResponsavel = amigoAtualizado.nomeResponsavel;
            this.telefone = amigoAtualizado.telefone;
        }

    }
}
