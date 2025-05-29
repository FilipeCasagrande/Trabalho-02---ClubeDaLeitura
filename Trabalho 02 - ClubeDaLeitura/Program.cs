using Trabalho_02___ClubeDaLeitura.Amigos;
using Trabalho_02___ClubeDaLeitura.Compartilhado;

namespace Trabalho_02___ClubeDaLeitura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();


            RepositorioAmigo repositorioAmigo = new RepositorioAmigo(); 
            TelaAmigo telaAmigo = new TelaAmigo(repositorioAmigo);

            while (true)
            {
                char telaEscolhida = telaPrincipal.ApresentarMenuPrincipal();


                if (telaEscolhida == 'S') 
                    break;

                if (telaEscolhida == '1')
                {
                    char opcao = telaAmigo.ControleAmigos();

                    switch (opcao)
                    {
                        case '1':
                            telaAmigo.CadastrarRegistro();
                            break;

                        case '2':
                            telaAmigo.VisualizarRegistros();
                            break;

                        case '3':
                            telaAmigo.EditarRegistro();
                            break;
                        case '4':
                            telaAmigo.ExcluirRegistro();
                            break;
                    }
                }
            }
        }
    }
}
