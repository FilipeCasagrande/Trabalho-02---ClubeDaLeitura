using Trabalho_02___ClubeDaLeitura.Amigos;
using Trabalho_02___ClubeDaLeitura.Caixas;
using Trabalho_02___ClubeDaLeitura.Compartilhado;

namespace Trabalho_02___ClubeDaLeitura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioAmigo repositorioAmigo = new RepositorioAmigo();
            RepositorioCaixas repositorioCaixas = new RepositorioCaixas();


            TelaPrincipal telaPrincipal = new TelaPrincipal();
            TelaAmigo telaAmigo = new TelaAmigo(repositorioAmigo);
            TelaCaixas telaCaixas = new TelaCaixas(repositorioCaixas);


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

                if (telaEscolhida == '2')
                {
                    char opcao = telaCaixas.ControleDeCaixas();

                    switch (opcao)
                    {
                        case '1':
                            telaCaixas.CadastrarRegistro();
                            break;
                        case '2':
                            telaCaixas.VisualizarRegistros();
                            break;

                            case '3':
                            telaCaixas.EditarRegistro();
                            break;

                        case '4':
                            telaCaixas.ExcluirRegistro();
                            break;


                    }

                }
            }
        }
    }
}
